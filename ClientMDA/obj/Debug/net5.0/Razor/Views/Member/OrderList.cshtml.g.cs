#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ccb4f339c13d6ee56341113f674227f6487b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_OrderList), @"mvc.1.0.view", @"/Views/Member/OrderList.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ccb4f339c13d6ee56341113f674227f6487b7f", @"/Views/Member/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 4 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
  
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
#line 13 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94ccb4f339c13d6ee56341113f674227f6487b7f5023", async() => {
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
                WriteLiteral("\r\n    <style>\r\n        .control-label {\r\n            color: white;\r\n        }\r\n\r\n        .white {\r\n            color: white;\r\n            text-align: center\r\n        }\r\n\r\n        .content {\r\n            margin: 0 auto;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<div class=\"member_id\">\r\n    <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 36 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 39 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 40 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 46 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
          
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
#line 52 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
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
#line 58 "C:\Users\Student\Documents\MSIT143.ClientMDA1026\ClientMDA\Views\Member\OrderList.cshtml"
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
            <h2 class=""white text-left"">訂單查詢</h2>

            <table class=""table white"">
                <thead>
                    <tr>
                        <th scope=""col"">序</th>
                        <th scope=""col"">日期</th>
                        <th scope=""col"">訂單編號</th>
                        <th sc");
            WriteLiteral(@"ope=""col"">訂單狀態</th>
                        <th scope=""col"">總金額</th>
                        <th scope=""col"">客服紀錄</th>
                    </tr>
                </thead>
                <tbody class=""white"">
                    <tr>
                        <th scope=""row""");
            BeginWriteAttribute("class", " class=\"", 3125, "\"", 3133, 0);
            EndWriteAttribute();
            WriteLiteral(">1</th>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3170, "\"", 3178, 0);
            EndWriteAttribute();
            WriteLiteral(">2022-09-23</td>\r\n                        <td class=\"orderId\" id=\"orderId\"><a>220923000007</a></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3307, "\"", 3315, 0);
            EndWriteAttribute();
            WriteLiteral(">未付款</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3354, "\"", 3362, 0);
            EndWriteAttribute();
            WriteLiteral(">500</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3401, "\"", 3409, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3510, "\"", 3518, 0);
            EndWriteAttribute();
            WriteLiteral(">2</th>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3555, "\"", 3563, 0);
            EndWriteAttribute();
            WriteLiteral(">2021-10-30</td>\r\n                        <td class=\"orderId\" id=\"orderId\"><a>211030000070</a></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3692, "\"", 3700, 0);
            EndWriteAttribute();
            WriteLiteral(">已完成</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3739, "\"", 3747, 0);
            EndWriteAttribute();
            WriteLiteral(">310</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3786, "\"", 3794, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3895, "\"", 3903, 0);
            EndWriteAttribute();
            WriteLiteral(">3</th>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3940, "\"", 3948, 0);
            EndWriteAttribute();
            WriteLiteral(">2020-04-06</td>\r\n                        <td class=\"orderId\" id=\"orderId\"><a>200406000162</a></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 4077, "\"", 4085, 0);
            EndWriteAttribute();
            WriteLiteral(">已取消</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 4124, "\"", 4132, 0);
            EndWriteAttribute();
            WriteLiteral(">630</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 4171, "\"", 4179, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script>\r\n");
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
