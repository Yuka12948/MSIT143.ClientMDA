#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88753cee6f44c1a3ba229a28ad23f2987cb7f3f"
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
#line 1 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88753cee6f44c1a3ba229a28ad23f2987cb7f3f", @"/Views/Member/CommentList.cshtml")]
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
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
  
    ViewData["Title"] = "CommentList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88753cee6f44c1a3ba229a28ad23f2987cb7f3f4368", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c88753cee6f44c1a3ba229a28ad23f2987cb7f3f4630", async() => {
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
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css"" integrity=""sha512-xh6O/CkQoPOWDdYTDqeRdPCVd1SpvCA9XXcUnZS2FmJNp1coAFzvtCN9BmamE+4aHK8yyUHUSCcJHgXloTyT2A=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />

    <style>
        .white {
            color: white;
        }

        .table-hover tbody tr:hover {
            color: #00b0f0;
            background-color: rgba(0,0,0,.075);
        }

        .modal-body p {
            color: black
        }

        #exampleModalLabel {
            color: black
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88753cee6f44c1a3ba229a28ad23f2987cb7f3f7146", async() => {
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
            <div class=""member_area white"">
                <!--content-->
                <h2 class=""white"">我的評論一覽</h2>
                <button id=""buttonAdd"" class=""site-btn mt-3 mb-3"">
                    <i class=""fa fa-plus""> 撰寫評論</i>
                </button>
                <table class=""table table-hover white"">
                    <thea");
                WriteLiteral(@"d>
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
                            <th scope=""row""");
                BeginWriteAttribute("class", " class=\"", 2767, "\"", 2775, 0);
                EndWriteAttribute();
                WriteLiteral(">1</th>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 2816, "\"", 2824, 0);
                EndWriteAttribute();
                WriteLiteral(">專題∣《幸福入場券》之外！５部茱莉亞羅勃茲主演浪漫愛情喜劇</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 2893, "\"", 2901, 0);
                EndWriteAttribute();
                WriteLiteral(">好久不見的「經典」好萊塢喜劇《幸福入場券 Ticket to Paradise》來了。之所以稱之「經典」，並不是因為它已經...</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3005, "\"", 3013, 0);
                EndWriteAttribute();
                WriteLiteral(@">2022/10/02</td>
                            <td>
                                <button type=""button"" class=""btn btn-link"">編輯</button>
                                <button type=""button"" class=""btn btn-link"" data-toggle=""modal"" data-target=""#exampleModal"">刪除</button>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row""");
                BeginWriteAttribute("class", " class=\"", 3429, "\"", 3437, 0);
                EndWriteAttribute();
                WriteLiteral(">2</th>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3478, "\"", 3486, 0);
                EndWriteAttribute();
                WriteLiteral(">專題∣必看《阿凡達》的５大理由重溫：看完再迎《阿凡達2：水之道》！</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3559, "\"", 3567, 0);
                EndWriteAttribute();
                WriteLiteral(">2009年的好萊塢電影《阿凡達》是部殿堂級電影，是大導演詹姆斯卡麥隆在《鐵達尼號》之後傾注心力所打造的鉅...</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 3662, "\"", 3670, 0);
                EndWriteAttribute();
                WriteLiteral(@">2022/09/19</td>
                            <td>
                                <button type=""button"" class=""btn btn-link"">編輯</button>
                                <button type=""button"" class=""btn btn-link"" data-toggle=""modal"" data-target=""#exampleModal"">刪除</button>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row""");
                BeginWriteAttribute("class", " class=\"", 4086, "\"", 4094, 0);
                EndWriteAttribute();
                WriteLiteral(">3</th>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 4135, "\"", 4143, 0);
                EndWriteAttribute();
                WriteLiteral(">專題∣《死侍3》影片公開：你可能錯過的５個彩蛋詳解</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 4208, "\"", 4216, 0);
                EndWriteAttribute();
                WriteLiteral(">真是萬萬沒想到！萊恩雷諾斯近期用推特公佈《死侍3》的上映日期，不僅如此，最令人驚喜的莫過於休傑克曼將以...</td>\r\n                            <td");
                BeginWriteAttribute("class", " class=\"", 4310, "\"", 4318, 0);
                EndWriteAttribute();
                WriteLiteral(@">2022/10/02</td>
                            <td>
                                <button type=""button"" class=""btn btn-link"">編輯</button>
                                <button type=""button"" class=""btn btn-link"" data-toggle=""modal"" data-target=""#exampleModal"">刪除</button>
                            </td>
                        </tr>
                        <tr id=""comment4"">
                            <th scope=""row"" class=""commentLink4"">4</th>
                            <td class=""commentLink4"">
                                不只關於速度與飛翔的渴望 也與我們的悔恨以及所需要的勇氣有關
                            </td>
                            <td class=""commentLink4"">湯姆．克魯斯的《捍衛戰士：獨行俠》在各地試映過後，隨即得到了一片熱烈好評， 並被不少人稱為一定要進戲院欣賞的超級大片...</td>
                            <td class=""commentLink4"">2022/09/23</td>
                            <td>
                                <button type=""button"" class=""btn btn-link"">編輯</button>
                                <button type=""button"" class=""btn btn-link"" data-toggle=""modal"" dat");
                WriteLiteral(@"a-target=""#exampleModal"">刪除</button>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <!--end content-->
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">刪除評論</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>確定要刪除嗎?</p>
                    <p class=""font-italic"">注意: 此動作無法復原</p>
                </div>
                <div class=""moda");
                WriteLiteral(@"l-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">取消</button>
                    <button type=""button"" class=""btn btn-danger"">確定刪除</button>
                </div>
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
            WriteLiteral("\r\n\r\n<script>\r\n    const com = document.querySelectorAll(\".commentLink4\")\r\n\r\n    com.forEach(c=>c.addEventListener(\"click\", () => {\r\n        console.log(\"check\")\r\n        window.location.assign(\'");
#nullable restore
#line 144 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                           Write(Url.Content("~/comment/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'+encodeURI(\"會員評論\"))\r\n    }))\r\n</script>\r\n\r\n<script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script>");
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
