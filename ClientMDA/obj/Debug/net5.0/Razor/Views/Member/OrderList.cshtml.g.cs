#pragma checksum "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6b92a26c2673526336f47760be599de57671d5"
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
#line 1 "C:\MDA143\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA143\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6b92a26c2673526336f47760be599de57671d5", @"/Views/Member/OrderList.cshtml")]
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
#line 7 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
  
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
#line 16 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e6b92a26c2673526336f47760be599de57671d54962", async() => {
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
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
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

        .border-bottom-0 {
            color: black !important;
            border-block-color: grey;
        }

        .row {
            text-align: center;
        }


        .seatrow .dot {
            display: inline-block;
            width: 13px;
            height: 13px;
            border-radius: 50%;
            margin: 0.2vw;
            cursor: pointer;
            background-color: black;
        }

        .seatrow div {
            display: block;
        }

        .seatrow .selected {
            background-color: deeppink;
        }

        .seatrow .none {
            background-color: transparent;
        }
    </style>
");
            }
            );
            WriteLiteral("<div class=\"member_id\">\r\n    <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 72 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 75 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 76 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 82 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
          
            if (mem.正式會員formal == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a id=""watchlist"" href=""../Member/WatchList"" title=""我的片單"" class=""member_link"">我的片單</a>
                <a id=""commentList"" href=""../Member/CommentList"" title=""我的評論"" class=""member_link"">我的評論</a>
                <a id=""wishlist"" href=""../Member/wishlist"" title=""我的追蹤"" class=""member_link"">我的追蹤</a>
");
#nullable restore
#line 88 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a id=""watchlist"" href=""../Member/NotFormal"" title=""我的片單"" class=""member_link"">我的片單</a>
                <a id=""commentList"" href=""../Member/NotFormal"" title=""我的評論"" class=""member_link"">我的評論</a>
                <a id=""wishlist"" href=""../Member/NotFormal"" title=""我的追蹤"" class=""member_link"">我的追蹤</a>
");
#nullable restore
#line 94 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a id=\"orderlist\" href=\"../Member/orderlist\" title=\"訂單查詢\" class=\"member_link\">訂單查詢</a>\r\n");
            WriteLiteral(@"        <a id=""memberdiscount"" href=""../Member/memberdiscount"" title=""我的抵用券"" class=""member_link"">我的抵用券</a>

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
                        <th scope=""col"">訂單狀態</th>
                        <th scope=""col"">總金額</th>
                        <th scope=""col"">查看詳情</th>
                    </tr>
                </thead>
                <tbody class=""whi");
            WriteLiteral("te\">\r\n");
#nullable restore
#line 122 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                      
                        int count = 0;
                        foreach (var order in Model)
                        {
                            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 4141, "\"", 4149, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 128 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                                                    Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4199, "\"", 4207, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 129 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.orderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4267, "\"", 4275, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"orderId\"><a>");
#nullable restore
#line 130 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                                                        Write(order.orderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4353, "\"", 4361, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 131 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4418, "\"", 4426, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 132 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"w3-button w3-green w3-large\"");
            BeginWriteAttribute("value", " value=\"", 4518, "\"", 4540, 1);
#nullable restore
#line 133 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
WriteAttributeValue("", 4526, order.orderId, 4526, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a>訂單詳情</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 135 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                        }


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"id01\" class=\"w3-modal\">\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>
    <script>
            $('.w3-green').click(function () {
                let id = this.getAttribute('value')
                console.log(id);
                $('#id01').css('display', 'block');
                CallAjax(id);

        })

        async function CallAjax(orderId) {
        $(""#id01"").empty();
           let _url = await '");
#nullable restore
#line 165 "C:\MDA143\ClientMDA\Views\Member\OrderList.cshtml"
                        Write(Url.Action("GetfullOrderInfo", "Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?orderId=${orderId}`;
                $.ajax({
                    type: ""GET"",
                    url: _url,
                    success: function (result) {
                        console.log(result);
                        $('#id01').html(result);
                    }});}


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<COrderListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
