#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Member\MemberDiscount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f21bffb84038e3b4756e727e56975ca60c44f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_MemberDiscount), @"mvc.1.0.view", @"/Views/Member/MemberDiscount.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f21bffb84038e3b4756e727e56975ca60c44f7a", @"/Views/Member/MemberDiscount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_MemberDiscount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/MemberMain.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Member\MemberDiscount.cshtml"
  
    ViewData["Title"] = "MemberDiscount";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f21bffb84038e3b4756e727e56975ca60c44f7a4370", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f21bffb84038e3b4756e727e56975ca60c44f7a4632", async() => {
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
        .control-label {
            color: white;
        }

        .white {
            color: white;
            text-align: center
        }

        .content {
            margin: 0 auto;
        }
        .available {
            color: #00B0F0
        }
        .used{
            color:lightgray
        }
        .overdue {
            color: lightgray
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f21bffb84038e3b4756e727e56975ca60c44f7a6934", async() => {
                WriteLiteral(@"
    <div class=""member_id"">
        <span class=""member_hello"">HELLO!</span>
        <span class=""member_id_name""></span>
    </div>

    <div class=""row"">
        <div class=""member_menu"">
            <a id=""watchlist"" href=""../Member/WatchList"" title=""我的片單"" class=""member_link"">我的片單</a>
            <a id=""commentList"" href=""../Member/CommentList"" title=""我的評論"" class=""member_link"">我的評論</a>
");
                WriteLiteral(@"
            <a id=""orderlist"" href=""../Member/orderlist"" title=""訂單查詢"" class=""member_link"">訂單查詢</a>
            <a id=""memberbonuslist"" href=""../Member/memberbonuslist"" title=""我的紅利金"" class=""member_link"">我的紅利金</a>
            <a id=""memberdiscount"" href=""../Member/memberdiscount"" title=""我的抵用券"" class=""member_link"">我的抵用券</a>

            <a id=""memberpassword"" href=""../Member/PasswordEdit"" title=""密碼修改"" class=""member_link"">密碼修改</a>
            <a id=""MemberEdit"" href=""../Member/MemberEdit"" title=""資料修改"" class=""member_link "">資料修改</a>
            <a href=""../Member/logout"" class=""member_link"" title=""登出"">登出</a>
        </div>
        <div class=""member_main"">
            <div class=""member_area"">
                <!--content-->
                <h2 class=""white text-left"">我的抵用券</h2>
                <input type=""text"" placeholder=""輸入優惠代碼"" />
                <button id=""buttonAdd"" class=""site-btn mt-3 mb-3"">
                    <i class=""fa fa-plus""> 新增優惠</i>
                </button>
                <ta");
                WriteLiteral(@"ble class=""table white"">
                    <thead>
                        <tr>
                            <th scope=""col"">折扣金額</th>
                            <th scope=""col"">抵用券內容</th>
                            <th scope=""col"">使用期限</th>
                            <th scope=""col"">使用狀況</th>
                        </tr>
                    </thead>
                    <tbody class=""white"">
                        <tr>
                            <th scope=""row""");
                BeginWriteAttribute("class", " class=\"", 2574, "\"", 2582, 0);
                EndWriteAttribute();
                WriteLiteral(">$50</th>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 2625, "\"", 2633, 0);
                EndWriteAttribute();
                WriteLiteral(">會員生日禮</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 2678, "\"", 2686, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                2022-10-01 00:00:00
                                <br />-<br />
                                2022-10-31 23:59:59
                            </td>
                            <td class=""available"">未使用</td>
                        </tr>
                        <tr>
                            <th scope=""row""");
                BeginWriteAttribute("class", " class=\"", 3042, "\"", 3050, 0);
                EndWriteAttribute();
                WriteLiteral(">$20</th>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3093, "\"", 3101, 0);
                EndWriteAttribute();
                WriteLiteral(">歡慶粉絲達一萬</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3148, "\"", 3156, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                2021-10-30 00:00:00
                                <br />-<br />
                                2022-02-04 23:59:59
                            </td>
                            <td class=""overdue"">已過期</td>
                        </tr>
                        <tr>
                            <th scope=""row""");
                BeginWriteAttribute("class", " class=\"", 3510, "\"", 3518, 0);
                EndWriteAttribute();
                WriteLiteral(">$50</th>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3561, "\"", 3569, 0);
                EndWriteAttribute();
                WriteLiteral(">新會員加入禮</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3615, "\"", 3623, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                2021-10-01 00:00:00
                                <br />-<br />
                                2021-10-31 23:59:59
                            </td>
                            <td class=""used"">已使用</td>
                        </tr>
                    </tbody>
                </table>
                <!--end content-->
            </div>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
