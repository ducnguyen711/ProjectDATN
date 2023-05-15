using WatchStore.Web.Data;
using WatchStore.Web.Repositories.IRepository;

namespace WatchStore.Web.Infrastructures
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        IPostRepository PostRepository { get; }

        WatchStoreDbContext WatchStoreDbContext { get; }

        int SaveChange();

        Task<int> SaveChangeAsync();
    }
}
