using WatchStore.Web.Data;
using WatchStore.Web.Infrastructures;
using WatchStore.Web.Models;
using WatchStore.Web.Repositories.IRepository;

namespace WatchStore.Web.Repositories.Repository
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(WatchStoreDbContext context) : base(context)
        {
        }
    }
}
