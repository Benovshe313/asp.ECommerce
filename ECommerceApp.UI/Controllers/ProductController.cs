using ECommerce.Entities.Models;
using ECommerceApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private static string oldSortName;
        private static string oldSortPrice;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index(int page = 1, int category = 0, string sortProducts = "asc", string sortPrice = "asc")
        {
            var items = await _productService.GetAllByCategoryId(category);
           
            
            if (oldSortName != sortProducts)
            {
                if (sortProducts == "asc")
                {
                    items = items.OrderBy(p => p.ProductName).ToList();
                }
                else
                {
                    items = items.OrderByDescending(p => p.ProductName).ToList();
                }
                oldSortName = sortProducts;
            }

            if (oldSortPrice != sortPrice)
            {
                if (sortPrice == "asc")
                {
                    items = items.OrderBy(p => p.UnitPrice).ToList();
                }
                else
                {
                    items = items.OrderByDescending(p => p.UnitPrice).ToList();
                }
                oldSortPrice = sortPrice;
            }

            if (oldSortName == "")
            {
                oldSortName = sortProducts;
            }
            if (oldSortPrice == "")
            {
                oldSortPrice = sortPrice;
            }


            var pageSize = 10;

            var model = new ProductListViewModel
            {
                Products = items.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPage = page,
                PageSize = pageSize,
                PageCount = (int)Math.Ceiling(items.Count / (decimal)pageSize),
                CurrentCategory = category,
                CurrentProducts = sortProducts,
                CurrentPrice = sortPrice
            };

            return View(model);
        }
    }
}
