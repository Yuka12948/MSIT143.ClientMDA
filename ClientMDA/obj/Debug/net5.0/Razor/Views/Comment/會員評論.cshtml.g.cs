#pragma checksum "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7402eba1a929d4b2aba2c9377add9ac3ed6bacc5"
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
#line 1 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7402eba1a929d4b2aba2c9377add9ac3ed6bacc5", @"/Views/Comment/會員評論.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_會員評論 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientMDA.ViewModels.CMemberCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Comment/jquery.eeyellow.Timeline.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%+733px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Comment/jquery.eeyellow.Timeline.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
  
    var a = "";
    會員member mem = null;
    if (Accessor.HttpContext.Session.Keys.Contains(ClientMDA.Models.CDictionary.SK_LOGINED_USER))
    {
        a = Accessor.HttpContext.Session.GetString(ClientMDA.Models.CDictionary.SK_LOGINED_USER);
        mem = JsonSerializer.Deserialize<會員member>(a);
    }


#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
  
    ViewData["Title"] = "會員評論";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        #memBgImg { /*會員背景圖*/
            background: #E55D87; /* fallback for old browsers */
            background: -webkit-linear-gradient(to right, #5FC3E4, #E55D87); /* Chrome 10-25, Safari 5.1-6 */
            background: linear-gradient(to right, rgba(137, 211, 235,0.8), rgba(236, 137, 168,0.8)); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        }

        .membtn {
            float: right;
            bottom: 0;
            margin-right: 20px;
        }

        .events-desc { /*時間軸評論內容*/
            overflow: hidden !important; /*溢位*/
            text-overflow: ellipsis !important; /*文字溢位ellipsis... */
            display: -webkit-box;
            -webkit-line-clamp: 3; /*限制元素顯示文字行數*/
            -webkit-box-orient: vertical; /*垂直排列*/
            word-break: break-all;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7402eba1a929d4b2aba2c9377add9ac3ed6bacc58814", async() => {
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
            WriteLiteral(" ");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div id=\"memBgImg\" class=\"py-1 bg-image-full\">\r\n");
            WriteLiteral("    <div class=\"text-center my-5\">\r\n\r\n");
#nullable restore
#line 51 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
         if (@Model.會員照片image != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img style=\"width: 100%+733px !important;\" class=\"img-fluid rounded-circle mb-4\" width=\"150\" alt=\"...\"");
            BeginWriteAttribute("src", "\r\n                 src=\"", 1801, "\"", 1879, 2);
            WriteAttributeValue("", 1825, "https://localhost:44381/images/Member/", 1825, 38, true);
#nullable restore
#line 54 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 1863, Model.會員照片image, 1863, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 55 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7402eba1a929d4b2aba2c9377add9ac3ed6bacc511397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"text-white fs-3 fw-bolder\">");
#nullable restore
#line 62 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                         Write(Model.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("        <span class=\"text-white-50 mb-0\">");
            WriteLiteral(" ");
#nullable restore
#line 65 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                     Write(Model.commentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 則評論 ‧ ");
#nullable restore
#line 65 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                                               Write(Model.memberfollow);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 人追蹤</span><br />\r\n        <div class=\"membtn\">\r\n            ");
#nullable restore
#line 67 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
       Write(Html.ActionLink("追蹤會員", "follow會員", new { followMid = 1 }, new { @class = "btn btn-info btn-sm", id = "followMem" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 68 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
       Write(Html.ActionLink("取消追蹤", "unfollow會員", new { followMid = 1 }, new { @class = "btn btn-info btn-sm", id = "followMem" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            <button type=\"button\" id=\"btnReport\" class=\"btn btn-danger btn-sm\" data-toggle=\"modal\" data-target=\"#reportModal\">檢舉</button>\r\n");
#nullable restore
#line 71 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
              
                if (mem != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- Modal -->
                    <div class=""modal fade"" id=""reportModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
");
#nullable restore
#line 77 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                             using (Html.BeginForm("Report檢舉", "Comment"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"" id=""exampleModalLongTitle"" style=""color:black"">檢舉</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"" style=""color:black"">
                                        <!--modal content start-->
                                        <input type=""hidden"" name=""會員編號Member_ID""");
            BeginWriteAttribute("value", " value=\"", 4249, "\"", 4274, 1);
#nullable restore
#line 88 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 4257, mem.會員編號memberId, 4257, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <input type=""hidden"" name=""對象Target_ID"" value=""1"" />
                                        <input type=""hidden"" name=""追讚倒編號ActionType_ID"" value=""3"" />
                                        <input type=""hidden"" name=""連接編號Connect_ID"" value=""1"" />
                                        <input type=""hidden""");
            BeginWriteAttribute("name", " name=\"", 4632, "\"", 4639, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4640, "\"", 4648, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <div><label>檢舉人</label><input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 4744, "\"", 4770, 1);
#nullable restore
#line 93 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 4752, mem.會員電話cellphone, 4752, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" /></div>
                                        <div><label>檢舉對象</label><input type=""text"" readonly value=""Yuka"" /></div>
                                        <div><label>檢舉理由</label><textarea cols=""50"" name=""檢舉理由ReportReason""></textarea></div>
                                        <!--modal content end-->
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">取消</button>
                                        <button type=""submit"" class=""btn btn-primary"" id=""submitAddList"">確定</button>
                                    </div>
                                </div>
");
#nullable restore
#line 103 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <!--modal end-->\r\n");
#nullable restore
#line 107 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7402eba1a929d4b2aba2c9377add9ac3ed6bacc519866", async() => {
                WriteLiteral("\r\n    <div class=\"VivaTimeline\">\r\n        <dl>\r\n            <!--今天-->\r\n            <dt>Today</dt>\r\n            <dt>");
#nullable restore
#line 119 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
           Write(DateTime.Now.ToString("yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 119 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                            Write(DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("en-us")).Substring(0, 3));

#line default
#line hidden
#nullable disable
                WriteLiteral("</dt>\r\n\r\n\r\n            ");
#nullable restore
#line 122 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
       Write(await Component.InvokeAsync("時間軸評論", new { id = Model.會員編號memberId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            <!--會員建立日期-->\r\n            <dt>");
#nullable restore
#line 126 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
           Write(Model.建立時間createdTime.ToString("yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 126 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                     Write(Model.建立時間createdTime.ToString("MMMM", new System.Globalization.CultureInfo("en-us")).Substring(0, 3));

#line default
#line hidden
#nullable disable
                WriteLiteral("</dt>\r\n            <dt>Start</dt>\r\n            <br />\r\n        </dl>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('.VivaTimeline').vivaTimeline();
        $('.VivaTimeline').vivaTimeline({
            carousel: true
        });
        $('.VivaTimeline').vivaTimeline({
            carousel: true,
            carouselTime: 3000
        });

    </script>
");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7402eba1a929d4b2aba2c9377add9ac3ed6bacc523197", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
                WriteLiteral("\r\n\r\n    <script>\r\n        //const follow = document.querySelector(\'#followMem\')\r\n        //follow.addEventListener(\'click\', () => {\r\n        //})\r\n    </script>\r\n    <script>\r\n            window.onload=function () {\r\n                if (\'");
#nullable restore
#line 156 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                Write(a);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' == \"\") {\r\n                    document.querySelector(\"#btnReport\").addEventListener(\'click\', () => {\r\n");
#nullable restore
#line 158 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                          Accessor.HttpContext.Session.SetString(CDictionary.SK登後要前往的頁面, "~/Comment/會員評論/1");

#line default
#line hidden
#nullable disable
                WriteLiteral("                        window.location = \'");
#nullable restore
#line 159 "E:\C#\03_iSpan資策會\MSIT_143_智慧應用微軟C#工程師就業養成班\06.專題_GitHub\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                      Write(Url.Content("~/member/login"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                    })\r\n                }\r\n            }\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor Accessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientMDA.ViewModels.CMemberCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
