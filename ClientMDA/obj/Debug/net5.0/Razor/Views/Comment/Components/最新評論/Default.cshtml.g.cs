#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376e667eb9785b6cc2b9e6e082ff1411f762924b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376e667eb9785b6cc2b9e6e082ff1411f762924b", @"/Views/Comment/Components/最新評論/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Components_最新評論_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CCommentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("memImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
  
    for (var i = 0; i < Model.Count; i++)
    {
        string urlpic = "";
        if (Model[i].cImgFrList.Count() > 0)
        {
            //urlpic = Model[i].cImgFrList[0];
            urlpic = "https://localhost:44381/images/Comment/" + Model[i].cImgFrList[0];
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\" style=\"max-width: 540px;\">\r\n");
            WriteLiteral("            <div class=\"row g-0\">\r\n                <div class=\"col-md-4 set-bg\" data-setbg=\"");
#nullable restore
#line 18 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                    Write(urlpic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("style", " style=\"", 588, "\"", 640, 3);
            WriteAttributeValue("", 596, "background-image:url(\'", 596, 22, true);
#nullable restore
#line 18 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 618, urlpic, 618, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 625, "\');height:220px", 625, 15, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 23 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                          Write(Html.DisplayFor(modelItem => Model[i].評論標題commentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <span class=\"mem_info\">\r\n                            <span>\r\n");
#nullable restore
#line 26 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                 if (Model[i].會員照片image != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img class=\"memImg\"");
            BeginWriteAttribute("src", " src=\"", 1191, "\"", 1254, 2);
            WriteAttributeValue("", 1197, "https://localhost:44381/images/Member/", 1197, 38, true);
#nullable restore
#line 28 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1235, Model[i].會員照片image, 1235, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1255, "\"", 1261, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 29 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "376e667eb9785b6cc2b9e6e082ff1411f762924b7965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                                                                 
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=", 1639, "", 1707, 1);
#nullable restore
#line 35 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1645, Url.Action("會員評論","Comment", new {id= Model[i].會員編號memberId}), 1645, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                                                                  Write(Html.DisplayFor(modelItem => Model[i].暱稱nickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </span>\r\n                            <span>\r\n                                - ");
#nullable restore
#line 38 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                             Write(Html.DisplayFor(modelItem => Model[i].發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:white\"></span>\r\n                            </span><hr />\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 41 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => Model[i].評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <a");
            BeginWriteAttribute("href", " href=", 2206, "", 2275, 1);
#nullable restore
#line 43 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 2212, Url.Action("電影評論","Comment", new {id= Model[i].評論編號commentId}), 2212, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"card-text\"><small class=\"text-muted\">詳全文 >> </small></p></a>\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n</script>");
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
