using Microsoft.AspNetCore.Mvc;
using OnlineShop.Helpers;
using OnlineShop.Interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IAllItems _allItems;
        public CartController(IAllItems iAllItems)
        {
            _allItems = iAllItems;
        }


        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }


        public EmptyResult AddToCart(int id)
        {
            int amount = 1;
            var cart = GetCart();
            var cartItem = new CartLine();

            cartItem.Item = _allItems.getObjectItem(id);
            cartItem.Quantity = amount;

            cart.Add(cartItem);
            HttpContext.Session.SetObjectAsJson("cart", cart);
                return new EmptyResult();
        }


        private List<CartLine> GetCart()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartLine>>("cart");
            if (cart == null)
            {
                Cart cartItems = new Cart();
                cart = new List<CartLine>();
                cartItems.AddItem(_allItems.getObjectItem(1), 2);
                cart.AddRange(cartItems.Lines);
                HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            return cart;
        }
/*
        public RedirectToActionResult AddToCart(int itemId,string returnUrl)
        {
            Item item = _allItems.getObjectItem(itemId);

            if(item != null)
            {
                
            }
            return RedirectToAction("Index", new {returnUrl})
        }

        */
    }

}
