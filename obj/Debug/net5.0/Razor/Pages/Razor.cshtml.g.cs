#pragma checksum "C:\SIS\Elin\ASP.NET_C#\Moment1\Pages\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee32b42491e4b840efd3a25aec1e40898fb95b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Moment1.Pages.Pages_Razor), @"mvc.1.0.razor-page", @"/Pages/Razor.cshtml")]
namespace Moment1.Pages
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
#line 1 "C:\SIS\Elin\ASP.NET_C#\Moment1\Pages\_ViewImports.cshtml"
using Moment1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee32b42491e4b840efd3a25aec1e40898fb95b4", @"/Pages/Razor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da6837e70a3044c785aa4efc8308d694b9bc8279", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Razor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-left\">\r\n    <h1 class=\"rubrik\">Razor</h1>\r\n\r\n    <div>\r\n\r\n");
#nullable restore
#line 10 "C:\SIS\Elin\ASP.NET_C#\Moment1\Pages\Razor.cshtml"
           
            var now = DateTime.Now.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 12 "C:\SIS\Elin\ASP.NET_C#\Moment1\Pages\Razor.cshtml"
              Write(now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("        \r\n    </div>\r\n    <p>\r\n        Här kommer det finnas information om mina kurser jag har läst.\r\n    </p>\r\n    <ul class=\"courseList\">\r\n");
#nullable restore
#line 20 "C:\SIS\Elin\ASP.NET_C#\Moment1\Pages\Razor.cshtml"
         foreach(var course in Model.GetCourses())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 22 "C:\SIS\Elin\ASP.NET_C#\Moment1\Pages\Razor.cshtml"
           Write(course);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 23 "C:\SIS\Elin\ASP.NET_C#\Moment1\Pages\Razor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Moment1.Pages.RazorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Moment1.Pages.RazorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Moment1.Pages.RazorModel>)PageContext?.ViewData;
        public Moment1.Pages.RazorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
