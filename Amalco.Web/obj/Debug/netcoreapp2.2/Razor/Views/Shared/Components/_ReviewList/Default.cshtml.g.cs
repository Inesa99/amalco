#pragma checksum "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ReviewList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e121f38a3c8900fb6aa06e169e131ffeffde43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ReviewList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ReviewList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_ReviewList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components__ReviewList_Default))]
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
#line 1 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\_ViewImports.cshtml"
using Amalco.Web;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\_ViewImports.cshtml"
using Amalco.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\_ViewImports.cshtml"
using Amalco.Data.ViewModels.Service;

#line default
#line hidden
#line 4 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\_ViewImports.cshtml"
using Amalco.Data.ViewModels.Page;

#line default
#line hidden
#line 5 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\_ViewImports.cshtml"
using Amalco.Data.ViewModels.Profile;

#line default
#line hidden
#line 6 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\_ViewImports.cshtml"
using Amalco.Data.ViewModels.Order;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e121f38a3c8900fb6aa06e169e131ffeffde43", @"/Views/Shared/Components/_ReviewList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318eea45e95c4bff299d1cfc41312817610659d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__ReviewList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReviewVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 231, true);
            WriteLiteral("<div class=\"row feedbacks mt-5 pb-5 w-100 mr-0 ml-0\">\r\n    <h3 class=\"col-md-12 col-12 text-center  pt-5 mb-3 pb-3\">Отзывы наших клиентов</h3>\r\n    <div class=\"offset-md-2 col-md-8 offset-1 col-10\">\r\n        <div class=\" slider\">\r\n");
            EndContext();
#line 6 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ReviewList\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
            BeginContext(317, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 333, "\"", 341, 0);
            EndWriteAttribute();
            BeginContext(342, 59, true);
            WriteLiteral(" style=\"width:300px;padding:0 10px;\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 401, "\"", 434, 2);
            WriteAttributeValue("", 407, "/images/Reviews/", 407, 16, true);
#line 9 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ReviewList\Default.cshtml"
WriteAttributeValue("", 423, item.Image, 423, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(435, 87, true);
            WriteLiteral(" class=\"width100 pb-3\" />\r\n                <p class=\"fontsize10 text-center pl-4 pr-4\">");
            EndContext();
            BeginContext(523, 12, false);
#line 10 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ReviewList\Default.cshtml"
                                                       Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(535, 86, true);
            WriteLiteral("</p>\r\n                <hr />\r\n                <p class=\"fontsize10 text-center mb-0 \">");
            EndContext();
            BeginContext(622, 9, false);
#line 12 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ReviewList\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(631, 56, true);
            WriteLiteral("</p>\r\n                <p class=\"fontsize10 text-center\">");
            EndContext();
            BeginContext(688, 15, false);
#line 13 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ReviewList\Default.cshtml"
                                             Write(item.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(703, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 15 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ReviewList\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(744, 76, true);
            WriteLiteral("            \r\n            \r\n            \r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReviewVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591