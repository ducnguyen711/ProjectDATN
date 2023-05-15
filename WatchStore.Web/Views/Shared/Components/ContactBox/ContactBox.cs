using Microsoft.AspNetCore.Mvc;
using WatchStore.Web.Data;

namespace WatchStore.Web.Views.Shared.Components.ContactBox
{
    [ViewComponent]
    public class ContactBox : ViewComponent
    {
        private readonly WatchStoreDbContext _context;
        public ContactBox(WatchStoreDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var list = (from c in _context.Contacts
                        orderby c.DateSent descending
                        select c).Take(4).ToList();
            return View(list);
        }
    }
}
