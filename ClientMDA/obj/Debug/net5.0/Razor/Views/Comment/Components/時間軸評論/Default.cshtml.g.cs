#pragma checksum "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "595608239f8899f32e79c5910255e1f9e84f63b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Components_時間軸評論_Default), @"mvc.1.0.view", @"/Views/Comment/Components/時間軸評論/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595608239f8899f32e79c5910255e1f9e84f63b9", @"/Views/Comment/Components/時間軸評論/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Components_時間軸評論_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CCommentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
  
    ViewData["Title"] = "Default"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
  
    for (var i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--#region 左側文章 start-->\r\n        <dd class=\"pos-left clearfix\">\r\n");
            WriteLiteral("            <div class=\"circ\"></div>\r\n            <div class=\"time\">\r\n                <!-- 填入日期 -->\r\n                ");
#nullable restore
#line 15 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
           Write(Model[i].發佈時間commentTime.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> ");
#nullable restore
#line 15 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
                                                             Write(Model[i].發佈時間commentTime.ToString("MMMM", new System.Globalization.CultureInfo("en-us")).Substring(0, 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
                                                                                                                                                                       Write(Model[i].發佈時間commentTime.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"events\">\r\n                <div class=\"events-header\"><h5>");
#nullable restore
#line 19 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
                                          Write(Model[i].評論標題commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></div><!--填入標題-->\r\n                <div class=\"events-body\">\r\n                    <div ");
            WriteLiteral(">\r\n                        <div class=\"pull-left\">\r\n                            <img class=\"events-object img-responsive img-rounded\"");
            BeginWriteAttribute("src", " src=\"", 970, "\"", 976, 0);
            EndWriteAttribute();
            WriteLiteral(" /><!--填入圖片網址-->\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"events-desc\">\r\n                            ");
#nullable restore
#line 27 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
                       Write(Html.Raw(Model[i].評論內容comments));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <br />

                        <!--填入描述-->
                    </div>
                </div>
                <div class=""events-footer"" style=""padding:5px 5px 4px 0;float:right"">
                    <a style=""padding-right:10px;""");
            BeginWriteAttribute("href", " href=\"", 1464, "\"", 1538, 1);
#nullable restore
#line 35 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
WriteAttributeValue("", 1471, Url.Action("電影評論", "Comment", new { id = Model[i].評論編號commentId }), 1471, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        繼續閱讀 >>\r\n                    </a>\r\n                </div><!--可填底部標題 或刪除-->\r\n            </div>\r\n        </dd>\r\n        <!--#endregion 左側文章 end-->\r\n        <!-- #region 右側文章 start -->\r\n");
            WriteLiteral("        <!--#endregion 右側文章 end-->\r\n");
#nullable restore
#line 66 "C:\shared\MSIT143.ClientMDA\ClientMDA\Views\Comment\Components\時間軸評論\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    let clearfix = document.querySelectorAll("".clearfix"");
    for (var i = 0; i < clearfix.length; i++) {
        if (i % 2 == 0)//偶數
        {
            clearfix[i].classList.remove(""pos-left"");
            clearfix[i].classList.add(""pos-left"");
        }
        else {
            clearfix[i].classList.remove(""pos-left"");
            clearfix[i].classList.add(""pos-right"");
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CCommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
