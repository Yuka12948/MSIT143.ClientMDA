#pragma checksum "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a6c2e61da4cb201a213ed10d0c6f2db0fa7456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_PaymentWeb2), @"mvc.1.0.view", @"/Views/Ticketing/PaymentWeb2.cshtml")]
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
#line 1 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3a6c2e61da4cb201a213ed10d0c6f2db0fa7456", @"/Views/Ticketing/PaymentWeb2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_PaymentWeb2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CInfoForMakeNewOrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cyborg/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Ticketing/PaymentWeb3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
  
    string text = "+886";
    decimal totalPrice = 0;

    foreach (var item in Model.Alltciket)
    {
        totalPrice += (item.TicketPrice) * (item.TicketCount);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3a6c2e61da4cb201a213ed10d0c6f2db0fa74565639", async() => {
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
<link href=""form-validation.css"" rel=""stylesheet"">
<style>
    .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
    }

    .b-example-divider {
        height: 3rem;
        background-color: rgba(0, 0, 0, .1);
        border: solid rgba(0, 0, 0, .15);
        border-width: 1px 0;
        box-shadow: inset 0 .5em 1.5em rgba(0, 0, 0, .1), inset 0 .125em .5em rgba(0, 0, 0, .15);
    }

    .b-example-vr {
        flex-shrink: 0;
        width: 1.5rem;
        height: 100vh;
    }

    .bi {
        vertical-align: -.125em;
        fill: currentColor;
    }

    .nav-scroller {
        position: relative;
        z-index: 2;
        height: 2.75rem;
        overflow-y: hidden;
    }

        .nav-scroller .nav {
            display: flex;
            flex-wrap: nowrap;
            padding-bottom: 1rem;
            margin-top: -1px;
            ove");
            WriteLiteral(@"rflow-x: auto;
            text-align: center;
            white-space: nowrap;
            -webkit-overflow-scrolling: touch;
        }

    .form-label {
        color: whitesmoke;
    }

    .form-check-label {
        color: whitesmoke;
    }

    .mb-3 {
        color: whitesmoke;
    }

    body {
        --bs-bg-opacity: 1;
    }

    .needs-validation .label-text {
        color: whitesmoke;
    }

    .my-0 {
        color: black !important;
    }

    .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 100px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    }

    /* Modal Content */
");
            WriteLiteral(@"    .modal-content {
        background-color: #fefefe;
        margin: auto;
        padding: 20px;
        border: 1px solid #888;
        width: 80%;
    }

    /* The Close Button */
    .close {
        color: #aaaaaa;
        float: right;
        font-size: 28px;
        font-weight: bold;
    }

        .close:hover,
        .close:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }

    .paypal {
    }

    .credit {
    }

    .opayment {
    }

    .box {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        width: 100%;
        height: 100vh;
    }
</style>


<div id=""preloder"">
    <div class=""loader""></div>
</div>

<section class=""container justify-content-center m-5"" id=""all"">
    <div class=""container justify-content-center m-2"">
        <main>
            <div class=""row g-5"">
                <div class=""col-md-5 col-l");
            WriteLiteral(@"g-4 order-md-last"">
                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                        <span class=""text-primary"">訂票內容</span>
                        <span class=""badge bg-primary rounded-pill"">3</span>
                    </h4>
                    <ul class=""list-group mb-3"">

");
#nullable restore
#line 159 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                         foreach (var item in Model.Alltciket)
                        {
                            decimal price = (item.TicketPrice) * (item.TicketCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between lh-sm\">\r\n                                <div>\r\n                                    <h6 class=\"my-0\">");
#nullable restore
#line 164 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                                                Write(item.TicketName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <small class=\"text-muted\">購買數量:");
#nullable restore
#line 165 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                                                              Write(item.TicketCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 張</small>\r\n                                </div>\r\n                                <span class=\"text-muted\">$");
#nullable restore
#line 167 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                                                     Write(price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n");
#nullable restore
#line 169 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""list-group-item d-flex justify-content-between bg-light"">
                            <div class=""text-success"">
                                <h6 class=""my-0"">優惠折扣</h6>
                                <small id=""coupontype"">折扣內容資訊</small>
                            </div>
                            <span class=""text-success"" id=""discount"">$0</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between"">
                            <span style=""color:gray!important"">總價(NT$)</span>
                            <strong style=""color:black!important"" id=""totalprice"">$");
#nullable restore
#line 179 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                                                                              Write(totalPrice.ToString("0.00#"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </li>
                    </ul>

                    <div class=""card p-2"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""優惠碼"" id=""coupontext"">
                            <button type=""button"" class=""btn btn-secondary"" id=""couponbtn"">輸入優惠碼</button>
                        </div>
                    </div>
                </div>
                <div class=""col-md-7 col-lg-8"">
                    <h4 class=""mb-3"">帳單地址</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3a6c2e61da4cb201a213ed10d0c6f2db0fa745613584", async() => {
                WriteLiteral(@"
                        <div class=""row g-3"">
                            <div class=""col-sm-6"">
                                <label for=""firstName"" class=""form-label"">姓 氏</label>
                                <input type=""text"" class=""form-control"" id=""firstName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6039, "\"", 6053, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 6054, "\"", 6062, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    姓氏需輸入
                                </div>
                            </div>

                            <div class=""col-sm-6"">
                                <label for=""lastName"" class=""form-label"">名 字</label>
                                <input type=""text"" class=""form-control"" id=""lastName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6483, "\"", 6497, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 6498, "\"", 6506, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    名字需輸入
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""username"" class=""form-label"">連絡電話</label>
                                <div class=""input-group has-validation"">
                                    <span class=""input-group-text""> ");
#nullable restore
#line 213 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                                                               Write(text);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                                    <input type=""tel"" class=""form-control"" id=""username"" placeholder=""電話號碼"" required>
                                    <div class=""invalid-feedback"">
                                        連絡電話需輸入
                                    </div>
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""email"" class=""form-label"">電子郵件 <span class=""text-muted"">(註明)</span></label>
                                <input type=""email"" class=""form-control"" name=""email"" id=""email"" required>
                                <div class=""invalid-feedback"">
                                    電子郵件需輸入
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""address"" class=""form-label"">帳單地址</label>
                                <input type=""text"" cla");
                WriteLiteral(@"ss=""form-control"" id=""address"" placeholder=""輸入地址"" required>
                                <div class=""invalid-feedback"">
                                    帳單地址需輸入
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""address2"" class=""form-label"">居住城市<span class=""text-muted"">(可選)</span></label>
                                <input type=""text"" class=""form-control"" id=""address2"" placeholder=""輸入城市"">
                            </div>
                        </div>

                        <hr class=""my-4"">

                        <div class=""form-check"">
                            <input type=""checkbox"" class=""form-check-input"" id=""send-email"">
                            <label class=""mb-0"" for=""send-email"">我同意以後會收到來自本網站的相關優惠訊息</label>
                        </div>

                        <div class=""form-check"">
                            <input type=""checkbox"" class=""");
                WriteLiteral(@"form-check-input"" id=""save-info"">
                            <label class=""mb-0"" for=""save-info"">儲存個人資訊</label>
                        </div>

                        <hr class=""my-4"">

                        <h4 class=""mb-3"">付款方式</h4>

                        <div class=""my-3"">
                            <div class=""form-check"">
                                <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""form-check-input"" checked required>
                                <label class=""mb-0"" for=""credit"">信用卡</label>
                            </div>
                            <div class=""form-check"">
                                <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""form-check-input"" required>
                                <label class=""mb-0"" for=""debit"">歐付寶支付</label>
                            </div>
                            <div class=""form-check"">
                                <input id=""paypal"" name=""paymentMethod"" type=""radio"" class=""");
                WriteLiteral(@"form-check-input"" required>
                                <label class=""mb-0"" for=""paypal"">PayPal</label>
                            </div>
                        </div>

                        <div class=""row gy-3 credit"">
                            <div class=""col-md-10 pb-2"">
                                <label for=""cc-number"" class=""form-label"">信用卡號碼</label>
                                <input type=""text"" class=""form-control"" id=""cc-number""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 10528, "\"", 10542, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    信用卡號碼需輸入
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <label for=""cc-expiration"" class=""form-label"">有效日期 月</label>
                                <input type=""text"" class=""form-control"" id=""cc-expirationM"" placeholder=""MM"" required>
                                <div class=""invalid-feedback"">
                                    有效日期需輸入
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <label for=""cc-expiration"" class=""form-label""> 年 </label>
                                <input type=""text"" class=""form-control"" id=""cc-expirationY"" placeholder=""YYYY"" required>
                                <div class=""invalid-feedback"">
                                    有效日期需輸");
                WriteLiteral(@"入
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <label for=""cc-cvv"" class=""form-label"">安全碼</label>
                                <input type=""text"" class=""form-control"" id=""cc-cvv""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 11867, "\"", 11881, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    安全碼需輸入
                                </div>
                            </div>
                        </div>

                        <hr class=""my-4"">
                        <input type=""hidden"" name=""fullPrice"" id=""fullPrice""");
                BeginWriteAttribute("value", " value=\"", 12231, "\"", 12250, 1);
#nullable restore
#line 309 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
WriteAttributeValue("", 12239, totalPrice, 12239, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"ScreenID\" id=\"ScreenID\"");
                BeginWriteAttribute("value", " value=\"", 12330, "\"", 12353, 1);
#nullable restore
#line 310 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
WriteAttributeValue("", 12338, Model.ScreenID, 12338, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"SeatInfo\" id=\"SeatInfo\"");
                BeginWriteAttribute("value", " value=\"", 12433, "\"", 12456, 1);
#nullable restore
#line 311 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
WriteAttributeValue("", 12441, Model.SeatInfo, 12441, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"TicketInfo\" id=\"TicketInfo\"");
                BeginWriteAttribute("value", " value=\"", 12540, "\"", 12565, 1);
#nullable restore
#line 312 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
WriteAttributeValue("", 12548, Model.TicketInfo, 12548, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <button class=""w-75 btn btn-primary btn-lg credit"" type=""submit"">確認付款</button>
                        <button class=""w-75 btn btn-primary btn-lg bi-paypal paypal"" type=""button"">PAYPAL</button>
                        <button class=""w-75 btn btn-primary btn-lg opayment"" type=""button"" id=""opayment"">前往歐付寶頁面</button>
                        <button class=""ml-3 btn btn-dark btn-lg credit"" type=""button"" id=""Demo"">Demo</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        </main>
    </div>
</section>


<div id=""myModal"" class=""modal"">
    <div class=""modal-content"">
        <span class=""close"" id=""closeModal"">&times;</span>
        <div class=""row justify-content-center m-auto pb-4"">
            <div>
                <p style=""color:black!important"">為確保您的安全，已向您輸入的電子郵件發送簡訊</p>
                <p style=""color:black!important"">請入電子郵件上的核准碼</p>
            </div>
        </div>
        <div class=""row justify-content-center m-auto pb-4"">
            <div>
                <input type=""text"" placeholder=""驗證碼"" class=""w-100"" id=""ckeckcode"" />
            </div>
        </div>
        <div class=""row"">
            <div class=""col text-center"">
                <button class=""btn-primary p-2"" id=""modalOK"">確認</button>
                <button class=""btn-danger p-2"" id=""modalClose"">取消</button>
                <button class=""btn-action p-2"" id=""modalRe"">重發驗證碼</button>
            </div>
        </div>
    </div>");
            WriteLiteral("\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        let total =");
#nullable restore
#line 351 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
              Write(totalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            (function ($) {
            $(window).on('load', function () {
                $("".loader"").fadeOut();
                $(""#preloder"").delay(20).fadeOut(""slow"");
            });
        })(jQuery);

        const modal = document.getElementById(""myModal"");
        const close = document.getElementById(""closeModal"");
        const code = document.getElementById(""ckeckcode"");
        const form = document.getElementById(""formInfo"");
        const view = document.getElementById(""all"");
        const preloader = document.getElementById(""preloder"");

        $('.opayment').hide();
        $('.paypal').hide();

        (() => {
            'use strict'
            const forms = document.querySelectorAll('.needs-validation')

            Array.from(forms).forEach(form => {
                form.addEventListener('submit', event => {
                    if (!form.checkValidity()) {
                        event.preventDefault()
                        event.stopPropagation()
    ");
                WriteLiteral(@"                }
                    else {
                        event.preventDefault()
                        modal.style.display = ""block"";
                        let checkemail = email.value
                        let url = ""/Ticketing/sendmail"" + `?email=${checkemail}`;
                        CallAjax(url);
                    }
                    form.classList.add('was-validated')
                }, false)
            })
        })()

        close.addEventListener('click', function () {
            modal.style.display = ""none"";
        })


        let firstName = document.getElementById('firstName');
        let lastName = document.getElementById('lastName');
        let username = document.getElementById('username');
        let email = document.getElementById('email');
        let address = document.getElementById('address');
        let ccnumber = document.getElementById('cc-number');
        let ccexpirationM = document.getElementById('cc-expirationM');
        le");
                WriteLiteral(@"t ccexpirationY = document.getElementById('cc-expirationY');
        let cccvv = document.getElementById('cc-cvv');
        let address2 = document.getElementById('address2');

        $('#Demo').click(() => {
            console.log('click');
            firstName.value = '王';
            lastName.value = '小名';
            username.value = '曉華';
            email.value = 'annlan08@gmail.com'
            address.value = '台北市大安區復興南路一段';
            ccnumber.value = '5882-5646-5465-6666';
            ccexpirationM.value = '12';
            ccexpirationY.value = '2035';
            cccvv.value = '666';
            address2.value = '台北市'
        })

        $('#modalClose').click(() => {
            modal.style.display = ""none"";
        })

        $('#modalRe').click(() => {
            let checkemail = email.value
            let url = ""/Ticketing/sendmail"" + `?email=${checkemail}`;
            CallAjax(url);
        })

        $('#modalOK').click(() => {
            console.log('c");
                WriteLiteral(@"lick');
            modal.style.display = ""none"";
            let checkcode = code.value
            let url = ""/Ticketing/checkcode"" + `?code=${checkcode}`;
            CallAjaxCheck(url);
        })

        async function CallAjax(url) {
            let response = await fetch(`${url}`)
        }

        async function CallAjaxCheck(url) {
            let response = await fetch(`${url}`)
            let data = await response.json();
            if (data == 1) {
                view.style.display = ""none"";
                preloader.style.display = ""block"";
                form.submit();

            }
            else {
                window.alert(""驗證碼錯誤"");
            }
            console.log(data);
        }

        $('#credit').click(function () {
            $('.credit').show();
            $('.opayment').hide();
            $('.paypal').hide();
        })

        $('#debit').click(function () {
            $('.credit').hide();
            $('.opayment').show();
  ");
                WriteLiteral(@"          $('.paypal').hide();
        })

        $('#paypal').click(function () {
            $('.credit').hide();
            $('.opayment').hide();
            $('.paypal').show();
        })

        $('#opayment').click(function () {
            $('#formInfo').attr(""action"", ""OPayment"")
            $('#formInfo').submit();
        })

        $('#couponbtn').click(function () {
            let code = $('#coupontext').val();
            CallAjaxCoupon(code);
        })

        async function CallAjaxCoupon(code) {
            let _url = await '");
#nullable restore
#line 487 "C:\MDA143\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                         Write(Url.Action("Coupon", "Ticketing"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?code=${code}`;
                $.ajax({
                    type: ""GET"",
                    url: _url,
                    success: function (result) {
                        console.log(result);
                        if (result == 'F') {
                            window.alert(""無此優惠或你已使用過優惠"");
                        }
                        else {
                            $('#coupontype').text(result['優惠名稱couponName']);
                            $('#discount').text(`$-${result['優惠折扣couponDiscount']}`);
                            let t = parseInt(total) - parseInt(result['優惠折扣couponDiscount']);
                            $('#totalprice').text(`$${t}.00`);
                            $('#fullPrice').val(t);
                        }
                    }});}

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CInfoForMakeNewOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
