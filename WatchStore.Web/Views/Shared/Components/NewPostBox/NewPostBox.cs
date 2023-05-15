using Microsoft.AspNetCore.Mvc;
using WatchStore.Web.Data;

namespace WatchStore.Web.Views.Shared.Components.NewPostBox
{
    public class NewPostBox : ViewComponent
    {
        private readonly WatchStoreDbContext _context;
        public NewPostBox(WatchStoreDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var list = _context.Posts.OrderBy(p => p.CreatedDate).Take(5).ToList();
            return View(list);
        }
    }
}
