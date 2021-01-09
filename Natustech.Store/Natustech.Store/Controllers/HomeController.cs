using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Natustech.Store.Business;
using Natustech.Store.Domain;
using Natustech.Store.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public int PageSize { get; set; } = 4;
        public IActionResult Index(int page = 1, int? categoryId=0)
        {
            IList<Product> products = null;
            if (categoryId.HasValue && categoryId.Value != 0)
            {
                products = productService.GetProductsByCategoryId(categoryId.Value);
            }
            else
            {
                products = productService.GetProducts();
            }

          //  var pro2 = categoryId.HasValue ? productService.GetProductsByCategoryId(categoryId.Value) : productService.GetProducts();
          
            var orderedProducts = products.OrderBy(x => x.Id)
                                          .Skip((page - 1) * PageSize)
                                          .Take(PageSize);


            /*1. sayfa 0
              2.       4
              3.       8
             */
            PagingInfo pagingInfo = new PagingInfo { CurrentPage = page, PageSize = PageSize, TotalItemsCount = products.Count };
            var viewModel = new ProductListViewModel { Products = orderedProducts, PagingInfo = pagingInfo, CategoryId = categoryId.Value };
            

            var totalProductsCount = products.Count;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)totalProductsCount / PageSize);
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
