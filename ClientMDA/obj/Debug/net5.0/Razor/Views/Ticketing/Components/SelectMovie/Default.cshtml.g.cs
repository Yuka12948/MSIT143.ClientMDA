#pragma checksum "D:\新增資料夾 (2)\ClientMDA\Views\Ticketing\Components\SelectMovie\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d0d17a4ff2e98c1e4692661096a079299d28b50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_Components_SelectMovie_Default), @"mvc.1.0.view", @"/Views/Ticketing/Components/SelectMovie/Default.cshtml")]
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
#nullable restore
#line 1 "D:\新增資料夾 (2)\ClientMDA\Views\Ticketing\Components\SelectMovie\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0d17a4ff2e98c1e4692661096a079299d28b50", @"/Views/Ticketing/Components/SelectMovie/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_Components_SelectMovie_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CAjaxMovieCodeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""container-xl pt-2"">
    <div class=""row"" style=""min-height:30vh"">
        <div class=""col-1""><div class=""swiper-button-prev"" style=""background-color:#070720"" id=""pic-prev""></div></div>
        <div class=""col-10 bg-opacity-25"">
            <div class=""swiper myPic"">
                <div class=""swiper-wrapper"">
");
#nullable restore
#line 15 "D:\新增資料夾 (2)\ClientMDA\Views\Ticketing\Components\SelectMovie\Default.cshtml"
                      
                        foreach(var item in Model)
                        {
                            string name = $"{item.MovieName}({item.MovieVersion})版";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide pr-2 MoviePicker\"");
            BeginWriteAttribute("data", " data=\"", 690, "\"", 712, 1);
#nullable restore
#line 19 "D:\新增資料夾 (2)\ClientMDA\Views\Ticketing\Components\SelectMovie\Default.cshtml"
WriteAttributeValue("", 697, item.MovieCode, 697, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <br />\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 792, "\"", 819, 2);
#nullable restore
#line 21 "D:\新增資料夾 (2)\ClientMDA\Views\Ticketing\Components\SelectMovie\Default.cshtml"
WriteAttributeValue("", 798, item.MovieOnlineUrl, 798, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 818, "", 819, 1, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"無圖片\" />\r\n                                <p>");
#nullable restore
#line 22 "D:\新增資料夾 (2)\ClientMDA\Views\Ticketing\Components\SelectMovie\Default.cshtml"
                              Write(item.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 25 "D:\新增資料夾 (2)\ClientMDA\Views\Ticketing\Components\SelectMovie\Default.cshtml"
                        }


                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""col-1""><div class=""swiper-button-next"" style=""background-color:#070720"" id=""pic-next""></div></div>
    </div>
    <div class=""row justify-content-center pt-4"">
        <button type=""button"" class=""btn btn-secondary btn-sm"" id=""InfoBtn"">電影資訊</button>
    </div>
    <div class=""row text-center"">
        <div class=""col-3""></div>
        <div class=""col-6 MovieInfoBox"" id=""MovieInfotext"">
");
            WriteLiteral("        </div>\r\n        <div class=\"col-3\"></div>\r\n        </div>\r\n</section>\r\n\r\n<br />\r\n<div class=\"bigline\"></div>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CAjaxMovieCodeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
