#pragma checksum "C:\MDA前\ClientMDA\Views\Ticketing\Components\SelectSeat\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd1dc8a5a81c9025c01637d14f4659a72080d7cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_Components_SelectSeat_Default), @"mvc.1.0.view", @"/Views/Ticketing/Components/SelectSeat/Default.cshtml")]
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
#line 1 "C:\MDA前\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1dc8a5a81c9025c01637d14f4659a72080d7cc", @"/Views/Ticketing/Components/SelectSeat/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_Components_SelectSeat_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""container justify-content-center mt-5"">
    <div class=""row"">
        <div class=""col-2""></div>
        <div class=""col-8 text-center"">
            <div class=""d-block mb-3"" style=""font-size:36px"">人數</div>
            <div class=""container-md mb-5"">
");
#nullable restore
#line 13 "C:\MDA前\ClientMDA\Views\Ticketing\Components\SelectSeat\Default.cshtml"
                  
                    for (int i = 1; i <= 8; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-inline round m-2 p-2 ManCount\"");
            BeginWriteAttribute("value", " value=\"", 455, "\"", 465, 1);
#nullable restore
#line 16 "C:\MDA前\ClientMDA\Views\Ticketing\Components\SelectSeat\Default.cshtml"
WriteAttributeValue("", 463, i, 463, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"num\">");
#nullable restore
#line 17 "C:\MDA前\ClientMDA\Views\Ticketing\Components\SelectSeat\Default.cshtml"
                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                        </div>\r\n");
#nullable restore
#line 19 "C:\MDA前\ClientMDA\Views\Ticketing\Components\SelectSeat\Default.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n</section>");
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
