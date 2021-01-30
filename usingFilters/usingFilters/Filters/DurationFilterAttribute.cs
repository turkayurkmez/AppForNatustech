using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using usingFilters.Models;

namespace usingFilters.Filters
{
    public class DurationFilterAttribute : ActionFilterAttribute,IActionFilter
    {
        Stopwatch stopwatch;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            stopwatch = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            stopwatch.Stop();
            ViewResult viewResult = (ViewResult)context.Result;
            //ViewBag
            viewResult.ViewData["Sure"] = $"İşlem süresi: {stopwatch.Elapsed.TotalMilliseconds} ms";
            //Model:
            if (viewResult.Model != null && viewResult.Model is RequestData)
            {
                var model = (RequestData)viewResult.Model;
                model.ElapsedTime = stopwatch.Elapsed.TotalMilliseconds;
            }


            
        }
    }
}
