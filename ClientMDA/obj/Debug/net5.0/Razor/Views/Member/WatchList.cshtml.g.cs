#pragma checksum "C:\MSIT143.ClientMDA\ClientMDA\Views\Member\WatchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93bd1d3bc382e47f8d47238ef175efb292480be6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_WatchList), @"mvc.1.0.view", @"/Views/Member/WatchList.cshtml")]
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
#line 1 "C:\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93bd1d3bc382e47f8d47238ef175efb292480be6", @"/Views/Member/WatchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_WatchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\MSIT143.ClientMDA\ClientMDA\Views\Member\WatchList.cshtml"
  
    ViewData["Title"] = "WatchList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93bd1d3bc382e47f8d47238ef175efb292480be63736", async() => {
                WriteLiteral(@"
    <style>
        .swiper-slide {
            width: 120px;
            height: 180px;
            margin-right: 8px;
            background-position: center;
            background-size: cover;
            float: left;
        }

        .rating {
        }

        .card-title {
            margin: 20px 0 0 0;
            font-size: 2em;
        }

        swiper-slide {
            position: relative;
        }

        .movie-card {
            position: absolute;
            bottom: 0px;
            right: 0px;
            font-size: 0.5em;
            opacity: 0;
        }
        /*.movie-card:hover {
                opacity:1;
            }*/

        .movie-tag.BottomArea {
            bottom: 0;
            left: 0;
        }

        .movie-tag span {
            padding: 8px 8px 4px;
        }

        .swiper-slide:hover {
            filter: grayscale(90%);
            transition-duration: 0.3s;
        }

            .swiper-slide:hover .movie-");
                WriteLiteral("card {\r\n                opacity: 1;\r\n                transition-duration: 0.3s;\r\n            }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93bd1d3bc382e47f8d47238ef175efb292480be65882", async() => {
                WriteLiteral("\r\n    <h2 style=\"text-align:center\">我的片單</h2>\r\n\r\n    <div class=\"card-title\">\r\n        <p>MyWatchList-哈利波特</p>\r\n    </div>\r\n    <div class=\"swiper-container\">\r\n        <div class=\"swiper-wrapper\">\r\n\r\n            <div class=\"swiper-slide\"");
                BeginWriteAttribute("style", "\r\n                 style=\"", 1462, "\"", 1652, 3);
                WriteAttributeValue("", 1488, "background-image:", 1488, 17, true);
                WriteAttributeValue(" ", 1505, "url(\'https://m.media-amazon.com/images/M/MV5BMzkyZGFlOWQtZjFlMi00N2YwLWE2OWQtYTgxY2NkNmM1NjMwXkEyXkFqcGdeQXVyNjY1NTM1MzA", 1506, 121, true);
                WriteLiteral("@");
                WriteAttributeValue("", 1628, "._V1_FMjpg_UX1000_.jpg\')", 1628, 24, true);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.5</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">哈利波特：神秘的魔法石</p>
                </a>
            </div>
            <div class=""swiper-slide""
                 style=""background-image: url('https://m.media-amazon.com/images/M/MV5BMjE0YjUzNDUtMjc5OS00MTU3LTgxMmUtODhkOThkMzdjNWI4XkEyXkFqcGdeQXVyMTA3MzQ4MTc0._V1_FMjpg_UX834_.jpg')"">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.8</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">哈利波特：消失的密室</p>
                </a>
            </div>
            <div class=""swiper-slide""
                 style=""background-image: url('https://www.mir");
                WriteLiteral(@"anewcinemas.com/miramarimaxauro/imax/images/upload/movie/201312121120071.jpg') "">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.2</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">哈利波特：火盃的考驗</p>
                </a>
            </div>
            <div class=""swiper-slide""
                 style=""background-image: url('https://m.media-amazon.com/images/M/MV5BMTM0NTczMTUzOV5BMl5BanBnXkFtZTYwMzIxNTg3._V1_FMjpg_UX450_.jpg')"">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.7</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">哈利波特：鳳凰會的密令</p>
                </a>
            </div>
            <div class=""swiper-slide""");
                BeginWriteAttribute("style", "\r\n                 style=\"", 3681, "\"", 3858, 3);
                WriteAttributeValue("", 3707, "background-image:", 3707, 17, true);
                WriteAttributeValue(" ", 3724, "url(\'https://m.media-amazon.com/images/M/MV5BMGVmMWNiMDktYjQ0Mi00MWIxLTk0N2UtN2ZlYTdkN2IzNDNlXkEyXkFqcGdeQXVyODE5NzE3OTE", 3725, 121, true);
                WriteLiteral("@");
                WriteAttributeValue("", 3847, "._V1_.jpg\')", 3847, 11, true);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.5</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">哈利波特：死神的聖物2</p>
                </a>
            </div>
        </div>
    </div>
    <div style=""clear:both;""></div>

    <div class=""card-title"">
        <p>周末片單</p>
    </div>
    <div class=""swiper-container"">
        <div class=""swiper-wrapper"">

            <div class=""swiper-slide""
                 style=""background-image: url('https://www.sonypictures.com/sites/default/files/styles/max_560x840/public/title-key-art/bullettrain_onesheet_1400x2100_v4.jpg?itok=khOUNLFM') "">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.5</span>
                    </div>
                </div>
                <a href=""/vod");
                WriteLiteral("/3795\">\r\n                    <p class=\"movie-card\">子彈列車</p>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"swiper-slide\"");
                BeginWriteAttribute("style", "\r\n                 style=\"", 5025, "\"", 5203, 4);
                WriteAttributeValue("", 5051, "background-image:", 5051, 17, true);
                WriteAttributeValue(" ", 5068, "url(\'https://m.media-amazon.com/images/M/MV5BZWYzOGEwNTgtNWU3NS00ZTQ0LWJkODUtMmVhMjIwMjA1ZmQwXkEyXkFqcGdeQXVyMjkwOTAyMDU", 5069, 121, true);
                WriteLiteral("@");
                WriteAttributeValue("", 5191, "._V1_.jpg\')", 5191, 11, true);
                WriteAttributeValue(" ", 5202, "", 5203, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.5</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">捍衛戰士：獨行俠</p>
                </a>
            </div>
        </div>
    </div>
    <div style=""clear:both;""></div>

    <div class=""card-title"">
        <p>魔戒</p>
    </div>
    <div class=""swiper-container"">
        <div class=""swiper-wrapper"">

            <div class=""swiper-slide""
                 style=""background-image: url('https://upload.wikimedia.org/wikipedia/zh/7/74/LOTRFOTRmovie.jpg')"">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.8</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">魔戒首部曲：魔戒現身</p>
               ");
                WriteLiteral(@" </a>
            </div>
            <div class=""swiper-slide""
                 style=""background-image: url('https://upload.wikimedia.org/wikipedia/zh/2/2a/LOTRTTTmovie.jpg')"">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.2</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">魔戒二部曲：雙城奇謀</p>
                </a>
            </div>
            <div class=""swiper-slide""
                 style=""background-image: url('https://upload.wikimedia.org/wikipedia/zh/e/e3/The_Lord_of_the_Rings_-_The_Return_of_the_King_poster.jpg')"">
                <div class=""movie-list"">
                    <div class=""movie-tag BottomArea"">
                        <span class=""rating"">4.7</span>
                    </div>
                </div>
                <a href=""/vod/3795"">
                    <p class=""movie-card"">魔戒三部曲：王者再臨</p>");
                WriteLiteral("\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div style=\"clear:both;\"></div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
