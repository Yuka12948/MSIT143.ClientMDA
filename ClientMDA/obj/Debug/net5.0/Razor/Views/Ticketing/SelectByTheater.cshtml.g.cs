#pragma checksum "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca7cba305dddde04e537ae17fbbc9ad789c15d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_SelectByTheater), @"mvc.1.0.view", @"/Views/Ticketing/SelectByTheater.cshtml")]
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
#line 1 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca7cba305dddde04e537ae17fbbc9ad789c15d6", @"/Views/Ticketing/SelectByTheater.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_SelectByTheater : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cyborg/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Ticketing/4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
  
    DateTime today = DateTime.Now.Date;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dca7cba305dddde04e537ae17fbbc9ad789c15d65246", async() => {
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
        /*       height: 100%;*/
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
        border-width: 2px;
        border-color: #FF359A;
        cursor: pointer;
    }

    .rou");
            WriteLiteral(@"nd .num {
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
        margin-top: 12px;
        text-align: left;
        padding: 8px;
    }

    .bigline {");
            WriteLiteral(@"
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

    .screen {
        width: 90px;
        height: 90px;
        border-radius: 50%;
   ");
            WriteLiteral(@"     cursor: pointer;
        display: inline-block;
        margin: 10px 15px;
        background-color: transparent;
        color: rgb(255, 255, 255);
        border: 1px solid transparent;
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
        }
</style>


<div id=""preloder"">
    <div class=""loader""></div>
</div>

<section class=""container pt-5 pb-2"">
    <div class=""text-center pt-2""><h2>電影院名稱</h2></div>
    <div class=""row pt-2"">
        <div class=""col-2""></div>
        <div class=""col-8 text-center"">電話 : <span>0912345678</span>   地址 : <span>台中市圈圈區叉叉路12街6巷8號10樓</span></div>
        <div class=""col-2""></div>
    </div>
</section>

<br />
<div class=""bigline""></div>
<br />

<div class=""fo");
            WriteLiteral(@"rm-group pt-3 pb-1"">
    <div class=""row"">
        <div class=""col-1""><div class=""swiper-button-prev"" style=""background-color:#070720"" id=""date-prev""></div></div>
        <div class=""col-10"">
            <div class=""swiper mySwiper"">
                <div class=""swiper-wrapper"">
");
#nullable restore
#line 196 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                      
                        DateTime date = today.AddDays(1.0);

                        for (int i = 0; i < 14; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide text-center border border-2 pr-3 date justify-content-center\">\r\n                                <br />\r\n                                <i class=\"d-block pt-1 pl-1\"> ");
#nullable restore
#line 203 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                                                         Write(date.ToString("dddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block\"> ");
#nullable restore
#line 204 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                                               Write(date.ToString("dd" + " 號"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block pb-1\"> ");
#nullable restore
#line 205 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                                                    Write(date.ToString("MM" + " 月"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <br />\r\n                            </div>\r\n");
#nullable restore
#line 208 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"

                            date = date.AddDays(1.0);
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""col-1""><div class=""swiper-button-next"" style=""background-color:#070720"" id=""date-next""></div></div>
    </div>
</div>

<br />
<div class=""bigline""></div>
<br />

<section class=""container-xl pt-2"">
    <div class=""row"" style=""min-height:30vh"">
        <div class=""col-1""><div class=""swiper-button-prev"" style=""background-color:#070720"" id=""pic-prev""></div></div>
        <div class=""col-10 bg-opacity-25"">
            <div class=""swiper myPic"">
                <div class=""swiper-wrapper"">
");
#nullable restore
#line 229 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                      
                        for (int i = 0; i < 10; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide pr-2\">\r\n                                <br />\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dca7cba305dddde04e537ae17fbbc9ad789c15d613921", async() => {
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
            WriteLiteral("\r\n                                <p>moviename</p>\r\n                            </div>\r\n");
#nullable restore
#line 237 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                        }


                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""col-1""><div class=""swiper-button-next"" style=""background-color:#070720"" id=""pic-next""></div></div>
    </div>
    <div class=""row justify-content-center pt-4"">
        <button type=""button"" class=""btn btn-secondary btn-sm"" id=""InfoBtn"">電影資訊</button>
    </div>
    <div class=""row text-center"">
        <div class=""col-3""></div>
        <div class=""col-6 MovieInfoBox"">
            <div class=""grade"">普遍級</div>
            <div class=""datebox m-auto mt-2"">片長 時間 上應日期</div>
            <div class=""staff p-1"">導 演：<span>崔國熙</span></div>
            <div class=""staff"">演 員：<span>柳承龍，廉晶雅，邕聖祐，朴世阮，夏賢尚，金觰璘</span></div>
            <div class=""Infotext"">《雞不可失》柳承龍與《天空之城》廉晶雅主演，老婆竟要我幫她尋找學生時期的初戀？人生中最閃耀的禮物，每個瞬間都能成為美妙樂章！影片在每個重要轉折時刻，以音樂劇的形式呈現，是一部讓人看了會感到幸福的電影。世妍（廉晶雅飾）為了木訥的丈夫振奉（柳承龍飾）和孩子奉獻一切，某天她卻發現自己時日無多。不知該如何面對接下來的日子的世妍，她所想要的最後的生日禮物竟是尋找自己的初戀，面對這荒唐的要求，即使振奉百般不願，最後仍陪著妻子踏上尋找初戀之旅。總是爭吵不休的夫妻倆，在旅程中想起他們曾閃耀無比的過去，珍貴的回憶一個一個地湧現……究竟世妍能否找到自己的初戀呢？他們的旅程能順利結束嗎");
            WriteLiteral(@"？影片中的音樂選自韓國1970年代至2000年代耳熟能詳的大眾音樂，至今在韓綜、韓劇中也常出現這些歌曲，臺灣觀眾也一定不陌生，包括「韓國搖滾教父」申重鉉的〈美人〉、「國民歌王」李文世的〈早鳥優惠〉〈無法預測的人生〉〈單身禮讚〉〈哀愁〉、Toy的〈熱情的告別〉、李承哲的〈睡不著的夜裡〉〈不要說再見〉、林炳秀的〈冰淇淋之戀〉、李笛的〈幸好有你〉等令人感到幸福的樂曲！柳承龍對於邕聖祐在《人生真美麗》的表現讚譽有加，甚至推薦他一起參演新作《鄭家牧場（網譯片名）》，柳承龍表示：「當時在《鄭家牧場》中有個角色還未找到適合的演員來詮釋時，我就向製作團隊推薦了邕聖祐，他在拍攝現場的態度真的很好，也十分努力，表現得非常好，讓整個團隊都很開心！」邕聖祐對此也感激表示：「真的非常感謝柳承龍前輩，當時真的每天都心懷感激地進行拍攝！」…………（影片資訊由【開眼電影網】提供）</div>
        </div>
        <div class=""col-3""></div>
    </div>
</section>

<br />
<div class=""bigline""></div>
<br />

<div class=""form-group"">
    <div>
        <div class=""row"">
            <div class=""col-2""></div>
            <div class=""col-8 text-center"">
                <div class=""versionList m-auto"">
                    <div class=""version addselect"" data=""0"">數位</div>
                    <div class=""version"" data=""1"">IMAX</div>
                    <div class=""version"" data=""2"">3D</div>
                    <div class=""version"" data=""3"">4DX</div>
                    <div class=""linebox ""><div class=""line"" st");
            WriteLiteral(@"yle=""margin-left:73px"" id=""Blueline""></div></div>
                </div>
            </div>
            <div class=""col-2""></div>
        </div>
    </div>

    <div>
        <div class=""row"">
            <div class=""col-2""></div>
            <div class=""col-8 text-center"">
                <div class=""versionList m-auto"">
                    <div class=""version addselect"" data=""0"">數位</div>
                    <div class=""version"" data=""1"">IMAX</div>
                    <div class=""version"" data=""2"">3D</div>
                    <div class=""linebox ""><div class=""line"" style=""margin-left:150px"" id=""Blueline""></div></div>
                </div>
            </div>
            <div class=""col-2""></div>
        </div>
    </div>

    <div>
        <div class=""row"">
            <div class=""col-2""></div>
            <div class=""col-8 text-center"">
                <div class=""versionList m-auto"">
                    <div class=""version addselect"" data=""0"">數位</div>
                    <div cl");
            WriteLiteral(@"ass=""version"" data=""1"">IMAX</div>

                    <div class=""linebox ""><div class=""line"" style=""margin-left:220px"" id=""Blueline""></div></div>
                </div>
            </div>
            <div class=""col-2""></div>
        </div>
    </div>

    <div>
        <div class=""row"">
            <div class=""col-2""></div>
            <div class=""col-8 text-center"">
                <div class=""versionList m-auto"">
                    <div class=""version addselect"" data=""0"">數位</div>

                    <div class=""linebox ""><div class=""line"" style=""margin-left:300px"" id=""Blueline""></div></div>
                </div>
            </div>
            <div class=""col-2""></div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-12 text-center"">
");
#nullable restore
#line 329 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
              
                for (int i = 0; i < 8; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"screen\">\r\n                        <i class=\"d-block pt-3 \"> 20:00</i>\r\n                        <i class=\"d-block \"> 200座位</i>\r\n                    </div>\r\n");
#nullable restore
#line 336 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

    </div>
</div>

<br />
<div class=""bigline""></div>
<br />

<section class=""container justify-content-center mt-5"">
    <div class=""row"">
        <div class=""col-2""></div>
        <div class=""col-8 text-center"">
            <div class=""d-block mb-3"" style=""font-size:36px"">人數</div>
            <div class=""container-md mb-5"">
");
#nullable restore
#line 353 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                  
                    for (int i = 1; i <= 8; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-inline round m-2 p-2\">\r\n                            <i class=\"num\">");
#nullable restore
#line 357 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                        </div>\r\n");
#nullable restore
#line 359 "C:\Users\yikis\OneDrive\文件\MDAfont\ClientMDA\Views\Ticketing\SelectByTheater.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

        </div>
        <div class=""col-2""></div>
    </div>
</section>

<br />
<div class=""bigline""></div>
<br />

<div class=""row justify-content-center pt-4 pb-5"">
    <button type=""button"" class=""btn btn-primary"" id=""okbtn"">選擇座位</button>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dca7cba305dddde04e537ae17fbbc9ad789c15d621725", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dca7cba305dddde04e537ae17fbbc9ad789c15d622765", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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

    var swiper = new Swiper("".myPic"", {
        slidesPerView: 3,
        centeredSlides: true,
        spaceBetween: 30,
        grabCursor: true,
        navigation: {
            nextEl: ""#pic-next"",
            prevEl: ""#pic-prev"",
        }
    });


    const dots = document.getElementsByClassName(""round"");
    for (let item of dots) {
        item.addEventListener('click', () => {
            $(event.currentTarget).siblings('.select').remo");
            WriteLiteral(@"veClass('select')
            $(event.currentTarget).addClass('select')

        })
    }

    let flag = 1;
    $('#InfoBtn').click(function () {

        console.log('click');
        if (flag == 1) {
            $('.MovieInfoBox').addClass('showMovieInfoBox')
        }
        else {
            $('.MovieInfoBox').removeClass('showMovieInfoBox')
        }
        flag = -flag;
    })

    let count = 0;
    let version = document.getElementsByClassName('version');
    let line = document.getElementById('Blueline');
    for (let item of version) {
        item.addEventListener('click', function () {
            $(event.currentTarget).siblings('.addselect').removeClass('addselect')
            $(event.currentTarget).addClass('addselect')
            let movement = event.currentTarget.getAttribute('data') * 100;
            line.style.transform = `translateX(${movement}%)`;

        })
    }


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
