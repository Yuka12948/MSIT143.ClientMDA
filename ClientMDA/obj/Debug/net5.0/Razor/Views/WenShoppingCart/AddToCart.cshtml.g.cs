#pragma checksum "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ff2167f4eed7c73a473bfcd0092f8e28a4809c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WenShoppingCart_AddToCart), @"mvc.1.0.view", @"/Views/WenShoppingCart/AddToCart.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ff2167f4eed7c73a473bfcd0092f8e28a4809c", @"/Views/WenShoppingCart/AddToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_WenShoppingCart_AddToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientMDA.Models.商品資料product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top p-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddToCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
  
    ViewData["Title"] = "AddToCart";
    Layout = "~/Views/Shared/_WenLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    /* Chrome, Safari, Edge, Opera */
    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }

    /* Firefox */
    input[type=number] {
        -moz-appearance: textfield;
    }
</style>

<div style=""display:block;height:20px;""></div>

");
#nullable restore
#line 23 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47ff2167f4eed7c73a473bfcd0092f8e28a4809c5449", async() => {
                WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"row justify-content-center\">\r\n               \r\n                <div class=\"card bg-white text-dark\" style=\"width:22rem;\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47ff2167f4eed7c73a473bfcd0092f8e28a4809c5923", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 816, "~/images/WenProduct/", 816, 20, true);
#nullable restore
#line 31 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
AddHtmlAttributeValue("", 836, Model.商品圖片路徑imagePath, 836, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"商品編號productId\"");
                BeginWriteAttribute("value", " value=\"", 925, "\"", 953, 1);
#nullable restore
#line 32 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
WriteAttributeValue("", 933, Model.商品編號productId, 933, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <h4>請選擇加入數量</h4>\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title\">");
#nullable restore
#line 35 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
                                          Write(Model.商品名稱productName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 36 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
                                        Write(Model.商品介紹introduce);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        <div class=""container"">
                            <div class=""row justify-content-center"">
                                <div class=""col-2""><button type=""button"" id=""btnMinus"" class=""btn btn-secondary"">-</button></div>
                                <div class=""col-8""> <input type=""number"" name=""count"" value=""1"" class=""form-control"" id=""count""></div>
                                <div class=""col-2""> <button type=""button"" id=""btnPlus"" class=""btn btn-secondary"">+</button></div>
                            </div>
                        </div>
                        <div style=""display:block;height:20px;""></div>
                        <input type=""submit"" value=""加入"" class=""btn btn-outline-success"" />
                    </div>

                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <div style=\"display:block;height:40px;\"></div>\r\n");
#nullable restore
#line 54 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\USER\Desktop\MDA\ClientMDA\Views\WenShoppingCart\AddToCart.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
        let btnMinus = document.getElementById('btnMinus')
        let count = document.getElementById('count')
        let btnPlus = document.getElementById('btnPlus')
        let curNum = 1
        btnPlus.addEventListener(""click"", function () {
            curNum++
            //console.log(curNum)
            count.value = curNum
        })
        btnMinus.addEventListener(""click"", function () {
            if (curNum >= 2) {
                curNum--
                console.log(curNum)
                count.value = curNum
            }
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientMDA.Models.商品資料product> Html { get; private set; }
    }
}
#pragma warning restore 1591
