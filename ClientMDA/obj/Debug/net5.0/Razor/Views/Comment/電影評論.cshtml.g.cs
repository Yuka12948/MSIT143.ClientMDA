#pragma checksum "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab57a3f0390763636901e1abceecf513a1ede63e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_電影評論), @"mvc.1.0.view", @"/Views/Comment/電影評論.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab57a3f0390763636901e1abceecf513a1ede63e", @"/Views/Comment/電影評論.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_電影評論 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientMDA.ViewModels.CCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fontawesome-free-6.2.0-web/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/fontawesome-free-6.2.0-web/all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
  
    ViewData["Title"] = "電影評論";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .row d-flex justify-content-center {
            margin: 0;
        }

        .mem_rate {
            float: right;
            padding-top: 5px;
        }

        .mem_info {
            float: left;
        }

        .mem_line {
            border: solid 1px white;
        }

        .report:hover {
            background-color: #e53637;
        }

        .img-fluid.rounded-circle {
            height: 30px !important;
            margin: 0 5px 0 0;
        }

        .report:hover {
            background-color: #e53637 !important;
        }

        .unLike:hover {
            background-color: #F5AB00 !important;
        }

        .blog__details__btns {
            margin-bottom: 10px;
        }
    </style>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab57a3f0390763636901e1abceecf513a1ede63e6898", async() => {
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
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab57a3f0390763636901e1abceecf513a1ede63e8111", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<section class=\"blog-details spad\">\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"blog__details__title\">\r\n");
            WriteLiteral("                    <div class=\"anime__details__title\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1408, "\"", 1471, 1);
#nullable restore
#line 60 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
WriteAttributeValue("", 1415, Url.Action("電影介紹","Movie", new {id= Model.電影編號movieId}), 1415, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h3><i class=\"fa-solid fa-film\"></i> ");
#nullable restore
#line 61 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                                            Write(Model.中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        </a>\r\n                    </div>\r\n");
            WriteLiteral("                    <h4>");
#nullable restore
#line 65 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                   Write(Model.評論標題commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><hr class=\"mem_line\" />\r\n                    <h6>\r\n                        <span class=\"mem_info\">\r\n");
            WriteLiteral("                            <span style=\"color:white\">\r\n");
#nullable restore
#line 70 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                 if (Model.會員照片image != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 2071, "\"", 2131, 2);
            WriteAttributeValue("", 2077, "https://localhost:44381/images/Member/", 2077, 38, true);
#nullable restore
#line 72 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
WriteAttributeValue("", 2115, Model.會員照片image, 2115, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2132, "\"", 2138, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 73 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ab57a3f0390763636901e1abceecf513a1ede63e12027", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2477, "\"", 2543, 1);
#nullable restore
#line 79 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
WriteAttributeValue("", 2484, Url.Action("會員評論","Comment", new {id= Model.會員編號memberId}), 2484, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                                                                                 Write(Model.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </span>\r\n");
#nullable restore
#line 82 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                             if (Model.觀影方式source != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> - ");
#nullable restore
#line 84 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 於<span style=\"color:white\"> ");
#nullable restore
#line 84 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                                                                                                     Write(Model.觀影方式source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> 觀看</span>\r\n");
#nullable restore
#line 85 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> - ");
#nullable restore
#line 88 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 觀看</span>\r\n");
#nullable restore
#line 89 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span>\r\n                        <span class=\"mem_rate\" style=\"color: #ffc107;\">\r\n                            <i class=\"fa fa-star\"></i> ");
#nullable restore
#line 92 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                                  Write(Model.評分rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </h6>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"col-lg-8\">\r\n                <div class=\"blog__details__content\">\r\n                    <div class=\"blog__details__text\">\r\n                        <p>\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 110 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                       Write(Html.Raw(Model.評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"blog__details__tags\">\r\n");
            WriteLiteral("                        <a href=\"#\">#神片</a>\r\n                        <a href=\"#\">#主角好帥</a>\r\n                        <a href=\"#\">#IMAX</a>\r\n\r\n");
            WriteLiteral(@"                    <div class=""blog__details__comment__item__text"" style=""float:right"">
                        <a class=""Like"" href=""#"">Like <i class=""fas fa-thumbs-up""></i></a>
                        <a class=""unLike"" href=""#"">UnLike <i class=""fas fa-thumbs-down""></i></a>
                        <a class=""follow"" href=""#"">追蹤</a>
                        <a class=""report"" href=""#"">檢舉</a>
                    </div>
                    </div>
");
            WriteLiteral("                    <div style=\"margin: 10px 0 10px 0; border: solid 1px rgba(0,0,0,0)\">\r\n                        <span class=\"mem_info\">\r\n                            <span style=\"color:white\">發佈時間</span>\r\n                            <span> - ");
#nullable restore
#line 133 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </span>\r\n                    </div>\r\n\r\n\r\n");
            WriteLiteral(@"                    <div class=""blog__details__btns"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""blog__details__btns__item"">
                                    <h5>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 5548, "\"", 5618, 1);
#nullable restore
#line 144 "C:\MDA143\ClientMDA\Views\Comment\電影評論.cshtml"
WriteAttributeValue("", 5555, Url.Action("電影評論", "Comment", new { id = Model.評論編號commentId}), 5555, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <span class=""arrow_left""></span> 上一篇評論
                                        </a>
                                    </h5>
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""blog__details__btns__item next__btn"">
                                    <h5>
                                        <a href=""#"">下一篇評論 <span class=""arrow_right""></span></a>
                                    </h5>
                                </div>
                            </div>
                        </div>
                    </div>

");
            WriteLiteral(@"                    <div class=""blog__details__social"" style=""float:right"">
                        <a href=""#"" class=""facebook""><i class=""fa fa-facebook-square""></i> Facebook</a>
                        <a href=""#"" class=""pinterest""><i class=""fa fa-pinterest""></i> Pinterest</a>
                        <a href=""#"" class=""linkedin""><i class=""fa fa-linkedin-square""></i> Linkedin</a>
                        <a href=""#"" class=""twitter""><i class=""fa fa-twitter-square""></i> Twitter</a>
                    </div><hr />

");
            WriteLiteral(@"                    <div class=""blog__details__comment"">
                        <h4>3則留言</h4>
                        <div class=""blog__details__comment__item"">
                            <div class=""blog__details__comment__item__pic"">
                                <img src=""img/blog/details/comment-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 7225, "\"", 7231, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog__details__comment__item__text"">
                                <span>Sep 08, 2020</span>
                                <h5>John Smith</h5>
                                <p>
                                    你寫的評論真棒!
                                </p>
                                <a href=""#"">Like <i class=""fas fa-thumbs-up""></i></a>
                                <a class=""unLike"" href=""#"">UnLike <i class=""fas fa-thumbs-down""></i></a>
                                <a class=""report"" href=""#"">檢舉</a>
                            </div>
                        </div>
                        <div class=""blog__details__comment__item blog__details__comment__item--reply"">
                            <div class=""blog__details__comment__item__pic"">
                                <img src=""img/blog/details/comment-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 8164, "\"", 8170, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog__details__comment__item__text"">
                                <span>Sep 08, 2020</span>
                                <h5>佩佩</h5>
                                <p>
                                    推薦4DX 效果真D讚 必看一次
                                </p>
                                <a href=""#"">Like <i class=""fas fa-thumbs-up""></i></a>
                                <a class=""unLike"" href=""#"">UnLike <i class=""fas fa-thumbs-down""></i></a>
                                <a class=""report"" href=""#"">檢舉</a>
                            </div>
                        </div>
                        <div class=""blog__details__comment__item"">
                            <div class=""blog__details__comment__item__pic"">
                                <img src=""img/blog/details/comment-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 9067, "\"", 9073, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog__details__comment__item__text"">
                                <span>Sep 08, 2020</span>
                                <h5>Adrian Coleman</h5>
                                <p>
                                    我三刷了!!! 內牛滿麵
                                </p>
                                <a href=""#"">Like <i class=""fas fa-thumbs-up""></i></a>
                                <a class=""unLike"" href=""#"">UnLike <i class=""fas fa-thumbs-down""></i></a>
                                <a class=""report"" href=""#"">檢舉</a>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral("                    <div class=\"blog__details__form\">\r\n                        <div class=\"section-title\">\r\n                            <h4>你的留言</h4>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab57a3f0390763636901e1abceecf513a1ede63e23930", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-lg-12 col-md-6 col-sm-6"">
                                    <input type=""text"" placeholder=""Name"">
                                </div>
                                <div class=""col-lg-12"">
                                    <textarea placeholder=""Message""></textarea>
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientMDA.ViewModels.CCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
