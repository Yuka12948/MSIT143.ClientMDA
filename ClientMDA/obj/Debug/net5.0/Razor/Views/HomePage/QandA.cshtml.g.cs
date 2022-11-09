#pragma checksum "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b926b54fd725d6ddfcf5a70ad28c990752d7fb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_QandA), @"mvc.1.0.view", @"/Views/HomePage/QandA.cshtml")]
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
#line 1 "C:\MDA前\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b926b54fd725d6ddfcf5a70ad28c990752d7fb2", @"/Views/HomePage/QandA.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_QandA : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CQANDAViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomePage/QandA.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
  
    ViewData["Title"] = "QandA";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b926b54fd725d6ddfcf5a70ad28c990752d7fb24384", async() => {
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
                WriteLiteral(@"
    <style>
        #box1, #box2 {
            display: flex;
            justify-content: center;
        }

        button {
            border: 0;
            border-radius: 10px;
            background-color: rgba(44,44,44,0.6);
            color: whitesmoke;
            width: 160px;
            height: 50px;
            vertical-align: middle;
            align-items: center;
            text-align: center;
            font-size: 1.25rem;
            margin: 1%;
        }

            button:hover {
                background-color: rgba(255, 191, 0,0.6);
            }
    </style>
");
            }
            );
            WriteLiteral(@"
<h2>FQA專區</h2>

<div id=""boxtoutside"">
    <div id=""box1"">
        <button id=""一般資訊"">一般資訊</button>
        <button id=""會員問題"">會員問題</button>
        <button id=""評分問題"">評分問題</button>
        <button id=""評論問題"">評論問題</button>
        <button id=""加入片單"">加入片單</button>
    </div>
    <div id=""box2"">
        <button id=""訂票問題"">訂票問題</button>
        <button id=""取票問題"">取票問題</button>
        <button id=""退票問題"">退票問題</button>
        <button id=""優惠券"">優惠紅利</button>
        <button id=""購物問題"">購物問題</button>
    </div>

    <div id=""頁面切換"">
        ");
#nullable restore
#line 57 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
   Write(await Component.InvokeAsync("一般資訊", new { datas = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""support-button text-center d-flex align-items-center justify-content-center mt-4 wow fadeInUp"" data-wow-delay=""0.5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInUp;"" id=""contenctus"">
        <i class=""lni-emoji-sad""></i>
        <p class=""mb-0 px-2"" style=""font-size:1.25rem;"">找不到你要的答案？</p>
        <a href=""mailto:ilovemdaofficial@gmail.com"" style=""color:palegreen;font-size:1.25rem;""> 聯絡我們</a>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $(\'#會員問題\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 70 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/memQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#一般資訊\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 73 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/GeneraInfor"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#評分問題\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 76 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/rateQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#評論問題\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 79 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/commentQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#加入片單\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 82 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/addlistQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#訂票問題\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 85 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/orderticketQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#取票問題\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 88 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/taketicketQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#退票問題\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 91 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/refundQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#優惠券\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 94 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/couponQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n    $(\'#購物問題\').click(function () {\r\n        $(\'#頁面切換\').load(\'");
#nullable restore
#line 97 "C:\MDA前\ClientMDA\Views\HomePage\QandA.cshtml"
                    Write(Url.Content("~/HomePage/shopQa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    })\r\n\r\n      \r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CQANDAViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
