#pragma checksum "C:\Users\Student\Desktop\MDA專題\MDA專題Git\ClientMDA\Views\Member\CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "374d8f995c58247da87bb139d74e5249d33864cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_CommentList), @"mvc.1.0.view", @"/Views/Member/CommentList.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\MDA專題\MDA專題Git\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\MDA專題\MDA專題Git\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"374d8f995c58247da87bb139d74e5249d33864cc", @"/Views/Member/CommentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Student\Desktop\MDA專題\MDA專題Git\ClientMDA\Views\Member\CommentList.cshtml"
  
    ViewData["Title"] = "CommentList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374d8f995c58247da87bb139d74e5249d33864cc4348", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "374d8f995c58247da87bb139d74e5249d33864cc4610", async() => {
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
                WriteLiteral("\r\n    <style>\r\n        .white {\r\n            color: white;\r\n        }\r\n\r\n        .table-hover tbody tr:hover {\r\n            color: #00b0f0;\r\n            background-color: rgba(0,0,0,.075);\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374d8f995c58247da87bb139d74e5249d33864cc6729", async() => {
                WriteLiteral(@"
    <div class=""member_id"">
        <span class=""member_hello"">HELLO!</span>
        <span class=""member_id_name""></span>
    </div>
    <div class=""row"">
        <div class=""member_menu"">
            <a id=""wishlist"" href=""../Member/WatchList"" title=""我的片單"" class=""member_link"">我的片單</a>
            <a id=""orderreturnlist"" href=""../Member/CommentList"" title=""我的評論"" class=""member_link"">我的評論</a>
            <a id=""wishlist"" href=""../zh-TW/wishlist"" title=""收藏清單"" class=""member_link"">收藏清單</a>

            <a id=""orderlist"" href=""../zh-TW/orderlist"" title=""訂單查詢"" class=""member_link"">訂單查詢</a>
            <a id=""memberbonuslist"" href=""../zh-TW/memberbonuslist"" title=""我的紅利金"" class=""member_link"">我的紅利金</a>
            <a id=""memberdiscount"" href=""../zh-TW/memberdiscount"" title=""我的抵用券"" class=""member_link"">我的抵用券</a>

            <a id=""memberpassword"" href=""../Member/PasswordEdit"" title=""密碼修改"" class=""member_link"">密碼修改</a>
            <a id=""membermodify"" href=""../Member/MemberEdit"" title=""資料修改"" class=""member_");
                WriteLiteral(@"link "">資料修改</a>
            <a href=""../zh-TW/logout"" class=""member_link"" title=""登出"">登出</a>
        </div>
        <div class=""member_main"">
            <div class=""member_area white"">
                <!--content-->
                <h2 class=""white"">我的評論一覽</h2>
                <table class=""table table-hover white"">
                    <thead>
                        <tr>
                            <th scope=""col"">序</th>
                            <th scope=""col"">標題</th>
                            <th scope=""col"">內文</th>
                            <th scope=""col"">發布時間</th>
                            <th scope=""col"">編輯</th>
                        </tr>
                    </thead>
                    <tbody class=""white"">
                        <tr>
                            <th scope=""row"">1</th>
                            <td>專題∣《幸福入場券》之外！５部茱莉亞羅勃茲主演浪漫愛情喜劇</td>
                            <td>好久不見的「經典」好萊塢喜劇《幸福入場券 Ticket to Paradise》來了。之所以稱之「經典」，並不是因為它已經...</td>
                ");
                WriteLiteral("            <td>2022/10/02</td>\r\n                            <td><a");
                BeginWriteAttribute("href", " href=\"", 2470, "\"", 2477, 0);
                EndWriteAttribute();
                WriteLiteral(">編輯</a> <a");
                BeginWriteAttribute("href", " href=\"", 2488, "\"", 2495, 0);
                EndWriteAttribute();
                WriteLiteral(@">刪除</a></td>
                        </tr>
                        <tr>
                            <th scope=""row"">2</th>
                            <td>專題∣必看《阿凡達》的５大理由重溫：看完再迎《阿凡達2：水之道》！</td>
                            <td>2009年的好萊塢電影《阿凡達》是部殿堂級電影，是大導演詹姆斯卡麥隆在《鐵達尼號》之後傾注心力所打造的鉅...</td>
                            <td>2022/09/19</td>
                            <td><a");
                BeginWriteAttribute("href", " href=\"", 2872, "\"", 2879, 0);
                EndWriteAttribute();
                WriteLiteral(">編輯</a> <a");
                BeginWriteAttribute("href", " href=\"", 2890, "\"", 2897, 0);
                EndWriteAttribute();
                WriteLiteral(@">刪除</a></td>
                        </tr>
                        <tr>
                            <th scope=""row"">3</th>
                            <td>專題∣《死侍3》影片公開：你可能錯過的５個彩蛋詳解</td>
                            <td>真是萬萬沒想到！萊恩雷諾斯近期用推特公佈《死侍3》的上映日期，不僅如此，最令人驚喜的莫過於休傑克曼將以...</td>
                            <td>2022/10/02</td>
                            <td><a");
                BeginWriteAttribute("href", " href=\"", 3265, "\"", 3272, 0);
                EndWriteAttribute();
                WriteLiteral(">編輯</a> <a");
                BeginWriteAttribute("href", " href=\"", 3283, "\"", 3290, 0);
                EndWriteAttribute();
                WriteLiteral(@">刪除</a></td>
                        </tr>
                        <tr>
                            <th scope=""row"">3</th>
                            <td>影評∣《破案天才伽利略：沉默的遊行》理性推理不失感性元素</td>
                            <td>《破案天才伽利略：沉默的遊行》過去有日劇也有另外兩部大銀幕電影，是東野圭吾偵探小說系列改編的電影，並不...</td>
                            <td>2022/09/23</td>
                            <td><a");
                BeginWriteAttribute("href", " href=\"", 3661, "\"", 3668, 0);
                EndWriteAttribute();
                WriteLiteral(">編輯</a> <a");
                BeginWriteAttribute("href", " href=\"", 3679, "\"", 3686, 0);
                EndWriteAttribute();
                WriteLiteral(">刪除</a></td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n                <!--end content-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
