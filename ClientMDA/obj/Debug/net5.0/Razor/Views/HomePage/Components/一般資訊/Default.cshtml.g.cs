#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ea4f01cdc5b470506984bd766cb75d4a6f4d0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Components_一般資訊_Default), @"mvc.1.0.view", @"/Views/HomePage/Components/一般資訊/Default.cshtml")]
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
#line 1 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ea4f01cdc5b470506984bd766cb75d4a6f4d0c", @"/Views/HomePage/Components/一般資訊/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Components_一般資訊_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CQANDAViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"Qbox\">\r\n    <div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 9 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
         foreach(var q in Model.First().一般資訊GeneraInformation) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" id=\"Qcard\">\r\n            <div class=\"card-header\"");
            BeginWriteAttribute("id", " id= \'", 321, "\'", 361, 2);
            WriteAttributeValue("", 327, "heading_", 327, 8, true);
#nullable restore
#line 11 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
WriteAttributeValue("", 335, q.一般資訊generaInformationId, 335, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h2 class=\"mb-0\">\r\n            <button class=\"btn btn-link collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 13 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
                                                                                                          Write(q.一般資訊generaInformationId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \"aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 556, "\"", 607, 2);
            WriteAttributeValue("", 572, "collapse_", 572, 9, true);
#nullable restore
#line 13 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
WriteAttributeValue("", 581, q.一般資訊generaInformationId, 581, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Qbtn\">");
#nullable restore
#line 13 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
                                                                                                                                                                                                                          Write(q.問題question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            </h2>\r\n            </div>\r\n\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 700, "\"", 740, 2);
            WriteAttributeValue("", 705, "collapse_", 705, 9, true);
#nullable restore
#line 17 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
WriteAttributeValue("", 714, q.一般資訊generaInformationId, 714, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 758, "\"", 810, 2);
            WriteAttributeValue("", 776, "heading_", 776, 8, true);
#nullable restore
#line 17 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
WriteAttributeValue("", 784, q.一般資訊generaInformationId, 784, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionExample\">\r\n                <div class=\"card-body\">");
#nullable restore
#line 18 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
                                  Write(Html.Raw(@q.答案answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\一般資訊\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n</div>");
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
