#pragma checksum "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55a86bd5fd295461a0f19b481097f1c90a7f8d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Components_電影評論list_Default), @"mvc.1.0.view", @"/Views/Movie/Components/電影評論list/Default.cshtml")]
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
#line 1 "C:\MDA前端\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前端\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55a86bd5fd295461a0f19b481097f1c90a7f8d6", @"/Views/Movie/Components/電影評論list/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Components_電影評論list_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CCommentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Comment/mem01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <div class=\"col-lg-8 col-md-8\">\r\n        <!-- #region 電影評論 -->\r\n        <div class=\"anime__details__review\">\r\n            <div class=\"section-title\">\r\n                <h5>電影評論</h5>\r\n            </div>\r\n\r\n");
#nullable restore
#line 14 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
             for (var i = 0; i < Model.Count; i++)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"anime__review__item\">\r\n                    <div class=\"anime__review__item__pic\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d55a86bd5fd295461a0f19b481097f1c90a7f8d65296", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"anime__review__item__text\">\r\n                        <h6>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 725, "\"", 794, 1);
#nullable restore
#line 24 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
WriteAttributeValue("", 732, Url.Action("會員評論","Comment", new {id= Model[i].會員編號memberId}), 732, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
                                                                                                Write(Model[i].暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - </a>\r\n                            <span>");
#nullable restore
#line 25 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
                             Write(Html.DisplayFor(modelItem => Model[i].發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"mem_rate\" style=\"color: #ffc107;\">\r\n                                <i class=\"fa fa-star\"></i> ");
#nullable restore
#line 27 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
                                                      Write(Model[i].評分rate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 分\r\n                            </span>\r\n                        </h6>\r\n                        <h5>");
#nullable restore
#line 30 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
                       Write(Model[i].評論標題commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><br />\r\n                        <p class=\"mComment-text\">");
#nullable restore
#line 31 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
                                            Write(Model[i].評論內容comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1317, "\"", 1390, 1);
#nullable restore
#line 32 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
WriteAttributeValue("", 1324, Url.Action("電影評論", "Comment", new { id = Model[i].評論編號commentId}), 1324, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"see-more\">詳全文 >></span></a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\MDA前端\ClientMDA\Views\Movie\Components\電影評論list\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <!-- #endregion 電影資訊 -->\r\n        <!-- #region 你的評論 -->\r\n        <div class=\"anime__details__form\">\r\n            <div class=\"section-title\">\r\n                <h5>你的評論</h5>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55a86bd5fd295461a0f19b481097f1c90a7f8d69639", async() => {
                WriteLiteral("\r\n                <textarea placeholder=\"Your Comment\" class=\"txtarea\"></textarea><br />\r\n                <button type=\"submit\"><i class=\"fa fa-location-arrow\"></i>送出</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <!-- #endregion 你的評論 -->\r\n    </div>\r\n");
            WriteLiteral("<script>\r\n\r\n</script>\r\n");
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
