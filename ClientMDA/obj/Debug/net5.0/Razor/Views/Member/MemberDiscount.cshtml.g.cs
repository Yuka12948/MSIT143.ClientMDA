#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf28c35fdce5fcd81612ce0e830b21ccefacf65c"
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
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf28c35fdce5fcd81612ce0e830b21ccefacf65c", @"/Views/Member/MemberDiscount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_MemberDiscount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CCouponListViewModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
  
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
#line 17 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
  
    ViewData["Title"] = "MemberDiscount";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf28c35fdce5fcd81612ce0e830b21ccefacf65c5298", async() => {
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

        .used {
            color: lightgray
        }

        .overdue {
            color: lightgray
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n<div class=\"member_id\">\r\n    <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 52 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 55 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 62 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
          
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
#line 68 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
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
#line 74 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
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
        <div class=""member_area"">
            <!--content-->
            <h2 class=""white text-left"">我的抵用券</h2>
            <div class=""mb-2 mt-2"">
                <strong class=""white"">可用紅利金餘額: ");
#nullable restore
#line 90 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                          Write(mem.紅利點數bonus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n            <div class=\"mb-4\">\r\n");
#nullable restore
#line 93 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                 using (Html.BeginForm("AddCoupon", "Member"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
               Write(Html.TextBox("txtKeyword", null, new { @placeholder = "輸入優惠代碼" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"submit\" class=\"site-btn mt-3 mb-3\"><i class=\"fa fa-plus\"> 新增優惠</i></button>\r\n");
#nullable restore
#line 97 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <table class=""table white"">
                <thead>
                    <tr>
                        <th scope=""col"">折扣金額</th>
                        <th scope=""col"">抵用券內容</th>
                        <th scope=""col"">使用期限</th>
                        <th scope=""col"">使用狀況</th>
                    </tr>
                </thead>
                <tbody class=""white"">
");
#nullable restore
#line 111 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                      

                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3896, "\"", 3904, 0);
            EndWriteAttribute();
            WriteLiteral(">$");
#nullable restore
#line 116 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                                     Write(decimal.Round(item.diccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3978, "\"", 3986, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 117 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                        Write(item.couponName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4046, "\"", 4054, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 119 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                               Write(item.dueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 121 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                  
                                    if (item.dueDate < DateTime.Now)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"overdue\">已過期</td>\r\n");
#nullable restore
#line 125 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                    }
                                    else if (item.used == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"used\">已使用</td>\r\n");
#nullable restore
#line 129 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"available\">未使用</td>\r\n");
#nullable restore
#line 133 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tr>\r\n");
#nullable restore
#line 137 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberDiscount.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                </tbody>\r\n            </table>\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CCouponListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
