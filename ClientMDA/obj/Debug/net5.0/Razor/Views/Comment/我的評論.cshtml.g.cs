#pragma checksum "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\我的評論.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7dd0e34e2222d506a3f0511c78c86d726dd5a41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_我的評論), @"mvc.1.0.view", @"/Views/Comment/我的評論.cshtml")]
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
#line 1 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\_ViewImports.cshtml"
using ClientMDA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7dd0e34e2222d506a3f0511c78c86d726dd5a41", @"/Views/Comment/我的評論.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_我的評論 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Comment/jquery.eeyellow.Timeline.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Comment/jquery.eeyellow.Timeline.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\jo3wait\Documents\MSIT143.ClientMDA\ClientMDA\Views\Comment\我的評論.cshtml"
  
    ViewData["Title"] = "我的評論";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7dd0e34e2222d506a3f0511c78c86d726dd5a414750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    <style>\r\n\r\n        body {\r\n            font-family: \'Roboto\';\r\n            background-color: #fafafa;\r\n        }\r\n\r\n        .container {\r\n            margin-top: 150px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""VivaTimeline"">
    <dl>

        <!--月份 1-->
        <dt>Feb 2018</dt>

        <!--左側文章 start-->
        <dd class=""pos-left clearfix"">
            <div class=""circ""></div>
            <div class=""time"">Feb 20</div><!--填入日期-->
            <div class=""events"">
                <div class=""events-header"">Blogger 官方免費幫自訂網址升級 HTTPS！</div><!--填入標題-->
                <div class=""events-body"">
                    <div class=""row"">
                        <div class=""col-md-6 pull-left"">
                            <img class=""events-object img-responsive img-rounded"" src=""https://4.bp.blogspot.com/-wXph1d9tAxM/WokCWJ06S6I/AAAAAAAAWZQ/kJcyc9mbSiIT99OE1yEx426CkET1NeHFgCLcBGAs/s1600/blogger-custom-domain-official-https-upgrade.jpg"" /><!--填入圖片網址-->
                        </div>
                        <div class=""events-desc"">這真的是最好的新年禮物了，過年前夕在「 FB 社團 」 +Vista Cheng 分享了「 Blogger站長看過來：自訂網域的網誌，也可以支援HTTPS囉 」 ，原來官方悄悄開始測試，可以讓自訂網域直接升級 HTTPS，這代表： 不用付錢，Blogger 免費提供我們網...</div><!--填入描述-->
       ");
            WriteLiteral(@"             </div>
                </div>
                <div class=""events-footer""><a href=""https://www.wfublog.com/2018/02/blogger-custom-domain-official-https-upgrade.html"" target=""_blank"">繼續閱讀</a></div><!--可填底部標題 或刪除-->
            </div>
        </dd>
        <!--左側文章 end-->
        <!--右側文章 start-->
        <dd class=""pos-right clearfix"">
            <div class=""circ""></div>
            <div class=""time"">Feb 13</div><!--填入日期-->
            <div class=""events"">
                <div class=""events-header"">究竟 Blogger 會不會關閉？從 Google 商業經營的角度分析</div><!--填入標題-->
                <div class=""events-body"">
                    <div class=""row"">
                        <div class=""col-md-6 pull-left"">
                            <img class=""events-object img-responsive img-rounded"" src=""https://2.bp.blogspot.com/-MQgmDdWOn5s/WoEcbqEIWPI/AAAAAAAAWXo/h8U_GHIW75obyskVvwgGQlD3ji0gjU7NACLcBGAs/s1600/will-google-close-blogger-business-analysis.jpg"" /><!--填入圖片網址-->
                        </div>
        ");
            WriteLiteral(@"                <div class=""events-desc"">Blogger 會不會倒閉，是使用者長期以來的擔憂。過去曾在「 Blogger 的未來 」發表過看法，不過曾有讀者看完，一段時間後仍提出相同的問題。我想，這件事除非有官方說詞，否則疑問不會有停止的一天。 然而，Google 官方有可能發佈這樣的聲明嗎？我想不會的，連 Yaho...</div><!--填入描述-->
                    </div>
                </div>
                <div class=""events-footer""><a href=""https://www.wfublog.com/2018/02/blogger-custom-domain-official-https-upgrade.html"" target=""_blank"">繼續閱讀</a></div><!--可填底部標題 或刪除-->
            </div>
        </dd>
        <!--右側文章 end-->
        <!--月份 2-->
        <dt>Jan 2018</dt>

        <!--左側文章 start-->
        <dd class=""pos-left clearfix"">
            <div class=""circ""></div>
            <div class=""time"">Jan 30</div><!--填入日期-->
            <div class=""events"">
                <div class=""events-header"">部落格載入速度太慢，要如何判斷哪些外掛可以移除？</div><!--填入標題-->
                <div class=""events-body"">
                    <div class=""row"">
                        <div class=""col-md-6 pull-left"">
                            <img class=""events-object img");
            WriteLiteral(@"-responsive img-rounded"" src=""https://2.bp.blogspot.com/-kSoFOb5NBBo/Wm-wzn619hI/AAAAAAAAWVw/13tYUepFvuk3zD3XnU25wBixfDuAzC-0wCLcBGAs/s1600/pagespeed-slow-remove-plugin.jpg"" /><!--填入圖片網址-->
                        </div>
                        <div class=""events-desc"">重視 SEO 的站長自然都會關注網頁的載入速度，因為這也是 Google 的排名評分項目之一。過去寫過一系列「 網站效能 」的相關文章，有興趣的站長可以瞭解不同的主題要如何處理。 由於提升「網頁載入速度」的詢問度一直很高，以往就算請讀者看這些相關文章，一段時間後還是可能回頭問...</div><!--填入描述-->
                    </div>
                </div>
                <div class=""events-footer""><a href=""https://www.wfublog.com/2018/01/pagespeed-slow-remove-plugin.html"" target=""_blank"">繼續閱讀</a></div><!--可填底部標題 或刪除-->
            </div>
        </dd>
        <!--左側文章 end-->
        <!--右側文章 start-->
        <dd class=""pos-right clearfix"">
            <div class=""circ""></div>
            <div class=""time"">Jan 17</div><!--填入日期-->
            <div class=""events"">
                <div class=""events-header"">從小編到總編之路﹍如何成為部落客中的佼佼者</div><!--填入標題-->
                <div class=""events");
            WriteLiteral(@"-body"">
                    <div class=""row"">
                        <div class=""col-md-6 pull-left"">
                            <img class=""events-object img-responsive img-rounded"" src=""https://3.bp.blogspot.com/-lo1NZ0KVZSU/WRrNvclwESI/AAAAAAAAPjQ/k50YaNha-1YlzwU0qtHwbhBoLfXPll1iACLcB/s780/how-to-become-top-blog-writer.jpg"" /><!--填入圖片網址-->
                        </div>
                        <div class=""events-desc"">前陣子這篇「 部落格從搜尋引擎而來的流量，是不會有感情的﹍找回經營網站的動力 」寫完後，有位美食部落格客戶，同時也算本站長期讀者，問了一些 SEO 問題。其實滿訝異的，既然是忠實讀者，想必知道我希望讀者將注意力放在 SEO 以外的地方。 瞭解她詢問的原因後，覺得這段對話可以看...</div><!--填入描述-->
                    </div>
                </div>
                <div class=""events-footer""><a href=""https://www.wfublog.com/2018/01/how-to-become-top-blog-writer.html"" target=""_blank"">繼續閱讀</a></div><!--可填底部標題 或刪除-->
            </div>
        </dd>
        <!--右側文章 end-->
        <!--月份 3-->
        <dt>Dec 2017</dt>

        <!--月份 4-->
        <dt>Nov 2017</dt>
    </dl>
</div>


<script>
    $('.VivaTimeline");
            WriteLiteral("\').vivaTimeline();\r\n    $(\'.VivaTimeline\').vivaTimeline({\r\n        carousel: true\r\n    });\r\n    $(\'.VivaTimeline\').vivaTimeline({\r\n        carousel: true,\r\n        carouselTime: 3000\r\n    });\r\n\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7dd0e34e2222d506a3f0511c78c86d726dd5a4111954", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
