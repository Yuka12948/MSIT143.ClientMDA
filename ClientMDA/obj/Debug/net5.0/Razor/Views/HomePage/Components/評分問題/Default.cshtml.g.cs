#pragma checksum "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695ebf107e5a6be9e56783db566cf79aaebc57ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Components_評分問題_Default), @"mvc.1.0.view", @"/Views/HomePage/Components/評分問題/Default.cshtml")]
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
#line 1 "D:\新增資料夾 (2)\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\新增資料夾 (2)\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695ebf107e5a6be9e56783db566cf79aaebc57ba", @"/Views/HomePage/Components/評分問題/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Components_評分問題_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CQANDAViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"Qbox\">\r\n    <div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 8 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
         foreach (var q in Model.First().評分問題rateQa)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" id=\"Qcard\">\r\n                <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\'", 321, "\'", 349, 2);
            WriteAttributeValue("", 326, "heading_", 326, 8, true);
#nullable restore
#line 11 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
WriteAttributeValue("", 334, q.評分問題rateQaId, 334, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2 class=\"mb-0\">\r\n                        <button class=\"btn btn-link collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 13 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
                                                                                                                      Write(q.評分問題rateQaId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 554, "\"", 594, 2);
            WriteAttributeValue("", 570, "collapse_", 570, 9, true);
#nullable restore
#line 13 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
WriteAttributeValue("", 579, q.評分問題rateQaId, 579, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Qbtn\">");
#nullable restore
#line 13 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
                                                                                                                                                                                                                 Write(q.問題question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </h2>\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 703, "\"", 732, 2);
            WriteAttributeValue("", 708, "collapse_", 708, 9, true);
#nullable restore
#line 17 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
WriteAttributeValue("", 717, q.評分問題rateQaId, 717, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 750, "\"", 791, 2);
            WriteAttributeValue("", 768, "heading_", 768, 8, true);
#nullable restore
#line 17 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
WriteAttributeValue("", 776, q.評分問題rateQaId, 776, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionExample\">\r\n                    <div class=\"card-body\">");
#nullable restore
#line 18 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
                                      Write(Html.Raw(@q.答案answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評分問題\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CQANDAViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
