#pragma checksum "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b163986e296d2fa16784beba0c598fc02e18236"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_Components_SelectScreen_Default), @"mvc.1.0.view", @"/Views/Ticketing/Components/SelectScreen/Default.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
using ClientMDA.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b163986e296d2fa16784beba0c598fc02e18236", @"/Views/Ticketing/Components/SelectScreen/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_Components_SelectScreen_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CAjaxCinemaTypeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
  
    var q = Model;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    <div>\r\n        <div class=\"row\">\r\n            <div class=\"col-2\"></div>\r\n            <div class=\"col-8 text-center\">\r\n                <div class=\"versionList m-auto\">\r\n");
#nullable restore
#line 16 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                      
                        int i = 0;
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"version VersionPicker\"");
            BeginWriteAttribute("data", " data=\"", 511, "\"", 520, 1);
#nullable restore
#line 20 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
WriteAttributeValue("", 518, i, 518, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                                                    Write(item.TypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 21 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                            i++;
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                      
                        switch (Model.Count())
                        {
                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"linebox \"><div class=\"line\" style=\"margin-left:300px\" id=\"Blueline\"></div></div>\r\n");
#nullable restore
#line 29 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                break;
                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"linebox \"><div class=\"line\" style=\"margin-left:220px\" id=\"Blueline\"></div></div>\r\n");
#nullable restore
#line 32 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                break;
                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"linebox \"><div class=\"line\" style=\"margin-left:150px\" id=\"Blueline\"></div></div>\r\n");
#nullable restore
#line 35 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                break;
                            case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"linebox \"><div class=\"line\" style=\"margin-left:73px\" id=\"Blueline\"></div></div>\r\n");
#nullable restore
#line 38 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                break;
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-2\"></div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-12 text-center\">\r\n");
#nullable restore
#line 50 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
              
                int flag = 1;
                int data = 0;
                foreach (var item in Model)
                {
                    foreach (var screen in item.Info_list)
                    {
                        string seatstr = $"{screen.seatCount}";
                        if (flag == 1)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"screen ScreenPicker showscreen\"");
            BeginWriteAttribute("data", " data=\"", 2198, "\"", 2210, 1);
#nullable restore
#line 61 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
WriteAttributeValue("", 2205, data, 2205, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2211, "\"", 2229, 1);
#nullable restore
#line 61 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
WriteAttributeValue("", 2219, screen.id, 2219, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"d-block pt-3 \">");
#nullable restore
#line 62 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                                    Write(screen.Start_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block \" style=\"font-size:10px;color:lightcyan\">");
#nullable restore
#line 63 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                                                                      Write(seatstr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block \" style=\"font-size:10px;color:lightcyan\">剩餘座位</i>\r\n                            </div>\r\n");
#nullable restore
#line 66 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"screen ScreenPicker\"");
            BeginWriteAttribute("data", " data=\"", 2700, "\"", 2712, 1);
#nullable restore
#line 69 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
WriteAttributeValue("", 2707, data, 2707, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2713, "\"", 2731, 1);
#nullable restore
#line 69 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
WriteAttributeValue("", 2721, screen.id, 2721, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"d-block pt-3 \">");
#nullable restore
#line 70 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                                    Write(screen.Start_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block \" style=\"font-size:10px;color:lightcyan\">");
#nullable restore
#line 71 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                                                                                      Write(seatstr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                <i class=\"d-block \" style=\"font-size:10px;color:lightcyan\">剩餘座位</i>\r\n                            </div>\r\n");
#nullable restore
#line 74 "C:\Users\Student\Documents\MDA\ClientMDA\Views\Ticketing\Components\SelectScreen\Default.cshtml"
                        }
                    }
                    flag = 0;
                    data++;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<br />\r\n<div class=\"bigline\"></div>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CAjaxCinemaTypeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
