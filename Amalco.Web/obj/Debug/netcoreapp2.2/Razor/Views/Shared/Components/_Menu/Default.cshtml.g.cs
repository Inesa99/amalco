#pragma checksum "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8d5d012187b5a35e7ec0d3432faf71f790121c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components__Menu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8d5d012187b5a35e7ec0d3432faf71f790121c", @"/Views/Shared/Components/_Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318eea45e95c4bff299d1cfc41312817610659d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuListVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/down-arrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right mt2_5 mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Main/flag_indonezia.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Main/flag_shrilanka.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 21, true);
            WriteLiteral("<div class=\"_menu\">\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(94, 86, true);
            WriteLiteral("        <div class=\"borderblue mb-2 menu-item\">\r\n            <div class=\"mt-2 mb-2\">\r\n");
            EndContext();
            BeginContext(270, 40, true);
            WriteLiteral("                <span class=\"pt-3 pl-2\">");
            EndContext();
            BeginContext(311, 10, false);
#line 8 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(321, 25, true);
            WriteLiteral("</span>\r\n                ");
            EndContext();
            BeginContext(346, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c8d5d012187b5a35e7ec0d3432faf71f790121c6463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(420, 50, true);
            WriteLiteral("\r\n                <div class=\"childs mt-2 mb-2\">\r\n");
            EndContext();
#line 11 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml"
                     foreach (var child in item.ChildMenues)
                    {

#line default
#line hidden
            BeginContext(555, 154, true);
            WriteLiteral("                        <div class=\"borderblue mb-2 mt-2\">\r\n                            <div class=\"mt-2 mb-2 pl-4\">\r\n\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 709, "\"", 727, 2);
            WriteAttributeValue("", 716, "/", 716, 1, true);
#line 16 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml"
WriteAttributeValue("", 717, child.Url, 717, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(728, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(802, 11, false);
#line 16 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml"
                                                                                                                         Write(child.Title);

#line default
#line hidden
            EndContext();
            BeginContext(813, 76, true);
            WriteLiteral("</a>\r\n\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 20 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(912, 60, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_Menu\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(979, 311, true);
            WriteLiteral(@"    <ul class=""mini-menu"">
        <li>
            <a href=""/pomosch-pri-vybore"">Помощь при выборе</a>
        </li>
        <li>
            <a href=""/metodi-podbora"">Методы подбора</a>
        </li>
        <li><a href=""/nashi-filialy"">Наши филиалы</a></li>
    </ul>
    <div class=""ind"">
        ");
            EndContext();
            BeginContext(1290, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c8d5d012187b5a35e7ec0d3432faf71f790121c10165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1336, 111, true);
            WriteLiteral("\r\n        <span>Персонал из Индонезии от 40 000 рублей!</span>\r\n    </div>\r\n    <div class=\"sh mt-3\">\r\n        ");
            EndContext();
            BeginContext(1447, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c8d5d012187b5a35e7ec0d3432faf71f790121c11455", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 89, true);
            WriteLiteral("\r\n        <span>Персонал из Шри-Ланки от 35000 рублей!</span>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuListVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
