#pragma checksum "C:\Users\Student\Documents\123\ClientMDA\Views\Ticketing\SelectPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "913482883fdc8e49401e25e90e8f207e7b9c6c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_SelectPartialView), @"mvc.1.0.view", @"/Views/Ticketing/SelectPartialView.cshtml")]
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
#line 1 "C:\Users\Student\Documents\123\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\123\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"913482883fdc8e49401e25e90e8f207e7b9c6c9e", @"/Views/Ticketing/SelectPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_SelectPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticketing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SeatMap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .header {
        transition: all 0.5s;
        z-index: 997;
        padding: 30px 0;
        background-color: #000;
    }

    .Screen {
        font-family: Montserrat, ""Noto Sans TC"", ""Microsoft JhengHei"", sans-serif !important;
        position: relative;
        width: 100%;
        min-height: 110vh;
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
     ");
            WriteLiteral(@"       }

            .Screen .wrapper .loc-part {
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
                    he");
            WriteLiteral(@"ight: 50px;
                }

                    .Screen .wrapper .loc-part .cinema:hover {
                        color: rgb(220, 220, 220);
                        font-size: 1.1rem;
                    }
</style>

<div class=""Screen"">
    <div class=""wrapper"">
        <div class=""space""></div>
        <div class=""loc-part north"">
            <h3 class=""big-title"">北區</h3>
            <div class=""commonStyled__Clearfix-sc-kt5vy-2 dyOReL""></div>
            <div class=""cinema"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "913482883fdc8e49401e25e90e8f207e7b9c6c9e6635", async() => {
                WriteLiteral("台北信義威秀影城");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
            <div class=""cinema"">台北美麗華大直影城</div>
            <div class=""cinema"">台北京站威秀影城</div>
            <div class=""cinema"">板橋大遠百威秀影城</div>
            <div class=""cinema"">喜樂時代影城南港店</div>
            <div class=""cinema"">台北in89豪華數位影城</div>
            <div class=""cinema"">喜滿客絕色影城</div>
            <div class=""cinema"">台北獅子林新光影城</div>
            <div class=""cinema"">林口MITSUI OUTLET PARK威秀影城</div>
            <div class=""cinema"">台北樂聲影城</div>
            <div class=""cinema"">喜樂時代影城永和店</div>
            <div class=""cinema"">台北真善美劇院</div>
            <div class=""cinema"">梅花數位影城</div>
            <div class=""cinema"">哈拉影城</div>
            <div class=""cinema"">台北新民生戲院</div>
            <div class=""cinema"">花蓮新天堂樂園威秀影城</div>
            <div class=""cinema"">中和環球威秀影城</div>
            <div class=""cinema"">MUVIE CINEMAS台北松仁威秀</div>
            <div class=""cinema"">台北天母新光影城</div>
        </div><div class=""loc-part "">
            <h3 class=""big-title"">桃竹苗</h3>
            <div class=""commonStyled__Cle");
            WriteLiteral(@"arfix-sc-kt5vy-2 dyOReL""></div>
            <div class=""cinema"">桃園青埔新光影城</div>
            <div class=""cinema"">喜樂時代影城桃園A19店</div>
            <div class=""cinema"">桃園in89統領影城</div>
            <div class=""cinema"">桃園統領威秀影城</div>
            <div class=""cinema"">新竹大遠百威秀影城</div>
            <div class=""cinema"">頭份尚順威秀影城</div>
            <div class=""cinema"">新竹巨城威秀影城</div>
        </div>
        <div class=""loc-part "">
            <h3 class=""big-title"">中區</h3><div class=""commonStyled__Clearfix-sc-kt5vy-2 dyOReL""></div>
            <div class=""cinema"">台中豐原in89豪華影城</div>
            <div class=""cinema"">台中大遠百威秀影城</div>
            <div class=""cinema"">台中大魯閣新時代威秀影城</div>
            <div class=""cinema"">台中Tiger City威秀影城</div>
            <div class=""cinema"">台中中港新光影城</div>
        </div>
        <div class=""loc-part "">
            <h3 class=""big-title"">南區及離島</h3>
            <div class=""commonStyled__Clearfix-sc-kt5vy-2 dyOReL""></div>
            <div class=""cinema"">台南南紡威秀影城</div><div class=""cinema"">台南大遠");
            WriteLiteral(@"百威秀影城</div>
            <div class=""cinema"">台南FOCUS威秀影城</div><div class=""cinema"">台南西門新光影城</div>
            <div class=""cinema"">台南真善美劇院</div><div class=""cinema"">高雄大遠百威秀影城</div>
            <div class=""cinema"">高雄in89駁二電影院</div><div class=""cinema"">中影屏東影城</div>
            <div class=""cinema"">澎湖in89豪華影城</div>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
