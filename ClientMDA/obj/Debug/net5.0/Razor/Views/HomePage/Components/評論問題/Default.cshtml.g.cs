#pragma checksum "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a4f45fc6b7fcd36d9e539b4fb4869ce9addac80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Components_評論問題_Default), @"mvc.1.0.view", @"/Views/HomePage/Components/評論問題/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a4f45fc6b7fcd36d9e539b4fb4869ce9addac80", @"/Views/HomePage/Components/評論問題/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Components_評論問題_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CQANDAViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"Qbox\">\r\n    <div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 8 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
         foreach (var q in Model.First().評論問題commentQa)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" id=\"Qcard\">\r\n                <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\'", 324, "\'", 355, 2);
            WriteAttributeValue("", 329, "heading_", 329, 8, true);
#nullable restore
#line 11 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
WriteAttributeValue("", 337, q.評論問題commentQaId, 337, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2 class=\"mb-0\">\r\n                        <button class=\"btn btn-link collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 13 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
                                                                                                                      Write(q.評論問題commentQaId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 563, "\"", 606, 2);
            WriteAttributeValue("", 579, "collapse_", 579, 9, true);
#nullable restore
#line 13 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
WriteAttributeValue("", 588, q.評論問題commentQaId, 588, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Qbtn\">");
#nullable restore
#line 13 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
                                                                                                                                                                                                                       Write(q.問題question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </h2>\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 715, "\"", 747, 2);
            WriteAttributeValue("", 720, "collapse_", 720, 9, true);
#nullable restore
#line 17 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
WriteAttributeValue("", 729, q.評論問題commentQaId, 729, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 765, "\"", 809, 2);
            WriteAttributeValue("", 783, "heading_", 783, 8, true);
#nullable restore
#line 17 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
WriteAttributeValue("", 791, q.評論問題commentQaId, 791, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionExample\">\r\n                    <div class=\"card-body\">");
#nullable restore
#line 18 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
                                      Write(Html.Raw(@q.答案answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "D:\新增資料夾 (2)\ClientMDA\Views\HomePage\Components\評論問題\Default.cshtml"
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
