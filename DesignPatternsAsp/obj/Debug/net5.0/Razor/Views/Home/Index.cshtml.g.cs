#pragma checksum "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8f22c92eee8c79f154813c70443ecde8807b93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\_ViewImports.cshtml"
using DesignPatternsAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\_ViewImports.cshtml"
using DesignPatternsAsp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\Home\Index.cshtml"
using DesignPatterns.Models.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8f22c92eee8c79f154813c70443ecde8807b93", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58cdd0aabf321e5f17fc40791b34db67a2dc3a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Beer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n");
#nullable restore
#line 10 "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\Home\Index.cshtml"
         foreach (var beer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 12 "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\Home\Index.cshtml"
          Write(beer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\Bioxor\source\repos\DesignPattern\DesignPatternsAsp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Beer>> Html { get; private set; }
    }
}
#pragma warning restore 1591