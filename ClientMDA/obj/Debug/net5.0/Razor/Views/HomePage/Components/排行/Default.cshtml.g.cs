#pragma checksum "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9fa43b4b8a31af6e5703a8258256de7e25e006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Components_排行_Default), @"mvc.1.0.view", @"/Views/HomePage/Components/排行/Default.cshtml")]
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
#line 2 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9fa43b4b8a31af6e5703a8258256de7e25e006", @"/Views/HomePage/Components/排行/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Components_排行_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CHomePageRankViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
  
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
                    <span class=""charts-list-rank"">排行</span>
                    <span class=""charts-list-poster"">電影海報</span>
                    <span class=""charts-list-movietitle"">電影資訊</span>
                    <span class=""charts-list-content""></span>
                    <span class=""charts-list-MDArate""> 本周票房 </span>
                    <span class=""charts-list-MemRate""> 累積票房 </span>
                    <span class=""charts-list-movieDate""> 周次 </span>
                    <span class=""charts-list-addList""> 加入片單 </span>
                </li>
");
#nullable restore
#line 22 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
                  
                    for (var i = 0; i < 10; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"charts-list-row\">\r\n                            <div class=\"divRow\">\r\n                                <span class=\"charts-list-rank\">");
#nullable restore
#line 27 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
                                                          Write(Model[i].電影排名Movie_Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <div class=\"flipper\">\r\n                                    <div class=\"flipper-item layer1\" id=\"im\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=", 1356, "", 1422, 1);
#nullable restore
#line 30 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
WriteAttributeValue("", 1362, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號Movie_ID}), 1362, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img class=\"charts-list-cover\" id=\"poster\"");
            BeginWriteAttribute("alt", " alt=\"", 1511, "\"", 1517, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1518, "\"", 1543, 1);
#nullable restore
#line 31 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
WriteAttributeValue("", 1526, Model[i].電影Movie, 1526, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1544, "\"", 1573, 1);
#nullable restore
#line 31 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
WriteAttributeValue("", 1550, Model[i].圖片雲端ImageIMDB, 1550, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n                                        <span class=\"charts-list-desc\">\r\n                                            <span class=\"charts-list-song\"");
            BeginWriteAttribute("title", " title=\"", 1770, "\"", 1795, 1);
#nullable restore
#line 34 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
WriteAttributeValue("", 1778, Model[i].電影Movie, 1778, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a");
            BeginWriteAttribute("href", " href=", 1849, "", 1915, 1);
#nullable restore
#line 35 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
WriteAttributeValue("", 1855, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號Movie_ID}), 1855, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => Model[i].電影Movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </span>\r\n                                            <span class=\"charts-list-artist\"");
            BeginWriteAttribute("title", " title=\"", 2098, "\"", 2127, 1);
#nullable restore
#line 37 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
WriteAttributeValue("", 2106, Model[i].電影英Movie_En, 2106, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a");
            BeginWriteAttribute("href", " href=", 2181, "", 2247, 1);
#nullable restore
#line 38 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
WriteAttributeValue("", 2187, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號Movie_ID}), 2187, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => Model[i].電影英Movie_En));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                            </span>
                                        </span>
                                        <span class=""charts-list-span"" id=""i"">1111111</span>
                                        <span class=""charts-list-span"" id=""ii"">2222222</span>
                                        <span class=""charts-list-span"" id=""iii"">3</span>
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
#line 60 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\HomePage\Components\排行\Default.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CHomePageRankViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
