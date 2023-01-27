using LocalGoods.Core;
using LocalGoods.Core.Repositories;
using LocalGoods.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace LocalGoods.DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LocalGoodsDbContext localGoodsDbContext;
        //private ProductRepository productRepository;
        private CategoryRepository categoryRepository;
        public UnitOfWork(LocalGoodsDbContext localGoodsDbContext)
        {
            this.localGoodsDbContext = localGoodsDbContext;
        }
        //public IProductRepository Products => productRepository ??= new ProductRepository(localGoodsDbContext);
        public ICategoryRepository Categories => categoryRepository ??= new CategoryRepository(localGoodsDbContext);
        public async Task CommitAsync()
        {
            await localGoodsDbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            localGoodsDbContext.Dispose();
        }
    }
}
