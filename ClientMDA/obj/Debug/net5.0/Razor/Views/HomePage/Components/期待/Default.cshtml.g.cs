#pragma checksum "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b54866d6c756bfe6113a08d01167d50dc902f2dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Components_期待_Default), @"mvc.1.0.view", @"/Views/HomePage/Components/期待/Default.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b54866d6c756bfe6113a08d01167d50dc902f2dc", @"/Views/HomePage/Components/期待/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Components_期待_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CHomePageNewViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"" id=""showlist"">
    <div class=""row"">
        <div class=""col-12 col-md-12"">
            <ul class=""charts-list"">
                <li class=""charts-list-row--header d-none d-md-flex"">
                    <span class=""charts-list-rank"">序號</span>
                    <span class=""charts-list-poster"">電影海報</span>
                    <span class=""charts-list-movietitle"">電影資訊</span>
                    <span class=""charts-list-content""></span>
                    <span class=""charts-list-MDArate""> 介紹 </span>
                    <span class=""charts-list-MemRate""> 上映日期 </span>
                    <span class=""charts-list-movieDate""> 期待度 </span>
                    <span class=""charts-list-addList""> 加入片單 </span>
                </li>
");
#nullable restore
#line 22 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
                  int count = 0;
                    for (var i = 0; i < Model.Count; i++)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"charts-list-row\">\r\n                            <div class=\"divRow\">\r\n                                <span class=\"charts-list-rank\">");
#nullable restore
#line 28 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
                                                          Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <div class=\"flipper\">\r\n                                    <div class=\"flipper-item layer1\" id=\"im\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=", 1393, "", 1459, 1);
#nullable restore
#line 31 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 1399, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號Movie_ID}), 1399, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img class=\"charts-list-cover\" id=\"poster\"");
            BeginWriteAttribute("alt", " alt=\"", 1548, "\"", 1554, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1555, "\"", 1586, 1);
#nullable restore
#line 32 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 1563, Model[i].中文標題Title_Cht, 1563, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1587, "\"", 1616, 1);
#nullable restore
#line 32 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 1593, Model[i].圖片雲端ImageIMDB, 1593, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n                                        <span class=\"charts-list-desc\">\r\n                                            <span class=\"charts-list-song\"");
            BeginWriteAttribute("title", " title=\"", 1813, "\"", 1844, 1);
#nullable restore
#line 35 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 1821, Model[i].中文標題Title_Cht, 1821, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a");
            BeginWriteAttribute("href", " href=", 1898, "", 1964, 1);
#nullable restore
#line 36 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 1904, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號Movie_ID}), 1904, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => Model[i].中文標題Title_Cht));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </span>\r\n                                            <span class=\"charts-list-artist\"");
            BeginWriteAttribute("title", " title=\"", 2153, "\"", 2182, 1);
#nullable restore
#line 38 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 2161, Model[i].電影英Movie_En, 2161, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a");
            BeginWriteAttribute("href", " href=", 2236, "", 2302, 1);
#nullable restore
#line 39 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 2242, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號Movie_ID}), 2242, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => Model[i].電影英Movie_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                            </span>
                                        </span>
                                        <span class=""charts-list-span"" id=""i"">
                                            <button class=""AddListBtn"" id=""addlistbtn""");
            BeginWriteAttribute("onclick", " onclick=\"", 2628, "\"", 2719, 2);
            WriteAttributeValue("", 2638, "window.location.href=", 2638, 21, true);
#nullable restore
#line 43 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
WriteAttributeValue("", 2659, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號Movie_ID}), 2659, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                電影介紹\r\n                                            </button>\r\n                                        </span>\r\n                                        <span class=\"charts-list-span\" id=\"ii2\">");
#nullable restore
#line 47 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
                                                                           Write(Model[i].上映日期Release_Date.Value.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"charts-list-span\" id=\"iii\"><i class=\'fa fa-star checked\' id=\"ToRE\"></i> &nbsp; ");
#nullable restore
#line 48 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
                                                                                                                               Write(Model[i].期待度anticipation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
                                        <div class=""charts-list-span"" id=""iiii"">
                                            <div class=""ipc-watchlist-ribbon ipc-focusable ipc-watchlist-ribbon--m ipc-watchlist-ribbon--baseAlt ipc-watchlist-ribbon--onImage ipc-poster__watchlist-ribbon poster-card-watchlist-ribbon"" aria-label=""add to watchlist"" role=""button"" tabindex=""0"" id=""bookmarkboard"">
                                                <svg class=""ipc-watchlist-ribbon__bg"" ");
            WriteLiteral(@" color=""red"" viewBox=""0 0 24 34"" xmlns=""http://www.w3.org/2000/svg"" role=""presentation"" id=""BOOOKmarkboard"">
                                                    <polygon class=""ipc-watchlist-ribbon__bg-ribbon2"" fill=""rgb(35, 35,37,.6)"" points=""24 0 0 0 0 32 12.2436611 26.2926049 24 31.7728343"" id=""BOOOkmarkboard""></polygon>
                                                    <polygon class=""ipc-watchlist-ribbon__bg-hover"" points=""24 0 0 0 0 32 12.2436611 26.2926049 24 31.7728343"" id=""BOOokmarkboard""></polygon>
                                                    <polygon class=""ipc-watchlist-ribbon__bg-shadow"" points=""24 31.7728343 24 33.7728343 12.2436611 28.2926049 0 34 0 32 12.2436611 26.2926049"" id=""BOokmarkboard""></polygon>
                                                </svg>
                                                <div id=""bookplusboard"">
                                                    <span class=""glyphicon"" id=""bookplusboardinner2"" style=""font-size: 2.15rem;"">&#x2b;</span>
        ");
            WriteLiteral(@"                                        </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
");
#nullable restore
#line 65 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\HomePage\Components\期待\Default.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CHomePageNewViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
