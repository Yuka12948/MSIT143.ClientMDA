#pragma checksum "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "020c3dd5ac7f03bad746e32b44bdc838c0414f2f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"020c3dd5ac7f03bad746e32b44bdc838c0414f2f", @"/Views/Comment/Components/最新評論/Default.cshtml")]
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
#line 3 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
  
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
            WriteLiteral("            <div class=\"row g-0\">\r\n                <div class=\"col-md-4 set-comImg-bg\" data-setbg=\"");
#nullable restore
#line 19 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                           Write(urlpic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("style", " style=\"", 597, "\"", 650, 3);
            WriteAttributeValue("", 605, "background-image:url(\'", 605, 22, true);
#nullable restore
#line 19 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 627, urlpic, 627, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 634, "\');height:220px;", 634, 16, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 20 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                      
                        if (@Model[i].mPoster.Count() <= 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "020c3dd5ac7f03bad746e32b44bdc838c0414f2f6659", async() => {
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
#line 24 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                        }
                        else if (@Model[i].mPoster.Count() > 0) 
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div><img");
            BeginWriteAttribute("src", " src=\"", 1009, "\"", 1088, 2);
            WriteAttributeValue("", 1015, "https://localhost:44381/images/MovieImage/", 1015, 42, true);
#nullable restore
#line 27 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1057, Model[i].mPoster[0].movieImage, 1057, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-start\" alt=\"...\"></div>\r\n");
#nullable restore
#line 28 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div><img");
            BeginWriteAttribute("src", " src=\"", 1261, "\"", 1297, 1);
#nullable restore
#line 31 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1267, Model[i].mPoster[0].movieIMDB, 1267, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-start\" alt=\"...\"></div>\r\n");
#nullable restore
#line 32 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 38 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                          Write(Html.DisplayFor(modelItem => Model[i].評論標題commentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <span class=\"mem_info\">\r\n                            <span>\r\n");
#nullable restore
#line 41 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                 if (Model[i].會員照片image != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img class=\"memImg\"");
            BeginWriteAttribute("src", " src=\"", 1946, "\"", 2009, 2);
            WriteAttributeValue("", 1952, "https://localhost:44381/images/Member/", 1952, 38, true);
#nullable restore
#line 43 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 1990, Model[i].會員照片image, 1990, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2010, "\"", 2016, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 44 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "020c3dd5ac7f03bad746e32b44bdc838c0414f2f11439", async() => {
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
#line 48 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                                                                 
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=", 2394, "", 2462, 1);
#nullable restore
#line 50 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 2400, Url.Action("會員評論","Comment", new {id= Model[i].會員編號memberId}), 2400, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                                                                                                  Write(Html.DisplayFor(modelItem => Model[i].暱稱nickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </span>\r\n                            <span>\r\n                                - ");
#nullable restore
#line 53 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                             Write(Html.DisplayFor(modelItem => Model[i].發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:white\"></span>\r\n                            </span><hr />\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 56 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => Model[i].評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <a");
            BeginWriteAttribute("href", " href=", 2961, "", 3030, 1);
#nullable restore
#line 58 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
WriteAttributeValue("", 2967, Url.Action("電影評論","Comment", new {id= Model[i].評論編號commentId}), 2967, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"card-text\"><small class=\"text-muted\">繼續閱讀 >> </small></p></a>\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 64 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\最新評論\Default.cshtml"
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
