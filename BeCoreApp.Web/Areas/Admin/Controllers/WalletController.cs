using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Claims;
using System.Threading.Tasks;
using BeCoreApp.Application.Interfaces;
using BeCoreApp.Application.ViewModels.BlockChain;
using BeCoreApp.Application.ViewModels.System;
using BeCoreApp.Application.ViewModels.Valuesshare;
using BeCoreApp.Data.Entities;
using BeCoreApp.Data.Enums;
using BeCoreApp.Extensions;
using BeCoreApp.Utilities.Constants;
using BeCoreApp.Utilities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Util;
using Newtonsoft.Json;

namespace BeCoreApp.Areas.Admin.Controllers
{
    public class WalletController : BaseController
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IBlockChainService _blockChainService;
        private readonly ITransactionService _transactionService;
        private readonly ITRONService _tronService;
        private readonly ILogger<WalletController> _logger;
        private readonly AddressUtil _addressUtil = new AddressUtil();
        public WalletController(
            ILogger<WalletController> logger,
            ITRONService tronService,
            ITransactionService transactionService,
            UserManager<AppUser> userManager,
            IUserService userService,
            IBlockChainService blockChainService)
        {
            _logger = logger;
            _tronService = tronService;
            _transactionService = transactionService;
            _userManager = userManager;
            _blockChainService = blockChainService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetSpecificClaim("UserId");
            var appUser = await _userService.GetById(userId);

            var model = new WalletViewModel()
            {
                TRXPublishKey = appUser.TRXAddressBase58,
                USDTTRC20PublishKey = appUser.TRXAddressBase58,
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetWalletDeposits()
        {
            var userId = User.GetSpecificClaim("UserId");
            var appUser = await _userService.GetById(userId);

            var model = new WalletViewModel();
            var walletTRX = await _tronService.GetBalanceByAddress(appUser.TRXAddressBase58);
            model.WalletTRX = 0;
            if (walletTRX.success)
                model.WalletTRX = decimal.Parse(walletTRX.result) / 1000000;

            var walletUsdtTrc20 = await _tronService.GetTRC20BalanceByAddress(
                        appUser.TRXAddressBase58, CommonConstants.TRC20USDTContract);
            model.WalletUSDTTRC20 = 0;
            if (walletUsdtTrc20.success)
                model.WalletUSDTTRC20 = decimal.Parse(walletUsdtTrc20.result) / 1000000;


            return new OkObjectResult(model);
        }

        public class WithdrawModel
        {
            public string AddressReceiving { get; set; }
            public decimal Amount { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WithdrawUSDTTRC20(string modelJson)
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
                {
                    return new OkObjectResult(new GenericResult(false, "The address receiving is not in the standard TRC20 format!"));
                }

                var walletUsdtTrc20 = await _tronService.GetTRC20BalanceByAddress(
                    appUser.TRXAddressBase58, CommonConstants.TRC20USDTContract);
                var balanceDepositUsdtTrc20 = decimal.Parse(walletUsdtTrc20.result) / 1000000;
                if (balanceDepositUsdtTrc20 < model.Amount)
                {
                    return new OkObjectResult(new GenericResult(false, $"Your balance USDT is not enough."));
                }

                var balanceTrx = await _tronService.GetBalanceByAddress(appUser.TRXAddressBase58);
                var balanceDepositTrx = decimal.Parse(balanceTrx.result) / 1000000;
                if (balanceDepositTrx < 5)
                {
                    return new OkObjectResult(new GenericResult(false, $"Your account does not have enough 5TRX to pay the transaction fee."));
                }

                var transactionReceipt = await _tronService.EasyTransferAssetByPrivate(appUser.TRXPrivateKey,
                         model.AddressReceiving, CommonConstants.TRC20USDTContract, (BigInteger)model.Amount * 1000000);

                if (transactionReceipt.success == true)
                {
                    var transtionLog = new TransactionViewModel()
                    {
                        AppUserId = appUser.Id,
                        TransactionHas = transactionReceipt.result,
                        Type = TransactionType.WithdrawUSDTTRC20,
                        Amount = model.Amount,
                        DateCreated = DateTime.Now,
                        AddressTo = model.AddressReceiving,
                    };

                    _transactionService.Add(transtionLog);
                    _transactionService.Save();
                }
                else
                {
                    return new OkObjectResult(new GenericResult(false, "There was a problem with the transfer USDT to Wallet."));
                }

                return new OkObjectResult(new GenericResult(true,
                    $"Withdraw {model.Amount}USDT to address {model.AddressReceiving} is success."));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WithdrawTRX(string modelJson)
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

                var walletTRX = await _tronService.GetBalanceByAddress(appUser.TRXAddressBase58);

                decimal amountTRX = 0;
                if (walletTRX.success)
                {
                    amountTRX = decimal.Parse(walletTRX.result) / 1000000;
                }

                if (model.Amount > amountTRX)
                {
                    return new OkObjectResult(new GenericResult(false, $"Your balance TRX is not enough."));
                }

                if (model.Amount < 10)
                {
                    return new OkObjectResult(new GenericResult(false, "Withraw TRX amount minimum is 10TRX"));
                }

                var balanceTRXTransfer = (BigInteger)((model.Amount - 0.2M) * 1000000);

                var transactionReceipt = await _tronService.EasyTransferByPrivate(
                      appUser.TRXPrivateKey, model.AddressReceiving, balanceTRXTransfer);

                if (transactionReceipt.success == true)
                {
                    var transtionLog = new TransactionViewModel()
                    {
                        AppUserId = appUser.Id,
                        TransactionHas = transactionReceipt.result,
                        Type = TransactionType.WithdrawTRX,
                        Amount = model.Amount,
                        DateCreated = DateTime.Now,
                        AddressTo = model.AddressReceiving,
                    };
                    _transactionService.Add(transtionLog);
                    _transactionService.Save();

                }
                else
                {
                    return new OkObjectResult(new GenericResult(false, "There was a problem with the transfer TRX to Wallet."));
                }

                return new OkObjectResult(new GenericResult(true,
                    $"Withdraw {model.Amount}TRX to address {model.AddressReceiving} is success."));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }
    }
}