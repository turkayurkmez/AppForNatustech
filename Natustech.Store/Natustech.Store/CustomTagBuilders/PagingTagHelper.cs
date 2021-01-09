using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Natustech.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.CustomTagBuilders
{
    [HtmlTargetElement("div", Attributes ="page-model")]
    public class PagingTagHelper : TagHelper
    {
        /*
         * <div>
                <ul class="pagination justify-content-center">                    
                     <li class="page-item"><a class="page-link" href="#">1</a></li>      
                </ul>
            </div>
         */
        private IUrlHelperFactory urlHelperFactory;
        public PagingTagHelper(IUrlHelperFactory helperFactory)
        {
            this.urlHelperFactory = helperFactory;
        }

        //Bir View içinden ulaşabileceğiniz tüm birimlerdir.
        [ViewContext]
        [HtmlAttributeNotBound] // Html attribute içinde, "ViewContext" adında bir attribute istemiyoruz. 
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }
        /*
      * <div>
             <ul class="pagination justify-content-center">                    
                  <li class="page-item"><a class="page-link" href="#">1</a></li>      
             </ul>
         </div>
      */
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper helper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder div = new TagBuilder("div");
            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination");
            ul.AddCssClass("justify-content-center");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder li = new TagBuilder("li");
                li.AddCssClass("page-item");
                if (i==PageModel.CurrentPage)
                {
                    li.AddCssClass("active");
                }
                TagBuilder a = new TagBuilder("a");
                a.AddCssClass("page-link");
                PageUrlValues["page"] = i;
                a.Attributes["href"] = helper.Action(PageAction, PageUrlValues);
                a.InnerHtml.AppendHtml(i.ToString());
                li.InnerHtml.AppendHtml(a);
                ul.InnerHtml.AppendHtml(li);
            }
            div.InnerHtml.AppendHtml(ul);
            output.Content.AppendHtml(div.InnerHtml);
        }

    }
}
