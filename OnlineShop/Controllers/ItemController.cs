using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class ItemController : Controller
    {
        private readonly IAllItems _allItems;

        public ItemController(IAllItems iAllItems)
        {
            _allItems = iAllItems;
        }
        public ViewResult Index(int id)
        {
            var items = _allItems.getCategoryItems(id);
            return View(items);
        }
    }
}
