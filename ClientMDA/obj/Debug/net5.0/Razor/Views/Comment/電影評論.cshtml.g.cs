#pragma checksum "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5628e39f55b63b7be8e7cb9d6bd7bfa2913e71a"
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
#line 1 "D:\新增資料夾 (2)\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\新增資料夾 (2)\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5628e39f55b63b7be8e7cb9d6bd7bfa2913e71a", @"/Views/Comment/電影評論.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_電影評論 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientMDA.ViewModels.CCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
      
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
            }
            );
            WriteLiteral(@"
    <section class=""blog-details spad"">
        <div class=""container"">
            <div class=""row d-flex justify-content-center"">
                <div class=""col-lg-8"">
                    <div class=""blog__details__title"">
                        <h2>");
#nullable restore
#line 54 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                       Write(Model.中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h3>");
#nullable restore
#line 55 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                       Write(Model.評論標題commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3><hr class=\"mem_line\" />\r\n                        <h6>\r\n                            <span class=\"mem_info\">\r\n                                <span style=\"color:white\">\r\n");
#nullable restore
#line 59 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                     if (Model.會員照片image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1737, "\"", 1797, 2);
            WriteAttributeValue("", 1743, "https://localhost:44381/images/Member/", 1743, 38, true);
#nullable restore
#line 61 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
WriteAttributeValue("", 1781, Model.會員照片image, 1781, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1798, "\"", 1804, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 62 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5628e39f55b63b7be8e7cb9d6bd7bfa2913e71a8142", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 66 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a ");
#nullable restore
#line 67 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                  Write(Url.Action("會員評論","Comment", new {id= Model.會員編號memberId}));

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 67 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                                                                              Write(Model.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </span>\r\n");
#nullable restore
#line 69 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                 if (Model.觀影方式source != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span> - ");
#nullable restore
#line 71 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                        Write(Html.DisplayFor(modelItem => Model.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 於<span style=\"color:white\"> ");
#nullable restore
#line 71 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                                                                                                         Write(Model.觀影方式source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> 觀看</span>\r\n");
#nullable restore
#line 72 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span> - ");
#nullable restore
#line 75 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                        Write(Html.DisplayFor(modelItem => Model.觀影日期viewingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 觀看</span>\r\n");
#nullable restore
#line 76 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n                            <span class=\"mem_rate\" style=\"color: #ffc107;\">\r\n                                <i class=\"fa fa-star\"></i> ");
#nullable restore
#line 79 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                                      Write(Model.評分rate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 分\r\n                            </span>\r\n                        </h6>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-8\">\r\n                    <div class=\"blog__details__pic\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3195, "\"", 3257, 2);
            WriteAttributeValue("", 3201, "https://localhost:44381/images/Comment/", 3201, 39, true);
#nullable restore
#line 86 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
WriteAttributeValue("", 3240, Model.cImgFrList, 3240, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3258, "\"", 3264, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 87 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                   Write(Model.cImgFrList);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-8\">\r\n                    <div class=\"blog__details__content\">\r\n                        <div class=\"blog__details__text\">\r\n                            <p>\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 95 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                           Write(Html.Raw(Model.評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                        <div class=""blog__details__tags"">
                            <a href=""#"">#神片</a>
                            <a href=""#"">#主角好帥</a>
                            <a href=""#"">#IMAX</a>

                            <div class=""blog__details__comment__item__text"" style=""float:right"">
                                <a href=""#"">Like <i class=""fas fa-thumbs-up""></i></a>
                                <a class=""unLike"" href=""#"">UnLike <i class=""fas fa-thumbs-down""></i></a>
                                <a class=""report"" href=""#"">檢舉</a>
                            </div>
                        </div>

                        <div style=""margin: 10px 0 10px 0; border: solid 1px rgba(0,0,0,0)"">
                            <span class=""mem_info"">
                                <span style=""color:white"">發佈時間</span>
                                <span> - ");
#nullable restore
#line 113 "D:\新增資料夾 (2)\ClientMDA\Views\Comment\電影評論.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.發佈時間commentTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </span>
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
                                    <div class=""blog__details__btns__item next__btn"">
                                        <h5>
                                            <a href=""#"">下一篇評論 <span class=""arrow_right""></span></a>
                                        </h5>
                                    </div>
                                </div>
  ");
            WriteLiteral(@"                          </div>
                        </div>

                        <div class=""blog__details__social"" style=""float:right"">
                            <a href=""#"" class=""facebook""><i class=""fa fa-facebook-square""></i> Facebook</a>
                            <a href=""#"" class=""pinterest""><i class=""fa fa-pinterest""></i> Pinterest</a>
                            <a href=""#"" class=""linkedin""><i class=""fa fa-linkedin-square""></i> Linkedin</a>
                            <a href=""#"" class=""twitter""><i class=""fa fa-twitter-square""></i> Twitter</a>
                        </div><hr />

                        <div class=""blog__details__comment"">
                            <h4>3則留言</h4>
                            <div class=""blog__details__comment__item"">
                                <div class=""blog__details__comment__item__pic"">
                                    <img src=""img/blog/details/comment-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 6667, "\"", 6673, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 7666, "\"", 7672, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 8629, "\"", 8635, 0);
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
                        <div class=""blog__details__form"">
                            <h4>你的留言</h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5628e39f55b63b7be8e7cb9d6bd7bfa2913e71a20552", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-lg-12 col-md-6 col-sm-6"">
                                        <input type=""text"" placeholder=""Name"" style=""max-width:none"">
                                    </div>
");
                WriteLiteral("                                <div class=\"col-lg-12\">\r\n                                    <textarea placeholder=\"Message\" style=\"max-width:none\"></textarea>\r\n                                    <button type=\"submit\" class=\"site-btn\">送出</button>\r\n");
                WriteLiteral("\r\n                                </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>");
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
