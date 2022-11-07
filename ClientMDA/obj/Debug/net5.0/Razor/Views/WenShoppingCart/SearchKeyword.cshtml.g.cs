#pragma checksum "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\SearchKeyword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c0db2cde1634a70adfe54d271c510e1f059c3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WenShoppingCart_SearchKeyword), @"mvc.1.0.view", @"/Views/WenShoppingCart/SearchKeyword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0db2cde1634a70adfe54d271c510e1f059c3de", @"/Views/WenShoppingCart/SearchKeyword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_WenShoppingCart_SearchKeyword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\SearchKeyword.cshtml"
  
    ViewData["Title"] = "SearchKeyword";
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
</style>
<div style=""display:block;height:40px;""></div>

<div class=""row"">
    <div class=""col-2"">

    </div>
    <div class=""col-8"">

");
            WriteLiteral("        <button type=\"button\" id=\"mysearch\" class=\"btn-primary\"><i class=\"fa-solid fa-magnifying-glass\"></i>搜尋關鍵字</button>\r\n        <input type=\"text\" class=\"form-control\" id=\"mykeyword\">\r\n\r\n    </div>\r\n    <div class=\"col-2\"></div>\r\n</div>\r\n\r\n<br />\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card-columns\">\r\n\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
     const inputText = document.querySelector(""#mykeyword"")
     const Mysearch = document.querySelector(""#mysearch"")
     const Mydiv1 = document.querySelector(""#mydiv"")
     const MylistData = document.querySelector("".container"")

     inputText.addEventListener(""input"", async () => {
         const keyword = inputText.value
         //console.log(keyword)
         let response = await fetch(""");
#nullable restore
#line 64 "C:\Users\Student\Documents\MDA\ClientMDA\Views\WenShoppingCart\SearchKeyword.cshtml"
                                Write(Url.Content("~/WenShoppingCart/TestSearchKeyword"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?keyword=${keyword}`)
         // console.log(response)
         let result = await response.json() //[""Chai"",""Chang"",""Chartreuse verte""]
         //console.log(result.length)
         console.log(result)

         result.forEach(item => {
             //console.log(item.商品名稱productName)
             //console.log(item.商品價格productPrice)
             //console.log(item.商品介紹introduce)
             //console.log(item.商品圖片路徑imagePath)
             //console.log(item.電影院名稱theaterName)
             //console.log(item.商品編號productId)

         })
         let b = result.map(item => {

             return (
                 `<div class=""container"">
<div class=""col-md-4"">
                 <div typeof=""hidden"" value=""${item.商品編號productId}""></div>
                 <div class=""card bg-white text-dark"" style=""width: 20rem; height:33rem;"" >
                 <img class=""card-img-top img-thumbnail p-4"" src=""/images/WenProduct/${item.商品圖片路徑imagePath}"" />
                 <div class=""card-body"">
   ");
                WriteLiteral(@"              <h5 class=""card-title"">品名: ${item.商品名稱productName}<br/><small>[${item.電影院名稱theaterName}]<small></h5>
                 <p class=""card-text"">類別: ${item.類別category}</br>價格: ${item.商品價格productPrice}</br>描述: ${item.商品介紹introduce}</p>
                 <a href=""#"" class=""btn btn-outline-success"">加入購物車</a>
                </div>
</div>
                </div>
</div>`
                 )
         })
         document.querySelector("".card-columns"").innerHTML = b.join("""")

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
