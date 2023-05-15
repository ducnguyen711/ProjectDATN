using Microsoft.AspNetCore.Mvc;
using WatchStore.Web.Services;

namespace WatchStore.Web.Views.Shared.Components.CartInCheckOut
{
    public class CartInCheckOut : ViewComponent
    {
        private readonly CartService _cartService;
        public CartInCheckOut(CartService cartService)
        {
            _cartService = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cartService.GetCartItems());
        }
    }
}
