#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "426614db24bec0520c2b95596b109a96e976496e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_WishList), @"mvc.1.0.view", @"/Views/Member/WishList.cshtml")]
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
#nullable restore
#line 1 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"426614db24bec0520c2b95596b109a96e976496e", @"/Views/Member/WishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_WishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CFollowListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/tab.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/MemberMain.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
  
    會員member mem = null;
    if (Accessor.HttpContext.Session.Keys.Contains(ClientMDA.Models.CDictionary.SK_LOGINED_USER))
    {
        var a = Accessor.HttpContext.Session.GetString(ClientMDA.Models.CDictionary.SK_LOGINED_USER);
        mem = JsonSerializer.Deserialize<會員member>(a);
    }


#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
  
    ViewData["Title"] = "WishList";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "426614db24bec0520c2b95596b109a96e976496e5556", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "426614db24bec0520c2b95596b109a96e976496e6734", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        .white {
            color: white;
            /*text-align: center*/
        }

        tbody td:hover {
            color: #00b0f0;
            /*background-color: rgba(0,0,0,.075);*/
        }

        .btn:hover {
            color: #E7008C;
        }
    </style>
");
            }
            );
            WriteLiteral("<div class=\"member_id\">\r\n    <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 40 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 43 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 44 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 49 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
          
            if (mem.正式會員formal == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a id=""watchlist"" href=""../Member/WatchList"" title=""我的片單"" class=""member_link"">我的片單</a>
                <a id=""commentList"" href=""../Member/CommentList"" title=""我的評論"" class=""member_link"">我的評論</a>
                <a id=""wishlist"" href=""../Member/wishlist"" title=""收藏清單"" class=""member_link"">收藏清單</a>
");
#nullable restore
#line 55 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a id=""watchlist"" href=""../Member/NotFormal"" title=""我的片單"" class=""member_link"">我的片單</a>
                <a id=""commentList"" href=""../Member/NotFormal"" title=""我的評論"" class=""member_link"">我的評論</a>
                <a id=""wishlist"" href=""../Member/NotFormal"" title=""收藏清單"" class=""member_link"">收藏清單</a>
");
#nullable restore
#line 61 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <a id=""orderlist"" href=""../Member/orderlist"" title=""訂單查詢"" class=""member_link"">訂單查詢</a>
        <a id=""memberbonuslist"" href=""../Member/memberbonuslist"" title=""我的紅利金"" class=""member_link"">我的紅利金</a>
        <a id=""memberdiscount"" href=""../Member/memberdiscount"" title=""我的抵用券"" class=""member_link"">我的抵用券</a>

        <a id=""memberpassword"" href=""../Member/PasswordEdit"" title=""密碼修改"" class=""member_link"">密碼修改</a>
        <a id=""MemberEdit"" href=""../Member/MemberEdit"" title=""資料修改"" class=""member_link "">資料修改</a>
        <a href=""../Member/logout"" class=""member_link"" title=""登出"">登出</a>
    </div>
    <div class=""member_main"">
        <div class=""member_area white"">
            <!--content-->
            <div class=""tab-contnet"">
                <div class=""btn-group checkout-btn"" role=""group"" id=""tabs"">
                    <a href=""#"" class=""btn active"">追蹤會員</a>
                    <a href=""#"" class=""btn"">追蹤評論</a>
                </div>

                <div id=""tab-inner""");
            BeginWriteAttribute("class", " class=\"", 3000, "\"", 3008, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <!-- 追蹤會員 -->
                    <div class=""form-content"" id=tab1>
                        <div class=""form-group"">
                            <table class=""table white"" id=""table_result"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">序</th>
                                        <th scope=""col"">會員暱稱</th>
                                        <th scope=""col"">最新發表</th>

                                    </tr>
                                </thead>
                                <tbody class=""white"">

");
#nullable restore
#line 95 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                      
                                        int count = 0;
                                        foreach (var item in Model)
                                        {
                                            if (item.targetId == 1) //會員
                                            {
                                                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr scope=\"row\">\r\n                                                    <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 4173, "\"", 4181, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 103 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                                        Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <td><a>");
#nullable restore
#line 104 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                      Write(item.followMemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                    <td>\r\n");
#nullable restore
#line 106 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                          
                                                            foreach (string s in item.comments)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a>");
#nullable restore
#line 109 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                              Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n");
#nullable restore
#line 110 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 114 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                            }

                                        }

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                

                                </tbody>
                            </table>

                        </div>

                    </div>

                    <!-- 追蹤評論 -->
                    <div class=""form-content"">
                        <div class=""form-group"">
                            <table class=""table white"" id=""table_result"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">序</th>
                                        <th scope=""col"">評論標題</th>
                                        <th scope=""col"">最新回覆</th>
                                    </tr>
                                </thead>
                                <tbody class=""white"">

");
#nullable restore
#line 142 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                      
                                        int count2 = 0;
                                        foreach (var item in Model)
                                        {
                                            if (item.targetId == 2) //評論
                                            {
                                                count2++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr scope=\"row\">\r\n\r\n                                                    <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 6352, "\"", 6360, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 151 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                                        Write(count2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <td><a>");
#nullable restore
#line 152 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                      Write(item.followComTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                    <td>\r\n");
#nullable restore
#line 154 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                          
                                                            foreach (string s in item.replies)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a>");
#nullable restore
#line 157 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                              Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n");
#nullable restore
#line 158 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 162 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\WishList.cshtml"
                                            }

                                        }

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                   

                                </tbody>
                            </table>

                        </div>
                    </div>



                </div>
            </div>
            <!--end content-->
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let tabLink = document.getElementById(""tabs"").querySelectorAll(""a"");

        let tabContents = document.getElementById(""tab-inner"").querySelectorAll('.form-content');

        window.onload = function () {

            // 啟動第一個panel
            panelDisplay(tabLink[0]);
            //點擊  tab a連結
            for (let i = 0; i < tabLink.length; i++) {
                tabLink[i].addEventListener('click', function (e) {
                    e.preventDefault();
                    panelDisplay(this);
                    // return false;
                });

            };

            function panelDisplay(activePanel) {
                // Do something...
                for (let i = 0; i < tabLink.length; i++) {

                    //設定條件tabLink ==activePanel
                    //將tablink代入for循環中並利用 if ...else 進行條件 classList.add增加class=""active"" ，就是每執行一次function的時候就進行全部tablinks增加class

                    if (tabLink[i] == activePanel) {
                        t");
                WriteLiteral(@"abLink[i].classList.add(""active"");
                        tabContents[i].style.display = ""block"";

                    } else {
                        tabLink[i].classList.remove(""active"");
                        tabContents[i].style.display = ""none"";
                    }
                }
            }

        };
    </script>

    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor Accessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CFollowListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591