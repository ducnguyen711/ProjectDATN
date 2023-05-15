using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WatchStore.Web.Infrastructures;
using WatchStore.Web.Models;

namespace WatchStore.Web.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReviewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index([Bind("Id, Vote, Comment, CreateDate, FullName, ProductId")] Review review)
        {
            //if (ModelState.IsValid)
            //{
            review.CreatedDate = DateTime.Now;
            _unitOfWork.WatchStoreDbContext.Reviews.Add(review);
            await _unitOfWork.SaveChangeAsync();
            return Ok();
        }
    }
}
