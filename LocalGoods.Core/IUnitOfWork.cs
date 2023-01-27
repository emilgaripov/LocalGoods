using LocalGoods.Core.Repositories;

namespace LocalGoods.Core
{
    public interface IUnitOfWork : IDisposable
    {
        //IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task CommitAsync();
    }
}
