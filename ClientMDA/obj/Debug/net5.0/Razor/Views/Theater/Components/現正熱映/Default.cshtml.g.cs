#pragma checksum "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b4e8c27184fadcdcfb83722a850e780b2f0f22c"
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
#line 1 "C:\MDA前\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b4e8c27184fadcdcfb83722a850e780b2f0f22c", @"/Views/Theater/Components/現正熱映/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Theater_Components_現正熱映_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CTheater>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
  
    ViewData["Title"] = "Default";




#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
  


    for (var i = 0; i < 12; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 164, "\"", 238, 1);
#nullable restore
#line 16 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 171, Url.Action("快定頁面測試", "Theater", new { id = Model[i].電影編號movieId }), 171, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            <div class=\"post-box\">\r\n\r\n");
#nullable restore
#line 20 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
                  
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
            BeginWriteAttribute("style", " style=\"", 735, "\"", 775, 4);
            WriteAttributeValue("", 743, "background-image:", 743, 17, true);
            WriteAttributeValue(" ", 760, "url(\'", 761, 6, true);
#nullable restore
#line 30 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 766, urlpic, 766, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 773, "\')", 773, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
            WriteLiteral("                <div class=\"star\">\r\n                    <div class=\"commonStyled__MovieStars-sc-kt5vy-3 ijuViJ\" style=\"text-align: center\">\r\n\r\n");
#nullable restore
#line 36 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
                          
                            decimal? x = Model[i].評分rate;
                            decimal? 總評分 = 0;
                            decimal? 平均評分 = 0;
                            decimal 會員的評分 = 0;
                            decimal 會員的評分結果 = 0;

                            string 轉 = "";
                            if (Model[i].會員評分.Count() != 0)
                            {
                                for (int a = 0; a < Model[i].會員評分.Count(); a++)
                                {

                                    總評分 += Model[i].會員評分[a];
                                }
                                平均評分 = 總評分 / Model[i].會員評分.Count();
                                轉 = 平均評分.ToString();
                                會員的評分 = decimal.Parse(轉);
                                會員的評分結果 = decimal.Round(會員的評分, 1);
                            }
                            if (Model[i].會員評分.Count() != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"star\" style=\" text-align: center\"><i class=\"fas fa-star\" style=\"color:#ffc107\"></i></div>\r\n                                <div class=\"star\" style=\" text-align: center\">");
#nullable restore
#line 59 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
                                                                         Write(會員的評分結果);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 60 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"star\" style=\" text-align: center\"><i class=\"fas fa-star\" style=\"color:#ffc107\"></i></div>\r\n                                <div class=\"star\" style=\" text-align: center\">");
#nullable restore
#line 64 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
                                                                         Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 65 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"title\"");
            BeginWriteAttribute("title", " title=\"", 2657, "\"", 2687, 1);
#nullable restore
#line 74 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 2665, Model[i].中文標題titleCht, 2665, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2731, "\"", 2760, 1);
#nullable restore
#line 75 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 2739, Model[i].電影編號movieId, 2739, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 76 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
               Write(Model[i].中文標題titleCht);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"en\"");
            BeginWriteAttribute("title", " title=\"", 2865, "\"", 2895, 1);
#nullable restore
#line 78 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
WriteAttributeValue("", 2873, Model[i].英文標題titleEng, 2873, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 79 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
               Write(Model[i].英文標題titleEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"grade\">\r\n                    ");
#nullable restore
#line 83 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"
               Write(Model[i].分級級數ratingLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 87 "C:\MDA前\ClientMDA\Views\Theater\Components\現正熱映\Default.cshtml"

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
