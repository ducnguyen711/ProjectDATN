using WatchStore.Web.Data;
using WatchStore.Web.Infrastructures;
using WatchStore.Web.Models;
using WatchStore.Web.Repositories.IRepository;

namespace WatchStore.Web.Repositories.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(WatchStoreDbContext context) : base(context)
        {
        }
    }
}
