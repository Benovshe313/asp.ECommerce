using ECommerce.Entities.Models;

namespace ECommerceApp.UI
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; internal set; }
        public int PageSize { get; internal set; }
        public int PageCount { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public string CurrentProducts { get; internal set; }
        public string CurrentPrice { get; internal set; }
    }
}