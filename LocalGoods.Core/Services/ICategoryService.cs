using LocalGoods.Core.Models;

namespace LocalGoods.Core.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetById(int id);
        Task Create(Category category);
        Task Update(Category category);
        Task Delete(Category category);
    }
}
