#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d49c771820a70dbca787edc2a4d3ecddec299f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_SelectTicket), @"mvc.1.0.view", @"/Views/Ticketing/SelectTicket.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d49c771820a70dbca787edc2a4d3ecddec299f", @"/Views/Ticketing/SelectTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_SelectTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSelectTicketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cyborg/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cyborg/css/templatemo-cyborg-gaming.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Ticketing/PaymentWeb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
  
    int MAXcount = Model.ticketCount;
    int screenID = Model.screenID;
    int theaterID = Model.theaterID;
    string seatInfo = Model.seatInfo;
    string[] arr = Model.seatInfo.Split('#');
    string Seatstring = "";
    foreach (string item in arr)
    {
        string[] arr_seat = item.Split(':');
        Seatstring += $"{arr_seat[0]}排{arr_seat[1]}列 | ";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "55d49c771820a70dbca787edc2a4d3ecddec299f6114", async() => {
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d49c771820a70dbca787edc2a4d3ecddec299f7233", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "55d49c771820a70dbca787edc2a4d3ecddec299f7495", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "55d49c771820a70dbca787edc2a4d3ecddec299f8674", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://unpkg.com/swiper@7/swiper-bundle.min.css"" />

    <style>
        .main-profile ul .seat {
            border-bottom: none;
        }

        .item {
            height: 400px;
        }

            .item img {
                height: 300px;
            }

        .pay {
            text-align: center;
        }

        body {
            background-color: #070720;
        }

        .TicketCounter span {
            font-size: 22px;
        }

        .TicketCounter .fa-solid {
            cursor: pointer;
        }

            .TicketCounter .fa-solid:hover {
                color: #0080FF;
            }

        .TicketCounter .count-value {
        }

        .Ticket{

        }
    </style>
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
            WriteLiteral("\r\n\r\n<div id=\"preloder\">\r\n    <div class=\"loader\"></div>\r\n</div>\r\n\r\n<div class=\"pt-4\">\r\n    <div class=\"main-profile pt-4\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 align-self-lg-start\">\r\n");
#nullable restore
#line 74 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                  
                    foreach (var item in Model.ALLticketInfo)
                    {
                        string name = item.TicketName票種名稱;
                        decimal price = item.TicketPrice票價;
                        int id = item.TicketID票價明細;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"border border-5 border-light p-3 m-3\">\r\n                            <div class=\"row Ticket\">\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2132, "\"", 2143, 1);
#nullable restore
#line 82 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 2140, id, 2140, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <div class=\"col-3 ml-3\"><h4>");
#nullable restore
#line 83 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                                                       Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                                <div class=\"col-2 ml-3 text-center\"><h4>");
#nullable restore
#line 84 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                                                                   Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></div>
                                <div class=""col-5 TicketCounter text-right""><span class=""fa-solid fa-plus""></span> <span class=""pr-3 pl-3 count-value""> 0 </span> <span class=""fa-solid fa-subtract""></span></div>
                            </div>
                        </div>
");
#nullable restore
#line 88 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-lg-4 align-self-center\">\r\n                <ul>\r\n                    <li>影城名稱<span>");
#nullable restore
#line 93 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                             Write(Model.theaterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li>場次日期<span>");
#nullable restore
#line 94 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                             Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li>場次時間<span>");
#nullable restore
#line 95 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                             Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li>張數<span>");
#nullable restore
#line 96 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                           Write(MAXcount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li class=\"seat\">座位<span>");
#nullable restore
#line 97 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
                                        Write(Seatstring);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d49c771820a70dbca787edc2a4d3ecddec299f15674", async() => {
                WriteLiteral("\r\n            <div class=\"pay\">\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"main-button\">\r\n                        <input type=\"hidden\" name=\"MovieCode\" id=\"MovieCode\"");
                BeginWriteAttribute("value", " value=\"", 3397, "\"", 3421, 1);
#nullable restore
#line 106 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 3405, Model.movieCode, 3405, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"MovieID\" id=\"MovieID\"");
                BeginWriteAttribute("value", " value=\"", 3499, "\"", 3521, 1);
#nullable restore
#line 107 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 3507, Model.movieID, 3507, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Time\" id=\"Time\"");
                BeginWriteAttribute("value", " value=\"", 3593, "\"", 3612, 1);
#nullable restore
#line 108 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 3601, Model.Time, 3601, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Data\" id=\"Data\"");
                BeginWriteAttribute("value", " value=\"", 3684, "\"", 3703, 1);
#nullable restore
#line 109 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 3692, Model.Date, 3692, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"count\" id=\"count\"");
                BeginWriteAttribute("value", " value=\"", 3777, "\"", 3794, 1);
#nullable restore
#line 110 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 3785, MAXcount, 3785, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"seatInfo\" id=\"seatInfo\"");
                BeginWriteAttribute("value", " value=\"", 3874, "\"", 3891, 1);
#nullable restore
#line 111 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 3882, seatInfo, 3882, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"screenID\" id=\"screenID\"");
                BeginWriteAttribute("value", " value=\"", 3971, "\"", 3988, 1);
#nullable restore
#line 112 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 3979, screenID, 3979, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"theaterID\" id=\"theaterID\"");
                BeginWriteAttribute("value", " value=\"", 4070, "\"", 4088, 1);
#nullable restore
#line 113 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
WriteAttributeValue("", 4078, theaterID, 4078, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Ticketstring\" id=\"Ticketstring\"");
                BeginWriteAttribute("value", " value=\"", 4176, "\"", 4184, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn-outline-primary\" id=\"submitBTN\">前往付款</button>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("form", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    (function ($) {\r\n        $(window).on(\'load\', function () {\r\n            $(\".loader\").fadeOut();\r\n            $(\"#preloder\").delay(20).fadeOut(\"slow\");\r\n\r\n\r\n        });\r\n    })(jQuery);\r\n\r\n    const maxcount =");
#nullable restore
#line 134 "C:\Users\Student\Documents\MSIT143.ClientMDA1020\ClientMDA\Views\Ticketing\SelectTicket.cshtml"
               Write(MAXcount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    let currentValue = 0;

    $('.fa-plus').click(function () {
        let text = $(event.currentTarget).parents('.TicketCounter').find('span')[1].textContent;
        let value = parseInt(text);
        if (value == maxcount) {
            return;
        }
        if (currentValue < maxcount) {
            currentValue = currentValue + 1;
            $(event.currentTarget).parents('.TicketCounter').find('span')[1].textContent = (value + 1);
        }
    })

    $('.fa-subtract').click(function () {
        let text = $(event.currentTarget).parents('.TicketCounter').find('span')[1].textContent;
        let value = parseInt(text);
        if (value == 0) {
            return;
        }
        if (currentValue > 0) {
            currentValue = currentValue - 1;
            $(event.currentTarget).parents('.TicketCounter').find('span')[1].textContent = (value - 1);
        }
    })

    let Allticket = document.getElementsByClassName('Ticket');
    let strValue = document.getEle");
            WriteLiteral(@"mentById('Ticketstring');
    $(""#submitBTN"").click(function () {
        if (currentValue != maxcount) {
            event.preventDefault();
            window.alert(""請選擇正確數量的票券"")
            return;
        }
        else {
            let str = """";
            for (let item of Allticket) {
                let id = $(item).find('input')[0].value;
                let count = $(item).find('span')[1].textContent;
                if (count != 0) {
                    str += `${id}:${count}#`;
                }
            }
            strValue.value = str;
        }
    })
</script>
<script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSelectTicketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591