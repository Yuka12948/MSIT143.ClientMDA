#pragma checksum "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "079a503cadb1f51a4dbf784f2f41f23f53551462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Components_OrderInfo_Default), @"mvc.1.0.view", @"/Views/Member/Components/OrderInfo/Default.cshtml")]
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
#nullable restore
#line 1 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079a503cadb1f51a4dbf784f2f41f23f53551462", @"/Views/Member/Components/OrderInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Components_OrderInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COrderInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
  
    string[] seatArr = Model.SelectSeatInfo.Split('#');

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""w3-modal-content w3-card-4 w3-animate-zoom"" style=""max-width:600px"">

    <div class=""w3-center"">
        <br>
        <span onclick=""document.getElementById('id01').style.display='none'"" class=""w3-button w3-xlarge w3-hover-red w3-display-topright"" title=""Close Modal"">&times;</span>
        <img");
            BeginWriteAttribute("src", " src=\"", 436, "\"", 463, 2);
#nullable restore
#line 12 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
WriteAttributeValue("", 442, Model.MoviePicture, 442, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 461, "", 463, 2, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Avatar\" style=\"width:30%\" class=\"w3-circle w3-margin-top\">\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "079a503cadb1f51a4dbf784f2f41f23f535514625179", async() => {
                WriteLiteral("\r\n        <div class=\"w3-section justify-content-center\">\r\n            <div class=\"border-bottom-0\">片名:");
#nullable restore
#line 17 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                       Write(Model.MovieName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 17 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                                         Write(Model.MovieVersion);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</div>\r\n            <div class=\"border-bottom-0\">放映日期:");
#nullable restore
#line 18 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                         Write(Model.StartTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"border-bottom-0\">放映時間:");
#nullable restore
#line 19 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                         Write(Model.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <hr />\r\n            <div class=\"border-bottom-0\">電影院:");
#nullable restore
#line 21 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                        Write(Model.TheaterName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (地址:");
#nullable restore
#line 21 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                                               Write(Model.TheaterAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</div>\r\n            <hr />\r\n            <div class=\"border-bottom-0\">訂票詳情</div>\r\n");
#nullable restore
#line 24 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
              
                foreach (string item in Model.TicketInfo)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"border-bottom-0\">");
#nullable restore
#line 27 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                            Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 28 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("            <hr />\r\n            <div class=\"border-bottom-0 pb-3\">座位資訊</div>\r\n            <div class=\"row justify-content-center pb-3\">\r\n                <div class=\"seatMap\">\r\n");
                WriteLiteral("                        ");
                WriteLiteral("<div>\r\n                            ");
                WriteLiteral("<div class=\"seatrow\">\r\n");
#nullable restore
#line 37 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                foreach (string seat in seatArr)
                                {
                                    if (seat.Contains("NA"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                WriteLiteral("<div class=\"dot none\"></div>\r\n");
#nullable restore
#line 42 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                    }
                                    else if (seat.Contains("||"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                WriteLiteral("</div></div><div>\r\n                                        ");
                WriteLiteral("<div class=\"seatrow\">\r\n");
#nullable restore
#line 47 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                        }
                                        else if (seat.Contains("selected"))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                WriteLiteral("<div class=\"dot selected\"></div>\r\n");
#nullable restore
#line 51 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                        }
                                        else if (seat != "")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                WriteLiteral("<div class=\"dot green\"></div>\r\n");
#nullable restore
#line 55 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                WriteLiteral("</div></div>\r\n");
                WriteLiteral("                </div>\r\n            </div>\r\n            <hr />\r\n            <div class=\"border-bottom-0\">已付金額:NT$");
#nullable restore
#line 62 "D:\新增資料夾 (2)\ClientMDA\Views\Member\Components\OrderInfo\Default.cshtml"
                                            Write(Model.fullprice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

    <div class=""w3-container w3-border-top w3-padding-16 w3-light-grey"">
        <button onclick=""document.getElementById('id01').style.display='none'"" type=""button"" class=""w3-button w3-red"">關閉</button>
        <button type=""button"" class=""w3-button w3-red"">退票</button>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COrderInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
