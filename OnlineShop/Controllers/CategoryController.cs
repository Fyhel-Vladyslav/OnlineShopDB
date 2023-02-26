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
        public IActionResult Index()
        {
            return View();
        }
    }
}
