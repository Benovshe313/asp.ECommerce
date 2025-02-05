using ECommerceApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ECommerceApp.UI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var categories=await _categoryService.GetAllAsync();
            var param = HttpContext.Request.Query["category"];

            var category=int.TryParse(param, out var categoryId);

            var model = new CategoryListViewModel
            {
                Categories=categories,
                CurrentCategory=category ? categoryId : 0,
            };

            return View(model);
        }
    }
}
