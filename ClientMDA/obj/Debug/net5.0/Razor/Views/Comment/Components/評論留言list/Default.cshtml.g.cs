#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298efab1fc09c85ee9fb01ff41ee7507ee1dd679"
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
#nullable restore
#line 3 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298efab1fc09c85ee9fb01ff41ee7507ee1dd679", @"/Views/Comment/Components/評論留言list/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Components_評論留言list_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CFloorViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("memImg-Circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Member/MEMBER.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- #region 會員Session-->\r\n");
#nullable restore
#line 6 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
  
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
            WriteLiteral("    <!-- #endregion 會員Session-->\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    btnfloorReport { /*留言檢舉按紐*/
        height: 20px;
        width: 60px;
        font-size: 9px;
        margin: 0;
        margin-bottom: 11px;
        padding: 0;
    }

    .memImg-Circle { /*會員大頭貼*/
        clip-path: circle(45% at 50% 50%);
        height: 55px;
        width: 55px;
    }
    .floorCount{
        background:none !important;
        padding:0 !important;
    }
</style>
");
#nullable restore
#line 41 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
  
    int count = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
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
#line 53 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                 if (Model[i].fMemImg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img class=\"memImg-Circle\"");
            BeginWriteAttribute("src", " src=\"", 1575, "\"", 1639, 2);
            WriteAttributeValue("", 1581, "https://localhost:44381/images/Member/", 1581, 38, true);
#nullable restore
#line 55 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 1619, Model[i].fMemImg[0], 1619, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1640, "\"", 1646, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 56 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "298efab1fc09c85ee9fb01ff41ee7507ee1dd6798142", async() => {
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
#line 60 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                                                                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"blog__details__comment__item__text\">\r\n                <h5>#");
#nullable restore
#line 64 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <a class=\"floorCount\"");
            BeginWriteAttribute("href", " href=\"", 2058, "\"", 2127, 1);
#nullable restore
#line 65 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 2065, Url.Action("會員評論","Comment", new {id= Model[i].會員編號memberId}), 2065, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5>\r\n                        ");
#nullable restore
#line 67 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                   Write(NickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span style=\"display: inline;\"> - ");
#nullable restore
#line 68 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                                     Write(Html.DisplayFor(modelItem => Model[i].發佈時間floorTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h5>\r\n                </a>\r\n                <p>\r\n                    ");
#nullable restore
#line 72 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
               Write(Model[i].回覆內容floors);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <div ");
            WriteLiteral(">\r\n");
            WriteLiteral("                    <a href=\"#\">Like ");
#nullable restore
#line 76 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                Write(Model[i].被按讚次數thumbsUp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-thumbs-up\"></i></a>\r\n                    <a class=\"unLike\" href=\"#\">UnLike ");
#nullable restore
#line 77 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                                 Write(Model[i].被倒讚次數thumbsDown);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-thumbs-down\"></i></a>\r\n");
#nullable restore
#line 78 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                      
                        if (mem != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"report\" href=\"#\" type=\"button\"");
            BeginWriteAttribute("name", " name=\"", 3252, "\"", 3290, 3);
#nullable restore
#line 81 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 3259, Model[i].樓數編號floorId, 3259, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3280, "/", 3280, 1, true);
#nullable restore
#line 81 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 3281, NickName, 3281, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"btnReport\" data-toggle=\"modal\" data-target=\"#floorReportModal\">檢舉</a>\r\n");
#nullable restore
#line 82 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                       Write(Html.ActionLink("檢舉", "checkLogin", new { page = "電影評論", id = Model[i].評論編號commentId }, new { type = "button", @class = "report" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                                                                                                                                                                
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!-- #region 留言檢舉 -->\r\n");
#nullable restore
#line 91 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                 if (mem != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- Modal -->
                    <div class=""modal fade"" id=""floorReportModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
");
#nullable restore
#line 96 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
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
                                        <input type=""hidden"" name=""會員編號memberId""");
            BeginWriteAttribute("value", " value=\"", 5104, "\"", 5129, 1);
#nullable restore
#line 107 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 5112, mem.會員編號memberId, 5112, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <input type=""hidden"" name=""對象targetId"" value=""0"" />
                                        <input type=""hidden"" name=""追讚倒編號actionTypeId"" value=""3"" />
                                        <input type=""hidden"" name=""連接編號connectId"" class=""連接編號connectId"" />
                                        <input type=""hidden"" name=""評論編號commentId""");
            BeginWriteAttribute("value", " value=\"", 5517, "\"", 5548, 1);
#nullable restore
#line 111 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 5525, Model[i].評論編號commentId, 5525, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <div><label style=\"width:80px\">檢舉人:</label><input style=\"width:300px\" type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 5684, "\"", 5707, 1);
#nullable restore
#line 112 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
WriteAttributeValue("", 5692, mem.暱稱nickName, 5692, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" /></div>
                                        <div><label style=""width:80px"">檢舉對象:</label><input style=""width:300px"" type=""text"" readonly class=""NickName"" /></div>
                                        <div><label style=""width:80px;vertical-align:top"">檢舉理由:</label><textarea style=""width:300px"" cols=""50"" name=""檢舉理由ReportReason""></textarea></div>
                                        <!--modal content end-->
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">取消</button>
                                        <button type=""button"" class=""btn btn-secondary"" id=""demo"">Demo</button>
                                        <button type=""submit"" class=""btn btn-primary"" id=""submitAddList"">確定</button>
                                    </div>
                                </div>
");
#nullable restore
#line 123 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <!--modal end-->\r\n");
#nullable restore
#line 127 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- #endregion 留言檢舉 -->\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 131 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\評論留言list\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- #region 留言檢舉 -->\r\n");
            WriteLiteral("    <!-- #endregion 留言檢舉 -->\r\n");
            WriteLiteral(@"
<script>
    ////檢舉DEMO

    //const demo = document.querySelector(""#demo"")
    //demo.addEventListener('click', () => {
    //    document.querySelector('[name=""檢舉理由ReportReason""]').value = ""不當言論""
    //})
</script>

<script>
        let btnclick = document.getElementsByClassName(""report"")
        for (let btn of btnclick) {

            btn.addEventListener(""click"", function () {
                let cId = btn.name;
                let connectId = document.querySelector("".連接編號connectId"");
                let NickName = document.querySelector("".NickName"")
                connectId.value = cId.split(""/"")[0];
                NickName.value = cId.split(""/"")[1];
                console.log(NickName.value);
                console.log(cId);
                console.log(connectId.value);
                
            })
        }
</script>

");
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
