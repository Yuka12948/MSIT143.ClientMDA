#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89893225db415cce39a04d6c5f42e60ef95756fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_Components_SelectDate_Default), @"mvc.1.0.view", @"/Views/Ticketing/Components/SelectDate/Default.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89893225db415cce39a04d6c5f42e60ef95756fa", @"/Views/Ticketing/Components/SelectDate/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_Components_SelectDate_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DateTime>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml"
  
    DateTime today = DateTime.Now.Date;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""form-group pt-3 pb-1"">
    <div class=""row"">
        <div class=""col-1""><div class=""swiper-button-prev"" style=""background-color:#070720"" id=""date-prev""></div></div>
        <div class=""col-10"">
            <div class=""swiper mySwiper"">
                <div class=""swiper-wrapper"">
");
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml"
                      
                        DateTime date = today.AddDays(1.0);

                        for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide text-center border border-2 pr-3 date justify-content-center DateTimePicker\"");
            BeginWriteAttribute("data", " data=\"", 1554, "\"", 1575, 1);
#nullable restore
#line 36 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml"
WriteAttributeValue("", 1561, Model[i].Date, 1561, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <br />\r\n                                <i class=\"d-block pt-1 pl-1\"> ");
#nullable restore
#line 38 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml"
                                                         Write(Model[i].ToString("dddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block\"> ");
#nullable restore
#line 39 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml"
                                               Write(Model[i].ToString("dd" + " 號"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block pb-1\"> ");
#nullable restore
#line 40 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml"
                                                    Write(Model[i].ToString("MM" + " 月"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <br />\r\n                            </div>\r\n");
#nullable restore
#line 43 "C:\Users\Student\Documents\MSIT143.ClientMDA1031night\ClientMDA\Views\Ticketing\Components\SelectDate\Default.cshtml"

                            date = date.AddDays(1.0);
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-1\"><div class=\"swiper-button-next\" style=\"background-color:#070720\" id=\"date-next\"></div></div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<div class=\"bigline\"></div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DateTime>> Html { get; private set; }
    }
}
#pragma warning restore 1591
