using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Claims;
using System.Threading.Tasks;
using BeCoreApp.Application.Interfaces;
using BeCoreApp.Application.ViewModels.System;
using BeCoreApp.Data.Entities;
using BeCoreApp.Data.Enums;
using BeCoreApp.Extensions;
using BeCoreApp.Utilities.Constants;
using BeCoreApp.Utilities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BeCoreApp.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        private readonly INotifyService _notifyService;
        public readonly ITransactionService _transactionService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ITRONService _tronService;
        private readonly IBlockChainService _blockChainService;
        public HomeController(
            IBlockChainService blockChainService,
            UserManager<AppUser> userManager,
            ITRONService tronService,
            ITransactionService transactionService,
            INotifyService notifyService
            )
        {
            _blockChainService = blockChainService;
            _userManager = userManager;
            _tronService = tronService;
            _transactionService = transactionService;
            _notifyService = notifyService;
        }

        public async Task<IActionResult> Index()
        {
            //var userId = User.GetSpecificClaim("UserId");
            //var user = await _userManager.FindByIdAsync(userId);
            //if (user == null)
            //{
            //    return RedirectToAction("login", "/admin/account/");
            //}

            //if (user.IsSystem != true)
            //{
            //    return RedirectToAction("index", "/admin/wallet");
            //}

            var model = _notifyService.GetbyActive();
            return View(model);
        }
    }
}