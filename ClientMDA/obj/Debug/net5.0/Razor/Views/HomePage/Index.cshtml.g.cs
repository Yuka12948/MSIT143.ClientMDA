#pragma checksum "C:\Users\Student\Desktop\MDA專題\AAAA\ClientMDA\Views\HomePage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971266540992cf967b0686b931e845684e707428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Index), @"mvc.1.0.view", @"/Views/HomePage/Index.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\MDA專題\AAAA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\MDA專題\AAAA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971266540992cf967b0686b931e845684e707428", @"/Views/HomePage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomePage/banner.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/HomePage/banner.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Student\Desktop\MDA專題\AAAA\ClientMDA\Views\HomePage\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "971266540992cf967b0686b931e845684e7074284665", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>M.D.A.觀享時刻</title>
    <meta name=""author"" content=""MSIT143 01陳苡錚 06王婷薇 11廖家毅 13李沛軒 16洪暐婷 18游曉雯 20鄭凱"" />
    <meta name=""keywords"" content=""M.D.A.觀享時刻,M.D.A.,MDA,觀享時刻,電影訂票,電影評論,訂票,評論,電影,電視劇,動畫"" />
    <meta name=""date"" content=""2022/06/15"" />
    <meta name=""description"" content=""M.D.A. 為 Movie, Drama, Anime 的縮寫。希望藉由這個整合平台，讓最完整的電影、電視劇及動畫相關資訊都能快速方便的被使用者查找、觀賞及討論。"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1"" />

    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "971266540992cf967b0686b931e845684e7074285881", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "971266540992cf967b0686b931e845684e7074287771", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <!-- banner -->
    <div class=""swiper mySwiper"">
        <div class=""swiper-wrapper"">

            <div class=""swiper-slide"" id=""img-wrapper"">
                <img src=""https://movies.yahoo.com.tw/x/r/w800/i/o/production/movie-photos/November2021/bdvDlvdXUbOvcR5pM7dw-1620x1080.jpg"" alt=""兜兜風"">

                <div class=""hangposter""><img");
                BeginWriteAttribute("class", " class=\"", 2609, "\"", 2617, 0);
                EndWriteAttribute();
                WriteLiteral(" src=\"https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg\" alt=\"小獅子王\"></div>\r\n                <div class=\"content-banner\" id=\"content\">\r\n\r\n");
                WriteLiteral(@"                    <span class=""fa fa-play-circle"" id=""play""></span>
                    <div id=""box-banner"">
                        <ul class=""listb"">
                            <li> <a href=""https://www.imdb.com/video/vi2140520985/?playlistId=tt14073780&ref_=tt_ov_vi"" id=""imgbanner"" class=""imgbanner"">野生幼獅實際拍攝X超擬真視覺特效，神級表現細膩真實情感</a></li>
                            <li>觀看預告片</li>
                        </ul>

                    </div>

                </div>


            </div>

            <div class=""swiper-slide""><img src=""https://movies.yahoo.com.tw/x/r/w800/i/o/production/movie-photos/September2022/PEQ1LzNrvP4SDV94mrI3-2168x1080.jpg"" alt=""微笑""></div>
            <div class=""swiper-slide""><img src=""https://movies.yahoo.com.tw/x/r/w800/i/o/production/movie-photos/August2022/YCDYyJp4rD0hSJLfm2kp-1280x720.jpg"" alt=""小獅子王""></div>
            <div class=""swiper-slide""><img src=""https://movies.yahoo.com.tw/x/r/w800/i/o/production/movie-photos/June2022/UYgvPUSEOxuopne8TVF7-1920x1080.jpg"" al");
                WriteLiteral(@"t=""鱷魚歌王""></div>
            <div class=""swiper-slide""><img src=""https://movies.yahoo.com.tw/x/r/w800/i/o/production/movie-photos/September2022/L6EqLNvBtcosacyfFWej-1620x1080.jpg"" alt=""樂透大作戰""></div>
        </div>
        <div class=""swiper-button-next""></div>
        <div class=""swiper-button-prev""></div>
        <div class=""swiper-pagination""></div>
    </div>


    <!-- Rate -->

    <div class=""region"">
        <div class=""row"">
            <div class=""col-lg-8 col-md-8 col-sm-8"">
                <div class=""section-title"">
                    <h4>新片排行</h4>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-4"">
                <div class=""btn__all"">
                    <a href=""#"" class=""primary-btn"">View All <span class=""arrow_right""></span></a>
                </div>
            </div>
        </div>
    </div>

    <div class=""swiper mySwiperRATE"">
        <div class=""swiper-wrapper"">

            <div class=""swiper-slide"">
          ");
                WriteLiteral(@"      <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""");
                WriteLiteral(@"fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">");
                WriteLiteral(@"
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
    ");
                WriteLiteral(@"                            </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
    ");
                WriteLiteral(@"                            <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
              ");
                WriteLiteral(@"      </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt140737");
                WriteLiteral(@"80/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button");
                WriteLiteral(@">
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
         ");
                WriteLiteral(@"                   <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" sr");
                WriteLiteral(@"c=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                       ");
                WriteLiteral(@"         <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                ");
                WriteLiteral(@"                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
         ");
                WriteLiteral(@"           </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8");
                WriteLiteral(@"E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
      ");
                WriteLiteral(@"                      <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div> <div class=""swiper-slide"">
                <div class=""box"">
                    <div class=""img-wrapper"">
                        <img class=""blur"" src=""https://movies.yahoo.com.tw/i/o/production/movies/August2022/hL4SXcrb1Solds7mscX1-1080x1543.jpg"" alt=""小獅子王"">
                        <div class=""content fade"">
                            <ul class=""list"">
                                <li><a href=""https://movies.yahoo.com.tw/movietime_result.html/id=13925"">購      票</a></li>
                                <li><a href=""https://movies.yahoo.com.tw/movieinfo_main/%E5%B0%8F%E7%8D%85%E5%AD%90%E7%8E%8B-king-13925"">電影介紹</a></li>
                                <li><a href=""https://www.imdb.com/title/tt14073780/?ref_=fn_al_tt_1"">加入片單</a></li>
                            </ul>
                        </div>
             ");
                WriteLiteral(@"       </div>
                    <div class=""info_box"">
                        <div class=""star"">
                            <div class=""showRate"">
                                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                                <span class=""starRate"">4.5</span>
                                <button class=""ToRate"">
                                    <i class='far fa-star' id=""ToR""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""info"">
                        <h5>小獅子王</h5>
                    </div>
                    <div class=""AddList"">
                        <button class=""AddListBtn"">
                            <div class=""fa fa-plus"" id=""plus""> &emsp;Watchlist</div>
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <div class=""swi");
                WriteLiteral("per-paginationR\" id=\"swiper-paginationR\"></div>\r\n    </div>\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "971266540992cf967b0686b931e845684e70742828565", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
