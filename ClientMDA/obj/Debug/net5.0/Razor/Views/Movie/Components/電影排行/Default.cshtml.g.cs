#pragma checksum "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ed0a0efaf2fcd2ce074b6d2fe585fe850ff9d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Components_電影排行_Default), @"mvc.1.0.view", @"/Views/Movie/Components/電影排行/Default.cshtml")]
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
#line 1 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ed0a0efaf2fcd2ce074b6d2fe585fe850ff9d6", @"/Views/Movie/Components/電影排行/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Components_電影排行_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CMovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("charts-list-cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("poster"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Movie/poster_none1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
#nullable restore
#line 8 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
      
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
            WriteLiteral("            <li class=\"charts-list-row\">\r\n                <div class=\"divRow\">\r\n                    <span class=\"charts-list-rank\">");
#nullable restore
#line 22 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
                                              Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
            WriteLiteral("\r\n                    <div class=\"flipper\">\r\n                        <div class=\"flipper-item layer1\">\r\n");
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=", 745, "", 810, 1);
#nullable restore
#line 26 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue("", 751, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號movieId}), 751, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 27 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
                                 if (@urlpic != "")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("title", " title=\"", 941, "\"", 1001, 1);
#nullable restore
#line 29 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue("", 949, Html.DisplayFor(modelItem => Model[i].中文標題titleCht), 949, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                         class=\"charts-list-cover\" id=\"poster\"");
            BeginWriteAttribute("alt", " alt=\"", 1082, "\"", 1088, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", "\r\n                                         src=\"", 1089, "\"", 1144, 1);
#nullable restore
#line 31 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue("", 1137, urlpic, 1137, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 32 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9ed0a0efaf2fcd2ce074b6d2fe585fe850ff9d68472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
AddHtmlAttributeValue("", 1304, Html.DisplayFor(modelItem => Model[i].中文標題titleCht), 1304, 52, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </a>\r\n");
            WriteLiteral("                            <span class=\"charts-list-desc\">\r\n                                <span class=\"charts-list-song\"");
            BeginWriteAttribute("title", " title=\"", 1757, "\"", 1817, 1);
#nullable restore
#line 42 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue("", 1765, Html.DisplayFor(modelItem => Model[i].中文標題titleCht), 1765, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=", 1859, "", 1924, 1);
#nullable restore
#line 43 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue("", 1865, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號movieId}), 1865, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => Model[i].中文標題titleCht));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </span>\r\n                                <span class=\"charts-list-artist\"");
            BeginWriteAttribute("title", " title=\"", 2088, "\"", 2148, 1);
#nullable restore
#line 45 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue("", 2096, Html.DisplayFor(modelItem => Model[i].英文標題titleEng), 2096, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=", 2190, "", 2255, 1);
#nullable restore
#line 46 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue("", 2196, Url.Action("電影介紹","Movie", new {id= Model[i].電影編號movieId}), 2196, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => Model[i].英文標題titleEng));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </span>\r\n                            </span>\r\n");
            WriteLiteral("                            <span class=\"charts-list-content\"></span>\r\n                            <span class=\"charts-list-span\"><i class=\"fas fa-star\" style=\"padding-right:5px;color:#ffc107\"></i> 5</span>\r\n");
            WriteLiteral("                            <div class=\"dropdown\">\r\n                                <button");
            BeginWriteAttribute("aria-label", " aria-label=\"", 2767, "\"", 2837, 2);
            WriteAttributeValue("", 2780, "Rate", 2780, 4, true);
#nullable restore
#line 54 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
WriteAttributeValue(" ", 2784, Html.DisplayFor(modelItem => Model[i].中文標題titleCht), 2785, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"ipc-rate-button ipc-rating-star-group--unrated ipc-rate-button--unrated ipc-rate-button--baseAlt\"\r\n                                        data-testid=\"rate-button\" data-modal-target=\"#ToRate\">\r\n");
            WriteLiteral(@"                                    <span class=""ipc-rating-star ipc-rating-star--baseAlt ipc-rating-star--rate"">
                                        <i class=""far fa-star"" style=""padding-right:5px;color:#ffc107""></i>評分
                                    </span>
                                </button>
                            </div>
");
            WriteLiteral("                            <span class=\"charts-list-date\">");
#nullable restore
#line 64 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
                                                      Write(Html.DisplayFor(modelItem => Model[i].上映日期releaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral(@"                            <span class=""charts-list-prev-rank"">
                                <div class=""wlb_ribbon"" data-tconst=""tt0111161"" data-recordmetrics=""true"" style=""position: relative;"">
                                    <div class=""wl-ribbon standalone not-inWL"" title=""點擊添加到我的片單""></div>
                                </div>
                            </span>
                        </div>
                    </div>
                </div>
            </li>
");
#nullable restore
#line 75 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Movie\Components\電影排行\Default.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script></script>\r\n\r\n\r\n");
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
