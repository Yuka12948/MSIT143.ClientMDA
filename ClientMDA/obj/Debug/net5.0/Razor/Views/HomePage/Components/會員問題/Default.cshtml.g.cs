#pragma checksum "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e32a6a19250cfdaff75ec211c2019072be5f1328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Components_會員問題_Default), @"mvc.1.0.view", @"/Views/HomePage/Components/會員問題/Default.cshtml")]
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
#line 1 "C:\MDA143\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA143\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e32a6a19250cfdaff75ec211c2019072be5f1328", @"/Views/HomePage/Components/會員問題/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Components_會員問題_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CQANDAViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"Qbox\">\r\n    <div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 9 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
         foreach (var q in Model.First().會員問題memQa)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" id=\"Qcard\">\r\n                <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\'", 322, "\'", 349, 2);
            WriteAttributeValue("", 327, "heading_", 327, 8, true);
#nullable restore
#line 12 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
WriteAttributeValue("", 335, q.會員問題memQaId, 335, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2 class=\"mb-0\">\r\n                        <button class=\"btn btn-link collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 14 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
                                                                                                                      Write(q.會員問題memQaId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 553, "\"", 592, 2);
            WriteAttributeValue("", 569, "collapse_", 569, 9, true);
#nullable restore
#line 14 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
WriteAttributeValue("", 578, q.會員問題memQaId, 578, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Qbtn\">");
#nullable restore
#line 14 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
                                                                                                                                                                                                               Write(q.問題question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </h2>\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 701, "\"", 729, 2);
            WriteAttributeValue("", 706, "collapse_", 706, 9, true);
#nullable restore
#line 18 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
WriteAttributeValue("", 715, q.會員問題memQaId, 715, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 747, "\"", 787, 2);
            WriteAttributeValue("", 765, "heading_", 765, 8, true);
#nullable restore
#line 18 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
WriteAttributeValue("", 773, q.會員問題memQaId, 773, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionExample\">\r\n                    <div class=\"card-body\">");
#nullable restore
#line 19 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
                                      Write(Html.Raw(@q.答案answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\MDA143\ClientMDA\Views\HomePage\Components\會員問題\Default.cshtml"
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
