#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70778b01cea8e9d5dc32fb956a6864d83cab24c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Components_訂票問題_Default), @"mvc.1.0.view", @"/Views/HomePage/Components/訂票問題/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70778b01cea8e9d5dc32fb956a6864d83cab24c7", @"/Views/HomePage/Components/訂票問題/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Components_訂票問題_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CQANDAViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"Qbox\">\r\n    <div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 8 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
         foreach (var q in Model.First().訂票問題orderticketQa)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" id=\"Qcard\">\r\n                <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\'", 328, "\'", 363, 2);
            WriteAttributeValue("", 333, "heading_", 333, 8, true);
#nullable restore
#line 11 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
WriteAttributeValue("", 341, q.訂票問題orderticketQaId, 341, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2 class=\"mb-0\">\r\n                        <button class=\"btn btn-link collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 13 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
                                                                                                                      Write(q.訂票問題orderticketQaId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 575, "\"", 622, 2);
            WriteAttributeValue("", 591, "collapse_", 591, 9, true);
#nullable restore
#line 13 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
WriteAttributeValue("", 600, q.訂票問題orderticketQaId, 600, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Qbtn\">");
#nullable restore
#line 13 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
                                                                                                                                                                                                                               Write(q.問題question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </h2>\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 731, "\"", 767, 2);
            WriteAttributeValue("", 736, "collapse_", 736, 9, true);
#nullable restore
#line 17 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
WriteAttributeValue("", 745, q.訂票問題orderticketQaId, 745, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 785, "\"", 833, 2);
            WriteAttributeValue("", 803, "heading_", 803, 8, true);
#nullable restore
#line 17 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
WriteAttributeValue("", 811, q.訂票問題orderticketQaId, 811, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionExample\">\r\n                    <div class=\"card-body\">");
#nullable restore
#line 18 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
                                      Write(Html.Raw(@q.答案answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\訂票問題\Default.cshtml"
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
