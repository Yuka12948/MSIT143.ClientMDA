#pragma checksum "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4afe141babbb58f035c57b8b18a57c9f02e7b71f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_SeatMap), @"mvc.1.0.view", @"/Views/Ticketing/SeatMap.cshtml")]
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
#line 1 "C:\MDA前端\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前端\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afe141babbb58f035c57b8b18a57c9f02e7b71f", @"/Views/Ticketing/SeatMap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_SeatMap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSeatMaoViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cyborg/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Ticketing/SelectTicket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
  
    string Seat = Model.出售座位資訊seatSoldInfo;
    string[] SeatArrs = Seat.Split('@');
    int count = Model.seatCount選擇座位數量;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<link href=\"https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4afe141babbb58f035c57b8b18a57c9f02e7b71f5649", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4afe141babbb58f035c57b8b18a57c9f02e7b71f6763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    section {
        margin-top: 25px
    }

    html {
        background-color: #070720;
    }

    body {
        background-color: #070720;
    }

    .body-content {
        background-color: #070720;
    }

    .movieInfo-library {
        margin-top: 10px;
        padding: 10px;
        background-color: #1f2122;
        border-radius: 23px;
    }

    .main-button {
        padding: 50px;
    }

    .row {
        text-align: center;
    }

    .seatSample {
        margin: auto;
        text-align: center;
    }

        .seatSample .sampleName {
            height: 15px;
            color: rgb(120, 120, 120);
            font-size: 0.875rem;
            display: inline-block;
        }

        .seatSample .screen {
            width: 300px;
            color: rgb(142, 142, 142);
            border: 1px solid rgb(142, 142, 142);
            font-size: 0.75rem;
            height: 26px;
            line-height: 26px;
            margin: 0p");
            WriteLiteral(@"x auto 30px;
        }

    .seatrow .dot {
        display: inline-block;
        width: 13px;
        height: 13px;
        border-radius: 50%;
        margin: 0.2vw;
        cursor: pointer;
        background-color: rgb(255, 255, 255);
    }

    .seatrow div {
        display: block;
    }

    .seatrow .green {
    }

    .seatrow .green2 {
    }

    .seatrow .none {
        background-color: transparent;
    }

    .seatrow .saled {
        background-color: rgb(100, 100, 100);
    }

    .seatMap {
        width: 100%;
        margin: 20px auto;
        text-align: center;
    }

    .seatrow .selected {
        background-color: rgb(231, 0, 140);
    }


    .movieInfo-library {
        margin-top: 60px;
        padding: 30px;
        background-color: #070720;
        border-radius: 23px;
    }

        .movieInfo-library .item {
            border-bottom: 1px solid #27292a;
            margin-bottom: 20px;
            padding-bottom: 20px;
     ");
            WriteLiteral(@"   }


            .movieInfo-library .item ul li {
                margin-top: 15px;
            }

                .movieInfo-library .item ul li img {
                    margin-top: -30px;
                }

            .movieInfo-library .item ul li {
                display: inline-block;
                width: 16%;
            }

                .movieInfo-library .item ul li h4 {
                    font-size: 20px;
                    margin-bottom: 5px;
                    color: whitesmoke;
                    font-family: sans-serif;
                }

                .movieInfo-library .item ul li span {
                    color: #666;
                    font-size: 16px;
                    color: whitesmoke;
                    font-family: 標楷體;
                }
</style>

<div id=""preloder"">
    <div class=""loader""></div>
</div>

<section>
    <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 3427, "\"", 3441, 1);
#nullable restore
#line 155 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 3435, count, 3435, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"countValue\" />\r\n    <div class=\"movieInfo-library\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"item\">\r\n                <ul>\r\n                    <li><h4>片名</h4><span>");
#nullable restore
#line 160 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                                    Write(Model.MovieName電影名稱);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li><h4>影城</h4><span>");
#nullable restore
#line 161 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                                    Write(Model.TheaterName影城名稱);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li><h4>日期</h4><span>");
#nullable restore
#line 162 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                                    Write(Model.Date日期);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li><h4>版本</h4><span>");
#nullable restore
#line 163 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                                    Write(Model.fileVersion電影版本);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li><h4>時間</h4><span>");
#nullable restore
#line 164 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                                    Write(Model.StartTime開始時間);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li><h4>人數</h4><span>");
#nullable restore
#line 165 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                                    Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""seatSample"">
            <div class=""seatrow"">
                <div class=""dot selected""></div><div class=""sampleName"">您的座位</div>
                <div class=""dot green2""></div><div class=""sampleName"">未售出</div>
                <div class=""dot saled""></div><div class=""sampleName"">已售出</div>
                <div class=""screen"">銀幕</div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""seatMap"">
");
            WriteLiteral("                ");
            WriteLiteral("<div>\r\n                    ");
            WriteLiteral("<div class=\"seatrow\">\r\n");
#nullable restore
#line 186 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                        foreach (string seat in SeatArrs)
                        {
                            if (seat.Contains("NA"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("<div class=\"dot none\"></div>\r\n");
#nullable restore
#line 191 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                            }
                            else if (seat.Contains("||"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("</div></div><div>\r\n                                ");
            WriteLiteral("<div class=\"seatrow\">\r\n");
#nullable restore
#line 196 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                            }
                            else if (seat.Contains("saled"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("<div class=\"dot saled\"></div>\r\n");
#nullable restore
#line 200 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                            }
                            else if (seat != "")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("<div class=\"dot green\" data=\"");
#nullable restore
#line 203 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                                                          Write(seat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n");
#nullable restore
#line 204 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                     ");
            WriteLiteral("</div></div>\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afe141babbb58f035c57b8b18a57c9f02e7b71f16077", async() => {
                WriteLiteral(@"
                <div class=""main-button"" style=""color:#e75e8d"">
                    <input class=""btn btn-primary"" style=""background-color: #e75e8d; border-color: #e75e8d "" type=""submit"" id=""submitbtn"" value=""前往付款"" />
                    <input type=""hidden"" name=""MovieCode"" id=""MovieCode""");
                BeginWriteAttribute("value", " value=\"", 5979, "\"", 6007, 1);
#nullable restore
#line 211 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 5987, Model.MovieCode電影代碼, 5987, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"MovieID\" id=\"MovieID\"");
                BeginWriteAttribute("value", " value=\"", 6081, "\"", 6107, 1);
#nullable restore
#line 212 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6089, Model.MovieID電影編號, 6089, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"theaterName\" id=\"theaterName\"");
                BeginWriteAttribute("value", " value=\"", 6189, "\"", 6219, 1);
#nullable restore
#line 213 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6197, Model.TheaterName影城名稱, 6197, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"theaterName\" id=\"theaterName\"");
                BeginWriteAttribute("value", " value=\"", 6301, "\"", 6331, 1);
#nullable restore
#line 214 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6309, Model.TheaterName影城名稱, 6309, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"Date\" id=\"Date\"");
                BeginWriteAttribute("value", " value=\"", 6399, "\"", 6420, 1);
#nullable restore
#line 215 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6407, Model.Date日期, 6407, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"Time\" id=\"Time\"");
                BeginWriteAttribute("value", " value=\"", 6488, "\"", 6516, 1);
#nullable restore
#line 216 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6496, Model.StartTime開始時間, 6496, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"ticketCount\" id=\"ticketCount\"");
                BeginWriteAttribute("value", " value=\"", 6598, "\"", 6628, 1);
#nullable restore
#line 217 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6606, Model.seatCount選擇座位數量, 6606, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"theaterID\" id=\"theaterID\"");
                BeginWriteAttribute("value", " value=\"", 6706, "\"", 6734, 1);
#nullable restore
#line 218 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6714, Model.TheaterID影城編號, 6714, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"screenID\" id=\"screenID\"");
                BeginWriteAttribute("value", " value=\"", 6810, "\"", 6840, 1);
#nullable restore
#line 219 "C:\MDA前端\ClientMDA\Views\Ticketing\SeatMap.cshtml"
WriteAttributeValue("", 6818, Model.場次編號screeningId, 6818, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"seatInfo\" id=\"seatInfo\"");
                BeginWriteAttribute("value", " value=\"", 6916, "\"", 6924, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            ");
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



</section>
<script>

    (function ($) {
        $(window).on('load', function () {
            $("".loader"").fadeOut();
            $(""#preloder"").delay(20).fadeOut(""slow"");


        });
    })(jQuery);



    const dots = document.getElementsByClassName(""dot green"");
    const count = document.getElementById(""countValue"").value;
    const btnsend = document.getElementById(""submitbtn"");

    const seatInfo = document.getElementById(""seatInfo"");
    const screenID = document.getElementById(""screenID"");

    const ArrSeats = new Array();
    for (let i = 0; i < count; i++) {
        ArrSeats.push(null);
    }
    for (let item of dots) {
        item.addEventListener(""click"", seat);
    }

    function seat(e) {
        if (e.target.className == ""dot green"") {
            e.target.className = e.target.className.replace(""dot green"", ""dot selected"");
            if (ArrSeats[count - 1] != null) {
                ArrSeats[count - 1].className = ");
            WriteLiteral(@"ArrSeats[count - 1].className.replace(""dot selected"", ""dot green"");
            }
            ArrSeats.pop();
            ArrSeats.unshift(event.currentTarget);
        }
        else if (e.target.className == ""dot selected"") {
            e.target.className = e.target.className.replace(""dot selected"", ""dot green"");
            for (let i = 0; i < count; i++) {
                if (ArrSeats[i] == e.target) {
                    ArrSeats.splice(i, 1);
                    ArrSeats.push(null);
                }
            }
        }
        console.log(ArrSeats)
    }


    let seatArr = new Array();
    btnsend.addEventListener('click', () => {
        for (let i = 0; i < count; i++) {
            if (ArrSeats[i] == null) {
                event.preventDefault();
                console.log(""No"")
                window.alert(""請選擇符合數量的座位數"")
                return;
            }
            seatArr.push(ArrSeats[i].getAttribute('data'))
        }
        seatInfo.value = seatArr.join");
            WriteLiteral("(\'#\');\r\n        console.log(seatInfo.value);\r\n        \r\n    })\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSeatMaoViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
