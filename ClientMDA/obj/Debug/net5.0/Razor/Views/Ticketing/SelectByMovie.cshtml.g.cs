#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f993f5dff94b2453d063e353f38438d0eb953fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_SelectByMovie), @"mvc.1.0.view", @"/Views/Ticketing/SelectByMovie.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f993f5dff94b2453d063e353f38438d0eb953fd0", @"/Views/Ticketing/SelectByMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_SelectByMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSelectByMovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cyborg/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Ticketing/SeatMap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Sumbitform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
  
    DateTime today = DateTime.Now.Date;
    string delectors = "";
    string actor = "";



    foreach (var item in Model.Delectors)
    {
        delectors += $"{item} ";
    }

    foreach (var item in Model.Actors)
    {
        actor += $"{item} ";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f993f5dff94b2453d063e353f38438d0eb953fd05856", async() => {
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
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.css"" />
<style>
    .swiper {
        width: 100%;
        height: 100%;
    }

    .swiper-slide {
        text-align: center;
        font-size: 15px;
        background: #0b0c2a;
        color: grey;
        display: inline;
        width: 100%;
        /*height: 100%;*/
        align-items: center;
        border-radius: 50%;
        border: 1px solid #0b0c2a;
    }

    .date:hover {
        background: #FF359A;
        color: whitesmoke;
    }

    .swiper-slide img {
        display: block;
        width: 100%;
    }

        .swiper-slide img:hover {
            border-width: 5px;
            border-color: royalblue;
        }

    .round {
        background: #6C6C6C;
        border-radius: 50%;
        border-width: 2px;
        border-color: #FF359A;
        cursor: pointer;
    }

    .select {
        background: #FF359A;
        border-radius: 50%;
        border-wid");
            WriteLiteral(@"th: 2px;
        border-color: #FF359A;
        cursor: pointer;
    }

    .round .num {
        font-size: 110%;
        color: whitesmoke;
        align-items: center;
    }

    .MovieInfoBox {
        display: none;
    }

    .showMovieInfoBox {
        display: block;
    }

    .MovieInfoBox .grade {
        text-align: center;
        width: 50px;
        height: 20px;
        color: rgb(158, 158, 158);
        margin: 20px auto 20px;
        font-size: 0.75rem;
        line-height: 20px;
        border: 1px solid rgb(158, 158, 158);
        border-radius: 120px;
    }

    .MovieInfoBox .datebox {
        min-height: 30px;
        width: 100%;
        text-align: center;
    }

    .MovieInfoBox .staff {
        color: rgb(255, 255, 255);
        height: 30px;
        font-size: 0.8rem;
    }

    .MovieInfoBox .Infotext {
        color: rgb(255, 255, 255);
        line-height: 2;
        letter-spacing: 1px;
        font-size: 0.8rem;
        margin-t");
            WriteLiteral(@"op: 12px;
        text-align: left;
        padding: 8px;
    }

    .bigline {
        border: 1px solid #5B5B5B;
    }

    .versionList {
        display: block;
    }

        .versionList .version {
            display: inline-block;
            margin: 0px auto 20px;
            width: 150px;
            height: 60px;
            color: rgb(100, 100, 100);
            border-bottom: 1px solid rgb(43, 43, 43);
            line-height: 60px;
            font-size: 1.1rem;
            cursor: pointer;
        }

    .addselect {
        color: rgb(255, 255, 255) !important;
    }

    .versionList .linebox {
        width: 300px;
        margin-top: -23px;
        margin-bottom: 40px;
        z-index: 300;
    }

        .versionList .linebox .line {
            width: 150px;
            height: 6px;
            background-color: #005AB5;
            z-index: 300;
            transition: all 0.3s ease 0s;
            transform: translateX(0%);
        }

    .sc");
            WriteLiteral(@"reen {
        width: 90px;
        height: 90px;
        border-radius: 50%;
        cursor: pointer;
        margin: 10px 15px;
        background-color: transparent;
        color: rgb(255, 255, 255);
        border: 1px solid transparent;
        display: none;
    }

    .showscreen {
        display: inline-block;
    }

    .screen:hover {
        width: 90px;
        height: 90px;
        border-radius: 50%;
        cursor: pointer;
        display: inline-block;
        margin: 10px 15px;
        background-color: transparent;
        color: rgb(255, 255, 255);
        border: 1px solid #005AB5;
        background: #005AB8;
    }

    .DateTimePicker {
    }

    .MoviePicker {
    }

    .VersionPicker {
    }

    .ScreenPicker {
    }

    .ManCount {
    }

    .DateItemSelect {
        background: #FF359A;
        border-color: #FF359A;
        cursor: pointer;
        color: white !important;
    }

    .MovieItemSelect {
        background-co");
            WriteLiteral(@"lor: #2894FF;
        border-radius: 0 !important;
        border-color: #005AB8;
        cursor: pointer;
        filter: contrast(155%);
        padding: 0 !important;
        border-width: 3px;
    }

    .ScreenItemSelect {
        background: #005AB8;
        border-color: #005AB8;
        cursor: pointer;
        color: white !important;
    }
</style>

<div id=""preloder"">
    <div class=""loader""></div>
</div>

<section class=""container pt-5 pb-2"">
    <div class=""text-center pt-2""><h2>");
#nullable restore
#line 236 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                 Write(Model.theater.電影院名稱theaterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n    <div class=\"row pt-2\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-8 text-center\">電話 : <span>");
#nullable restore
#line 239 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                             Write(Model.theater.電話phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> || 地址 : <span>");
#nullable restore
#line 239 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                                                                         Write(Model.theater.地址address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n</section>\r\n\r\n<div class=\"container pt-5\">\r\n    <div class=\"text-center pt-2\"><h2>");
#nullable restore
#line 245 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                 Write(Model.movie.電影編號movie.中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n    <div class=\"text-center pt-2\"><h4>");
#nullable restore
#line 246 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                 Write(Model.movie.語言編號language.語言名稱languageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></div>
    <div class=""row justify-content-center pt-4"">
        <button type=""button"" class=""btn btn-secondary btn-sm"" id=""InfoBtn"">電影資訊</button>
    </div>
    <div class=""row text-center"">
        <div class=""col-3""></div>
        <div class=""col-6 MovieInfoBox"" id=""MovieInfotext"">
            <div class=""grade"">");
#nullable restore
#line 253 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                          Write(Model.movie.電影編號movie.電影分級編號rating.分級級數ratingLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"datebox m-auto mt-2\">片長:");
#nullable restore
#line 254 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                           Write(Model.movie.電影編號movie.片長runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 上應日期:");
#nullable restore
#line 254 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                                                                 Write(Model.movie.電影編號movie.上映日期releaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"staff d-block p-1\">導 演：<span>");
#nullable restore
#line 255 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                                Write(delectors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            <div class=\"staff d-block\">演 員：<span>");
#nullable restore
#line 256 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                                            Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            <div class=\"Infotext\">");
#nullable restore
#line 257 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                             Write(Model.movie.電影編號movie.劇情大綱plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"col-3\"></div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<div class=\"bigline\"></div>\r\n<br />\r\n\r\n\r\n\r\n<div id=\"DatePicker\">\r\n    ");
#nullable restore
#line 270 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
Write(await Component.InvokeAsync("SelectDate", 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"ScreenPicker\">\r\n");
            WriteLiteral("</div>\r\n\r\n<div id=\"SeatCountPicker\">\r\n    ");
#nullable restore
#line 278 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
Write(await Component.InvokeAsync("SelectSeat"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"row justify-content-center pt-4 pb-5\">\r\n    <button type=\"button\" class=\"btn btn-primary\" id=\"okbtn\">選擇座位</button>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f993f5dff94b2453d063e353f38438d0eb953fd016886", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"ScreenID\" name=\"ScreenID\" value=\"-1\" />\r\n    <input type=\"hidden\" id=\"Count\" name=\"Count\" value=\"-1\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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

<script src=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.js""></script>
<script>
    (function ($) {
        $(window).on('load', function () {
            $("".loader"").fadeOut();
            $(""#preloder"").delay(20).fadeOut(""slow"");
        });
    })(jQuery);

    /*日期選擇*/
    var swiper = new Swiper("".mySwiper"", {
        slidesPerView: 6,
        centeredSlides: true,
        spaceBetween: 30,
        grabCursor: true,
        navigation: {
            nextEl: ""#date-next"",
            prevEl: ""#date-prev"",
        },
    });

    let flag = 1;/*是否開啟資訊欄位*/
    let movement = 0;/*藍線飄移距離*/

    let line = document.getElementById('Blueline');/*那條藍線*/
    let version = document.getElementsByClassName('version'); /*廳種名稱*/
    let datePicker = document.getElementsByClassName('DateTimePicker');/*選擇日期*/
    let screenPicker = document.getElementsByClassName('ScreenPicker');/*選擇場次時間*/
    datePicker[0].classList.add('DateItemSelect')
    const dots = document.getElementsBy");
            WriteLiteral(@"ClassName(""round""); /*選人數的點*/

    let count = 0;

    /*藍線移動*/
    for (let item of version) {
        item.addEventListener('click', function () {
            $(event.currentTarget).siblings('.addselect').removeClass('addselect')
            $(event.currentTarget).addClass('addselect')
            let movement = event.currentTarget.getAttribute('data') * 100;
            line.style.transform = `translateX(${movement}%)`;
        })
    }

    AddClickEvent(datePicker, ""DateItemSelect"");
    AddClickEvent(dots, ""select"");

    /*選擇日期*/
    $('.DateTimePicker').click(function () {
        let dataValue = event.currentTarget.getAttribute('data');
        findMovie(dataValue);
    });

    /*選擇人數*/
    $('.ManCount').click(function () {
        let count = event.currentTarget.getAttribute('value')
        $('#Count').val(count)
    })

    /*電影資訊按鈕*/
    $('#InfoBtn').click(function () {
        if (flag == 1) {
            $('.MovieInfoBox').addClass('showMovieInfoBox')
       ");
            WriteLiteral(@" }
        else {
            $('.MovieInfoBox').removeClass('showMovieInfoBox')
        }
        flag = -flag;
    })

    /*透過日期載入場次(日期字串)*/
    async function findMovie(datepara) {
        $(""#ScreenPicker"").empty();
        let _url = await '");
#nullable restore
#line 362 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Ticketing\SelectByMovie.cshtml"
                     Write(Url.Action("ComponentSelectScreen2", "Ticketing"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + `?data=${datepara}`;
                $.ajax({
                    type: ""GET"",
                    url: _url,
                    success: function (result) {
                        /*清除並重新載入*/
                        $('#ScreenID').val(-1)
                        $('.VersionPicker').off('click');
                        $('.ScreenPicker').off('click');
                        $(""#ScreenPicker"").html(result);
                        /*綁定事件*/
                        screenPicker = document.getElementsByClassName('ScreenPicker');
                        version = document.getElementsByClassName('VersionPicker');
                        line = document.getElementById('Blueline');

                        AddClickEvent(screenPicker, ""ScreenItemSelect"")
                        $('.VersionPicker').click(function () {
                            let currentdata = event.currentTarget.getAttribute('data');
                            screenPicker = document.getElementsByClassName('ScreenPicker')");
            WriteLiteral(@"
                            for (let item of screenPicker) {
                                if (item.getAttribute('data') == currentdata) {
                                    $(item).addClass('showscreen')
                                } else {
                                    $(item).removeClass('showscreen')
                                }
                            }
                        })

                        /*載入畫面功能*/
                        version[0].classList.add('addselect')
                        for (let item of version) {
                            item.addEventListener('click', function () {
                                $(event.currentTarget).siblings('.addselect').removeClass('addselect')
                                $(event.currentTarget).addClass('addselect')
                                movement = event.currentTarget.getAttribute('data') * 100;
                                line.style.transform = `translateX(${movement}%)`;
                  ");
            WriteLiteral(@"          })
                        }
                        $('.ScreenPicker').click(function () {
                            let Sid = event.currentTarget.getAttribute('value');
                            $('#ScreenID').val(Sid);
                        })
                    },
                });
    }


    StartUp();

    /*方法初始*/
    function StartUp() {
        findMovie(datePicker[0].getAttribute('data'));

    }

    /*方法 click改變CSS樣式*/
    function AddClickEvent(group, classname) {
        for (let item of group) {
            item.addEventListener('click', function () {
                $(event.currentTarget).siblings(`.${classname}`).removeClass(`${classname}`)
                $(event.currentTarget).addClass(`${classname}`)
            })
        }
    }

    /*確認按鈕*/
    $('#okbtn').click(function () {
        let ScreenID = $('#ScreenID').val();
        let Count = $('#Count').val();
        console.log(Count);
        console.log(ScreenID);
        if (Scr");
            WriteLiteral("eenID == -1 || Count == -1) {\r\n            window.alert(\"請選擇必要資訊\");\r\n        } else {\r\n            $(\'#Sumbitform\').submit();\r\n        }\r\n    })\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSelectByMovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
