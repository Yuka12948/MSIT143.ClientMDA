#pragma checksum "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4b4bddcc1d2a8a753de068023013b5404635b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_MovieInfoIndex2), @"mvc.1.0.view", @"/Views/Ticketing/MovieInfoIndex2.cshtml")]
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
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4b4bddcc1d2a8a753de068023013b5404635b7", @"/Views/Ticketing/MovieInfoIndex2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_MovieInfoIndex2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<電影院theater>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cyborg/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticketing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectByMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e4b4bddcc1d2a8a753de068023013b5404635b74701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
<style>
    html {
        background-color: #070720;
    }

    body {
        background-color: #070720;
    }

    .Screen {
        font-family: Montserrat, ""Noto Sans TC"", ""Microsoft JhengHei"", sans-serif !important;
        position: relative;
        width: 100%;
        min-height: 100vh;
        height: 100vh;
        background-color: #070720;
        z-index: 2000;
        padding-bottom: 100px;
        overflow: auto;
        height: calc(100vh - 130px);
        float: none;
        width: 100%;
        margin: 5px auto;
        overflow-y: auto;
    }

    .dyOReL {
        clear: both;
    }

    .Screen .wrapper {
        max-width: 1200px;
        width: 100%;
        margin: auto;
        text-align: center;
        position: relative;
        justify-content: space-between;
    }

        .Screen .wrapper .north {
            width: 35%;
        }

        .Screen .wrapper .space {
            width: 20%;
            height: 5vh;
        }

 ");
            WriteLiteral(@"       .Screen .wrapper .loc-part {
            min-width: 180px;
            width: 22%;
            min-height: 80vh;
            display: inline-flex;
            -webkit-box-pack: start;
            place-content: flex-start;
            flex-wrap: wrap;
            vertical-align: top;
        }

            .Screen .wrapper .loc-part .big-title {
                width: 100%;
                font-size: 1.375rem;
                color: rgb(158, 158, 158);
                font-weight: 300;
                text-align: left;
                height: 50px;
                float: left;
                margin: 0px;
            }

            .Screen .wrapper .loc-part .cinema {
                width: 100%;
                color: rgb(255, 255, 255);
                font-weight: 300;
                text-align: left;
                cursor: pointer;
                height: 50px;
            }

                .Screen .wrapper .loc-part .cinema:hover {
                    color: rgb(");
            WriteLiteral(@"220, 220, 220);
                    font-size: 1.1rem;
                }
</style>


<div id=""preloder"">
    <div class=""loader""></div>
</div>

<main id=""main"" data-aos=""fade"" data-aos-delay=""1500"">
    <section class=""pricing"" id=""pricing"">
        <div class=""Screen"">
            <div class=""wrapper"">
                <div class=""space""></div>
                <div class=""loc-part north"">
                    <h3 class=""big-title"">北區</h3>
                    <div class=""commonStyled__Clearfix-sc-kt5vy-2 dyOReL""></div>
");
#nullable restore
#line 107 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                      
                        foreach (var item in Model)
                        {
                            if (item.地址address.Contains("台北") || item.地址address.Contains("新北") || item.地址address.Contains("宜蘭") || item.地址address.Contains("基隆"))
                            {
                                int id = item.電影院編號theaterId;
                                string name = item.電影院名稱theaterName;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"cinema\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4b4bddcc1d2a8a753de068023013b5404635b79193", async() => {
#nullable restore
#line 114 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                                                                                                Write(name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-theaterID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                               WriteLiteral(id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-theaterID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 115 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"loc-part \">\r\n                    <h3 class=\"big-title\">桃竹苗</h3>\r\n                    <div class=\"commonStyled__Clearfix-sc-kt5vy-2 dyOReL\"></div>\r\n");
#nullable restore
#line 122 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                      
                        foreach (var item in Model)
                        {
                            if (item.地址address.Contains("桃園") || item.地址address.Contains("新竹") || item.地址address.Contains("苗栗"))
                            {
                                int id = item.電影院編號theaterId;
                                string name = item.電影院名稱theaterName;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"cinema\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4b4bddcc1d2a8a753de068023013b5404635b713076", async() => {
#nullable restore
#line 129 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                                                                                                Write(name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-theaterID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                               WriteLiteral(id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-theaterID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 130 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"loc-part \">\r\n                    <h3 class=\"big-title\">中區</h3><div class=\"commonStyled__Clearfix-sc-kt5vy-2 dyOReL\"></div>\r\n");
#nullable restore
#line 136 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                      
                        foreach (var item in Model)
                        {
                            if (item.地址address.Contains("台中") || item.地址address.Contains("彰化") || item.地址address.Contains("南投") || item.地址address.Contains("雲林"))
                            {
                                int id = item.電影院編號theaterId;
                                string name = item.電影院名稱theaterName;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"cinema\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4b4bddcc1d2a8a753de068023013b5404635b716968", async() => {
#nullable restore
#line 143 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                                                                                                Write(name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-theaterID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                               WriteLiteral(id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-theaterID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 144 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"loc-part \">\r\n                    <h3 class=\"big-title\">南區花東及離島</h3>\r\n                    <div class=\"commonStyled__Clearfix-sc-kt5vy-2 dyOReL\"></div>\r\n");
#nullable restore
#line 151 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                      
                        foreach (var item in Model)
                        {
                            if (item.地址address.Contains("高雄") || item.地址address.Contains("台南") || item.地址address.Contains("澎湖") || item.地址address.Contains("屏東") || item.地址address.Contains("嘉義") || item.地址address.Contains("花蓮"))
                            {
                                int id = item.電影院編號theaterId;
                                string name = item.電影院名稱theaterName;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"cinema\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4b4bddcc1d2a8a753de068023013b5404635b720955", async() => {
#nullable restore
#line 158 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                                                                                                Write(name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-theaterID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                                                               WriteLiteral(id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-theaterID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["theaterID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 159 "C:\Users\Student\Documents\MSIT143.ClientMDA1025_2\ClientMDA\Views\Ticketing\MovieInfoIndex2.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </section>

</main>

<script>
    (function ($) {
        $(window).on('load', function () {
            $("".loader"").fadeOut();
            $(""#preloder"").delay(20).fadeOut(""slow"");


        });
    })(jQuery);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<電影院theater>> Html { get; private set; }
    }
}
#pragma warning restore 1591
