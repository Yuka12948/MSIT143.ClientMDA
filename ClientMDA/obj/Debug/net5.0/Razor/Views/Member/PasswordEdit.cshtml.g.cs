#pragma checksum "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb25e12c4120279bffbceb99b5acf14054352716"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_PasswordEdit), @"mvc.1.0.view", @"/Views/Member/PasswordEdit.cshtml")]
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
#line 1 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb25e12c4120279bffbceb99b5acf14054352716", @"/Views/Member/PasswordEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_PasswordEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/MemberMain.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Member/toast.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("userInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Member/PasswordEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
  
    會員member mem = null;
    if (Accessor.HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
    {
        var a = Accessor.HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
        mem = JsonSerializer.Deserialize<會員member>(a);
    }


#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
  
    ViewData["Title"] = "PasswordEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb25e12c4120279bffbceb99b5acf140543527166554", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb25e12c4120279bffbceb99b5acf140543527167732", async() => {
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
                WriteLiteral("\r\n    <style>\r\n        .white {\r\n            color: white;\r\n        }\r\n\r\n        .content {\r\n            width: 80%;\r\n            margin: 0 auto;\r\n        }\r\n\r\n        .btn-cancel {\r\n            background-color: #6c757d;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"member_id\">\r\n    <span class=\"member_hello\">HELLO!</span>\r\n");
#nullable restore
#line 39 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
      
        if (mem.暱稱nickName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"member_id_name\">");
#nullable restore
#line 42 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
                                    Write(mem.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 43 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"row\">\r\n    <div class=\"member_menu\">\r\n");
#nullable restore
#line 48 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
          
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
#line 54 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
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
#line 60 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
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
            <div class=""content white"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb25e12c4120279bffbceb99b5acf1405435271612220", async() => {
                WriteLiteral(@"
                    <div class=""dialog-title"">
                        <h2 class=""white"">變更密碼</h2>
                        <div class=""dialog-close mui-icon icon-btn mui-icon-close"" title=""關閉""></div>
                    </div>
                    <div class=""dialog-content"">
                        <div class=""op"" style=""margin-top: 10px;"">
                            <div class=""label div-old-pswd"">
                                <label for=""txt_old_password"">目前密碼</label>
                                <input type=""hidden"" name=""memberId""");
                BeginWriteAttribute("value", " value=\"", 3243, "\"", 3268, 1);
#nullable restore
#line 84 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
WriteAttributeValue("", 3251, mem.會員編號memberId, 3251, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </div>\r\n                            <div class=\"div-old-pswd\">\r\n                                <input autocomplete=\"off\" id=\"txt_old_password\" name=\"txt_old_password\" style=\"width:240px\" type=\"password\">\r\n");
#nullable restore
#line 88 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
                                  
                                    if (ViewBag.txtError == false)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <small id=\"wrongpwdMessage\" style=\"color:red\">原密碼錯誤</small>\r\n");
#nullable restore
#line 92 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div class=""label mt-3"">
                                <label for=""login-pwd"" style=""margin-right:0px"">新密碼</label><span class=""r-hint"">(密碼長度需為 6 ~ 16 個字元)</span>
                            </div>
                            <div>
                                <input autocomplete=""off"" id=""txt_new_password"" name=""txt_new_password"" style=""width:240px"" type=""password"">
                            </div>
                            <div class=""label mt-3"">
                                <label for=""login-pwd"">確認新密碼</label>
                            </div>
                            <div>
                                <input autocomplete=""off"" id=""txt_new_password_confirm"" name=""txt_new_password_confirm"" style=""width:240px"" type=""password"">
                                <small id=""differMessage""></small>
                            </div>
                        </div>
                    </div>
                    <div cla");
                WriteLiteral(@"ss=""form-group"">
                        <input type=""submit"" id=""save"" value=""儲存變更"" class=""site-btn m-1"" />
                        <input type=""button"" id=""cancel"" value=""取消"" class=""site-btn btn-cancel m-1"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <!-- The actual snackbar -->\r\n            <div id=\"snackbar\">密碼修改成功</div>\r\n\r\n            <!--end content-->\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>


    <script>
    const btnCancel = document.querySelector(""#cancel"");
    const txtOld = document.querySelector(""#txt_old_password"");
    const txtNew = document.querySelector(""#txt_new_password"");
    const txtNewCon = document.querySelector(""#txt_new_password_confirm"");
    const msgWrong = document.querySelector(""#wrongpwdMessage"");
    const msgDiffer = document.querySelector(""#differMessage"");
    const save = document.querySelector(""#save"");
    const a = '");
#nullable restore
#line 137 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Member\PasswordEdit.cshtml"
          Write(ViewBag.txtSuccess);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'

    btnCancel.addEventListener(""click"", () => {
        document.querySelector(""#txt_old_password"").value = """";
        document.querySelector(""#txt_new_password"").value = """";
        document.querySelector(""#txt_new_password_confirm"").value = """";
    })
    txtNewCon.addEventListener(""input"", () => {
        if (txtNew.value != txtNewCon.value) {
            msgDiffer.textContent = ""輸入密碼不一致""
        }
        else {
            msgDiffer.textContent = """"
        }
    })
    txtNew.addEventListener(""input"", () => {
        if (txtNew.value != txtNewCon.value) {
            msgDiffer.textContent = ""輸入密碼不一致""
        }
        else {
            msgDiffer.textContent = """"
        }
    })
    save.addEventListener(""click"", () => {
        if (msgDiffer.textContent != """" || txtOld.value == """" || txtNew.value=="""") {
            save.setAttribute('type', 'button')
        }
        else {
            save.setAttribute('type', 'submit')
        }
    })

    if (a == ""s"") {
     ");
                WriteLiteral(@"   window.onload=myFunction()
    }


    function myFunction() {
        // Get the snackbar DIV
        var x = document.getElementById(""snackbar"");

        // Add the ""show"" class to DIV
        x.className = ""show"";

        // After 3 seconds, remove the show class from DIV
        setTimeout(function () { x.className = x.className.replace(""show"", """"); }, 3000);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
