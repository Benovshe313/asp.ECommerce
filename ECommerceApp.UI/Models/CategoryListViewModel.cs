using ECommerce.Entities.Models;

namespace ECommerceApp.UI
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}