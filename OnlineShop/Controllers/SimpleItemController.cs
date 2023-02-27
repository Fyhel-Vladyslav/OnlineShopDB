using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class SimpleItemController : Controller
    {
        private readonly IAllItems _allItems;
        public SimpleItemController(IAllItems iAllItems)
        {
            _allItems = iAllItems;

        }

        public IActionResult Index(int id = 0)
        {
            return View(_allItems.getObjectItem(id));
        }
    }
}
