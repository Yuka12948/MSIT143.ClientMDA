#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\WenShoppingCart\AddToCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d81797fdca1cc19ed556367b078e8b0d481a681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WenShoppingCart_AddToCard), @"mvc.1.0.view", @"/Views/WenShoppingCart/AddToCard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d81797fdca1cc19ed556367b078e8b0d481a681", @"/Views/WenShoppingCart/AddToCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_WenShoppingCart_AddToCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClientMDA.Models.商品資料product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/0eb3302b-ae56-40e6-ab27-c888991b95f3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\WenShoppingCart\AddToCard.cshtml"
  
    ViewData["Title"] = "AddToCard";
    Layout = "~/Views/Shared/_WenLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>我的購物車</h4>\r\n\r\n\r\n");
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <table class=""table table-striped-columns table-dark table-hover text-white"">
                <thead>
                    <tr>
                        <td class=""col-1"">商品圖</td>
                        <td class=""col-auto"">品名</td>
                        <td class=""col-1"">價格</td>
                        <td class=""col-1"">數量</td>
                        <td class=""col-auto"">描述</td>
                        <td class=""col-auto"">電影院</td>
                        <td class=""col-auto"">    </td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d81797fdca1cc19ed556367b078e8b0d481a6815065", async() => {
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
                        </td>
                        <td>
                            <label name=""productName"">漢堡</label>
                        </td>
                        <td>
                            <label name=""productPrice"">$120</label>
                        </td>
                        <td>
                            <input type=""number"" min=""1"" value=""1"" id=""qty"" name=""quantity"">
                        </td>
                        <td>這裡是產品描述、如產品內容</td>
                        <td>
                            <label name=""TheaterName"">基隆秀泰戲院</label>
                        </td>
                        <td><button class=""btn btn-success mb-3"" data-toggle=""modal"" data-target=""#myModel""><i class=""fa-regular fa-trash-can""></i></button></td>
                    </tr>
                </tbody>
            </table>
            <div class=""modal fade text-dark"" id=""myModel"" data-backdrop=""static"">
                <div class=""modal-dialog"">
                    <div class=""mo");
            WriteLiteral(@"dal-content"">
                        <div class=""modal-header"">
                            <h4>您好，要移除商品嗎?</h4>
                            <button class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>
                        <div class=""modal-body"">
                            <p>親愛的顧客您好，確定要移除此商品嗎?</p>
                        </div>
                        <div class=""modal-footer"">
                            <button class=""btn btn-default"" data-dismiss=""modal"">關閉</button>
                            <button class=""btn btn-danger"" data-dismiss=""modal"">移除</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-6""></div>
        <div class=""col-6"">
            <table class=""table table-borderless text-success justify-content-end"">
                <tr>
                    <td>小計</td>
                 ");
            WriteLiteral(@"   <td>$120</td>
                </tr>
                <tr>
                    <td>優惠折扣</td>
                    <td>$20</td>
                </tr>
                <tr>
                    <td>含稅</td>
                    <td>$20</td>
                </tr>
                <tr class=""table-bordered"">
                    <td>共計</td>
                    <td>$100</td>
                </tr>
            </table>
            <button class=""btn-success"">訂單送出</button>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClientMDA.Models.商品資料product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
