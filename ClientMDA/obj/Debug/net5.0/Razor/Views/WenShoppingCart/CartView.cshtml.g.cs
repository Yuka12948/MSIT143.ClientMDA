#pragma checksum "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2a2c60a12038ba0abdb964510f7da66e15845a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WenShoppingCart_CartView), @"mvc.1.0.view", @"/Views/WenShoppingCart/CartView.cshtml")]
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
#line 1 "C:\MDA143\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA143\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a2c60a12038ba0abdb964510f7da66e15845a4", @"/Views/WenShoppingCart/CartView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_WenShoppingCart_CartView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModel.WenViewModel.WenCAddToCartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OptionTheater", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top w-100 p-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("DelInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/WenShoppingCart/ProductDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("text/plain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Deleteform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateReceipt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("application/x-www-form-urlencoded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
  
    ViewData["Title"] = "AddToCard";
    Layout = "~/Views/Shared/_WenLayout.cshtml";
    decimal sum = 0;

    foreach (var item in Model)
    {
        sum += item.小計;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .text-6:hover {
        /*box-shadow: 0 10px;*/
        padding-bottom: 20px;
        margin: 10px;
        padding: 10px;
        text-decoration: none;
        border-bottom: 5px #00ffff solid;
    }

    .text-6 {
        /*box-shadow: 0 10px;*/
        padding-bottom: 20px;
        margin: 10px;
        padding: 10px;
        text-decoration: none;
    }

    a:hover {
        text-decoration: none;
        color: darkgreen;
        /*border-bottom: 2px #0094ff solid;*/
    }

    fieldset {
        width: 500px;
        border: 1px solid #acd6ff;
        border-radius: 15px;
        margin: 15px;
    }

    .st1 {
        width: 450px;
        border-bottom: 3px dashed #bebebe;
        margin: 20px;
        padding-bottom: 10px;
    }

    .prdprice {
    }
</style>

<div style=""display:block;height:40px;""></div>
<div id=""listBtn"" onclick=""listBtn()"">選擇付款方式</div>
<div id=""C"" style=""display:none;"">
    <p>信用卡</p>
    <fieldset>
        <div class=");
            WriteLiteral(@"""st1""> <label>卡號:</label>&nbsp;&nbsp;<input type=""text"" value=""1234567890123456"" /></div>
        <div class=""st1""><label>驗證碼(3碼):</label>&nbsp;&nbsp;<input type=""text"" value=""890"" /></div>
        <div class=""st1""><label>有效期限:</label>&nbsp;&nbsp;<input type=""text"" value=""20230101"" /></div>
    </fieldset>
</div>
<div style=""display:block;height:40px;""></div>
<h4>我的購物車</h4>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a2c60a12038ba0abdb964510f7da66e15845a49490", async() => {
                WriteLiteral("繼續購物");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<div style=""display:block;height:40px;""></div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <table class=""table table-hover table-dark"">
                <thead>
                    <tr>
                        <td class=""col-2 text-white"">&nbsp;</td>
                        <td class=""col-1 text-white"">數量</td>
                        <td class=""col-3 text-white"">描述</td>
                        <td class=""col-3 text-white"">電影院</td>
                        <td class=""col-3 text-white"">小計</td>
                        <td class=""col-auto"">  </td>
                    </tr>
                </thead>
                <tbody class=""text-white"">
");
#nullable restore
#line 87 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                       int No = 0;
                        foreach (var item in Model)
                        {
                            No++;
                            string proID = "productItem" + No;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("data", " data=\"", 2688, "\"", 2714, 1);
#nullable restore
#line 92 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
WriteAttributeValue("", 2695, item.商品編號productId, 2695, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white\"");
            BeginWriteAttribute("id", " id=\"", 2734, "\"", 2745, 1);
#nullable restore
#line 92 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
WriteAttributeValue("", 2739, proID, 2739, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <td class=""text-white"">
                                    <div class=""container"">
                                        <div class=""card bg-white text-black"" style=""width:8rem;"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2a2c60a12038ba0abdb964510f7da66e15845a412845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3052, "~/images/WenProduct/", 3052, 20, true);
#nullable restore
#line 96 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
AddHtmlAttributeValue("", 3072, item.商品圖片路徑imagePath, 3072, 21, false);

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
            WriteLiteral("\r\n                                            <div class=\"row justify-content-center card-header\">\r\n                                                <p class=\"card-title\">");
#nullable restore
#line 98 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.商品名稱productName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                <p class=\"card-title prdprice\">單價: ");
#nullable restore
#line 99 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                                                                              Write(item.商品價格productPrice.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </td>

                                <td>
                                    <input type=""hidden"" id=""No""");
            BeginWriteAttribute("value", " value=\"", 3736, "\"", 3748, 1);
#nullable restore
#line 106 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
WriteAttributeValue(" ", 3744, No, 3745, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"No\" />  ");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                                    <!--<input type=\"hidden\" id=\"inputdelete\" name=\"Inprod\" />\r\n                                    </form>-->\r\n");
            WriteLiteral("                                    ");
#nullable restore
#line 113 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 117 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.商品介紹introduce));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <label>");
#nullable restore
#line 119 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.電影院名稱theaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                </td>\r\n                                <td>\r\n                                    <label>");
#nullable restore
#line 122 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                                      Write(item.小計.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                </td>
                                <td><button class=""Deletebtn btn btn-success mb-3"" data-toggle=""modal"" data-target=""#myModel""><i class=""fa-regular fa-trash-can""></i></button></td>

                            </tr>
");
#nullable restore
#line 127 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <div class=""modal fade text-dark"" id=""myModel"" data-backdrop=""static"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h4>您好，要移除商品嗎?</h4>
                            <button class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>
                        <div class=""modal-body"">
                            <p>親愛的顧客您好，確定要移除此商品嗎?</p>
                        </div>
                        <div class=""modal-footer"">
                            <button class=""btn btn-default"" data-dismiss=""modal"">關閉</button>
                            <button id=""D"" type=""submit"" class=""btn btn-warning"" data-dismiss=""modal"">移除</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a2c60a12038ba0abdb964510f7da66e15845a419115", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <input type=\"hidden\" id=\"inputdelete\" name=\"id\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-6""></div>
        <div class=""col-6"">
            <table class=""table table-borderless text-success justify-content-end"">

                <tr>
                    <td>請輸入優惠代碼</td>
                    <td>
                        <input id=""Coupon_Code"" type=""text"" />
                        <input id=""hiddenpoint"" type=""hidden"" />
                    </td>
                    <td>
                        <button class=""btn btn-outline-info"" type=""submit"" id=""btnpoint"">優惠</button>

                    </td>
                    <td id=""discount"">
                    </td>
                </tr>

                <tr class=""table-bordered"">
                    <td>含稅共計</td>
                    <td id=""fullprice"">");
#nullable restore
#line 180 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                                  Write(sum.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\"></div>\r\n        <div class=\"col-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a2c60a12038ba0abdb964510f7da66e15845a422586", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 195 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2a2c60a12038ba0abdb964510f7da66e15845a423208", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 198 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].商品編號productId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2a2c60a12038ba0abdb964510f7da66e15845a425001", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 201 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].count);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 203 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"訂單送出\" class=\"btn btn-outline-success\" id=\"subcreateR\">\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let deletebtns = document.getElementsByClassName('Deletebtn')//自動長出的刪除鍵
        let deleteID = document.querySelector('#inputdelete')//隱藏欄位，放要刪除的產品id號碼
        let D = document.querySelector('#D')//出現要刪除的方塊，「移除」的按鈕
        let inputdelete = document.querySelector('#inputdelete')//隱藏欄位，放要刪除的產品id號碼,設定value
        let proID = document.getElementById('proID')//根據序號No產生的Id

        let hiddenpoint = document.getElementById('hiddenpoint')
        let Coupon_Code = document.getElementById('Coupon_Code')
        let mypoint = document.getElementById('mypoint')
        let btn = document.getElementById('btnpoint')
        let u1 = document.getElementById(""u1"")

        let subcreateR = document.getElementById('subcreateR')

        function listBtn() {
            var listBtn = document.getElementById('listBtn');
            var C = document.getElementById('C');
            if (C.style.display === 'none') {
                C.style.display = 'block';
              /*  C.inner");
                WriteLiteral(@"Text = ""畫面收"";*/
            } else {
                C.style.display = 'none';
                listBtn.innerText = ""選擇付款方式"";
            }
        }


        btn.addEventListener(""click"", async () => {
            hiddenpoint.value = Coupon_Code.value
            //console.log(hiddenpoint.value)
            let point = hiddenpoint.value
            hiddenpoint.setAttribute(""value"", `${hiddenpoint.value}`)

            let response = await fetch(""");
#nullable restore
#line 248 "C:\MDA143\ClientMDA\Views\WenShoppingCart\CartView.cshtml"
                                   Write(Url.Content("~/WenShoppingCart/expoint"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" +`?Coupon_Code=${point}`)
            let DATAS = await response.json()
            //console.log(DATAS)
            //let Frag = document.createDocumentFragment()
            for (let i = 0; i < DATAS.length; i++) {
                const cell1 = document.getElementById(""discount"")
                let txt = document.createTextNode(DATAS[i])
                cell1.classList.add(""btn-primary"")
                cell1.appendChild(txt)
            }
            let d = $('#discount').text();
            //console.log('d is ' + d);
            let o = $('#fullprice').text();
            //console.log('o is ' + o);
            let numd = parseInt(d);
            let numo = parseInt(o);
            $('#fullprice').text(numo - numd);
        })

        for (let item of deletebtns) {
            item.addEventListener('click', evt => {
                evt.preventDefault();
                deleteID = $(event.currentTarget).parents('tr')[0].getAttribute('data');
                console.log($(event.");
                WriteLiteral(@"currentTarget).parents('tr')[0].getAttribute('data'))
                inputdelete.setAttribute('value', deleteID);
                D.addEventListener('click', evt => {
                    item.closest(""tr"").remove();
                    console.log(inputdelete)
                    $('#Deleteform').submit();
                })
            })
        }

        //subcreateR.addEventListener('click', evt => {
        //    evt.preventDefault();
        //    $('createR').submit();
        //})


        //let prdprice = document.getElementsByClassName('.prdprice');
        //console.log(prdprice)
        //let fullprice = 0;
        //addprice();
        //function addprice(){
        //    for (let item of prdprice) {
        //        let p = item.innerHTML;
        //        console.log(p)
        //        fullprice = fullprice + p;
        //    }
        //}

        //$('#fullprice').text(fullprice);
        //console.log(fullprice);
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModel.WenViewModel.WenCAddToCartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
