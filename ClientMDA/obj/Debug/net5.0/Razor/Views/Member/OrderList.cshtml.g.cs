#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda484c87507313b5c386dd0d8dd72805690a49a"
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda484c87507313b5c386dd0d8dd72805690a49a", @"/Views/Member/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<COrderListViewModel>>
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
#nullable restore
#line 7 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
  
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
#line 16 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fda484c87507313b5c386dd0d8dd72805690a49a5274", async() => {
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
#line 39 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 42 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 43 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 49 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
          
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
#line 55 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
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
#line 61 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
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
            WriteLiteral("ope=\"col\">訂單狀態</th>\r\n                        <th scope=\"col\">總金額</th>\r\n                        <th scope=\"col\">客服</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody class=\"white\">\r\n");
#nullable restore
#line 89 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                      
                        int count = 0;
                        foreach (var order in Model)
                        {
                            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3387, "\"", 3395, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 95 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                                                    Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3445, "\"", 3453, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 96 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.orderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3513, "\"", 3521, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"orderId\"><a>");
#nullable restore
#line 97 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                                                        Write(order.orderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3599, "\"", 3607, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3664, "\"", 3672, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 99 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3728, "\"", 3736, 0);
            EndWriteAttribute();
            WriteLiteral("><a>聯繫客服</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Student\Documents\MSIT143.ClientMDA1028\ClientMDA\Views\Member\OrderList.cshtml"
                        }


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                </tbody>\r\n            </table>\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<COrderListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
