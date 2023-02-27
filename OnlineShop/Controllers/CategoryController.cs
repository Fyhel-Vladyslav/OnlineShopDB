using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IAllCategories _allCategories;

        public CategoryController(IAllCategories iItemsCategory)
        {
            _allCategories = iItemsCategory;
        }
        public IActionResult Index()
        {
            var categories = _allCategories.AllCategories;
            return View(categories);
        }
    }
}
