using IntrodotnetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntrodotnetCore.Controllers
{
    public class HomeController : Controller
    {
        //amaç: hangi talepte hangi view gösterilecek ve hangi view hangi model'i gönderecek?
        public IActionResult Index()
        {
            //dynamicObject:
            ViewBag.Isim = "Türkay";
            ViewBag.Saat = DateTime.Now.Hour;
            List<Product> products = new List<Product>
            {
                new Product{ Id=1, Name="Kitap", Description="Roman", Price=10, Rating=5},
                new Product{ Id=2, Name="Film", Description="Bilim-Kurgu", Price=20, Rating=4.5f},
                new Product{ Id=3, Name="Telefon", Description="Iphone", Price=10000, Rating=4.2f},


            };
            return View(products);
        }
    }
}
