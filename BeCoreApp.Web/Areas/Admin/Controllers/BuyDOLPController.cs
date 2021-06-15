using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BeCoreApp.Application.Interfaces;
using BeCoreApp.Application.ViewModels.BlockChain;
using BeCoreApp.Application.ViewModels.System;
using BeCoreApp.Data.Entities;
using BeCoreApp.Data.Enums;
using BeCoreApp.Extensions;
using BeCoreApp.Utilities.Constants;
using BeCoreApp.Utilities.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace BeCoreApp.Areas.Admin.Controllers
{
    public class BuyDOLPController : BaseController
    {
        public readonly ITransactionService _transactionService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ITRONService _tronService;
        private readonly IBlockChainService _blockChainService;
        public BuyDOLPController(
            IBlockChainService blockChainService,
            UserManager<AppUser> userManager,
            ITRONService tronService,
            ITransactionService transactionService
            )
        {
            _blockChainService = blockChainService;
            _userManager = userManager;
            _tronService = tronService;
            _transactionService = transactionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public class BuyModel
        {
            public decimal Amount { get; set; }
            public string AddressReceiving { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(string modelJson)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<BuyModel>(modelJson);

                var userId = User.GetSpecificClaim("UserId");

                var appUser = await _userManager.FindByIdAsync(userId);

                if (appUser == null)
                    return new OkObjectResult(new GenericResult(false, "Account does not exist."));

                var validateAddress = await _tronService.ValidateAddress(model.AddressReceiving);
                if (validateAddress.success == false)
                    return new OkObjectResult(new GenericResult(false, "The address receiving is not in the standard TRC20 format!"));

                if (model.Amount < 50)
                    return new OkObjectResult(new GenericResult(false, "TRX Amount minimum is 50TRX"));

                if (model.Amount > 100000)
                    return new OkObjectResult(new GenericResult(false, "TRX Amount maximum is 100000TRX"));

                var walletTrx = await _tronService.GetBalanceByAddress(appUser.TRXAddressBase58);
                if (walletTrx == null)
                    return new OkObjectResult(new GenericResult(false, "There was a problem loading the balance value..."));

                var balanceTrxDeposit = decimal.Parse(walletTrx.result) / 1000000;

                if (balanceTrxDeposit < model.Amount)
                {
                    return new OkObjectResult(new GenericResult(false,
                        $"Your account does not have sufficient quota {model.Amount}TRX"));
                }

                var coinMarKetCapInfo = _blockChainService.GetListingLatest(1, 50, "USD");
                if (coinMarKetCapInfo == null)
                    return new OkObjectResult(new GenericResult(false, "There was a problem loading the currency value..."));

                var dataTRX = coinMarKetCapInfo.data.Find(x => x.symbol == "TRX");
                if (dataTRX == null)
                    return new OkObjectResult(new GenericResult(false, "There was a problem loading the currency value..."));

                var priceTRX = dataTRX.quote.USD.price;

                decimal ttPrice = 0.09m;

                decimal totalPayment = Math.Round(model.Amount * priceTRX, 5);

                var ttReceivingAmount = Math.Round(totalPayment / ttPrice, 5);

                var balanceTRXTransfer = (BigInteger)((model.Amount - 0.2M) * 1000000);

                var transactionReceipt = await _tronService.EasyTransferByPrivate(
                      appUser.TRXPrivateKey, CommonConstants.TRONViTongPublishKey, balanceTRXTransfer);

                if (transactionReceipt.success == true)
                {
                    var balanceDOLPTransfer = (BigInteger)(ttReceivingAmount * 1000000);

                    transactionReceipt = await _tronService.EasyTransferAssetByPrivate(CommonConstants.TRONViTongPrivateKey,
                        model.AddressReceiving, CommonConstants.TRONELCContract, balanceDOLPTransfer);

                    if (transactionReceipt.success == true)
                    {
                        var transtionLog = new TransactionViewModel()
                        {
                            AppUserId = appUser.Id,
                            TransactionHas = transactionReceipt.result,
                            Type = TransactionType.Buy,
                            Amount = ttReceivingAmount,
                            DateCreated = DateTime.Now,
                            AddressTo = model.AddressReceiving,
                        };

                        _transactionService.Add(transtionLog);
                        _transactionService.Save();

                        var referralF1 = appUser.ReferralId.HasValue ? await _userManager.FindByIdAsync(appUser.ReferralId.Value.ToString()) : null;
                        if (referralF1 != null && !referralF1.IsSystem)
                        {
                            decimal expectTRXDepositF1 = model.Amount * 0.09M;
                            BigInteger balanceTRXTransferF1 = (BigInteger)(expectTRXDepositF1 * 1000000);

                            var transactionReceiptF1 = await _tronService.EasyTransferByPrivate(
                            CommonConstants.TRONViTongPrivateKey, referralF1.TRXAddressBase58, balanceTRXTransferF1);

                            if (transactionReceiptF1.success == true)
                            {
                                var transtionLogF1 = new TransactionViewModel()
                                {
                                    AppUserId = referralF1.Id,
                                    TransactionHas = transactionReceiptF1.result,
                                    Type = TransactionType.AffiliateBuy,
                                    Amount = expectTRXDepositF1,
                                    DateCreated = DateTime.Now,
                                    AddressTo = referralF1.TRXAddressBase58,
                                };

                                _transactionService.Add(transtionLogF1);
                                _transactionService.Save();
                            }

                            //var referralF2 = referralF1.ReferralId.HasValue ? await _userManager.FindByIdAsync(referralF1.ReferralId.ToString()) : null;
                            //if (referralF2 != null && !referralF2.IsSystem)
                            //{
                            //    decimal expectTRXDepositF2 = model.Amount * 0.05M;
                            //    BigInteger balanceTRXTransferF2 = (BigInteger)(expectTRXDepositF2 * 1000000);

                            //    var transactionReceiptF2 = await _tronService.EasyTransferByPrivate(
                            //    CommonConstants.TRONViTongPrivateKey, referralF2.TRXAddressBase58, balanceTRXTransferF2);

                            //    if (transactionReceiptF2.success == true)
                            //    {
                            //        var transtionLogF2 = new TransactionViewModel()
                            //        {
                            //            AppUserId = referralF2.Id,
                            //            TransactionHas = transactionReceiptF2.result,
                            //            Type = TransactionType.AffiliateBuy,
                            //            Amount = expectTRXDepositF2,
                            //            DateCreated = DateTime.Now,
                            //            AddressTo = referralF2.TRXAddressBase58,
                            //        };

                            //        _transactionService.Add(transtionLogF2);
                            //        _transactionService.Save();
                            //    }

                            //    var referralF3 = referralF2.ReferralId.HasValue ? await _userManager.FindByIdAsync(referralF2.ReferralId.ToString()) : null;
                            //    if (referralF3 != null && !referralF3.IsSystem)
                            //    {
                            //        decimal expectTRXDepositF3 = model.Amount * 0.03M;
                            //        BigInteger balanceTRXTransferF3 = (BigInteger)(expectTRXDepositF3 * 1000000);

                            //        var transactionReceiptF3 = await _tronService.EasyTransferByPrivate(
                            //        CommonConstants.TRONViTongPrivateKey, referralF3.TRXAddressBase58, balanceTRXTransferF3);

                            //        if (transactionReceiptF3.success == true)
                            //        {
                            //            var transtionLogF3 = new TransactionViewModel()
                            //            {
                            //                AppUserId = referralF3.Id,
                            //                TransactionHas = transactionReceiptF3.result,
                            //                Type = TransactionType.AffiliateBuy,
                            //                Amount = expectTRXDepositF3,
                            //                DateCreated = DateTime.Now,
                            //                AddressTo = referralF3.TRXAddressBase58,
                            //            };

                            //            _transactionService.Add(transtionLogF3);
                            //            _transactionService.Save();
                            //        }
                            //    }
                            //}
                        }
                    }
                    else
                    {
                        return new OkObjectResult(new GenericResult(false,
                            $"There was a problem with the transfer ELC to address {model.AddressReceiving}."));
                    }
                }
                else
                    return new OkObjectResult(new GenericResult(false, "There was a problem with the transfer TRX to Wallet System."));

                return new OkObjectResult(new GenericResult(true, $"Buy {ttReceivingAmount}ELC to address {model.AddressReceiving} is success."));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuyUSDT(string modelJson)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<BuyModel>(modelJson);

                var userId = User.GetSpecificClaim("UserId");

                var appUser = await _userManager.FindByIdAsync(userId);

                if (appUser == null)
                {
                    return new OkObjectResult(new GenericResult(false, "Account does not exist."));
                }

                var validateAddress = await _tronService.ValidateAddress(model.AddressReceiving);
                if (validateAddress.success == false)
                {
                    return new OkObjectResult(new GenericResult(false, "The address receiving is not in the standard TRC20 format!"));
                }

                if (model.Amount < 10)
                {
                    return new OkObjectResult(new GenericResult(false, "USDT Amount minimum is 10USDT"));
                }

                if (model.Amount > 50000)
                {
                    return new OkObjectResult(new GenericResult(false, "USDT Amount maximum is 50000USDT"));
                }

                var walletUsdtTrc20 = await _tronService.GetTRC20BalanceByAddress(
                    appUser.TRXAddressBase58, CommonConstants.TRC20USDTContract);
                if (walletUsdtTrc20 == null)
                {
                    return new OkObjectResult(new GenericResult(false, "There was a problem loading the balance value..."));
                }

                var balanceDepositUsdtTrc20 = decimal.Parse(walletUsdtTrc20.result) / 1000000;
                if (balanceDepositUsdtTrc20 < model.Amount)
                {
                    return new OkObjectResult(new GenericResult(false, $"Your balance USDT is not enough."));
                }

                var walletTrx = await _tronService.GetBalanceByAddress(appUser.TRXAddressBase58);
                if (walletTrx == null)
                {
                    return new OkObjectResult(new GenericResult(false, "There was a problem loading the balance value..."));
                }

                var balanceDepositTrx = decimal.Parse(walletTrx.result) / 1000000;
                if (balanceDepositTrx < 5)
                {
                    return new OkObjectResult(new GenericResult(false, $"Your account does not have enough 5TRX to pay the transaction fee."));
                }


                decimal ttPrice = 0.09m;

                var ttReceivingAmount = Math.Round(model.Amount / ttPrice, 5);

                var transactionReceipt = await _tronService.EasyTransferAssetByPrivate(appUser.TRXPrivateKey,
                         CommonConstants.TRONViTongPublishKey, CommonConstants.TRC20USDTContract, (BigInteger)model.Amount * 1000000);

                if (transactionReceipt.success == true)
                {
                    var balanceDOLPTransfer = (BigInteger)(ttReceivingAmount * 1000000);

                    transactionReceipt = await _tronService.EasyTransferAssetByPrivate(CommonConstants.TRONViTongPrivateKey,
                        model.AddressReceiving, CommonConstants.TRONELCContract, balanceDOLPTransfer);

                    if (transactionReceipt.success == true)
                    {
                        var transtionLog = new TransactionViewModel()
                        {
                            AppUserId = appUser.Id,
                            TransactionHas = transactionReceipt.result,
                            Type = TransactionType.BuyUSDT,
                            Amount = ttReceivingAmount,
                            DateCreated = DateTime.Now,
                            AddressTo = model.AddressReceiving,
                        };

                        _transactionService.Add(transtionLog);
                        _transactionService.Save();

                        var referralF1 = appUser.ReferralId.HasValue ? await _userManager.FindByIdAsync(appUser.ReferralId.Value.ToString()) : null;
                        if (referralF1 != null && !referralF1.IsSystem)
                        {
                            decimal expectUSDTDepositF1 = model.Amount * 0.09M;
                            BigInteger balanceUSDTTransferF1 = (BigInteger)(expectUSDTDepositF1 * 1000000);

                            var transactionReceiptF1 = await _tronService.EasyTransferAssetByPrivate(
                                CommonConstants.TRONViTongPrivateKey, referralF1.TRXAddressBase58,
                                CommonConstants.TRC20USDTContract, balanceUSDTTransferF1);

                            if (transactionReceiptF1.success == true)
                            {
                                var transtionLogF1 = new TransactionViewModel()
                                {
                                    AppUserId = referralF1.Id,
                                    TransactionHas = transactionReceiptF1.result,
                                    Type = TransactionType.AffiliateBuy,
                                    Amount = expectUSDTDepositF1,
                                    DateCreated = DateTime.Now,
                                    AddressTo = referralF1.TRXAddressBase58,
                                };

                                _transactionService.Add(transtionLogF1);
                                _transactionService.Save();
                            }
                        }
                    }
                    else
                    {
                        return new OkObjectResult(new GenericResult(false,
                            $"There was a problem with the transfer ELC to address {model.AddressReceiving}."));
                    }
                }
                else
                {
                    return new OkObjectResult(new GenericResult(false, "There was a problem with the transfer USDT TRC20 to Wallet System."));
                }

                return new OkObjectResult(new GenericResult(true, $"Buy {ttReceivingAmount}ELC to address {model.AddressReceiving} is success."));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }

        public class GetUSDTTRC20PaymentAmountModel
        {
            public decimal Amount { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetUSDTTRC20PaymentAmount(string modelJson)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<GetUSDTTRC20PaymentAmountModel>(modelJson);

                decimal ttPrice = 0.09m;

                var ttReceivingAmount = Math.Round(model.Amount / ttPrice, 5);

                return new OkObjectResult(new GenericResult(true, ttReceivingAmount));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }

        public class GetTRXPaymentAmountModel
        {
            public decimal Amount { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetTRXPaymentAmount(string modelJson)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<GetTRXPaymentAmountModel>(modelJson);

                decimal ttPrice = 0.09m;

                var coinMarKetCapInfo = _blockChainService.GetListingLatest(1, 50, "USD");
                if (coinMarKetCapInfo == null)
                    return new OkObjectResult(new GenericResult(false, "There was a problem loading the currency value..."));

                var dataTRX = coinMarKetCapInfo.data.Find(x => x.symbol == "TRX");
                if (dataTRX == null)
                    return new OkObjectResult(new GenericResult(false, "There was a problem loading the currency value..."));

                var priceTRX = dataTRX.quote.USD.price;

                decimal totalPayment = Math.Round(model.Amount * priceTRX, 5);

                var ttReceivingAmount = Math.Round(totalPayment / ttPrice, 5);

                return new OkObjectResult(new GenericResult(true, ttReceivingAmount));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }
    }
}