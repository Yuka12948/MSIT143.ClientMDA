#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c359476c33402340e5be6605224cffb7c373ccc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c359476c33402340e5be6605224cffb7c373ccc", @"/Views/Comment/Components/評論輪播/Default.cshtml")]
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
            WriteLiteral("\r\n<style>\r\n    .set-bg {\r\n        background-position: center,-500px;\r\n    }\r\n</style>\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
     foreach (var item in Model)
    {
        var t = item.發佈時間commentTime;
        var BGsrc = "";
        var q = item.mPoster[0];
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
         if (item.mPoster.Count() <= 0) {
            BGsrc = "~/images/Movie/poster_none1.png";
        }
        else if (item.mPoster.Count() > 0) 
        {
            BGsrc = "https://localhost:44381/images/MovieImage/" + @item.mPoster[1].movieImage;
        }
        else
        {
            BGsrc = @item.mPoster[0].movieIMDB;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"hero__items set-bg\" data-setbg=\"");
#nullable restore
#line 32 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                               Write(BGsrc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""hero__text"">
                        <div class=""label"">
                            <span class=""mem_info"">
                                <span style=""color:white"">
");
#nullable restore
#line 39 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                     if (item.會員照片image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img class=\"memImg\"");
            BeginWriteAttribute("src", " src=\"", 1204, "\"", 1263, 2);
            WriteAttributeValue("", 1210, "https://localhost:44381/images/Member/", 1210, 38, true);
#nullable restore
#line 41 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
WriteAttributeValue("", 1248, item.會員照片image, 1248, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1264, "\"", 1270, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 42 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c359476c33402340e5be6605224cffb7c373ccc7474", async() => {
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
#line 46 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                                                                                     
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1676, "\"", 1741, 1);
#nullable restore
#line 48 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
WriteAttributeValue("", 1683, Url.Action("會員評論","Comment", new {id= item.會員編號memberId}), 1683, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-weight:700;font-size:18px\"> ");
#nullable restore
#line 48 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                                                                                                                            Write(item.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - ");
#nullable restore
#line 48 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                                                                                                                                                                   Write(Html.DisplayFor(modelItem => item.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </span>\r\n                        </div>\r\n                        <h3>");
#nullable restore
#line 52 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                       Write(item.評論標題commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3><hr />\r\n                        <p class=\"mComment-text\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
                       Write(item.評論內容comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2189, "\"", 2258, 1);
#nullable restore
#line 57 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
WriteAttributeValue("", 2196, Url.Action("電影評論", "Comment", new { id = item.評論編號commentId}), 2196, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-comment\">\r\n");
            WriteLiteral("                            <span>看評論</span>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 65 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論輪播\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n</script>");
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
