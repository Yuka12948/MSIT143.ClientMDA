#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67bccac12cda20086f3cd792dba7f87ce3c5399b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_WatchList), @"mvc.1.0.view", @"/Views/Member/WatchList.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bccac12cda20086f3cd792dba7f87ce3c5399b", @"/Views/Member/WatchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_WatchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/WatchList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/MemberMain.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/modal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/comment/電影評論"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
  
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
#line 13 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
  
    ViewData["Title"] = "WatchList";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67bccac12cda20086f3cd792dba7f87ce3c5399b6097", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67bccac12cda20086f3cd792dba7f87ce3c5399b7275", async() => {
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
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css"" integrity=""sha512-xh6O/CkQoPOWDdYTDqeRdPCVd1SpvCA9XXcUnZS2FmJNp1coAFzvtCN9BmamE+4aHK8yyUHUSCcJHgXloTyT2A=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67bccac12cda20086f3cd792dba7f87ce3c5399b8737", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        .content {
            width: 80%;
            margin: 0 auto;
        }

        .member_area {
            color: white;
        }

        .white {
            color: white;
            /*text-align: center*/
        }

        .btn-cancel {
            background-color: #6c757d;
        }
    </style>

");
            }
            );
            WriteLiteral("\r\n<div class=\"white\">\r\n    <div class=\"member_id\">\r\n        <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 51 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
          
            if (mem.暱稱nickName != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"member_id_name\">");
#nullable restore
#line 54 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
                                        Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n        <div class=\"member_menu\">\r\n");
#nullable restore
#line 60 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
              
                if (mem.正式會員formal == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <a id=""watchlist"" href=""../Member/WatchList"" title=""我的片單"" class=""member_link"">我的片單</a>
                    <a id=""commentList"" href=""../Member/CommentList"" title=""我的評論"" class=""member_link"">我的評論</a>
                    <a id=""wishlist"" href=""../Member/wishlist"" title=""收藏清單"" class=""member_link"">收藏清單</a>
");
#nullable restore
#line 66 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <a id=""watchlist"" href=""../Member/NotFormal"" title=""我的片單"" class=""member_link"">我的片單</a>
                    <a id=""commentList"" href=""../Member/NotFormal"" title=""我的評論"" class=""member_link"">我的評論</a>
                    <a id=""wishlist"" href=""../Member/NotFormal"" title=""收藏清單"" class=""member_link"">收藏清單</a>
");
#nullable restore
#line 72 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Member\WatchList.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a id=""orderlist"" href=""../Member/orderlist"" title=""訂單查詢"" class=""member_link"">訂單查詢</a>
            <a id=""memberbonuslist"" href=""../Member/memberbonuslist"" title=""我的紅利金"" class=""member_link"">我的紅利金</a>
            <a id=""memberdiscount"" href=""../Member/memberdiscount"" title=""我的抵用券"" class=""member_link"">我的抵用券</a>

            <a id=""memberpassword"" href=""../Member/PasswordEdit"" title=""密碼修改"" class=""member_link"">密碼修改</a>
            <a id=""MemberEdit"" href=""../Member/MemberEdit"" title=""資料修改"" class=""member_link "">資料修改</a>
            <a href=""../Member/logout"" class=""member_link"" title=""登出"">登出</a>
        </div>
        <div class=""member_main"" style=""color:white"">
            <div class=""member_area "">
                <!--content-->
                <h2>
                    我的片單
                    <button id=""buttonAdd"" class=""btn btn-link add"" data-modal-target=""#modal"">
                        <i class=""fas fa-plus-square""></i>
                    </button>
                </h2>
     ");
            WriteLiteral(@"           <div class=""content"">
                    <div class=""card-title"">
                        <p>
                            MyWatchList-哈利波特
                            <button id=""buttonEdit"" class=""btn btn-link btn-sm edit"" data-modal-target=""#editModal"">
                                <i class=""fa fa-pencil-square-o""></i>
                            </button>
                        </p>
                    </div>
                    <div class=""swiper-container"">
                        <div class=""swiper-wrapper"">

                            <div class=""swiper-slide""");
            BeginWriteAttribute("style", "\r\n                                 style=\"", 4081, "\"", 4287, 3);
            WriteAttributeValue("", 4123, "background-image:", 4123, 17, true);
            WriteAttributeValue(" ", 4140, "url(\'https://m.media-amazon.com/images/M/MV5BMzkyZGFlOWQtZjFlMi00N2YwLWE2OWQtYTgxY2NkNmM1NjMwXkEyXkFqcGdeQXVyNjY1NTM1MzA", 4141, 121, true);
            WriteLiteral("@");
            WriteAttributeValue("", 4263, "._V1_FMjpg_UX1000_.jpg\')", 4263, 24, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">哈利波特：神秘的魔法石</p>
                                </a>
                            </div>
                            <div class=""swiper-slide""
                                 style=""background-image: url('https://m.media-amazon.com/images/M/MV5BMjE0YjUzNDUtMjc5OS00MTU3LTgxMmUtODhkOThkMzdjNWI4XkEyXkFqcGdeQXVyMTA3MzQ4MTc0._V1_FMjpg_UX834_.jpg')"">
");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">哈利波特：消失的密室</p>
                                </a>
                            </div>
                            <div class=""swiper-slide""
                                 style=""background-image: url('https://www.miranewcinemas.com/miramarimaxauro/imax/images/upload/movie/201312121120071.jpg') "">
");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">哈利波特：火盃的考驗</p>
                                </a>
                            </div>
                            <div class=""swiper-slide""
                                 style=""background-image: url('https://m.media-amazon.com/images/M/MV5BMTM0NTczMTUzOV5BMl5BanBnXkFtZTYwMzIxNTg3._V1_FMjpg_UX450_.jpg')"">
");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">哈利波特：鳳凰會的密令</p>
                                </a>
                            </div>
                            <div class=""swiper-slide""");
            BeginWriteAttribute("style", "\r\n                                 style=\"", 7084, "\"", 7277, 3);
            WriteAttributeValue("", 7126, "background-image:", 7126, 17, true);
            WriteAttributeValue(" ", 7143, "url(\'https://m.media-amazon.com/images/M/MV5BMGVmMWNiMDktYjQ0Mi00MWIxLTk0N2UtN2ZlYTdkN2IzNDNlXkEyXkFqcGdeQXVyODE5NzE3OTE", 7144, 121, true);
            WriteLiteral("@");
            WriteAttributeValue("", 7266, "._V1_.jpg\')", 7266, 11, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">哈利波特：死神的聖物2</p>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div style=""clear:both;""></div>

                    <div class=""card-title"">
                        <p>
                            周末片單
                            <button id=""buttonEdit"" class=""btn btn-link btn-sm edit"" data-modal-target=""#editModal"">
                                <i class=""fa fa-pencil-square-o""></i>
                            </button>
                        </p>
                    </div>
                    <div class=""swiper-container"">
                        <div class=""swiper-wrapper"">

                            <div class=""swiper-slide""
                                 style=""background-image: url('https://www.sonypictures.com/sites/default/files/styles/max_560x840/public/title-key-");
            WriteLiteral("art/bullettrain_onesheet_1400x2100_v4.jpg?itok=khOUNLFM\') \">\r\n");
            WriteLiteral("                                <a href=\"/vod/3795\">\r\n                                    <p class=\"movie-card\">子彈列車</p>\r\n                                </a>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67bccac12cda20086f3cd792dba7f87ce3c5399b18853", async() => {
                WriteLiteral("\r\n                                <div class=\"swiper-slide\"");
                BeginWriteAttribute("style", "\r\n                                     style=\"", 9289, "\"", 9487, 4);
                WriteAttributeValue("", 9335, "background-image:", 9335, 17, true);
                WriteAttributeValue(" ", 9352, "url(\'https://m.media-amazon.com/images/M/MV5BZWYzOGEwNTgtNWU3NS00ZTQ0LWJkODUtMmVhMjIwMjA1ZmQwXkEyXkFqcGdeQXVyMjkwOTAyMDU", 9353, 121, true);
                WriteLiteral("@");
                WriteAttributeValue("", 9475, "._V1_.jpg\')", 9475, 11, true);
                WriteAttributeValue(" ", 9486, "", 9487, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("\r\n                                    <p class=\"movie-card\">捍衛戰士：獨行俠</p>\r\n\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div style=""clear:both;""></div>

                    <div class=""card-title"">
                        <p>
                            魔戒
                            <button id=""buttonEdit"" class=""btn btn-link btn-sm edit"" data-modal-target=""#editModal"">
                                <i class=""fa fa-pencil-square-o""></i>
                            </button>
                        </p>
                    </div>
                    <div class=""swiper-container"">
                        <div class=""swiper-wrapper"">

                            <div class=""swiper-slide""
                                 style=""background-image: url('https://upload.wikimedia.org/wikipedia/zh/7/74/LOTRFOTRmovie.jpg')"">
");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">魔戒首部曲：魔戒現身</p>
                                </a>
                            </div>
                            <div class=""swiper-slide""
                                 style=""background-image: url('https://upload.wikimedia.org/wikipedia/zh/2/2a/LOTRTTTmovie.jpg')"">
");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">魔戒二部曲：雙城奇謀</p>
                                </a>
                            </div>
                            <div class=""swiper-slide""
                                 style=""background-image: url('https://upload.wikimedia.org/wikipedia/zh/e/e3/The_Lord_of_the_Rings_-_The_Return_of_the_King_poster.jpg')"">
");
            WriteLiteral(@"                                <a href=""/vod/3795"">
                                    <p class=""movie-card"">魔戒三部曲：王者再臨</p>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div style=""clear:both;""></div>
                    <!--end content-->
                </div>
            </div>
        </div>
    </div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
            const add = document.querySelector(""#buttonAdd"")
            function showModal1(titleHtml, contentHtml, buttons) {
                const modal = document.createElement(""div"");

                modal.classList.add(""modal"");
                modal.innerHTML = `
                                                                    <div class=""modal__inner"">
                                                                        <div class=""modal__top"">
                                                                            <div class=""modal__title"">${titleHtml}</div>
                                                                            <button class=""modal__close"" type=""button"">
                                                                                <span class=""material-icons""><i class=""fa fa-times"" aria-hidden=""true""></i></span>
                                                                            </button>
                                      ");
                WriteLiteral(@"                                  </div>
                                                                        <div class=""modal__content"">${contentHtml}</div>
                                                                        <div class=""modal__bottom""></div>
                                                                    </div>
                                                                `;

                for (const button of buttons) {
                    const element = document.createElement(""button"");
                    element.setAttribute(""type"", ""button"");
                    element.classList.add(""modal__button"");
                    if (button.triggerClose) {
                        element.classList.add(""btn-secondary"");
                    }
                    else { element.classList.add(""site-btn""); }
                    element.textContent = button.label;
                    element.addEventListener(""click"", () => {
                        if (button.triggerCl");
                WriteLiteral(@"ose) {
                            document.body.removeChild(modal);
                        }
                    });
                    modal.querySelector("".modal__bottom"").appendChild(element);
                }

                modal.querySelector("".modal__close"").addEventListener(""click"", () => {
                    document.body.removeChild(modal);
                });

                document.body.appendChild(modal);
            }

            const cont1 = `
                                                                        <input type=""hidden"" name=""WatchListID"" id=""WatchListID"">
                                                                                    <div class=""form-group"">
                                                                                        <label for=""WatchListName"" style=""color:black"">我的所有片單</label>
                                                                                    </div>
                                                    ");
                WriteLiteral(@"                                <table id=""WatchList"" class=""table table-bordered"">
                                                                                        <thead>
                                                                                            <tr>
                                                                                                <th>序</th>
                                                                                                <th>片單</th>
                                                                                                <th>移除</th>
                                                                                            </tr>
                                                                                        </thead>
                                                                                        <tbody>
                                                                                            <tr>
                          ");
                WriteLiteral(@"                                                                      <td>1</td>
                                                                                                <td>
                                                                                                    <input type=""text"" class=""form-control"" id=""WatchListName"" name=""WatchListName"" value=""MyWatchList-哈利波特"">
                                                                                                </td>
                                                                                                <td><button type=""button"" class=""btn btn-danger btn-sm""><i class=""fas fa-trash-alt""></i></button></td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td>2</td>
                         ");
                WriteLiteral(@"                                                                       <td>
                                                                                                    <input type=""text"" class=""form-control"" id=""WatchListName"" name=""WatchListName"" value=""周末片單"">
                                                                                                </td>
                                                                                                <td><button type=""button"" class=""btn btn-danger btn-sm""><i class=""fas fa-trash-alt""></i></button></td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td>3</td>
                                                                                                <td>
                                          ");
                WriteLiteral(@"                                                          <input type=""text"" class=""form-control"" id=""WatchListName"" name=""WatchListName"" value=""魔戒"">
                                                                                                </td>
                                                                                                <td><button type=""button"" class=""btn btn-danger btn-sm""><i class=""fas fa-trash-alt""></i></button></td>
                                                                                            </tr>
                                                                                        </tbody>
                                                                                    </table>
                                                                                    <input type=""text"" class=""form-control"" id=""WatchListName"" name=""WatchListName""
                                                                                           placeholder=""我的片單"">
  ");
                WriteLiteral(@"                                                                                  <button type=""button"" id=""buttonAdd"" class=""site-btn btn-sm mt-3"">
                                                                                        <i class=""fa fa-plus"">新增</i>
                                                                                    </button>
                                                                    `

            add.addEventListener('click', () => {
                showModal1(""修改我的片單"", cont1, [
                    {
                        label: ""取消"",
                        triggerClose: true
                    },
                    {
                        label: ""確認修改"",
                        triggerClose: false
                    }
                ])
            })
        </script>

        <script>
            const edits = document.querySelectorAll("".edit"")
            function showModal2(titleHtml, contentHtml, buttons) {
                const mod");
                WriteLiteral(@"al = document.createElement(""div"");
                modal.classList.add(""modal"");
                modal.classList.add(""editModal"");
                modal.innerHTML = `
                                                                    <div class=""modal__inner"">
                                                                        <div class=""modal__top"">
                                                                            <div class=""modal__title"">${titleHtml}</div>
                                                                            <button class=""modal__close"" type=""button"">
                                                                                <span class=""material-icons""><i class=""fa fa-times"" aria-hidden=""true""></i></span>
                                                                            </button>
                                                                        </div>
                                                                        <div class=""");
                WriteLiteral(@"modal__content"">${contentHtml}</div>
                                                                        <div class=""modal__bottom""></div>
                                                                    </div>
                                                                `;

                for (const button of buttons) {
                    const element = document.createElement(""button"");
                    element.setAttribute(""type"", ""button"");

                    if (button.triggerClose) {
                        element.classList.add(""btn-secondary"");
                    }
                    else { element.classList.add(""site-btn""); }
                    element.classList.add(""modal__button"");
                    element.textContent = button.label;
                    element.addEventListener(""click"", () => {
                        if (button.triggerClose) {
                            document.body.removeChild(modal);
                        }
                    });
 ");
                WriteLiteral(@"                   modal.querySelector("".modal__bottom"").appendChild(element);
                }
                modal.querySelector("".modal__close"").addEventListener(""click"", () => {
                    document.body.removeChild(modal);
                });
                document.body.appendChild(modal);
            }

            const cont2 = `
                                                                        <form id = ""editForm"">
                                                                            <input type=""hidden"" name=""WatchListID"" id=""WatchListID"">
                                                                                <div class=""form-group"">
                                                                                    <label for=""WatchListName"" style=""color:black"">片單名稱</label>
                                                                                    <input type=""text"" class=""form-control"" id=""WatchListName"" name=""WatchListName""
                 ");
                WriteLiteral(@"                                                                       value=""周末片單"">
                                                                                    </div>
                                                                                    <table id=""WatchList"" class=""table table-bordered"">
                                                                                        <thead>
                                                                                            <tr>
                                                                                                <th>序</th>
                                                                                                <th>片名</th>
                                                                                                <th>移除</th>
                                                                                            </tr>
                                                                                        <");
                WriteLiteral(@"/thead>
                                                                                        <tbody>
                                                                                            <tr>
                                                                                                <td>1</td>
                                                                                                <td>子彈列車</td>
                                                                                                <td><button type=""button"" class=""btn btn-danger btn-sm""><i class=""fas fa-trash-alt""></i></button></td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td>2</td>
                                                                                                ");
                WriteLiteral(@"<td>捍衛戰士：獨行俠</td>
                                                                                                <td><button type=""button"" class=""btn btn-danger btn-sm""><i class=""fas fa-trash-alt""></i></button></td>
                                                                                            </tr>
                                                                                        </tbody>
                                                                                    </table>
                                                                                    <input type=""text"" class=""form-control"" id=""WatchListName"" name=""WatchListName""
                                                                                        placeholder=""搜尋"">
                                                                                        <button type=""button"" id=""buttonAdd"" class=""site-btn btn-sm mt-3"">
                                                                                      ");
                WriteLiteral(@"      <i class=""fa fa-plus"">新增</i>
                                                                                        </button>
                                                                                </form>
                                                                    `

            edits.forEach(btn => btn.addEventListener('click', () => {
                showModal2(""修改我的片單"", cont2, [
                    {
                        label: ""取消"",
                        triggerClose: true
                    },
                    {
                        label: ""確定修改"",
                        triggerClose: false
                    }
                ])
            }))
        </script>
    </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
