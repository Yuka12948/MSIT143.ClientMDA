#pragma checksum "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43a3cf0e5801721653a86610a381aa3c9c8784d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Theater_Components_即將上映_Default), @"mvc.1.0.view", @"/Views/Theater/Components/即將上映/Default.cshtml")]
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
#line 1 "C:\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43a3cf0e5801721653a86610a381aa3c9c8784d", @"/Views/Theater/Components/即將上映/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Theater_Components_即將上映_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CTheater>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
  

    for (var i = 0; i < 12; i++)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 154, "\"", 228, 1);
#nullable restore
#line 11 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 161, Url.Action("快定頁面測試", "Theater", new { id = Model[i].電影編號movieId }), 161, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"post-box\">\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
                   string urlpic = "";
                    if (Model[i].MPimg.Count > 0)
                        urlpic = "https://localhost:44381/images/MovieImage/" + Model[i].MPimg[0];
                    //urlpic = Model[i].MPimg[0];


                    else
                    {
                        urlpic = "../../images/Theater/common/poster.png";


                    }


                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"post\"");
            BeginWriteAttribute("style", " style=\"", 728, "\"", 769, 4);
            WriteAttributeValue("", 736, "background-image:", 736, 17, true);
            WriteAttributeValue(" ", 753, "url(\'", 754, 6, true);
#nullable restore
#line 31 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 759, urlpic, 759, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 766, "\');", 766, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\r\n                <div class=\"coming\">\r\n                    上映日期<span>");
#nullable restore
#line 34 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
                         Write(Model[i].上映日期releaseDate.Value.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"title\" title=\"阮玲玉\">\r\n                    <input class=\"mov\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1028, "\"", 1057, 1);
#nullable restore
#line 37 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 1036, Model[i].電影編號movieId, 1036, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    ");
#nullable restore
#line 39 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
               Write(Model[i].中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"en\" title=\"Ruan Ling Yu\">\r\n                    ");
#nullable restore
#line 42 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
               Write(Model[i].英文標題titleEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"grade\">\r\n                    ");
#nullable restore
#line 45 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
               Write(Model[i].分級級數ratingLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </a>\r\n");
#nullable restore
#line 50 "C:\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<script>\r\n  \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CTheater>> Html { get; private set; }
    }
}
#pragma warning restore 1591
