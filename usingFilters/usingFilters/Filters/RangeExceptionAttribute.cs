using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace usingFilters.Filters
{
    public class RangeExceptionAttribute : ExceptionFilterAttribute
    {
        /*
         * Bir action'da bir nedenle ArgumentOutOfRange hatası oluşursa, bu filtre devreye girsin ve kullanıcıya bir mesaj iletsin.
         * 
         */
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ArgumentOutOfRangeException)
            {
                var actualValue = ((ArgumentOutOfRangeException)context.Exception).ActualValue;
                context.Result = new ViewResult()
                {
                    ViewName = "Mesaj",
                    ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                    {
                        Model = $"{actualValue} değeri, istenen aralıkta değil! 10'dan küçük değer almalı"
                    }
                };
            }
        }
    }
}
