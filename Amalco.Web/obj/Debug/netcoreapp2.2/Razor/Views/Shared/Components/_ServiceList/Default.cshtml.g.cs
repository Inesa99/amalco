#pragma checksum "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe254b4ddeab57e8a9cfb0a4f180f781ff3d9802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ServiceList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_ServiceList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components__ServiceList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe254b4ddeab57e8a9cfb0a4f180f781ff3d9802", @"/Views/Shared/Components/_ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318eea45e95c4bff299d1cfc41312817610659d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServiceListVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("width100 position-relative"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 92, true);
            WriteLiteral("\r\n<div class=\"offset-lg-2 col-lg-8 col-md-11 offset-1 col-10 mt-3\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 5 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(176, 177, true);
            WriteLiteral("            <div class=\"col-md-4 col-lg-3 offset-1 col-11 mb-5 pl-0 pr-0  mr-0 w-100\">\r\n                <div class=\"container middlemenuelement ml05rem\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 353, "\"", 370, 2);
            WriteAttributeValue("", 360, "/", 360, 1, true);
#line 9 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml"
WriteAttributeValue("", 361, item.Url, 361, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(371, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(398, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe254b4ddeab57e8a9cfb0a4f180f781ff3d98025564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 443, "~/images/Services/", 443, 18, true);
#line 10 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml"
AddHtmlAttributeValue("", 461, item.MainImage, 461, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(480, 138, true);
            WriteLiteral("\r\n                        <div class=\"content position-absolute\">\r\n                            <h6 class=\"text-white mb-0 ml-1 mr-1 mb-2\">");
            EndContext();
            BeginContext(619, 10, false);
#line 12 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml"
                                                                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(629, 113, true);
            WriteLiteral("</h6>\r\n                            <small class=\"text-white mb-0 ml-1 mr-1 middleborderd pl-3 pr-3 pb-1 pt-1\">от ");
            EndContext();
            BeginContext(743, 10, false);
#line 13 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml"
                                                                                                     Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(753, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(755, 19, false);
#line 13 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml"
                                                                                                                 Write(item.DisplayPayType);

#line default
#line hidden
            EndContext();
            BeginContext(774, 112, true);
            WriteLiteral("</small>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\Components\_ServiceList\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(897, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServiceListVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
