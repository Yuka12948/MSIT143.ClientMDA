#pragma checksum "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8bf45d01569ba2e5dc42faf9a27bdb6847e046b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_Components_MovieInfo_Default), @"mvc.1.0.view", @"/Views/Ticketing/Components/MovieInfo/Default.cshtml")]
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
#line 1 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8bf45d01569ba2e5dc42faf9a27bdb6847e046b", @"/Views/Ticketing/Components/MovieInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_Components_MovieInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<電影movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
  
    string delectors = "";
    string actor = "";

    var d = Model.電影導演movieDirectors.Select(D => D.導演編號director.導演中文名字nameCht);
    var a = Model.電影主演casts.Select(A => A.演員編號actor.演員中文名字nameCht);

    foreach(var item in d)
    {
        delectors += $"{item} ";
    }

    foreach (var item in a)
    {
        actor += $"{item} ";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n    <div class=\"grade\">");
#nullable restore
#line 24 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
                  Write(Model.電影分級編號rating.分級級數ratingLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"datebox m-auto mt-2\">片長:");
#nullable restore
#line 25 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
                                   Write(Model.片長runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 上應日期:");
#nullable restore
#line 25 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
                                                         Write(Model.上映日期releaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"staff p-1 d-block\">導 演：<span>");
#nullable restore
#line 26 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
                                        Write(delectors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <div class=\"staff d-block\">演 員：<span>");
#nullable restore
#line 27 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
                                    Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <div class=\"Infotext d-block\">");
#nullable restore
#line 28 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\Components\MovieInfo\Default.cshtml"
                             Write(Model.劇情大綱plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<電影movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
