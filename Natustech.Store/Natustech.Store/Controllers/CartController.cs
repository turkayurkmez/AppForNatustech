using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natustech.Store.Business;
using Natustech.Store.Domain;
using Natustech.Store.Extensions;
using Natustech.Store.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Controllers
{
    public class CartController : Controller
    {
        private IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            Cart cart = GetCart();

            return View(cart);
        }

        public IActionResult AddToCart(int id)
        {
            Product product = productService.GetProductById(id);
            if (product == null)
            {
                return BadRequest();
            }

            Cart cart = GetCart();
            cart.AddItem(product, 1);
            SaveCart(cart);


            return Json("OK");
        }

        public IActionResult RemoveCart(int id)
        {
            Cart cart = GetCart();
            var product = productService.GetProductById(id);
            cart.Remove(product);
            SaveCart(cart);
            return Json("OK");
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("sepetim") ?? new Cart();
            return cart;
        }

      

        void SaveCart(Cart cart) {
            HttpContext.Session.SetString("isOnline", "true");
            HttpContext.Session.SetJson("sepetim", cart);


        }
    }
}
