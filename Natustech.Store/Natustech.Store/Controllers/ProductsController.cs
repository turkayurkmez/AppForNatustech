using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Natustech.Store.Business;
using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Controllers
{
    public class ProductsController : Controller
    {
        private ICategoryService categoryService;
        private IProductService productService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.categoryService = categoryService;
            this.productService = productService;
        }
        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);

        }

        public IActionResult Create()
        {
            List<SelectListItem> optionList = GetCategoriesForSelect();
            ViewBag.Options = optionList.AsEnumerable();
            return View();
        }

        private List<SelectListItem> GetCategoriesForSelect()
        {
            var optionList = new List<SelectListItem>();
            var categories = categoryService.GetCategories();
            categories.ToList().ForEach(c =>
            {
                SelectListItem selectListItem = new SelectListItem { Text = c.Name, Value = c.Id.ToString() };
                optionList.Add(selectListItem);
            });
            return optionList;
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                //db'ye kaydet:
                productService.AddProduct(product);
                return Json("OK");
            }
            ViewBag.Options = GetCategoriesForSelect().AsEnumerable();
            return View();
        }

    }
}
