#pragma checksum "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1de96b50eb1add0350f968b676fcec346ed5ada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Theater_Components_現正熱映_Default), @"mvc.1.0.view", @"/Views/Theater/Components/現正熱映/Default.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\MDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1de96b50eb1add0350f968b676fcec346ed5ada", @"/Views/Theater/Components/現正熱映/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Theater_Components_現正熱映_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CTheater>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
  
    ViewData["Title"] = "Default";

 


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
  


    for (var i = 0; i < 12; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 165, "\"", 239, 1);
#nullable restore
#line 16 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 172, Url.Action("快定頁面測試", "Theater", new { id = Model[i].電影編號movieId }), 172, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            <div class=\"post-box\">\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
                  
                    string urlpic = "";
                    if (Model[i].MPimg.Count > 0)
                        urlpic = "https://localhost:44381/images/MovieImage/" + Model[i].MPimg[0];
                    //urlpic =Model[i].MPimg[0];

                    else
                    {
                        urlpic = "../../images/Theater/common/poster.png";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"post\"");
            BeginWriteAttribute("style", " style=\"", 736, "\"", 776, 4);
            WriteAttributeValue("", 744, "background-image:", 744, 17, true);
            WriteAttributeValue(" ", 761, "url(\'", 762, 6, true);
#nullable restore
#line 30 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 767, urlpic, 767, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 774, "\')", 774, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
            WriteLiteral(@"                <div class=""star"">
                    <div class=""commonStyled__MovieStars-sc-kt5vy-3 ijuViJ "">
                        <div class=""star""><i class=""fas fa-star"" style=""padding-right:5px;color:#ffc107""></i></div>
                        <div class=""star""><i class=""fas fa-star"" style=""padding-right:5px;color:#ffc107""></i></div>
                        <div class=""star""><i class=""fas fa-star"" style=""padding-right:5px;color:#ffc107""></i></div>
                        <div class=""star""><i class=""fas fa-star"" style=""padding-right:5px;color:#ffc107""></i></div>
                        <div class=""star""><i class=""fas fa-star"" style=""padding-right:5px;color:#ffc107""></i></div>
                    </div>
                </div>

                <div class=""title""");
            BeginWriteAttribute("title", " title=\"", 1595, "\"", 1625, 1);
#nullable restore
#line 43 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 1603, Model[i].中文標題titleCht, 1603, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1669, "\"", 1698, 1);
#nullable restore
#line 44 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 1677, Model[i].電影編號movieId, 1677, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 45 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
               Write(Model[i].中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"en\"");
            BeginWriteAttribute("title", " title=\"", 1803, "\"", 1833, 1);
#nullable restore
#line 47 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 1811, Model[i].英文標題titleEng, 1811, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 48 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
               Write(Model[i].英文標題titleEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"grade\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
               Write(Model[i].分級級數ratingLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 56 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"

    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n   \r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CTheater>> Html { get; private set; }
    }
}
#pragma warning restore 1591
