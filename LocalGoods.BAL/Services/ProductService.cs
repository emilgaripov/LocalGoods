using LocalGoods.Core;
using LocalGoods.Core.Models;
using LocalGoods.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalGoods.BAL.Services
{
    public class ProductService //: IProductService
    {
        //private readonly IUnitOfWork unitOfWork;
        //public ProductService(IUnitOfWork unitOfWork)
        //{
        //    this.unitOfWork = unitOfWork;
        //}

        //public async Task<Product> Create(Product newProduct)
        //{
        //    await unitOfWork.Products.AddAsync(newProduct);
        //    await unitOfWork.CommitAsync();
        //    return newProduct;
        //}

        //public async Task Delete(Product product)
        //{
        //    unitOfWork.Products.Remove(product);
        //    await unitOfWork.CommitAsync(); 
        //}

        //public async Task<IEnumerable<Product>> GetAllWithCategory()
        //{
        //    return await unitOfWork.Products.GetAllWithCategoryAsync();
        //}

        //public async Task<Product> GetById(int id)
        //{
        //    return await unitOfWork.Products.GetWithCategoryByIdAsync(id);
        //}

        //public async Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId)
        //{
        //    return await unitOfWork.Products.GetAllWithCategoryByCategoryIdAsync(categoryId);
        //}

        //public async Task Update(Product productToBeUpdated, Product product)
        //{
        //    productToBeUpdated.Name=product.Name;
        //    productToBeUpdated.CategoryId=product.CategoryId;
        //    await unitOfWork.CommitAsync();
        //}
    }
}
