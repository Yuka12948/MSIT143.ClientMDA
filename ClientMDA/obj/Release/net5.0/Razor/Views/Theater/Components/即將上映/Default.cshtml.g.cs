#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3501fd3517b748e2c3dbf97c56da4854954d9498"
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3501fd3517b748e2c3dbf97c56da4854954d9498", @"/Views/Theater/Components/即將上映/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Theater_Components_即將上映_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CTheater>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
  

    for (var i = 0; i < 12; i++)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 154, "\"", 228, 1);
#nullable restore
#line 11 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 161, Url.Action("快定頁面測試", "Theater", new { id = Model[i].電影編號movieId }), 161, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"post-box\">\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
                   string urlpic = "";
                    if (Model[i].MPimg.Count > 0)
                        urlpic = "http://192.168.24.5:44383/images/MovieImage/" + Model[i].MPimg[0];
                    //urlpic = Model[i].MPimg[0];


                    else
                    {
                        urlpic = "../../images/Theater/common/poster.png";


                    }


                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"post\"");
            BeginWriteAttribute("style", " style=\"", 730, "\"", 771, 4);
            WriteAttributeValue("", 738, "background-image:", 738, 17, true);
            WriteAttributeValue(" ", 755, "url(\'", 756, 6, true);
#nullable restore
#line 31 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 761, urlpic, 761, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 768, "\');", 768, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\r\n                <div class=\"coming\">\r\n                    上映日期<span>");
#nullable restore
#line 34 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
                         Write(Model[i].上映日期releaseDate.Value.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"title\"");
            BeginWriteAttribute("title", " title=\"", 963, "\"", 993, 1);
#nullable restore
#line 36 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 971, Model[i].中文標題titleCht, 971, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <input class=\"mov\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1049, "\"", 1078, 1);
#nullable restore
#line 37 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 1057, Model[i].電影編號movieId, 1057, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    ");
#nullable restore
#line 39 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
               Write(Model[i].中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"en\"");
            BeginWriteAttribute("title", " title=\"", 1185, "\"", 1215, 1);
#nullable restore
#line 41 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
WriteAttributeValue("", 1193, Model[i].英文標題titleEng, 1193, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 42 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
               Write(Model[i].英文標題titleEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"grade\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
               Write(Model[i].分級級數ratingLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </a>\r\n");
#nullable restore
#line 50 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Theater\Components\即將上映\Default.cshtml"
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
