#pragma checksum "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2572b08fe42095b91afa8d740c5ee2a912364045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Theater_Components_時間_Default), @"mvc.1.0.view", @"/Views/Theater/Components/時間/Default.cshtml")]
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
#line 1 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2572b08fe42095b91afa8d740c5ee2a912364045", @"/Views/Theater/Components/時間/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Theater_Components_時間_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CTheater>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .roddy {\r\n        border: 2px solid blue;\r\n        box-shadow: blue 0px 2px 4px 0px;\r\n    }\r\n    .oo {\r\n    }\r\n    .kk {\r\n    }\r\n</style>\r\n\r\n\r\n\r\n");
#nullable restore
#line 20 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
 foreach (var item in Model)
{





    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
     foreach (CcinemaViewMode q in item.cinemas影廳種類)
    {
        
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
         if (q.場次ID.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cinemabox\" id=\"ts22\">\r\n\r\n    <div class=\"cinemaName\">\r\n        ");
#nullable restore
#line 35 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
   Write(item.電影院名稱theaterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"toggleBox  sts\" id=\"time\">\r\n");
            WriteLiteral("                <div class=\"sessionBox\" id=\"tt\">\r\n                \r\n");
#nullable restore
#line 41 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                     if (q.場次ID.Count > 0)
                    {

                      

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"version\" id=\"tn\">\r\n                            ");
#nullable restore
#line 46 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                       Write(q.CinemaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            \r\n                        </div>\r\n");
#nullable restore
#line 49 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"session\">\r\n");
#nullable restore
#line 51 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                         for (int i = 0; i < q.場次ID.Count(); i++)
                        {
                            string a = q.放映時間[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"time tt1\">\r\n");
            WriteLiteral("                            <input type=\"hidden\" class=\"場場\"");
            BeginWriteAttribute("value", " value=\"", 1351, "\"", 1369, 1);
#nullable restore
#line 58 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
WriteAttributeValue("", 1359, q.場次ID[i], 1359, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div style=\"display:none\" class=\"場次123\">");
#nullable restore
#line 59 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                                                               Write(q.場次ID[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <span class=\"seats\"></span> ");
#nullable restore
#line 60 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                                                   Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n");
#nullable restore
#line 63 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n");
#nullable restore
#line 71 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
                         
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\新增資料夾 (2)\ClientMDA\Views\Theater\Components\時間\Default.cshtml"
         
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $("".time"").click(function () {
        var x = $("".datebox.checked .month"").html()+$("".datebox.checked .date"").html()
        var i = $("".oo .cinemaName"").html()
        var a = $("".kk .version"").html()
        var t = $("".roddy"").html()
        var 場次 = $("".time.roddy input"").val()
        var 座位 = $("".場場"").val()
        console.log(座位)
        //console.log(t)
        document.querySelector(""#新視窗"").style.display = ""inline""
        document.querySelector(""#影城"").innerHTML=i
        document.querySelector(""#日期"").innerHTML = x
        document.querySelector(""#時間"").innerHTML = t
        document.querySelector(""#版本"").innerHTML = a

    })
    //$("".session .time"").hover(function () {
    //    $(this).removeClass(""roddy"").siblings().removeClass(""roddy"").end().addClass(""roddy"");
    //},
    //    function () {
    //        $(this).prevAll().removeClass(""roddy"").end().removeClass(""roddy"");
    //    });
    $("".tt1"").hover(function () {

        $(this).removeClass(""roddy"").s");
            WriteLiteral(@"iblings().removeClass(""roddy"").end().addClass(""roddy"");
        var 場次 = $("".場次123"").html()
        var 場次2 = $("".場場"").html()
        console.log(場次2)

        console.log(場次)
    },
        function () {
            $(this).prevAll().removeClass(""roddy"").end().removeClass(""roddy"");
        });

    $("".session .time"").click(function () {
        $(this).removeClass(""iooi"").siblings().removeClass(""iooi"").end().addClass(""iooi"");
        $("".submit"").addClass(""iooi"")
        var 場次 = $("".場次"").val()
        console.log(場次)
    })
    $("".cinemabox"").hover(function () {

            $(this).removeClass(""oo"").siblings().removeClass(""oo"").end().addClass(""oo"");
        },
            function () {

                $(this).prevAll().removeClass(""oo"").end().removeClass(""oo"");
        });
    $("".sessionBox"").hover(function () {

        $(this).removeClass(""kk"").siblings().removeClass(""kk"").end().addClass(""kk"");
    },
        function () {

            $(this).prevAll().removeClass(""kk""");
            WriteLiteral(").end().removeClass(\"kk\");\r\n        });\r\n</script>");
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
