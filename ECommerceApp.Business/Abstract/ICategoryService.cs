using ECommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Business.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
    }
}
