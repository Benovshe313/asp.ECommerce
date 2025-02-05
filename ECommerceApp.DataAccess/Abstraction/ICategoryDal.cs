using ECommerce.Core.DataAccess;
using ECommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DataAccess.Abstraction
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
