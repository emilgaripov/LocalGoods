using LocalGoods.DAL.Data;
//using LocalGoods.DAL.Models;
using Microsoft.EntityFrameworkCore;
using LocalGoods.Core.Models;
using LocalGoods.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace LocalGoods.DAL.Repositories
{
    //public class ProductRepository : Repository<Product>,IProductRepository
    //{
    //    public ProductRepository(LocalGoodsDbContext context) : base(context) { }


    //     public async Task<IEnumerable<Product>> GetAllWithCategoryAsync()
    //     {
    //        return await LocalGoodsDbContext.Products.Include(a => a.Category).ToListAsync();
    //     }

    //    public async Task<Product> GetWithCategoryByIdAsync(int id)
    //    {
    //        return await LocalGoodsDbContext.Products
    //            .Include(m => m.Category)
    //            .SingleOrDefaultAsync(m => m.Id == id); 
    //    }

    //    public async Task<IEnumerable<Product>> GetAllWithCategoryByCategoryIdAsync(int categoryId)
    //    {
    //        return await LocalGoodsDbContext.Products
    //            .Include(m => m.Category)
    //            .Where(m => m.CategoryId == categoryId)
    //            .ToListAsync();
    //    }

    //    //private LocalGoodsDbContext LocalGoodsDbContext
    //    //{
    //    //    get { return Context as LocalGoodsDbContext; }
    //    //}
    //}
}
