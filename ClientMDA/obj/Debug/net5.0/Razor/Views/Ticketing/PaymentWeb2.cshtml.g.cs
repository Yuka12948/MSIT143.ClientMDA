#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b98e6345b9d071b1789400077c59fcd382eef4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b98e6345b9d071b1789400077c59fcd382eef4", @"/Views/Ticketing/PaymentWeb2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_PaymentWeb2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
  
    string text = "文字";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b98e6345b9d071b1789400077c59fcd382eef44310", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 172, "\"", 182, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Hugo 0.101.0"">

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.2/examples/checkout/"">

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
  ");
                WriteLiteral(@"          position: relative;
            z-index: 2;
            height: 2.75rem;
            overflow-y: hidden;
        }

            .nav-scroller .nav {
                display: flex;
                flex-wrap: nowrap;
                padding-bottom: 1rem;
                margin-top: -1px;
                overflow-x: auto;
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
    </style>


    <!-- Custom styles for this template -->
    <link href=""form-validation.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""container justify-content-center m-5"">
    <div class=""container justify-content-center m-2"">
        <main>
            <div class=""row g-5"">
                <div class=""col-md-5 col-lg-4 order-md-last"">
                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                        <span class=""text-primary"">訂單內容</span>
                        <span class=""badge bg-primary rounded-pill"">3</span>
                    </h4>
                    <ul class=""list-group mb-3"">
                        <li class=""list-group-item d-flex justify-content-between lh-sm"">
                            <div>
                                <h6 class=""my-0"">Product name</h6>
                                <small class=""text-muted"">Brief description</small>
                            </div>
                            <span class=""text-muted"">$12</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-bet");
            WriteLiteral(@"ween lh-sm"">
                            <div>
                                <h6 class=""my-0"">Second product</h6>
                                <small class=""text-muted"">Brief description</small>
                            </div>
                            <span class=""text-muted"">$8</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between lh-sm"">
                            <div>
                                <h6 class=""my-0"">Third item</h6>
                                <small class=""text-muted"">Brief description</small>
                            </div>
                            <span class=""text-muted"">$5</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between bg-light"">
                            <div class=""text-success"">
                                <h6 class=""my-0"">Promo code</h6>
                                <small>EXAMPLECODE</small>
     ");
            WriteLiteral(@"                       </div>
                            <span class=""text-success"">−$5</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between"">
                            <span>Total (USD)</span>
                            <strong>$20</strong>
                        </li>
                    </ul>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b98e6345b9d071b1789400077c59fcd382eef410079", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Promo code"">
                            <button type=""submit"" class=""btn btn-secondary"">Redeem</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-7 col-lg-8\">\r\n                    <h4 class=\"mb-3\">Billing address</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b98e6345b9d071b1789400077c59fcd382eef411858", async() => {
                WriteLiteral(@"
                        <div class=""row g-3"">
                            <div class=""col-sm-6"">
                                <label for=""firstName"" class=""form-label"">First name</label>
                                <input type=""text"" class=""form-control"" id=""firstName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5331, "\"", 5345, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5346, "\"", 5354, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    Valid first name is required.
                                </div>
                            </div>

                            <div class=""col-sm-6"">
                                <label for=""lastName"" class=""form-label"">Last name</label>
                                <input type=""text"" class=""form-control"" id=""lastName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5805, "\"", 5819, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5820, "\"", 5828, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    Valid last name is required.
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""username"" class=""form-label"">Username</label>
                                <div class=""input-group has-validation"">
                                    <span class=""input-group-text""> ");
#nullable restore
#line 155 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\PaymentWeb2.cshtml"
                                                               Write(text);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                                    <input type=""text"" class=""form-control"" id=""username"" placeholder=""Username"" required>
                                    <div class=""invalid-feedback"">
                                        Your username is required.
                                    </div>
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""email"" class=""form-label"">Email <span class=""text-muted"">(Optional)</span></label>
                                <input type=""email"" class=""form-control"" id=""email"" placeholder=""you@example.com"">
                                <div class=""invalid-feedback"">
                                    Please enter a valid email address for shipping updates.
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""address""");
                WriteLiteral(@" class=""form-label"">Address</label>
                                <input type=""text"" class=""form-control"" id=""address"" placeholder=""1234 Main St"" required>
                                <div class=""invalid-feedback"">
                                    Please enter your shipping address.
                                </div>
                            </div>

                            <div class=""col-12"">
                                <label for=""address2"" class=""form-label"">Address 2 <span class=""text-muted"">(Optional)</span></label>
                                <input type=""text"" class=""form-control"" id=""address2"" placeholder=""Apartment or suite"">
                            </div>
                        </div>

                        <hr class=""my-4"">

                        <div class=""form-check"">
                            <input type=""checkbox"" class=""form-check-input"" id=""same-address"">
                            <label class=""form-check-label"" for=""same-address"">Shi");
                WriteLiteral(@"pping address is the same as my billing address</label>
                        </div>

                        <div class=""form-check"">
                            <input type=""checkbox"" class=""form-check-input"" id=""save-info"">
                            <label class=""form-check-label"" for=""save-info"">Save this information for next time</label>
                        </div>

                        <hr class=""my-4"">

                        <h4 class=""mb-3"">Payment</h4>

                        <div class=""my-3"">
                            <div class=""form-check"">
                                <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""form-check-input"" checked required>
                                <label class=""form-check-label"" for=""credit"">Credit card</label>
                            </div>
                            <div class=""form-check"">
                                <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""form-check-input"" required>");
                WriteLiteral(@"
                                <label class=""form-check-label"" for=""debit"">Debit card</label>
                            </div>
                            <div class=""form-check"">
                                <input id=""paypal"" name=""paymentMethod"" type=""radio"" class=""form-check-input"" required>
                                <label class=""form-check-label"" for=""paypal"">PayPal</label>
                            </div>
                        </div>

                        <div class=""row gy-3"">
                            <div class=""col-md-6"">
                                <label for=""cc-name"" class=""form-label"">Name on card</label>
                                <input type=""text"" class=""form-control"" id=""cc-name""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 10159, "\"", 10173, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <small class=""text-muted"">Full name as displayed on card</small>
                                <div class=""invalid-feedback"">
                                    Name on card is required
                                </div>
                            </div>

                            <div class=""col-md-6"">
                                <label for=""cc-number"" class=""form-label"">Credit card number</label>
                                <input type=""text"" class=""form-control"" id=""cc-number""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 10728, "\"", 10742, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    Credit card number is required
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <label for=""cc-expiration"" class=""form-label"">Expiration</label>
                                <input type=""text"" class=""form-control"" id=""cc-expiration""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 11205, "\"", 11219, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    Expiration date required
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <label for=""cc-cvv"" class=""form-label"">CVV</label>
                                <input type=""text"" class=""form-control"" id=""cc-cvv""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 11655, "\"", 11669, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    Security code required
                                </div>
                            </div>
                        </div>

                        <hr class=""my-4"">

                        <button class=""w-75 btn btn-primary btn-lg"" type=""submit"">確認付款</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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

<script>
        // Example starter JavaScript for disabling form submissions if there are invalid fields
        (() => {
            'use strict'

            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            const forms = document.querySelectorAll('.needs-validation')

            // Loop over them and prevent submission
            Array.from(forms).forEach(form => {
                form.addEventListener('submit', event => {
                    if (!form.checkValidity()) {
                        event.preventDefault()
                        event.stopPropagation()
                    }

                    form.classList.add('was-validated')
                }, false)
            })
        })()
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
