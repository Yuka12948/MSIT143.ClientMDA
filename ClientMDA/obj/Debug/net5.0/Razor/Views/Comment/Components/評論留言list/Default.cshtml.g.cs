#pragma checksum "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63daec600b0873413408789df6ef07c38b4a240e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Components_評論留言list_Default), @"mvc.1.0.view", @"/Views/Comment/Components/評論留言list/Default.cshtml")]
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
#line 1 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63daec600b0873413408789df6ef07c38b4a240e", @"/Views/Comment/Components/評論留言list/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Components_評論留言list_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CFloorViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("55"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:25px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
  
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
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    btnfloorReport {\r\n        height: 20px;\r\n        width: 60px;\r\n        font-size: 9px;\r\n        margin: 0;\r\n        margin-bottom: 11px;\r\n        padding: 0;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 29 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
  
    int count = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
     for (var i = 0; i < @Model.Count; i++)
    {
        count++;
        string NickName = "";
        if (Model[i].fNickName.Count() > 0)
        {
            NickName = Model[i].fNickName[0];
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog__details__comment__item\">\r\n            <div class=\"blog__details__comment__item__pic\" style=\"margin-right:20px\">\r\n");
#nullable restore
#line 41 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                 if (Model[i].fMemImg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 1241, "\"", 1305, 2);
            WriteAttributeValue("", 1247, "https://localhost:44381/images/Member/", 1247, 38, true);
#nullable restore
#line 43 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 1285, Model[i].fMemImg[0], 1285, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1306, "\"", 1312, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"55\" style=\"border-radius:25px\" />\r\n");
#nullable restore
#line 44 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63daec600b0873413408789df6ef07c38b4a240e7889", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                                                                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"blog__details__comment__item__text\">\r\n                <h5>#");
#nullable restore
#line 52 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5> ");
#nullable restore
#line 53 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                Write(NickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span style=\"display: inline;\"> - ");
#nullable restore
#line 53 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                                           Write(Html.DisplayFor(modelItem => Model[i].發佈時間floorTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                <p>\r\n                    ");
#nullable restore
#line 55 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
               Write(Model[i].回覆內容floors);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <div ");
            WriteLiteral(">\r\n");
            WriteLiteral("                    <a href=\"#\">Like ");
#nullable restore
#line 59 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                Write(Model[i].被按讚次數thumbsUp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-thumbs-up\"></i></a>\r\n                    <a class=\"unLike\" href=\"#\">UnLike ");
#nullable restore
#line 60 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                                 Write(Model[i].被倒讚次數thumbsDown);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-thumbs-down\"></i></a>\r\n");
            WriteLiteral("                    <button type=\"button\" id=\"btnfloorReport\" class=\"btn btn-danger btn-sm\" data-toggle=\"modal\" data-target=\"#floorReportModal\">檢舉</button>\r\n                </div>\r\n\r\n");
#nullable restore
#line 65 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                   //留言檢舉
                    if (mem != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!-- Modal -->
                        <div class=""modal fade"" id=""floorReportModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
");
#nullable restore
#line 71 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                 using (Html.BeginForm("Report檢舉", "Comment"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title"" id=""exampleModalLongTitle"" style=""color:black"">檢舉</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>
                                        <div class=""modal-body"" style=""color:black"">
                                            <!--modal content start-->
                                            <input type=""hidden"" name=""會員編號Member_ID""");
            BeginWriteAttribute("value", " value=\"", 4234, "\"", 4259, 1);
#nullable restore
#line 82 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 4242, mem.會員編號memberId, 4242, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                            <input type=""hidden"" name=""對象Target_ID"" value=""0"" />
                                            <input type=""hidden"" name=""追讚倒編號ActionType_ID"" value=""3"" />
                                            <input type=""hidden"" name=""連接編號Connect_ID""");
            BeginWriteAttribute("value", " value=\"", 4554, "\"", 4583, 1);
#nullable restore
#line 85 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 4562, Model[i].樓數編號floorId, 4562, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4653, "\"", 4660, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4661, "\"", 4669, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <div><label>檢舉人</label><input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 4769, "\"", 4792, 1);
#nullable restore
#line 87 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 4777, mem.暱稱nickName, 4777, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                                            <div><label>檢舉對象</label><input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 4899, "\"", 4916, 1);
#nullable restore
#line 88 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 4907, NickName, 4907, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" /></div>
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
#line 97 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <!--modal end-->\r\n");
#nullable restore
#line 101 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 105 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CFloorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
