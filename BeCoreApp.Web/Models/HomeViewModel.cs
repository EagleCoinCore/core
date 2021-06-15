using BeCoreApp.Application.ViewModels;
using BeCoreApp.Application.ViewModels.Blog;
using BeCoreApp.Application.ViewModels.Common;
using BeCoreApp.Application.ViewModels.Product;
using System.Collections.Generic;

namespace BeCoreApp.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            MainItems = new List<BlogCategoryViewModel>();
            HomeBlogs = new List<BlogViewModel>();
        }
        public List<BlogCategoryViewModel> MainItems { get; set; }
        public List<BlogViewModel> HomeBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }

        public int TotalFreeWithdrawls { get; set; }
        public decimal PercentFreeWithdrawls { get; set; }
    }
}
