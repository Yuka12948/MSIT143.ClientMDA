#pragma checksum "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22f22beb4de69c2de48ab4d99c912fd8ac018746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Theater_測試業面), @"mvc.1.0.view", @"/Views/Theater/測試業面.cshtml")]
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
#line 1 "C:\MDA前端\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MDA前端\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22f22beb4de69c2de48ab4d99c912fd8ac018746", @"/Views/Theater/測試業面.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Theater_測試業面 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientMDA.ViewModels.CTheater >>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Theater/電影院用改.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml"
  
    ViewData["Title"] = "測試業面";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22f22beb4de69c2de48ab4d99c912fd8ac0187463996", async() => {
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
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\r\n<style>\r\n\r\n    .star {\r\n        font-size: 2px !important;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f22beb4de69c2de48ab4d99c912fd8ac0187465293", async() => {
                WriteLiteral(@"


    <div class=""commonStyled__WrapperSampleNoContent-sc-kt5vy-9 MovieInfoContentWrapper--1tebbv1 exLSHN gYprgf"" id=""title"" style=""        padding-top: 100px; overflow: auto"">
        <div class=""wrapper"" style=""width:100% ;height:130px "">
            <div id=""熱映"" class=""tab checked"">
                現正熱映
            </div>
            <div id=""上映"" class=""tab"">
                即將上映
            </div>
            <div class=""underline"">
                <div class=""bar""></div>
            </div>
        </div>
        <div class=""commonStyled__WrapperSampleNoContent-sc-kt5vy-9 MovieInfoBoxWrapper--13nahzv exLSHN bYVeqc"">

            <div id=""頁面切換"" class=""box-wrapper"">

                ");
#nullable restore
#line 32 "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml"
           Write(await Component.InvokeAsync("現正熱映", new { datas = Model }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            </div>\r\n            <div class=\"page\">\r\n                ");
#nullable restore
#line 37 "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml"
           Write(await Component.InvokeAsync("頁數", new { datas = Model }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            </div>
        </div>




    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script> 
<script>
            $(""#上映"").click(function () {
                $(this).removeClass(""checked"").siblings().removeClass(""checked"").end().addClass(""checked"");
                $(""#title"").removeClass(""gYprgf"").addClass(""iyFFWC"")
                $(""#頁面切換"").load(""");
#nullable restore
#line 50 "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml"
                            Write(Url.Content("~/Theater/now"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n                $(\".page\").load(\"");
#nullable restore
#line 51 "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml"
                            Write(Url.Content("~/Theater/page"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""")

            })

            $(""#熱映"").click(function () {
                $(this).removeClass(""checked"").siblings().removeClass(""checked"").end().addClass(""checked"");
                $(""#title"").removeClass(""iyFFWC"").addClass(""gYprgf"")
                $(""#頁面切換"").load(""");
#nullable restore
#line 58 "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml"
                            Write(Url.Content("~/Theater/hot"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n                $(\".page\").load(\"");
#nullable restore
#line 59 "C:\MDA前端\ClientMDA\Views\Theater\測試業面.cshtml"
                            Write(Url.Content("~/Theater/page"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n\r\n            })\r\n \r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientMDA.ViewModels.CTheater >> Html { get; private set; }
    }
}
#pragma warning restore 1591
