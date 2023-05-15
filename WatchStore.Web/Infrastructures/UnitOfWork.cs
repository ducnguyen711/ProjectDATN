using WatchStore.Web.Data;
using WatchStore.Web.Repositories.IRepository;
using WatchStore.Web.Repositories.Repository;

namespace WatchStore.Web.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WatchStoreDbContext context;
        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;
        private IPostRepository postRepository;
        public UnitOfWork(WatchStoreDbContext context)
        {
            this.context = context;
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new CategoryRepository(this.context);
                }
                return this.categoryRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new ProductRepository(this.context);
                }
                return this.productRepository;
            }
        }
        public IPostRepository PostRepository
        {
            get
            {
                if (this.postRepository == null)
                {
                    this.postRepository = new PostRepository(this.context);
                }
                return this.postRepository;
            }
        }
        public WatchStoreDbContext WatchStoreDbContext => this.context;

        public void Dispose()
        {
            this.context.Dispose();
        }

        public int SaveChange()
        {
            return this.context.SaveChanges();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await this.context.SaveChangesAsync();
        }
    }
}
