#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edb64ca19da7f30841363f157bcb02005a76c483"
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
#nullable restore
#line 3 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb64ca19da7f30841363f157bcb02005a76c483", @"/Views/Member/CommentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClientMDA.Models.電影評論movieComment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/MemberMain.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/modal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
  
    ViewData["Title"] = "CommentList";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
  
    會員member mem = null;
    if (Accessor.HttpContext.Session.Keys.Contains(ClientMDA.Models.CDictionary.SK_LOGINED_USER))
    {
        var a = Accessor.HttpContext.Session.GetString(ClientMDA.Models.CDictionary.SK_LOGINED_USER);
        mem = JsonSerializer.Deserialize<會員member>(a);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edb64ca19da7f30841363f157bcb02005a76c4835449", async() => {
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

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edb64ca19da7f30841363f157bcb02005a76c4836911", async() => {
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
                WriteLiteral("\r\n    <style>\r\n        .white {\r\n            color: white;\r\n        }\r\n\r\n        .table-hover tbody tr:hover {\r\n            color: #00b0f0;\r\n            background-color: rgba(0,0,0,.075);\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"member_id\">\r\n\r\n    <span class=\"member_hello\">HELLO! </span>\r\n");
#nullable restore
#line 40 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 43 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 44 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
        }



    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 52 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
          
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
#line 58 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
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
#line 64 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
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
            <div class=""mb-4"">
");
#nullable restore
#line 84 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("關鍵字 ");
#nullable restore
#line 86 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                     Write(Html.TextBox("txtKeyword"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"submit\" value=\"查詢\" />\r\n");
#nullable restore
#line 87 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <table class=\"table table-hover white\" id=\"table_result\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">序</th>\r\n");
            WriteLiteral(@"                        <th scope=""col"">標題</th>
                        <th scope=""col"">內文</th>
                        <th scope=""col"">發布時間</th>
                        <th scope=""col"">編輯</th>
                    </tr>
                </thead>
                <tbody class=""white"">
");
#nullable restore
#line 101 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                      
                        int count = 0;
                        foreach (var comm in Model)
                        {
                            count++;
                            if (comm.評論標題commentTitle == null) { continue; }


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 4165, "\"", 4173, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 109 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                                    Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("                                <td");
            BeginWriteAttribute("class", " class=\"", 4298, "\"", 4306, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 111 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                        Write(comm.評論標題commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 112 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                   if (comm.評論內容comments.Length > 50)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td");
            BeginWriteAttribute("class", " class=\"", 4490, "\"", 4498, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 114 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                                Write(comm.評論內容comments.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</td>\r\n");
#nullable restore
#line 115 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td");
            BeginWriteAttribute("class", " class=\"", 4708, "\"", 4716, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                                Write(comm.評論內容comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 119 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                    }

                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td");
            BeginWriteAttribute("class", " class=\"", 4854, "\"", 4862, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 122 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                                        Write(comm.發佈時間commentTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 124 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                               Write(Html.ActionLink("編輯", "CommentEdit", new { id = comm.評論編號commentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                    ");
#nullable restore
#line 125 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"
                               Write(Html.ActionLink("刪除", "Delete", "Product", new { id = comm.評論編號commentId }, new { onclick = "return confirm('確定刪除')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 128 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\CommentList.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n                </tbody>\r\n            </table>\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n  \r\n\r\n\r\n\r\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClientMDA.Models.電影評論movieComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
