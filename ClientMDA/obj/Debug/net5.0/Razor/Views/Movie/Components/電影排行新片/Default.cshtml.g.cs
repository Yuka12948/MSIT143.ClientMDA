#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b4a48f72521e78dd555d01abe0c7b41b4c2a6d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Components_電影排行新片_Default), @"mvc.1.0.view", @"/Views/Movie/Components/電影排行新片/Default.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4a48f72521e78dd555d01abe0c7b41b4c2a6d1", @"/Views/Movie/Components/電影排行新片/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Components_電影排行新片_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CMovieViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    //let x = Math.floor((Math.random(* 10) + 1);\r\n    //document.getElementById(\"AAA\").innerHTML = x;\r\n</script>\r\n");
#nullable restore
#line 9 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
  
    int count = 0;
    for (var i = 0; i < Model.Count; i++)
    {

        count++;
        string urlpic = "";
        if (Model[i].mImgFrList.Count() > 0)
        {
            urlpic = Model[i].mImgFrList[0];
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"charts-list-row\">\r\n            <div class=\"divRow\">\r\n                <span class=\"charts-list-rank\">");
#nullable restore
#line 23 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
                                          Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
            WriteLiteral("\r\n                <div class=\"flipper\">\r\n                    <div class=\"flipper-item layer1\">\r\n                        <a");
            BeginWriteAttribute("href", " href=", 774, "", 839, 1);
#nullable restore
#line 26 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue("", 780, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號movieId}), 780, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"charts-list-cover\" id=\"poster\"");
            BeginWriteAttribute("alt", " alt=\"", 912, "\"", 918, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 919, "\"", 979, 1);
#nullable restore
#line 27 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue("", 927, Html.DisplayFor(modelItem => Model[i].中文標題titleCht), 927, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", "\r\n                                 src=\"", 980, "\"", 1027, 1);
#nullable restore
#line 28 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue("", 1020, urlpic, 1020, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
            WriteLiteral("\r\n                            </a>\r\n                        <span class=\"charts-list-desc\">\r\n                            <span class=\"charts-list-song\"");
            BeginWriteAttribute("title", " title=\"", 1224, "\"", 1284, 1);
#nullable restore
#line 31 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue("", 1232, Html.DisplayFor(modelItem => Model[i].中文標題titleCht), 1232, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=", 1322, "", 1387, 1);
#nullable restore
#line 32 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue("", 1328, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號movieId}), 1328, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
                                                                                               Write(Html.DisplayFor(modelItem => Model[i].中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </span>\r\n                            <span class=\"charts-list-artist\"");
            BeginWriteAttribute("title", " title=\"", 1543, "\"", 1603, 1);
#nullable restore
#line 34 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue("", 1551, Html.DisplayFor(modelItem => Model[i].英文標題titleEng), 1551, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=", 1641, "", 1706, 1);
#nullable restore
#line 35 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue("", 1647, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號movieId}), 1647, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
                                                                                               Write(Html.DisplayFor(modelItem => Model[i].英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </span>
                        </span>

                        <span class=""charts-list-content""></span>
                        <span class=""charts-list-span""><i class=""fas fa-star"" style=""padding-right:5px;color:#ffc107""></i> 5</span>

                        <div class=""dropdown"">
                            <button");
            BeginWriteAttribute("aria-label", " aria-label=\"", 2122, "\"", 2192, 2);
            WriteAttributeValue("", 2135, "Rate", 2135, 4, true);
#nullable restore
#line 43 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
WriteAttributeValue(" ", 2139, Html.DisplayFor(modelItem => Model[i].中文標題titleCht), 2140, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""ipc-rate-button ipc-rating-star-group--unrated ipc-rate-button--unrated ipc-rate-button--baseAlt""
                                    data-testid=""rate-button"" data-modal-target=""#ToRate"">
                                <span class=""ipc-rating-star ipc-rating-star--baseAlt ipc-rating-star--rate"">
                                    <i class=""far fa-star"" style=""padding-right:5px;color:#ffc107""></i>評分
                                </span>
                            </button>
                        </div>
                        <span class=""charts-list-date"">");
#nullable restore
#line 50 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
                                                  Write(Html.DisplayFor(modelItem => Model[i].上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        <span class=""charts-list-prev-rank"">
                            <div class=""wlb_ribbon"" data-tconst=""tt0111161"" data-recordmetrics=""true"" style=""position: relative;"">
                                <div class=""wl-ribbon standalone not-inWL"" title=""點擊添加到關注列表""></div>
                            </div>
                        </span>
                    </div>
                </div>
            </div>
        </li>
");
#nullable restore
#line 60 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行新片\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        const element = document.getElementById(\'#poster\');\r\n        if (element(\'src\', null))\r\n            element.setAttribute(\'src\', \'~/images/Comment/poster_none1.png\');\r\n\r\n    </script>\r\n");
            WriteLiteral("\r\n\r\n\r\n<script>\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CMovieViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
