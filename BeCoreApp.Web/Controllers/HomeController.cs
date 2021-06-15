using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeCoreApp.Models;
using BeCoreApp.Application.Interfaces;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using BeCoreApp.Models.ProjectViewModels;
using BeCoreApp.Data.Enums;

namespace BeCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ITransactionService _transactionService;
        public HomeController(
            ITransactionService transactionService,
            IConfiguration configuration
            )
        {
            _transactionService = transactionService;
            _configuration = configuration;
        }

        //[ResponseCache(CacheProfileName ="Default")]
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            //model.HomeBlogs = _blogService.GetHomeBlogs();
            //model.MainItems = _blogCategoryService.GetMainItems();
            model.TotalFreeWithdrawls = _transactionService.CountByType(TransactionType.WithdrawELC);
            model.PercentFreeWithdrawls = Math.Round((decimal)model.TotalFreeWithdrawls / 4000000, 5);
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
