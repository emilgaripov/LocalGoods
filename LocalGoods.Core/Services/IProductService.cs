using LocalGoods.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalGoods.Core.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllWithCategory();
        Task<Product> GetById(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId); 
        Task<Product> Create(Product newProduct);
        Task Update(Product productToBeUpdated, Product product);
        Task Delete(Product product);
    }
}
