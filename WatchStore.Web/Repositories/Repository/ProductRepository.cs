using WatchStore.Web.Data;
using WatchStore.Web.Infrastructures;
using WatchStore.Web.Models;
using WatchStore.Web.Repositories.IRepository;

namespace WatchStore.Web.Repositories.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(WatchStoreDbContext context) : base(context)
        {
        }
    }
}
