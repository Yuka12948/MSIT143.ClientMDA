#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a69a44a67e8ba475b9e149758ceb1d91f40583"
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
#line 2 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a69a44a67e8ba475b9e149758ceb1d91f40583", @"/Views/Comment/會員評論.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_會員評論 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientMDA.ViewModels.CMemberCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Comment/jquery.eeyellow.Timeline.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("memImg-Circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("170"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Comment/jquery.eeyellow.Timeline.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
  
    var a = "";
    會員member mem = null;
    if (Accessor.HttpContext.Session.Keys.Contains(ClientMDA.Models.CDictionary.SK_LOGINED_USER))
    {
        a = Accessor.HttpContext.Session.GetString(ClientMDA.Models.CDictionary.SK_LOGINED_USER);
        mem = JsonSerializer.Deserialize<會員member>(a);
    }
    var connectId = Html.ViewContext.RouteData.Values["id"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
  
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

        .memImg-Circle { /*會員大頭貼*/
            clip-path: circle(45% at 50% 50%);
        }
    </style>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06a69a44a67e8ba475b9e149758ceb1d91f405838319", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<div id=\"memBgImg\" class=\"py-1 bg-image-full\">\r\n");
            WriteLiteral("    <div class=\"text-center my-5\">\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
         if (@Model.會員照片image != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n                <img class=\"memImg-Circle\" height=\"170\" alt=\"...\"");
            BeginWriteAttribute("src", "\r\n                     src=\"", 1916, "\"", 2000, 2);
            WriteAttributeValue("", 1944, "http://192.168.24.5:44383/images/Member/", 1944, 40, true);
#nullable restore
#line 57 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 1984, Model.會員照片image, 1984, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n");
#nullable restore
#line 59 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "06a69a44a67e8ba475b9e149758ceb1d91f4058310924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"text-white fs-3 fw-bolder\">");
#nullable restore
#line 66 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                         Write(Model.暱稱nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("        <span class=\"text-white-50 mb-0\">\r\n            <span type=\"button\" data-toggle=\"modal\" data-target=\"#commentCountModal\">\r\n                ");
#nullable restore
#line 71 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
           Write(Model.commentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span> 則評論 ‧\r\n            <span type=\"button\" data-toggle=\"modal\" data-target=\"#memberFollowModal\">\r\n                ");
#nullable restore
#line 74 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
           Write(Model.memberfollow);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </span> 人追蹤
        </span><br />
        <!-- #region 評論Modal -->
        <div class=""modal fade"" id=""commentCountModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"" style=""color:black"">評論清單</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"" style=""color:black"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"" style=""color:black !important;text-align:left"">
                        <!--modal content start-->
");
#nullable restore
#line 89 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                          
                            var cCount = 0;
                            for (int i = 0; i < Model.commentCount; i++)
                            {
                                cCount++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div><a style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 3957, "\"", 3980, 2);
            WriteAttributeValue("", 3964, "#comment_", 3964, 9, true);
#nullable restore
#line 94 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 3973, cCount, 3973, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 94 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                                Write(cCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 94 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                                        Write(Model.commentList[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 95 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!--modal content end-->
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">確定</button>
                    </div>
                </div>
            </div>
        </div>
        <!--#endregion 評論Modal end-->
        <!-- #region 追蹤會員Modal -->
        <div class=""modal fade"" id=""memberFollowModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"" style=""color:black"">追蹤會員清單</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"" style=""color:black"">&times;</span>
             ");
            WriteLiteral("           </button>\r\n                    </div>\r\n                    <div class=\"modal-body\" style=\"color:black;text-align:left\">\r\n                        <!--modal content start-->\r\n");
#nullable restore
#line 118 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                          
                            var fCount = 0;
                            for (int i = 0; i < Model.memberfollow; i++)
                            {
                                fCount++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div><a style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 5570, "\"", 5602, 1);
#nullable restore
#line 123 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 5577, Model.memFollowIdList[i], 5577, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 123 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                                         Write(fCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 123 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                                                                                 Write(Model.memFollowList[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 124 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!--modal content end-->
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">確定</button>
                    </div>
                </div>
            </div>
        </div>
        <!--#endregion 追蹤會員Modal end-->

        <div class=""membtn"">
            <!--weiting begin-->
");
#nullable restore
#line 139 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
              
                if (mem != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <span><input class=""btn btn-info btn-sm"" type=""button"" id=""followMem"" status=""y"" value=""追蹤會員"" onclick=""setFollow(event)""></span>
                    <span><button type=""button"" id=""btnReport"" class=""btn btn-danger btn-sm"" data-toggle=""modal"" data-target=""#reportModal"">檢舉</button></span>
");
#nullable restore
#line 144 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 147 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                     Write(Html.ActionLink("追蹤會員", "checkLogin", new { page = "會員評論", id = connectId }, new { type = "button", @class = "btn btn-info btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span>");
#nullable restore
#line 148 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                     Write(Html.ActionLink("檢舉", "checkLogin", new { page = "會員評論", id = connectId }, new { type = "button", @class = "btn btn-danger btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 149 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Modal -->\r\n            <div class=\"modal fade\" id=\"reportModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n");
#nullable restore
#line 154 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                     using (Html.BeginForm("Report檢舉", "Comment"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalLongTitle"" style=""color:black"">檢舉</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"" style=""color:black;text-align:left"">
                                <!--modal content start-->
");
#nullable restore
#line 165 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                   if (mem != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input type=\"hidden\" name=\"會員編號memberId\"");
            BeginWriteAttribute("value", " value=\"", 8261, "\"", 8286, 1);
#nullable restore
#line 167 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 8269, mem.會員編號memberId, 8269, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <input type=""hidden"" name=""對象targetId"" value=""1"" />
                                        <input type=""hidden"" name=""追讚倒編號actionTypeId"" value=""3"" />
                                        <input type=""hidden"" name=""連接編號connectId""");
            BeginWriteAttribute("value", " value=\"", 8566, "\"", 8584, 1);
#nullable restore
#line 170 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 8574, connectId, 8574, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 8650, "\"", 8657, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 8658, "\"", 8666, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <div><label>檢舉人</label><input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 8762, "\"", 8788, 1);
#nullable restore
#line 172 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 8770, mem.會員電話cellphone, 8770, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                                        <div><label>檢舉對象</label><input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 8891, "\"", 8916, 1);
#nullable restore
#line 173 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
WriteAttributeValue("", 8899, Model.暱稱nickName, 8899, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                                        <div><label>檢舉理由</label><textarea cols=\"100\" name=\"檢舉理由reportReason\" required></textarea></div>\r\n");
#nullable restore
#line 175 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--modal content end-->
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">取消</button>
                                <button type=""submit"" class=""btn btn-primary"" id=""submitReport"">確定</button>
                            </div>
                        </div>
");
#nullable restore
#line 182 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <!--modal end-->\r\n            <!--weiting end-->\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a69a44a67e8ba475b9e149758ceb1d91f4058326760", async() => {
                WriteLiteral("\r\n    <div class=\"VivaTimeline\">\r\n        <dl>\r\n            <!--今天-->\r\n            <dt>Today</dt>\r\n            <dt>");
#nullable restore
#line 199 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
           Write(DateTime.Now.ToString("yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 199 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                                            Write(DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("en-us")).Substring(0, 3));

#line default
#line hidden
#nullable disable
                WriteLiteral("</dt>\r\n\r\n\r\n            ");
#nullable restore
#line 202 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
       Write(await Component.InvokeAsync("時間軸評論", new { id = Model.會員編號memberId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            <!--會員建立日期-->\r\n            <dt>");
#nullable restore
#line 206 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
           Write(Model.建立時間createdTime.ToString("yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 206 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a69a44a67e8ba475b9e149758ceb1d91f4058329941", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
                WriteLiteral("\r\n\r\n    <script>\r\n        //const follow = document.querySelector(\'#followMem\')\r\n        //follow.addEventListener(\'click\', () => {\r\n        //})\r\n    </script>\r\n    <script>\r\n");
                WriteLiteral("    </script>\r\n\r\n");
                WriteLiteral("    <script>\r\n\r\n\r\n    window.onload = async function () {\r\n        const btnfollow = document.querySelector(\'#followMem\')\r\n");
                WriteLiteral("        \'");
#nullable restore
#line 254 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
           int login = 0;
            int? memid = null;
            if (mem != null)
            {
                login = 1;
                memid = mem.會員編號memberId;
            }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n        console.log(\'");
#nullable restore
#line 262 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                Write(login);

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n        console.log(\'");
#nullable restore
#line 263 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                Write(mem);

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n        if (\'");
#nullable restore
#line 264 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
        Write(login);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' ==1) {\r\n            let memid = \'");
#nullable restore
#line 265 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                    Write(memid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                let followid = \'");
#nullable restore
#line 266 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                           Write(connectId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                let target = 1\r\n\r\n                const url = \'");
#nullable restore
#line 269 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                        Write(Url.Content("~/comment/checkFollow"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                const params = `?memid=${memid}&followid=${followid}&target=${target}`
                let response = await fetch(url + params)
            let data = await response.text()
            if (data == ""y"")
                btnfollow.setAttribute('value', '取消追蹤')
        }
        else
            await btnfollow.setAttribute('value', '追蹤會員')

                // checkFollow(int memid, int followid, int target)
            }
    </script>
    <script>
    async function setFollow(event){
        let follomid = '");
#nullable restore
#line 284 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                   Write(connectId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                const url = \'");
#nullable restore
#line 285 "C:\Users\Student\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\會員評論.cshtml"
                        Write(Url.Content("~/comment/follow"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
        const params = `?connectid=${follomid}&target=1`
                let response = await fetch(url + params)
                let data = await response.text()
        if (data == ""add"") {
            event.target.setAttribute('value', '取消追蹤')
        }
        else {
            event.target.setAttribute('value', '追蹤會員')
        }
            }

    </script>


");
                WriteLiteral("\r\n");
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
