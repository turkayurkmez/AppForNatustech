#pragma checksum "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f41468ac0dd73d6ffcbb374793d7876a90ae514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Katilacaklar), @"mvc.1.0.view", @"/Views/Home/Katilacaklar.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\_ViewImports.cshtml"
using LifeCycleOfMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f41468ac0dd73d6ffcbb374793d7876a90ae514", @"/Views/Home/Katilacaklar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747e1671e5bc22b9d8d7eb59ee8dd4a3a623ed7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Katilacaklar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<YanitModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        Henüz yanıt eklenmedi!\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Katılacaklar listesi</h3>\r\n    <table class=\"table table-striped\">\r\n        <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml"
             foreach (var yanit in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml"
                   Write(yanit.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml"
                   Write(yanit.Eposta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 26 "C:\Users\turka\source\repos\Kurumsal\Natustech\.NET Core\LifeCycleOfMVC\LifeCycleOfMVC\Views\Home\Katilacaklar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<YanitModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
