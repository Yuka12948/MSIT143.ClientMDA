#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f085af89194b2e3e0f72a31e2b3492628e72eae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_會員評論), @"mvc.1.0.view", @"/Views/Comment/會員評論.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f085af89194b2e3e0f72a31e2b3492628e72eae", @"/Views/Comment/會員評論.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_會員評論 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Comment/mem01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "我的評論", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
  
    ViewData["Title"] = "會員評論";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
<style>
    .row d-flex justify-content-center {
        margin:0;
    }
    .mem_rate {
        float: right;
        
    }
    .mem_info{
        float:left;
    }
    .mem_line {
        border: solid 1px white;
    }
    .report:hover {
        background-color: #e53637;
    }

</style>
    ");
            }
            );
            WriteLiteral(@"

<section class=""blog-details spad"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""blog__details__title"">
                    <h2>捍衛戰士：獨行俠</h2>
                    <h3>不只關於速度與飛翔的渴望<br />也與我們的悔恨以及所需要的勇氣有關</h3><hr class=""mem_line""/>
                    <h6>
                        <span class=""mem_info"">
                            <span style=""color:white"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9f085af89194b2e3e0f72a31e2b3492628e72eae6983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f085af89194b2e3e0f72a31e2b3492628e72eae8212", async() => {
                WriteLiteral("會員 Rainbow");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </span>
                            <span> - 2022/07/25  於<span style=""color:white""> 欣欣秀泰影城</span> 觀看</span>

                        </span>
                        <span class=""mem_rate"" style=""color: #e89f12;"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-half-o""></i>
                        </span>
                    </h6>
                </div>
            </div>
            <div class=""col-lg-12"">
                <div class=""blog__details__pic"">
                    <img src=""https://im.marieclaire.com.tw/m800c533h100b0/assets/mc/202205/628C963D8F7801653380669.jpeg""");
            BeginWriteAttribute("alt", " alt=\"", 1896, "\"", 1902, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""blog__details__content"">
                    <div class=""blog__details__text"">
                        <p>
                            湯姆．克魯斯（Tom Cruise）的《捍衛戰士：獨行俠》（Top Gun: Maverick）在各地試映過後，隨即得到了一片熱烈好評，
                            並被不少人稱為一定要進戲院欣賞的超級大片。而且這部電影被稱讚的，還不只是真實感十足的空戰場面，甚至就連角色塑造
                            等環節，也同樣獲得了不少影評讚美。究竟，這部眾人期待已久的電影魅力何在？又是否真的符合這樣的優秀評價？
                        </p>
                    </div>
                    <div class=""blog__details__item__text"">
");
            WriteLiteral("                        <img src=\"https://im.marieclaire.com.tw/m800c533h100b0/assets/mc/202205/628C96458963A1653380677.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 2696, "\"", 2702, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <p>
                            關於《捍衛戰士：獨行俠》，你首先得知道的是，就算你沒看過當年讓湯姆．克魯斯一舉成為全球超級巨星的《捍衛戰士》（Top Gun），
                            又或者是就算過去看過，但如今已印象不深，基本上全都可以毫無窒礙地進入到《捍衛戰士：獨行俠》的故事裡。
                        </p>
                    </div>
                    <div class=""blog__details__item__text"">
");
            WriteLiteral("                        <img src=\"https://im.marieclaire.com.tw/m800c533h100b0/assets/mc/202205/628C9650831071653380688.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 3230, "\"", 3236, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <p>
                            不騙你，《捍衛戰士：獨行俠》確實是一部為了大銀幕而生的電影。不管是那些讓演員實際登上戰鬥機拍攝的空戰畫面，
                            又或者是震撼感十足的飛行音效，全都令人感受到一股血脈賁張的效果，因此只要是在戲院看過本片，便會知道像是這樣
                            的體驗，絕對難以在家裡的觀影環境中重現，更別說要是你看的是IMAX版所能感受到的臨場感了。
                        </p>
                    </div>
                    <div class=""blog__details__item__text"">
");
            WriteLiteral("                        <img src=\"https://im.marieclaire.com.tw/m800c533h100b0/assets/mc/202205/628C965A7CAF41653380698.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 3805, "\"", 3811, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <p>
                            但《捍衛戰士：獨行俠》讓人佩服的地方，其實還不只是那些確實精采絕倫的空戰場面，而是在於這部片既能在懷舊方面滿足
                            《捍衛戰士》的影迷，同時卻也顧及了主角的發展，在適度加入一些回憶片段的情況下，便能讓沒看過前作的觀眾也能清楚本
                            作某些角色的相關背景，甚至是對他們的內心狀況有一定程度的理解，接著再透過本集的劇情，讓你了解到角色之間的衝突，
                            甚至是他們自己與自己的內在衝突。
                        </p><hr />
                        <p>
                            是的，如果從這樣的角度來看，《捍衛戰士：獨行俠》所要講述的，其實是一則與罪惡感有關的故事，描繪我們如何緊緊地抓著自己
                            最為悔恨的事，就這麼在不知不覺中度過一年又一年，縱使表面上看起來像是什麼事也沒有，但其實只有你自己才最為清楚，有些事
                            情就是讓你從此不敢放手去做，讓你有著各種說不出口來的顧忌，就連想要解釋的勇氣，或許也根本難以鼓起。
                        </p><hr />
                        <p>
                            事實上，那與你堅不堅強、強不強悍根本一點關係也沒有。就是有些往事，會讓你從此自願當個「獨行俠」，不想再把任何可能會牽
                            連到他人的事情給扛在肩上，因此使得勇氣與逃避之間的界線，也就這麼模糊了起來，讓一切變得像是一體兩面的存在。
                        </p><hr />
                        <p>
                            從表面上來看，這是一種樂於獨挑大樑的氣魄，但在更深一點的層面，這則是一種畏懼與別人建");
            WriteLiteral(@"立深厚關係的逃避，不管是並肩作戰
                            的夥伴，又或者是攜手並行的伴侶，都有可能是你在獨行了許久以後，已經不敢再去承受，甚至也忘記該要如何接納的關係。
                        </p><hr />
                        <p>
                            只是，我們究竟該懲罰自己多久？這樣的行為，是否對於某些深愛你的人來說，也同樣造成了一種不可磨滅的傷害？
                        </p><hr />
                        <p>
                            像是以上的這些問題，其實全在《捍衛戰士：獨行俠》中有所觸及，因此也使這部電影除了帶來緊張刺激的高度娛樂性以外，同時也
                            在角色塑造上，得以史觀眾心生共鳴，甚至讓我們對他們的安危因此更感關心，最終則在兩者之間達成了相輔相成的結果，就這麼帶
                            來一場令人心滿意足的觀影體驗。
                        </p><hr />
                        <p>
                            說真的，作為一部有這麼多熱情支持者的經典續集，要在影評與觀眾之間都能獲得好評，可不是一件那麼簡單的事。但《捍衛戰士：獨
                            行俠》確實大有可能完成這項不可能的任務，甚至還很有機會讓未曾看過《捍衛戰士》的人，會在看了《捍衛戰士：獨行俠》以後，回
                            頭去接觸這部在許多地方都可以稱之為「文化現象」，熱潮遠超過一般電影的通俗經典，進而使《捍衛戰士：獨行俠》那些關於世代交
                            替的元素，就這麼拓展至銀幕外頭，來到了我們所身處的觀眾席之間。
                        </p><hr />
                        <p>
                            但在此");
            WriteLiteral(@"之前，不管你到底有沒有看過《捍衛戰士》，都暫且不用擔心。你所需要做的，就是踏入戲院，然後隨著銀幕上的角色們一同飛
                            向危險地帶，感受他們對於速度與飛翔的渴望，以及那些我們或許也曾有過的悔恨，然後從中獲得某些勇氣。
                        </p><hr />
                        <p>
                            不是所有事情都只能獨行。而擺脫悔恨的機會，有時也只能靠自己爭取──在看完《捍衛戰士：獨行俠》後，你或許會這麼發現。
                        </p><hr />
                    </div>

                    <div class=""blog__details__tags"">
                        <a href=""#"">#捍衛戰士2</a>
                        <a href=""#"">#阿湯哥好帥</a>
                        <a href=""#"">#IMAX</a>
                    </div>

                    <div style=""margin: 10px 0 10px 0; border: solid 1px rgba(0,0,0,0)"">
                        <span class=""mem_info"">
                            <span style=""color:white"">發佈時間</span>
                            <span> - 2022/07/26 21:52</span>
                        </span>

                        <div class=""blog__details__social"" style=""float:right"">
                            <a href=""#"" class=""facebook""><");
            WriteLiteral(@"i class=""fa fa-facebook-square""></i> Facebook</a>
                            <a href=""#"" class=""pinterest""><i class=""fa fa-pinterest""></i> Pinterest</a>
                            <a href=""#"" class=""linkedin""><i class=""fa fa-linkedin-square""></i> Linkedin</a>
                            <a href=""#"" class=""twitter""><i class=""fa fa-twitter-square""></i> Twitter</a>
                        </div><hr />
                    </div>



                    <div class=""blog__details__btns"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""blog__details__btns__item"">
                                    <h5>
                                        <a href=""#""><span class=""arrow_left""></span> 上一篇評論 </a>
                                    </h5>
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""blog");
            WriteLiteral(@"__details__btns__item next__btn"">
                                    <h5>
                                        <a href=""#"">下一篇評論 <span class=""arrow_right""></span></a>
                                    </h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""blog__details__comment"">
                        <h4>3則留言</h4>
                        <div class=""blog__details__comment__item"">
                            <div class=""blog__details__comment__item__pic"">
                                <img src=""img/blog/details/comment-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 8576, "\"", 8582, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog__details__comment__item__text"">
                                <span>Sep 08, 2020</span>
                                <h5>會員 John Smith</h5>
                                <p>
                                    你寫的評論真棒!
                                </p>
                                <span>102 <i class=""fas fa-thumbs-up""></i></span>
                                <a href=""#"">讚</a>
                                <a class=""report"" href=""#"">檢舉</a>
                            </div>
                        </div>
                        <div class=""blog__details__comment__item blog__details__comment__item--reply"">
                            <div class=""blog__details__comment__item__pic"">
                                <img src=""img/blog/details/comment-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 9459, "\"", 9465, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog__details__comment__item__text"">
                                <span>Sep 08, 2020</span>
                                <h5>會員 Elizabeth Perry</h5>
                                <p>
                                    推薦4DX 效果真D讚 必看一次
                                </p>
                                <span>14 <i class=""far fa-thumbs-up""></i></span>
                                <a href=""#"">讚</a>
                                <a class=""report"" href=""#"">檢舉</a>
                            </div>
                        </div>
                        <div class=""blog__details__comment__item"">
                            <div class=""blog__details__comment__item__pic"">
                                <img src=""img/blog/details/comment-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 10318, "\"", 10324, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog__details__comment__item__text"">
                                <span>Sep 08, 2020</span>
                                <h5>會員 Adrian Coleman</h5>
                                <p>
                                    我三刷了!!! 內牛滿麵
                                </p>
                                <span>21 <i class=""far fa-thumbs-up""></i></span>
                                <a href=""#"">讚</a>
                                <a class=""report"" href=""#"">檢舉</a>
                            </div>
                        </div>
                    </div>
                    <div class=""blog__details__form"">
                        <h4>你的留言</h4>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f085af89194b2e3e0f72a31e2b3492628e72eae20935", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                                    <input type=\"text\" placeholder=\"Name\">\r\n                                </div>\r\n");
                WriteLiteral(@"                                <div class=""col-lg-12"">
                                    <textarea placeholder=""Message""></textarea><hr />
                                    <button type=""submit"" class=""site-btn"">送出</button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<script src=\'https://kit.fontawesome.com/a076d05399.js\' crossorigin=\'anonymous\'></script> ");
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
