#pragma checksum "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7aaa7c5d85c67f63a17e5a14c9fb7178cfaf81e"
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
#line 1 "C:\MDA前端1101\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前端1101\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7aaa7c5d85c67f63a17e5a14c9fb7178cfaf81e", @"/Views/Member/WatchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_WatchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CMovieListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/WatchList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
  
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
#line 15 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
  
    ViewData["Title"] = "WatchList";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7aaa7c5d85c67f63a17e5a14c9fb7178cfaf81e5297", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7aaa7c5d85c67f63a17e5a14c9fb7178cfaf81e6475", async() => {
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
#line 53 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
          
            if (mem.暱稱nickName != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"member_id_name\">");
#nullable restore
#line 56 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                        Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 57 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n        <div class=\"member_menu\">\r\n");
#nullable restore
#line 62 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
              
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
#line 68 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
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
#line 74 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a id=\"orderlist\" href=\"../Member/orderlist\" title=\"訂單查詢\" class=\"member_link\">訂單查詢</a>\r\n");
            WriteLiteral(@"            <a id=""memberdiscount"" href=""../Member/memberdiscount"" title=""我的抵用券"" class=""member_link"">我的抵用券</a>

            <a id=""memberpassword"" href=""../Member/PasswordEdit"" title=""密碼修改"" class=""member_link"">密碼修改</a>
            <a id=""MemberEdit"" href=""../Member/MemberEdit"" title=""資料修改"" class=""member_link "">資料修改</a>
            <a href=""../Member/logout"" class=""member_link"" title=""登出"">登出</a>
        </div>
        <div class=""member_main"" style=""color:white"">
            <div class=""member_area "">
                <!--content-->

                <h2>
                    我的片單
                    <!-- Button trigger modal -->
                    <button type=""button"" class=""btn btn-link add"" data-toggle=""modal"" data-target=""#AddModalCenter"">
                        <i class=""fas fa-plus-square""></i>
                    </button>
                </h2>
                <!-- Modal -->
                <div class=""modal fade"" id=""AddModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""example");
            WriteLiteral("ModalCenterTitle\" aria-hidden=\"true\">\r\n                    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n");
#nullable restore
#line 98 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                         using (Html.BeginForm("WatchListCreate", "Member"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalLongTitle"" style=""color:black"">我的所有片單</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    <!--modal content start-->

                                    <table id=""WatchList"" class=""table table-bordered"">
                                        <thead>
                                            <tr>
                                                <th>片單</th>
                                                <th>移除</th>
                                            </tr>
                    ");
            WriteLiteral("                    </thead>\r\n                                        <tbody id=\"tableLists\">\r\n");
#nullable restore
#line 118 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                              
                                                foreach (CMovieListViewModel list in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            <input type=\"hidden\" class=\"id\" name=\"listId\"");
            BeginWriteAttribute("value", " value=\"", 5467, "\"", 5487, 1);
#nullable restore
#line 123 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 5475, list.listId, 5475, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                            <input type=\"text\" class=\"form-control name\" name=\"listName\"");
            BeginWriteAttribute("value", " value=\"", 5613, "\"", 5635, 1);
#nullable restore
#line 124 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 5621, list.listName, 5621, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                        </td>
                                                        <td><button type=""button"" onclick=""deleteRow(event)"" class=""btn btn-danger btn-sm delList""><i class=""fas fa-trash-alt""></i></button></td>
                                                    </tr>
");
#nullable restore
#line 128 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                    <input type=""text"" class=""form-control"" id=""inputListName"" name=""listName""
                                           placeholder=""我的片單"">
                                    <button type=""button"" id=""btnAddList"" class=""site-btn btn-sm mt-3"">
                                        <i class=""fa fa-plus"">新增</i>
                                    </button>
                                    <small id=""duplicate"" style=""color:darkgray""></small>
                                    <!--modal content end-->
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">取消</button>
                                    <button type=""button"" class=""btn btn-primary"" id=""submitAddList"">確定</button>
                                </div>
   ");
            WriteLiteral("                         </div>\r\n");
#nullable restore
#line 146 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!--modal end-->\r\n\r\n");
#nullable restore
#line 151 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                  
                    foreach (CMovieListViewModel list in Model)
                    {
                        string modalName = "Edit" + list.listId;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"content\">\r\n                                    <div class=\"card-title\">\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 158 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                       Write(list.listName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"listId\"");
            BeginWriteAttribute("value", " value=\"", 7700, "\"", 7720, 1);
#nullable restore
#line 159 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 7708, list.listId, 7708, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <button class=\"btn btn-link btn-sm edit\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 160 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                                                                                                  Write(modalName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                <i class=""fa fa-pencil-square-o""></i>
                                            </button>
                                        </p>
                                    </div>
                                    <div class=""swiper-container"">
                                        <div class=""swiper-wrapper"">
");
#nullable restore
#line 167 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                              
                                                foreach (var movie in list.myLists)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"swiper-slide\"");
            BeginWriteAttribute("style", "\r\n                                                         style=\"", 8490, "\"", 8596, 4);
            WriteAttributeValue("", 8556, "background-image:", 8556, 17, true);
            WriteAttributeValue(" ", 8573, "url(\'", 8574, 6, true);
#nullable restore
#line 171 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 8579, movie.moviePic, 8579, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8594, "\')", 8594, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\'", 8660, "\'", 8715, 1);
#nullable restore
#line 173 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 8667, Url.Content($"~/movie/電影介紹?id={movie.movieId}"), 8667, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <p class=\"movie-card\">");
#nullable restore
#line 174 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                                                             Write(movie.movieTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        </a>\r\n                                                    </div>\r\n");
#nullable restore
#line 177 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    <div style=\"clear:both;\"></div>\r\n                                </div>\r\n");
            WriteLiteral("                        <!--edit modal-->\r\n                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 9341, "\"", 9356, 1);
#nullable restore
#line 187 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 9346, modalName, 9346, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n                            <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n");
#nullable restore
#line 189 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                 using (Html.BeginForm("MyWatchListEdit", "Member"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"modal-content\">\r\n                                        <div class=\"modal-header\">\r\n                                            <input type=\"hidden\" name=\"listId\" class=\"listId_forEdit\" id=\"listId_forEdit\"");
            BeginWriteAttribute("value", " value=\"", 9918, "\"", 9938, 1);
#nullable restore
#line 193 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 9926, list.listId, 9926, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <h5 class=\"modal-title\" id=\"exampleModalLongTitle\" style=\"color:black\">");
#nullable restore
#line 194 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                                                                                              Write(list.listName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>
                                        <div class=""modal-body"">
                                            <!--modal content start-->

                                            <table id=""MovieList"" class=""table table-bordered"">
                                                <thead>
                                                    <tr>
                                                        <th>電影</th>
                                                        <th>移除</th>
                                                    </tr>
                                                </thead>
                                                <tbody class=""tableMovies"">
");
#nullable restore
#line 210 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                                      
                                                        foreach (var movie in list.myLists)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                <td>\r\n                                                                    <input type=\"hidden\" class=\"listId\" name=\"listId\"");
            BeginWriteAttribute("value", " value=\"", 11539, "\"", 11560, 1);
#nullable restore
#line 215 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 11547, movie.listId, 11547, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                                    <input type=\"hidden\" class=\"mylistId\" name=\"mylistId\"");
            BeginWriteAttribute("value", " value=\"", 11687, "\"", 11715, 1);
#nullable restore
#line 216 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 11695, movie.myMovieListId, 11695, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                                    <input type=\"hidden\" class=\"movieId\" name=\"movieId\"");
            BeginWriteAttribute("value", " value=\"", 11840, "\"", 11862, 1);
#nullable restore
#line 217 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 11848, movie.movieId, 11848, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                                    <input type=\"text\" class=\"form-control movieName\"");
            BeginWriteAttribute("name", " name=\"", 11985, "\"", 11992, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 11993, "\"", 12018, 1);
#nullable restore
#line 218 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
WriteAttributeValue("", 12001, movie.movieTitle, 12001, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                                </td>
                                                                <td><button type=""button"" onclick=""deleteRow(event)"" class=""btn btn-danger btn-sm delMovie""><i class=""fas fa-trash-alt""></i></button></td>
                                                            </tr>
");
#nullable restore
#line 222 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </tbody>
                                            </table>
                                            <input type=""text"" list=""typelist"" class=""form-control inputMovie"" id=""inputMovie"" name=""movieName"" placeholder=""電影名稱"">
                                            <datalist id=""typelist"" class=""typelist""></datalist>
                                            <button type=""button"" id=""btnAddMovie"" class=""site-btn btn-sm mt-3 btnAddMovie"">
                                                <i class=""fa fa-plus"">新增</i>
                                            </button>
                                            <small id=""duplicateMovie"" class=""duplicateMovie"" style=""color:darkgray""></small>
                                            <!--modal content end-->
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""bt");
            WriteLiteral(@"n btn-secondary"" data-dismiss=""modal"">取消</button>
                                            <button type=""button"" class=""btn btn-primary submitAddMovie"" id=""submitAddMovie"">確定</button>
                                        </div>
                                    </div>
");
#nullable restore
#line 240 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <!--edit modal end-->\r\n");
#nullable restore
#line 244 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--end content-->\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>

    <script>
        const inputName = document.querySelector(""#inputListName"")
        const btnAddList = document.querySelector(""#btnAddList"")
        const duplicate = document.querySelector(""#duplicate"")
        const tableLists = document.querySelector(""#tableLists"")

        btnAddList.addEventListener(""click"", async () => {

            const url = """);
#nullable restore
#line 265 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                    Write(Url.Content("~/member/checkWatchList"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
            const params = `?name=${inputName.value}`
            let response = await fetch(url + params)  //resolve->response, reject
            let data = await response.text()
            if (inputName.value == """") {
                duplicate.textContent = ""不可空白""
            }
            else if (data == 'True') {
                duplicate.textContent = ""片單名稱重複""
            }
            else {
                duplicate.textContent = """"

                var tr = document.createElement('tr');
                tr.innerHTML = `
<td>
<input type=""hidden"" class=""id"" name=""listId"" value="""" />
<input type=""text"" class=""form-control name"" name=""listName"" value=""${inputName.value}""/>
</td>
<td><button type=""button"" onclick=""deleteRow(event)"" class=""btn btn-danger btn-sm delList""><i class=""fas fa-trash-alt""></i></button></td>
                `
                tableLists.appendChild(tr);

            }
        })



        const submitAddList = document.querySelector(""#submitAddList"")");
                WriteLiteral(@"
        submitAddList.addEventListener(""click"", async () => {
            var ids = document.querySelectorAll('.id')
            var names = document.querySelectorAll('.name')
            for (let i = 0; i < ids.length; i++) {
                ids[i].setAttribute('name',`ls[${i}].listId`)
            }
            for (let i = 0; i < names.length; i++) {
                names[i].setAttribute('name', `ls[${i}].listName`)
            }
            await submitAddList.setAttribute('type', 'submit')
        })


    </script>
    <script>
        function deleteRow(event) {
            event.target.closest('tr').remove();
        }
    </script>
    <script>
    const inputMovie = document.querySelectorAll("".inputMovie"")
    const btnAddMovie = document.querySelectorAll("".btnAddMovie"")
    const duplicateMovie = document.querySelectorAll("".duplicateMovie"")
    const tableMovies = document.querySelectorAll("".tableMovies"")

        btnAddMovie.forEach(item => {
            item.addEventLi");
                WriteLiteral(@"stener(""click"", addtargetmovie)
        })

        function addtargetmovie(event) {
            //console.log(this)
            console.log(this.closest('div'))
            console.log(this.closest('div').querySelector('.inputMovie'))
            console.log(this.closest('div').querySelector('.duplicateMovie'))
            console.log(this.closest('div').querySelector('.tableMovies'))
            if (this.closest('div').querySelector('.inputMovie').value == """") {
                this.closest('div').querySelector('.duplicateMovie').textContent = ""不可空白""
            }
            else {
                this.closest('div').querySelector('.duplicateMovie').textContent = """"

                var tr = document.createElement('tr');
                tr.innerHTML = `
                                                        <td>
                                                            <input type=""hidden"" class=""listId"" name=""listId"" value=""${this.closest('form').querySelector('.listId_forEdit').value");
                WriteLiteral(@"}"" />
                                                            <input type=""hidden"" class=""mylistId"" name=""mylistId"" value="""" />
                                                            <input type=""hidden"" class=""movieId"" name=""movieId"" value="""" />
                                                            <input type=""text"" class=""form-control movieName"" name=""movieName"" value=""${this.closest('div').querySelector('.inputMovie').value}"">
                                                        </td>
                                                        <td><button type=""button"" onclick=""deleteRow(event)"" class=""btn btn-danger btn-sm delMovie""><i class=""fas fa-trash-alt""></i></button></td>
                `
                this.closest('div').querySelector('.tableMovies').appendChild(tr);
            }
        }


        const submitAddMovie = document.querySelectorAll("".submitAddMovie"")
        submitAddMovie.forEach(item => {
            item.addEventListener(""click"", addIndex)
     ");
                WriteLiteral(@"   })
        function addIndex(event) {
            var movieids = this.closest('form').querySelectorAll('.movieId')
            var listids = this.closest('form').querySelectorAll('.listId')
            var mylistids = this.closest('form').querySelectorAll('.mylistId')
            var movieName = this.closest('form').querySelectorAll('.movieName')

            for (let i = 0; i < movieids.length; i++) {
                movieids[i].setAttribute('name', `mv[${i}].movieId`)
                listids[i].setAttribute('name', `mv[${i}].listId`)
                mylistids[i].setAttribute('name', `mv[${i}].mylistId`)
                movieName[i].setAttribute('name', `mv[${i}].movieName`)
            }

            this.setAttribute('type', 'submit')
        }



        const listData = document.querySelectorAll("".typelist"")

        listData.forEach(item => {
            item.style.display=""none""
        })

        inputMovie.forEach(item => {

            item.addEventListener(""input"", as");
                WriteLiteral("ync () => {\r\n                let keyword = item.value\r\n                let results = await fetch(\"");
#nullable restore
#line 382 "C:\MDA前端1101\ClientMDA\Views\Member\WatchList.cshtml"
                                      Write(Url.Content("~/Member/autoCmpMovie"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?movie=${keyword}`)
                let datas = await results.json()
                //console.log(datas)
                let htmlDatas = datas.map(data => {
                    return (
                        `
                <option onclick=""read(event)"">${data}</option>
                `)
                })
                listData.forEach(item => { item.innerHTML = htmlDatas.join("""") })
            })
        })


        function read(evt) {
            this.closest('input').value = evt.target.textContent
        }




    </script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CMovieListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
