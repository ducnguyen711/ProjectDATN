using Microsoft.AspNetCore.Mvc;
using WatchStore.Web.Infrastructures;
using WatchStore.Web.Services;

namespace WatchStore.Web.Views.Shared.Components.CategoryBox
{
    public class CategoryBox : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryBox(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            var list = _unitOfWork.WatchStoreDbContext.Categories.ToList();
            return View(list);
        }
    }
}
