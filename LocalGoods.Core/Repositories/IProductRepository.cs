using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalGoods.Core.Models;

namespace LocalGoods.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllWithCategoryAsync();
        Task<Product> GetWithCategoryByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllWithCategoryByCategoryIdAsync(int categoryId);

    }
}
