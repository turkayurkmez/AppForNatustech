using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using usingFilters.Filters;
using usingFilters.Models;

namespace usingFilters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            Thread.Sleep(1500);
            return View();
        }
        
        public IActionResult Privacy()
        {
            RequestData requestData = new RequestData();
            return View(requestData);
        }
        [RangeException]
        public IActionResult Hatali(int id)
        {
            if (id>10)
            {
                throw new ArgumentOutOfRangeException(nameof(id),id,null);
            }
            return View("Mesaj","Doğru çalıştı");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
