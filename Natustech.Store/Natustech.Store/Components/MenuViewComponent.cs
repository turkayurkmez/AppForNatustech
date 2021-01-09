using Microsoft.AspNetCore.Mvc;
using Natustech.Store.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private ICategoryService categoryService;

        public MenuViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var result = categoryService.GetCategories().AsEnumerable();
            return View(result);
        }
    }
}
