#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c41edac0af50e1d87dfee68c7633756ae3b11f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Components_評論輪播_Default), @"mvc.1.0.view", @"/Views/Comment/Components/評論輪播/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c41edac0af50e1d87dfee68c7633756ae3b11f", @"/Views/Comment/Components/評論輪播/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Components_評論輪播_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CCommentViewModel>>
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
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
     foreach (var item in Model)
    {
        var t = item.發佈時間commentTime;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""hero__items set-bg"" data-setbg=""https://im.marieclaire.com.tw/m800c533h100b0/assets/mc/202205/628C963D8F7801653380669.jpeg"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""hero__text"">
                        <div class=""label"">
                            <span class=""mem_info"">
                                <span style=""color:white"">
");
#nullable restore
#line 19 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                     if (item.會員照片image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img class=\"memImg\"");
            BeginWriteAttribute("src", " src=\"", 780, "\"", 839, 2);
            WriteAttributeValue("", 786, "https://localhost:44381/images/Member/", 786, 38, true);
#nullable restore
#line 21 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
WriteAttributeValue("", 824, item.會員照片image, 824, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 840, "\"", 846, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 22 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "52c41edac0af50e1d87dfee68c7633756ae3b11f6572", async() => {
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
#line 27 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                                                                                     
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1254, "\"", 1319, 1);
#nullable restore
#line 29 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
WriteAttributeValue("", 1261, Url.Action("會員評論","Comment", new {id= item.會員編號memberId}), 1261, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-weight:700;font-size:18px\"> ");
#nullable restore
#line 29 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                                                                                                                            Write(item.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - ");
#nullable restore
#line 29 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                                                                                                                                                   Write(Html.DisplayFor(modelItem => item.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </span>\r\n                        </div>\r\n                        <h3>");
#nullable restore
#line 33 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                       Write(item.評論標題commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3><hr />\r\n                        <p class=\"mComment-text\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                       Write(item.評論內容comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1767, "\"", 1836, 1);
#nullable restore
#line 38 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
WriteAttributeValue("", 1774, Url.Action("電影評論", "Comment", new { id = item.評論編號commentId}), 1774, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-comment\">\r\n");
            WriteLiteral("                            <span>看評論</span>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
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
