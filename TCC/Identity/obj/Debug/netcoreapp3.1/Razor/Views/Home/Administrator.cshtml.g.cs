#pragma checksum "C:\tcc\tcc-mvc\TCC\Identity\Views\Home\Administrator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f8347684d33b75d19c33d222f052d3d350c47cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Administrator), @"mvc.1.0.view", @"/Views/Home/Administrator.cshtml")]
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
#line 1 "C:\tcc\tcc-mvc\TCC\Identity\Views\_ViewImports.cshtml"
using Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\tcc\tcc-mvc\TCC\Identity\Views\_ViewImports.cshtml"
using Identity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8347684d33b75d19c33d222f052d3d350c47cb", @"/Views/Home/Administrator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6028f7b1dce99287641c3b05c72618329a55e074", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Administrator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\tcc\tcc-mvc\TCC\Identity\Views\Home\Administrator.cshtml"
  
    ViewData["Title"] = "Administrator Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Bem vindo usuário Administrador</a>.</p>\r\n</div>\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "C:\tcc\tcc-mvc\TCC\Identity\Views\Home\Administrator.cshtml"
     foreach(var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 14 "C:\tcc\tcc-mvc\TCC\Identity\Views\Home\Administrator.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 14 "C:\tcc\tcc-mvc\TCC\Identity\Views\Home\Administrator.cshtml"
                     Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 16 "C:\tcc\tcc-mvc\TCC\Identity\Views\Home\Administrator.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
