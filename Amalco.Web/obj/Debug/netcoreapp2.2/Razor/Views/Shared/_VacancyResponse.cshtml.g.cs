#pragma checksum "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9604b035447b62bffb9616ede83b7c250ff8bd39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__VacancyResponse), @"mvc.1.0.view", @"/Views/Shared/_VacancyResponse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_VacancyResponse.cshtml", typeof(AspNetCore.Views_Shared__VacancyResponse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9604b035447b62bffb9616ede83b7c250ff8bd39", @"/Views/Shared/_VacancyResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318eea45e95c4bff299d1cfc41312817610659d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__VacancyResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VacancyResponseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(36, 10, false);
#line 3 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml"
Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(46, 37, true);
            WriteLiteral(" получен новый отклик на вакансию <b>");
            EndContext();
            BeginContext(84, 17, false);
#line 3 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml"
                                               Write(Model.VacancyName);

#line default
#line hidden
            EndContext();
            BeginContext(101, 30, true);
            WriteLiteral("</b></h3>\r\n<hr />\r\nОт:\r\n<br />");
            EndContext();
            BeginContext(132, 14, false);
#line 6 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml"
 Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(146, 15, true);
            WriteLiteral(" \r\n<br /> Тел: ");
            EndContext();
            BeginContext(162, 17, false);
#line 7 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml"
       Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(179, 31, true);
            WriteLiteral("\r\n<br />Опыт работы в семьях : ");
            EndContext();
            BeginContext(212, 33, false);
#line 8 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml"
                         Write(Model.FamilyExperience?"Да":"Нет");

#line default
#line hidden
            EndContext();
            BeginContext(246, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml"
 if(Model.HasCv)
{

#line default
#line hidden
            BeginContext(269, 11, true);
            WriteLiteral("    <br /> ");
            EndContext();
            BeginContext(282, 28, true);
            WriteLiteral(" Кандидат прикрепил резюме\r\n");
            EndContext();
#line 12 "C:\Users\Admin\Desktop\Новая папка\Amalco\Amalco.Web\Views\Shared\_VacancyResponse.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VacancyResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
