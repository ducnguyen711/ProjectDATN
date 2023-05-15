﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WatchStore.Web.Data;

namespace WatchStore.Web.Views.Shared.Components.RelatedProductsBox
{
    public class RelatedProductsBox : ViewComponent
    {
        private readonly WatchStoreDbContext _context;
        public RelatedProductsBox(WatchStoreDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var list = _context.Products.Include(p => p.ProductImages).Include(p => p.Category).AsQueryable();
            Random random = new Random();
            int temp = random.Next(4);
            if (temp == 0)
            {
                list.OrderBy(p => p.Id);
            }
            else if (temp == 1)
            {
                list.OrderBy(p => p.ProductName);
            }
            else if (temp == 2)
            {
                list.OrderBy(p => p.Summary);
            }
            else if (temp == 3)
            {
                list.OrderBy(p => p.Price);
            }
            return View(list.Take(4).ToList());
        }
    }
}
