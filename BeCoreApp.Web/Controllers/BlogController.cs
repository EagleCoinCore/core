using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeCoreApp.Application.Interfaces;
using BeCoreApp.Data.Enums;
using BeCoreApp.Models.BlogViewModels;
using BeCoreApp.Utilities.Constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace BeCoreApp.Controllers
{
    public class BlogController : Controller
    {
        IMenuGroupService _menuGroupService;
        IMenuItemService _menuItemService;
        IBlogCategoryService _blogCategoryService;
        IBlogService _blogService;
        IConfiguration _configuration;
        public BlogController(
            IMenuGroupService menuGroupService,
            IMenuItemService menuItemService,
            IBlogCategoryService blogCategoryService,
            IBlogService blogService,
            IConfiguration configuration)
        {
            _menuGroupService = menuGroupService;
            _menuItemService = menuItemService;
            _blogCategoryService = blogCategoryService;
            _blogService = blogService;
            _configuration = configuration;
        }

        [Route("chu-de-bai-viet/{id}.html")]
        public IActionResult BlogTag(string id, int? pageSize, int page = 1)
        {
            var catalog = new CatalogViewModel();
            catalog.Tag = _blogService.GetTagById(id);
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("BlogPageSize");

            catalog.PageSize = pageSize;
            catalog.Data = _blogService.GetAllByTagId(id, page, pageSize.Value);
            catalog.Tags = _blogService.GetListTagByType(CommonConstants.BlogTag);
            catalog.SideBarBlogCategorys = _blogCategoryService.SideBarCategoryByType(MenuFrontEndType.None);

            return View(catalog);
        }


        [Route("{alias}-bc.{id}.html")]
        public IActionResult BlogCategory(int id, int? pageSize, int page = 1)
        {
            var catalog = new CatalogViewModel();
            catalog.BlogCategory = _blogCategoryService.GetById(id);
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("BlogPageSize");

            catalog.PageSize = pageSize;
            catalog.Data = _blogService.GetAllPaging("", "", "", id, page, pageSize.Value);
            catalog.Tags = _blogService.GetListTagByType(CommonConstants.BlogTag);
            catalog.SideBarBlogCategorys = _blogCategoryService.SideBarCategoryByType(MenuFrontEndType.None);

            return View(catalog);
        }

        public IActionResult Search(string searchValue, int? pageSize, int page = 1)
        {
            var catalog = new CatalogViewModel();
            catalog.SearchValue = searchValue;
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("BlogPageSize");

            catalog.PageSize = pageSize;
            catalog.Data = _blogService.GetAllPaging("", "", searchValue, 0, page, pageSize.Value);
            catalog.Tags = _blogService.GetListTagByType(CommonConstants.BlogTag);
            catalog.SideBarBlogCategorys = _blogCategoryService.SideBarCategoryByType(MenuFrontEndType.None);

            ViewBag.Search = searchValue;
            return View(catalog);
        }

        [Route("{alias}-b.{id}.html", Name = "BlogDetail")]
        public IActionResult BlogDetail(int id)
        {
            _blogService.UpdateViewCount(id);

            var catalog = new DetailViewModel();
            catalog.Blog = _blogService.GetById(id);
            catalog.BlogCategory = _blogCategoryService.GetById(catalog.Blog.BlogCategoryId);
            catalog.Tags = _blogService.GetListTagByType(CommonConstants.BlogTag);
            catalog.SideBarBlogCategorys = _blogCategoryService.SideBarCategoryByType(MenuFrontEndType.None);
            catalog.BlogTags = _blogService.GetListTagByBlogId(catalog.Blog.Id);

            return View(catalog);
        }
    }
}