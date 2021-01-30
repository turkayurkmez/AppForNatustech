using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles ="Admin")]
    public class ProductsController : Controller
    {
        private ICategoryService categoryService;
        private IProductService productService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.categoryService = categoryService;
            this.productService = productService;
        }
        [AllowAnonymous]
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

        [HttpPost]

        public IActionResult Create([Bind("Token,Name,Description,Price, Rating, ImageUrl, Discount, ProductInfo, StockCount, OrderNumber,CategoryId")] Product product)
        {
            //token değeri, manuel olarak karşılaştırılmalı.
            if (ModelState.IsValid)
            {
                //db'ye kaydet:
                var added = productService.AddProduct(product);
                return Json(added.Name);
            }
            ViewBag.Options = GetCategoriesForSelect().AsEnumerable();
            return View();
        }


        public IActionResult Edit(int id)
        {
            var product = productService.GetProductById(id);
            var categories = GetCategoriesForSelect();
            ViewBag.Categories = categories;
            return View(product);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id,Name,Price,Description, Rating, ImageUrl, Discount, StockCount,CategoryId,OrderNumber, ProductInfo")] Product product)
        {
            if (ModelState.IsValid)
            {
                productService.Update(product);
                return RedirectToAction(nameof(Index));
            }
            return View();


        }

        public IActionResult Delete(int id)
        {
            //Silmek istediğinize emin misiniz?
            return View();
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            //productService.Delete(id);
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



    }
}
