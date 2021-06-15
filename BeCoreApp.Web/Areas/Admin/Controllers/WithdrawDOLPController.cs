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
    public class WithdrawDOLPController : BaseController
    {
        public readonly ITransactionService _transactionService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ITRONService _tronService;
        private readonly IBlockChainService _blockChainService;
        public WithdrawDOLPController(
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

        public class WithdrawModel
        {
            public string AddressReceiving { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Withdraw(string modelJson)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<WithdrawModel>(modelJson);

                var userId = User.GetSpecificClaim("UserId");
                var appUser = await _userManager.FindByIdAsync(userId);

                if (appUser == null)
                    return new OkObjectResult(new GenericResult(false, "Account does not exist."));

                var validateAddress = await _tronService.ValidateAddress(model.AddressReceiving);
                if (validateAddress.success == false)
                    return new OkObjectResult(new GenericResult(false, "The address receiving is not in the standard TRC20 format!"));

                decimal feeWithdraw = 28;

                int countTransaction = _transactionService.CountByType(userId, TransactionType.WithdrawELC);

                if (countTransaction > 0)
                {
                    feeWithdraw = feeWithdraw * (countTransaction + 1);
                }

                var walletTrx = await _tronService.GetBalanceByAddress(appUser.TRXAddressBase58);
                if (walletTrx == null)
                {
                    return new OkObjectResult(new GenericResult(false,
                                            "There was a problem loading the balance value..."));
                }

                var balanceTrxDeposit = decimal.Parse(walletTrx.result) / 1000000;

                if (balanceTrxDeposit < feeWithdraw)
                {
                    return new OkObjectResult(new GenericResult(false,
                        $"Your account does not have sufficient quota {feeWithdraw}TRX"));
                }

                var balanceTRXTransfer = (BigInteger)((feeWithdraw - 0.1M) * 1000000);

                var transactionReceipt = await _tronService.EasyTransferByPrivate(
                      appUser.TRXPrivateKey, CommonConstants.TRONViTongPublishKey, balanceTRXTransfer);

                if (transactionReceipt.success == true)
                {
                    decimal amountDOLP = 5000000;

                    var balanceDOLPTransfer = (BigInteger)amountDOLP * 1000000;

                    transactionReceipt = await _tronService.EasyTransferAssetByPrivate(
                        CommonConstants.TRONViTongPrivateKey, model.AddressReceiving,
                        CommonConstants.TRONELCContract, balanceDOLPTransfer);

                    if (transactionReceipt.success == true)
                    {
                        var transtionLog = new TransactionViewModel()
                        {
                            AppUserId = appUser.Id,
                            TransactionHas = transactionReceipt.result,
                            Type = TransactionType.WithdrawELC,
                            Amount = amountDOLP,
                            DateCreated = DateTime.Now,
                            AddressTo = model.AddressReceiving,
                        };

                        _transactionService.Add(transtionLog);
                        _transactionService.Save();

                        var referralF1 = appUser.ReferralId.HasValue ? await _userManager.FindByIdAsync(appUser.ReferralId.Value.ToString()) : null;
                        if (referralF1 != null && !referralF1.IsSystem)
                        {
                            BigInteger balanceTRXTransferF1 = 6 * 1000000;

                            var transactionReceiptF1 = await _tronService.EasyTransferByPrivate(
                       CommonConstants.TRONViTongPrivateKey, referralF1.TRXAddressBase58, balanceTRXTransferF1);

                            if (transactionReceiptF1.success == true)
                            {
                                var transtionLogF1 = new TransactionViewModel()
                                {
                                    AppUserId = referralF1.Id,
                                    TransactionHas = transactionReceiptF1.result,
                                    Type = TransactionType.AffiliateWithdraw,
                                    Amount = 6,
                                    DateCreated = DateTime.Now,
                                    AddressTo = referralF1.TRXAddressBase58,
                                };

                                _transactionService.Add(transtionLogF1);
                                _transactionService.Save();
                            }


                            var referralF2 = referralF1.ReferralId.HasValue ? await _userManager.FindByIdAsync(referralF1.ReferralId.ToString()) : null;
                            if (referralF2 != null && !referralF2.IsSystem)
                            {
                                BigInteger balanceTRXTransferF2 = 4 * 1000000;

                                var transactionReceiptF2 = await _tronService.EasyTransferByPrivate(
                           CommonConstants.TRONViTongPrivateKey, referralF2.TRXAddressBase58, balanceTRXTransferF2);

                                if (transactionReceiptF2.success == true)
                                {
                                    var transtionLogF2 = new TransactionViewModel()
                                    {
                                        AppUserId = referralF2.Id,
                                        TransactionHas = transactionReceiptF2.result,
                                        Type = TransactionType.AffiliateWithdraw,
                                        Amount = 4,
                                        DateCreated = DateTime.Now,
                                        AddressTo = referralF2.TRXAddressBase58,
                                    };

                                    _transactionService.Add(transtionLogF2);
                                    _transactionService.Save();
                                }

                                var referralF3 = referralF2.ReferralId.HasValue ? await _userManager.FindByIdAsync(referralF2.ReferralId.ToString()) : null;
                                if (referralF3 != null && !referralF3.IsSystem)
                                {
                                    BigInteger balanceTRXTransferF3 = 2 * 1000000;

                                    var transactionReceiptF3 = await _tronService.EasyTransferByPrivate(
                               CommonConstants.TRONViTongPrivateKey, referralF3.TRXAddressBase58, balanceTRXTransferF3);

                                    if (transactionReceiptF3.success == true)
                                    {
                                        var transtionLogF3 = new TransactionViewModel()
                                        {
                                            AppUserId = referralF3.Id,
                                            TransactionHas = transactionReceiptF3.result,
                                            Type = TransactionType.AffiliateWithdraw,
                                            Amount = 2,
                                            DateCreated = DateTime.Now,
                                            AddressTo = referralF3.TRXAddressBase58,
                                        };

                                        _transactionService.Add(transtionLogF3);
                                        _transactionService.Save();
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        return new OkObjectResult(new GenericResult(false,
                            $"There was a problem with the transfer ***** to address {model.AddressReceiving}."));
                    }
                }
                else
                {
                    return new OkObjectResult(new GenericResult(false, "There was a problem with the transfer TRX to Wallet System."));
                }

                return new OkObjectResult(new GenericResult(true,
                    $"Withdraw ***** to address receiving {model.AddressReceiving} is success."));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }
    }
}