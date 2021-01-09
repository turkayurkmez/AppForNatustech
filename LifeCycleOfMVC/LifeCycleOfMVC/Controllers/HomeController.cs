using LifeCycleOfMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Yanit()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{ Text="Evet katılacağım", Value= Boolean.TrueString},
                new SelectListItem{ Text="Hayır katılmayacağım", Value= Boolean.FalseString},

            };
            ViewBag.Items = items;
            return View();
        }
        [HttpPost]
        public IActionResult Yanit(YanitModel yanitModel)
        {
            if (ModelState.IsValid)
            {
                if (yanitModel.KatilimDurumu)
                {
                    GelenKatilimcilar.Yanitlar.Add(yanitModel);
                }
                return View("kabul",yanitModel);

            }
            var gelenKatilimcilar = GelenKatilimcilar.Yanitlar;
            return View();
        }

        public IActionResult Katilacaklar()
        {
            var katilanlar = GelenKatilimcilar.Yanitlar;
            return View(katilanlar);
        }

    }
}
