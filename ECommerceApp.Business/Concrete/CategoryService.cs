using ECommerce.Entities.Models;
using ECommerceApp.Business.Abstract;
using ECommerceApp.DataAccess.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _categoryDal.GetList();
        }
    }
}
