#pragma checksum "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "745fcc2fcbe115c4305f937049b098a930913b2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_MemberBonusList), @"mvc.1.0.view", @"/Views/Member/MemberBonusList.cshtml")]
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
#line 1 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"745fcc2fcbe115c4305f937049b098a930913b2f", @"/Views/Member/MemberBonusList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_MemberBonusList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 5 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
  
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
#line 14 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
  
    ViewData["Title"] = "MemberBonusList";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "745fcc2fcbe115c4305f937049b098a930913b2f4940", async() => {
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
            WriteLiteral("\r\n<div class=\"member_id\">\r\n    <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 38 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 41 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
        }



    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 51 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
          
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
#line 57 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
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
#line 63 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\MemberBonusList.cshtml"
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
            <h2 class=""white text-left mb-3"">我的紅利金</h2>
");
            WriteLiteral(@"            <table class=""table white"">
                <thead>
                    <tr>
                        <th scope=""col"">序</th>
                        <th scope=""col"">項目</th>
                        <th scope=""col"">紅利金</th>
                        <th scope=""col"">生效日期</th>
                        <th scope=""col"">使用期限</th>
                        <th scope=""col"">抵用紀錄</th>
                    </tr>
                </thead>
                <tbody class=""white"">
                    <tr>
                        <th scope=""row""");
            BeginWriteAttribute("class", " class=\"", 3190, "\"", 3198, 0);
            EndWriteAttribute();
            WriteLiteral(">1</th>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3235, "\"", 3243, 0);
            EndWriteAttribute();
            WriteLiteral(">購票使用</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3283, "\"", 3291, 0);
            EndWriteAttribute();
            WriteLiteral(">-100</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3331, "\"", 3339, 0);
            EndWriteAttribute();
            WriteLiteral(">2021-07-31</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3385, "\"", 3393, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3429, "\"", 3437, 0);
            EndWriteAttribute();
            WriteLiteral(">2021-07-31</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3548, "\"", 3556, 0);
            EndWriteAttribute();
            WriteLiteral(">2</th>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3593, "\"", 3601, 0);
            EndWriteAttribute();
            WriteLiteral(">新入會員</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3641, "\"", 3649, 0);
            EndWriteAttribute();
            WriteLiteral(">+300</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3689, "\"", 3697, 0);
            EndWriteAttribute();
            WriteLiteral(">2022-04-27</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3743, "\"", 3751, 0);
            EndWriteAttribute();
            WriteLiteral(">2022-12-31</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3797, "\"", 3805, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3906, "\"", 3914, 0);
            EndWriteAttribute();
            WriteLiteral("></th>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3950, "\"", 3958, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 3994, "\"", 4002, 0);
            EndWriteAttribute();
            WriteLiteral(">可用紅利金餘額: 200</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 4050, "\"", 4058, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 4094, "\"", 4102, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 4138, "\"", 4146, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script>\r\n");
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
