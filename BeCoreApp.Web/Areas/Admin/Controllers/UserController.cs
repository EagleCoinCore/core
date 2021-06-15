using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeCoreApp.Application.Interfaces;
using BeCoreApp.Application.ViewModels.System;
using BeCoreApp.Authorization;
using BeCoreApp.Extensions;
using BeCoreApp.Utilities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeCoreApp.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IRoleService _roleService;
        private readonly IUserService _userService;
        private readonly IAuthorizationService _authorizationService;
        public UserController(IUserService userService,
            IRoleService roleService,
            IAuthorizationService authorizationService)
        {
            _userService = userService;
            _roleService = roleService;
            _authorizationService = authorizationService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _authorizationService.AuthorizeAsync(User, "USER", Operations.Read);
            if (result.Succeeded == false)
                return new RedirectResult("/Admin/Account/Login");

            var roles = await _roleService.GetAllAsync();
            ViewBag.RoleId = new SelectList(roles, "Name", "Name");

            return View();
        }

        public async Task<IActionResult> IndexTree()
        {
            var result = await _authorizationService.AuthorizeAsync(User, "USER", Operations.Read);
            if (result.Succeeded == false)
                return new RedirectResult("/Admin/Account/Login");

            return View();
        }

        [HttpGet]
        public IActionResult GetTreeAll()
        {
            var model = _userService.GetTreeAll();
            return new ObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _userService.GetAllPagingAsync(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        public async Task<IActionResult> Customers()
        {
            var result = await _authorizationService.AuthorizeAsync(User, "USER", Operations.Read);
            if (result.Succeeded == false)
                return new RedirectResult("/Admin/Account/Login");

            return View();
        }

        [HttpGet]
        public IActionResult GetAllCustomerPaging(string keyword, int page, int pageSize)
        {
            var model = _userService.GetAllCustomerPagingAsync(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            var model = await _userService.GetById(id);

            return new OkObjectResult(model);
        }



        [HttpPost]
        public async Task<IActionResult> SaveEntity(AppUserViewModel userVm)
        {
            var roleName = User.GetSpecificClaim("RoleName");
            if (roleName.ToLower() != "admin")
                return RedirectToAction("Index", "Home");

            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            else
            {
                if (userVm.Id == null)
                    await _userService.AddAsync(userVm);
                else
                    await _userService.UpdateAsync(userVm);

                return new OkObjectResult(userVm);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomer(string id)
        {
            try
            {
                var model = await _userService.GetById(id);
                if (model.EmailConfirmed == true)
                {
                    return new OkObjectResult(new GenericResult(false, "Accounts confirmed email cannot be deleted."));
                }

                await _userService.DeleteAsync(id);

                return new OkObjectResult(new GenericResult(true, "Account deleted successfully"));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }


        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var roleName = User.GetSpecificClaim("RoleName");
            if (roleName.ToLower() != "admin")
                return RedirectToAction("Index", "Home");

            if (!ModelState.IsValid)
                return new BadRequestObjectResult(ModelState);
            else
            {
                await _userService.DeleteAsync(id);

                return new OkObjectResult(id);
            }
        }
    }
}