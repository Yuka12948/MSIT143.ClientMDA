#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "902895d20a6911784cda64822d8fc47bb8f8e691"
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902895d20a6911784cda64822d8fc47bb8f8e691", @"/Views/Member/OrderList.cshtml")]
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
#line 7 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
  
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
#line 16 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "902895d20a6911784cda64822d8fc47bb8f8e6915242", async() => {
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

        .swal2-title {
            color: ");
                WriteLiteral("red !important;\r\n        }\r\n\r\n        .swal2-label {\r\n            color: black !important;\r\n            display: block !important;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<div class=\"member_id\">\r\n    <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 81 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 84 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 85 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 91 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
          
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
#line 97 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
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
#line 103 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
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
#line 131 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                      
                        int count = 0;
                        foreach (var order in Model)
                        {
                            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 4329, "\"", 4337, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 137 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                                    Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4387, "\"", 4395, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 138 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.orderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4455, "\"", 4463, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"orderId\"><a>");
#nullable restore
#line 139 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                                        Write(order.orderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4541, "\"", 4549, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 140 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4606, "\"", 4614, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 141 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                        Write(order.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"wbtn btn-secondary btn-sm\"");
            BeginWriteAttribute("value", " value=\"", 4704, "\"", 4726, 1);
#nullable restore
#line 142 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
WriteAttributeValue("", 4712, order.orderId, 4712, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a>訂單詳情</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 144 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                        }


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div id=\"id01\" class=\"w3-modal\">\r\n</div>\r\n\r\n<input type=\"hidden\" id=\"orderCode\"");
            BeginWriteAttribute("value", " value=\"", 5038, "\"", 5046, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script>
        $('.btn-sm').click(function () {
                let id = this.getAttribute('value')
                console.log(id);
                $('#id01').css('display', 'block');
                CallAjax(id);
        })

        async function CallAjax(orderId) {
        $(""#id01"").empty();
           let _url = await '");
#nullable restore
#line 176 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                        Write(Url.Action("GetfullOrderInfo", "Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?orderId=${orderId}`;
                $.ajax({
                    type: ""GET"",
                    url: _url,
                    success: function (result) {
                        $('#id01').html(result);
                        RefundClick();
                    }
                });
        }

        function RefundClick() {
            $(""button[name='refundbtn']"").click(function () {
                Swal.fire({
                    title: '請輸入退票序號',
                    input: 'text',
                    inputLabel: '發送郵件上的退票序號',
                    inputPlaceholder: 'XXXXXX',
                    inputAttributes: {
                        maxlength: 18,
                        autocapitalize: 'off',
                        autocorrect: 'off'
                    }
                })

                $('button[class=""swal2-confirm swal2-styled""]').click(function () {
                    document.getElementById('orderCode').setAttribute('value', `${$('#swal2-input').val()}`)");
                WriteLiteral(@"
                    checkcodestaut();
                });
            })
        }

        function checkcodestaut() {
            let code = document.getElementById('orderCode').getAttribute('value');
            console.log(code);
            let _url ='");
#nullable restore
#line 211 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                  Write(Url.Action("CheckCode", "Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?code=${code}`;
            $.ajax({
                type: ""GET"",
                url: _url,
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (result) {
                    if (result == 'T') {
                        Swal.fire({
                            title: '請再次輸入密碼',
                            html:
                                '<label>輸入會員密碼</label>' +
                                '<input type=""password"" id=""swal-input1"" class=""swal2-input"">' +
                                '<label>輸入驗證圖形</label>' +
                                '<input id=""swal-input2"" class=""swal2-input"">' +
                                '<img id=""code"" src=");
#nullable restore
#line 226 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                               Write(Url.Action("GetValidatePic","Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" style=""cursor:pointer""/>' +
                                '<p style=""color:black"">點擊已更換圖示</p>',
                        })

                        $('#code').click(function () {
                            console.log('click')
                            let _picurl = '");
#nullable restore
#line 232 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                      Write(Url.Action("GetValidatePic", "Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                            $.ajax({
                                type: 'GET',
                                url: _picurl,
                                success: function () {
                                    document.getElementById('code').setAttribute('src', '");
#nullable restore
#line 237 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                                                                                    Write(Url.Action("GetValidatePic","Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
                                }
                            })
                        })


                        $('button[class=""swal2-confirm swal2-styled""]').click(function () {
                            checkpassword($('#swal-input1').val(), $('#swal-input2').val());
                        });

                    } else if (result == 'F') {
                        Swal.fire({
                            icon: 'error',
                            title: '錯誤',
                            text: '退票序號輸入錯誤，請再次確認!',
                        })
                    }
                    else if (result == 'O') {
                        Swal.fire({
                            icon: 'error',
                            title: '錯誤',
                            text: '此訂單已無法退款!',
                        })
                     }
                }
            });
        }

        function checkpassword(password, code) {
            console.log(password);
            console.");
                WriteLiteral("log(code);\r\n            let _url = \'");
#nullable restore
#line 268 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                   Write(Url.Action("PasswordCheck", "Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?password=${password}&code=${code}`;
            $.ajax({
                type: ""GET"",
                url: _url,
                success: function (result) {
                    if (result == 'T') {
                        const inputOptions = new Promise((resolve) => {
                            setTimeout(() => {
                                resolve({
                                    '#ff0000': '我臨時改變行程',
                                    '#00ff00': '我認定訂票流程不方便',
                                    '#0000ff': '我認為優惠不夠吸引人'
                                })
                            }, 1000)
                        })

                        Swal.fire({
                            title: '懇請告知我們退款原因',
                            input: 'radio',
                            inputOptions: inputOptions,
                            inputValidator: (value) => {
                                if (!value) {
                                    return '請選擇一項!'
                ");
                WriteLiteral(@"                }
                                else {
                                    callrefund();
                                }
                            }
                        })
                    }
                    else{
                        Swal.fire({
                            icon: 'error',
                            title: '錯誤',
                            text: '密碼或驗證錯誤，請再次確認!',
                        })
                    }
                }
            })
        }

        function callrefund() {
            let _url = '");
#nullable restore
#line 310 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Member\OrderList.cshtml"
                   Write(Url.Action("Ajaxrefund", "Member"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            $.ajax({
                type: 'GET',
                url: _url,
                success: function (result) {
                    if (result == 'T') {
                        Swal.fire({
                            icon: 'success',
                            title: '訂單成功取消',
                        })
                    }
                }
            })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<COrderListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
