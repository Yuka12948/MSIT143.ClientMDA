#pragma checksum "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "504aa9d37b50b29b729c422797d938bc74e12a00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WenShoppingCart_Index), @"mvc.1.0.view", @"/Views/WenShoppingCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"504aa9d37b50b29b729c422797d938bc74e12a00", @"/Views/WenShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_WenShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/unknown.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100 rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/WenProduct/bg04.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Fist slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/WenProduct/bg05.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second side"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/WenProduct/bg06.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WenLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .text-6:hover {
        /*box-shadow: 0 10px;*/
        padding-bottom: 20px;
        margin: 10px;
        padding: 10px;
        text-decoration: none;
        border-bottom: 5px #00ffff solid;
    }

    .text-6 {
        /*box-shadow: 0 10px;*/
        padding-bottom: 20px;
        margin: 10px;
        padding: 10px;
        text-decoration: none;
    }

    a:hover {
        text-decoration: none;
        color: darkgreen;
        /*border-bottom: 2px #0094ff solid;*/
    }

    tab-pane {
        display: none;
    }

    show {
        display: block;
    }
</style>
<div style=""display:block;height:40px;""></div>
<figure style=""float:left; position: fixed;left: 40px;top:50%;width:600px;margin-top: -2.5em;border-block: initial;list-style-type: none;z-index:999;"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "504aa9d37b50b29b729c422797d938bc74e12a007201", async() => {
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
            WriteLiteral("\r\n</figure>\r\n");
            WriteLiteral(@"<div class=""container"">
    <div id=""carousel1"" class=""carousel slide"" data-interval=""5000"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carousel1"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carousel1"" data-slide-to=""0""></li>
            <li data-target=""#carousel1"" data-slide-to=""0""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "504aa9d37b50b29b729c422797d938bc74e12a008877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "504aa9d37b50b29b729c422797d938bc74e12a0010156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "504aa9d37b50b29b729c422797d938bc74e12a0011436", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <a style=""border-bottom:none"" class=""carousel-control-prev"" href=""#carousel1"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon""></span>
        </a>
        <a style=""border-bottom:none"" class=""carousel-control-next"" href=""#carousel1"" data-slide=""next"">
            <span class=""carousel-control-next-icon""></span>
        </a>
    </div>
</div>
");
            WriteLiteral("\r\n<div style=\"display:block;height:40px;\"></div>\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-7\"></div>\r\n        <div class=\"col-5\">\r\n            <select id=\"select1\" class=\"form-select text-white bg-success bg-opacity-50\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "504aa9d37b50b29b729c422797d938bc74e12a0013431", async() => {
                WriteLiteral("請選擇電影院");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n<div style=\"display:block;height:40px;\"></div>\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <ul id=\"u1\" class=\"nav nav-tabs\">\r\n    </ul>\r\n    <div style=\"display:block;height:20px;\"></div>\r\n    <div class=\"tab-content\" id=\"prdcontainer\">\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n<div style=\"display:block;height:20px;\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //<option value=""cat"" selected>Cat</option>
        const sel = document.getElementById(""select1"")
        let u1 = document.getElementById(""u1"")
        let mytab = document.getElementById(""mytab"")
        let prdcontainer = document.getElementById('prdcontainer')
        let divarr = new Array();

         async function LoadTheaters() {
             let response = await fetch(""");
#nullable restore
#line 112 "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\Index.cshtml"
                                    Write(Url.Content("~/WenShoppingCart/Theater"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""")
             //JSON.stringify(response)
             //let datas = await JSON.stringify(response)
             let datas = await response.json()
             //console.log(datas.length)
             console.log(datas)
             for (var i = 0; i < datas.length; i++) {
                 const opt = new Option(datas[i]['電影院名稱theaterName'], datas[i]['電影院編號theaterId'])
                 sel.options.add(opt)
             }
        }
        LoadTheaters()

        //$(document).ready(init);
        //function init(){

        //}

        sel.addEventListener(""change"", async () => {
            divarr = [];
            $('#prdcontainer').empty();
            let intheater = sel.options[sel.selectedIndex].value
            console.log(sel.options[sel.selectedIndex].value)
            console.log(sel.options[sel.selectedIndex].textContent)
            let response = await fetch(""");
#nullable restore
#line 136 "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\Index.cshtml"
                                   Write(Url.Content("~/WenShoppingCart/Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?theaterId=${intheater}`)
            let DATAS = await response.json()

            let Frag = document.createDocumentFragment()
            for (let i = 0; i < DATAS.length; i++) {

                let innobj = """";
                const ele = document.createElement(""li"")
                const Aele = document.createElement(""a"")
                const txt = document.createTextNode(DATAS[i])
                ele.classList.add(""nav-item"")
                ele.classList.add(""myitem"" + i)
                Aele.classList.add(""nav-linke"")
                Aele.classList.add(""text-white"")
                Aele.classList.add(""text-6"")
                Aele.setAttribute(""href"", `javascript::#item${i}`)
                Aele.setAttribute(""value"", `${i}`)
                Aele.setAttribute(""data-toggle"", ""tab"")
                ele.appendChild(Aele)
                Aele.appendChild(txt)
                Frag.appendChild(ele)


                let Prdresponse = await fetch(""");
#nullable restore
#line 159 "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\Index.cshtml"
                                          Write(Url.Content("~/WenShoppingCart/Prod"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?categoryName=${txt.textContent}` + `&` + `theaterId=${intheater}`)
                let Prdresult = await Prdresponse.json()
                console.log(Prdresult);

                let divout = document.createElement(""div"");
                divout.classList.add('tab-pane')
                divout.classList.add('show');
                /*divout.classList.add('fade');*/

                divout.classList.add('active');
                divout.setAttribute('id',`#item${i}`)

                for (let prd of Prdresult) {
                    innobj += `<div class=""pt-2"" >
                                <div class=""container"">
                                    <ul class=""list-unstyled text-success"" style=""float:left;margin-right:25px;margin-top:30px;"">
                                        <li class=""media p-3"">
                                            <input type=""hidden"" value=""${prd.商品編號productId}"" />
                                            <img src=""/images/WenProduct/${prd.商品圖片路");
                WriteLiteral(@"徑imagePath}"" class=""mr-3 img-thumbnail img-fluid"" style=""width:150px;height:120px"" />
                                            <div class=""media-body"">
                                                <h4>${prd.商品名稱productName}</h4>
                                                <p><i class=""fa-solid fa-sign-hanging""></i>${prd.商品介紹introduce}</p>
                                                <a href=""WenShoppingCart/AddToCart/?id=${prd.商品編號productId}"" class=""btn btn-outline-success"">加入購物車</a>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>`
                }
                divout.innerHTML = innobj;
                //prdcontainer.appendChild(divout);
                divarr.push(divout);
            }//for迴圈

            u1.innerHTML = """";
            u1.appendChild(Frag)
            prdcontainer.appendChild(divarr[0]);

  ");
                WriteLiteral(@"          $('.nav-linke').click(function () {
                targetboxid = this.getAttribute('value')
                $('#prdcontainer').empty();
                prdcontainer.appendChild(divarr[targetboxid]);
            })


        })


    </script>
");
            }
            );
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
