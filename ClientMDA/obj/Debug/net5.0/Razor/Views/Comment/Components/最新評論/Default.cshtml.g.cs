#pragma checksum "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb30e1c05fe44cbb15e4f3eb45ae1b251301bcae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Components_最新評論_Default), @"mvc.1.0.view", @"/Views/Comment/Components/最新評論/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb30e1c05fe44cbb15e4f3eb45ae1b251301bcae", @"/Views/Comment/Components/最新評論/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Components_最新評論_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CCommentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Movie/poster_none1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("memImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
  
    for (var i = 0; i < Model.Count; i++)
    {
        string urlpic = "";
        if (Model[i].cImgFrList.Count() > 0)
        {
            //urlpic = Model[i].cImgFrList[0];
            urlpic = "http://192.168.36.4:44383/images/Comment/" + Model[i].cImgFrList[0];
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\" style=\"max-width: 540px;\">\r\n");
            WriteLiteral("            <div class=\"row g-0\">\r\n                <div class=\"col-md-4 set-comImg-bg\" data-setbg=\"");
#nullable restore
#line 19 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                           Write(urlpic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("style", " style=\"", 599, "\"", 652, 3);
            WriteAttributeValue("", 607, "background-image:url(\'", 607, 22, true);
#nullable restore
#line 19 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 629, urlpic, 629, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 636, "\');height:220px;", 636, 16, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 20 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                      
                        if (@Model[i].mPoster.Count() <= 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb30e1c05fe44cbb15e4f3eb45ae1b251301bcae7037", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 24 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                        }
                        else if (@Model[i].mPoster.Count() > 0) 
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div><img");
            BeginWriteAttribute("src", " src=\"", 1011, "\"", 1092, 2);
            WriteAttributeValue("", 1017, "http://192.168.36.4:44383/images/MovieImage/", 1017, 44, true);
#nullable restore
#line 27 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1061, Model[i].mPoster[0].movieImage, 1061, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-start\" alt=\"...\"></div>\r\n");
#nullable restore
#line 28 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div><img");
            BeginWriteAttribute("src", " src=\"", 1265, "\"", 1301, 1);
#nullable restore
#line 31 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1271, Model[i].mPoster[0].movieIMDB, 1271, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-start\" alt=\"...\"></div>\r\n");
#nullable restore
#line 32 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 38 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                          Write(Html.DisplayFor(modelItem => Model[i].評論標題commentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <span class=\"mem_info\">\r\n                            <span>\r\n");
#nullable restore
#line 41 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                 if (Model[i].會員照片image != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img class=\"memImg\"");
            BeginWriteAttribute("src", " src=\"", 1950, "\"", 2015, 2);
            WriteAttributeValue("", 1956, "http://192.168.36.4:44383/images/Member/", 1956, 40, true);
#nullable restore
#line 43 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1996, Model[i].會員照片image, 1996, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2016, "\"", 2022, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 44 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eb30e1c05fe44cbb15e4f3eb45ae1b251301bcae12244", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
#line 48 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                                                                 
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=", 2400, "", 2468, 1);
#nullable restore
#line 50 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 2406, Url.Action("會員評論","Comment", new {id= Model[i].會員編號memberId}), 2406, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                                                                  Write(Html.DisplayFor(modelItem => Model[i].暱稱nickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </span>\r\n                            <span>\r\n                                - ");
#nullable restore
#line 53 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                             Write(Html.DisplayFor(modelItem => Model[i].發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:white\"></span>\r\n                            </span><hr />\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 56 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => Model[i].評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <a");
            BeginWriteAttribute("href", " href=", 2967, "", 3036, 1);
#nullable restore
#line 58 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 2973, Url.Action("電影評論","Comment", new {id= Model[i].評論編號commentId}), 2973, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"card-text\"><small class=\"text-muted\">繼續閱讀 >> </small></p></a>\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 64 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CCommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
