#pragma checksum "C:\MDA前端\ClientMDA\Views\HomePage\test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4bada9dc47a4cc25def07d34463c5cd28a70fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_test), @"mvc.1.0.view", @"/Views/HomePage/test.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4bada9dc47a4cc25def07d34463c5cd28a70fd", @"/Views/HomePage/test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771dfde91e9627c6175ce4a1776b9243c8ca42e1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4bada9dc47a4cc25def07d34463c5cd28a70fd2942", async() => {
                WriteLiteral(@"
    <style>
        .modal1 {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%) scale(0);
            transition:200ms ease-in-out;
            border: 1px solid black;
            border-radius: 10%;
            z-index: 10;
            background-color: white;
            width: 500px;
            max-width: 80%;
        }
            .modal1.active {
                transform: translate(-50%,-50%) scale(1);
            }

        .modal-headers {
            padding: 10px 15px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            border-bottom: 1px solid black;
        }

        .modal-headers titles {
            font-size: 1.25rem;
            font-weight: bold;
            
        }

        .modal-headers .close-btn {
            cursor: pointer;
            border: none;
            outline: none;
            background: none;
     ");
                WriteLiteral(@"       font-size: 1.25rem;
            font-weight: bold;
        }

        .modal-bodys {
            padding: 10px 15px;
            color:black;
        }

        #overlays {
            position: fixed;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-color: transparent;
            pointer-events: none;
        }

        #overlays.active{
           opacity:1;
           pointer-events:all;
        }
        button{
            background-color:red;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


    <button data-modal-target=""#modal1"">open Modal</button>
    <div class=""modal1"" id=""modal1"">
        <div class=""modal-headers"">
            <div class=""titles"" style=""color:black"">Ex Modal</div>
            <button data-close-button class=""close-btn""></button>
        </div>
        <div class=""modal-bodys"">
            If you have used the web anytime in the last 5 years then you have most definitely run into an abundance of popups, also known as modals, which are quickly becoming one of the most popular components in web development.

            In this video I will cover how to create a simple modal that animates in on button click, and fades out when the modal is closed. This modal is also able to be closed by clicking anywhere outside the modal which is something most tutorial don't cover. Lastly, this modal is setup in a way that it is incredibly easy for you to customize it to the needs of your exact website.

        </div>

    </div>
    <div id=""overlays"">0000</div>
    <");
            WriteLiteral(@"div>
        <div>jk;qljyq32</div>
        <div>jk;qljyq32</div>
    </div>


    <div class=""info_box"">
        <div class=""star"">
            <div class=""showRate"">
                <span class=""fa fa-star checked"" id=""fafastarchecked""></span>
                <span class=""starRate"">4.3</span>
                <button class=""ToRate"" id=""openbtn"">
                    <i class='far fa-star' id=""ToR""></i>
                </button>
            </div>

            <div class=""showRateE"">
                <span class=""fa fa-star checked"" id=""fafastarcheckedE""></span>
                <span class=""starRate"">4.3</span>
                <button class=""ToRateE"" id=""openbtn"">
                    <i class='far fa-star' id=""ToR""></i>
                </button>
            </div>
        </div>
    </div>

    <div class=""swiper mySwiperList"" id=""mylist"">
        <div>
            <p id=""addmylist"">快來新增你的專屬片單吧!</p>
        </div>
        <div");
            BeginWriteAttribute("class", " class=\"", 3600, "\"", 3608, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""pluslist"">
            <button class=""AddListBtn"" id=""addlistbtn"" scr=""/Member/Login"">
                新增片單

            </button>
        </div>
    </div>

    <div class=""swiper mySwipermyList"" id=""mylist"">

        <div> <span id=""addmylist"">快來新增你的專屬片單吧!</span></div>
        <div");
            BeginWriteAttribute("class", " class=\"", 3909, "\"", 3917, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"pluslist\">\r\n");
            WriteLiteral("            <button class=\"AddListBtn\" id=\"addlistbtn\" onclick=\"window.location.href=\'/Member/Login\'\">\r\n                新增片單\r\n            </button>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    const openModalBtn = document.querySelectorAll('[dta-modal-target]')
    const openModalBtn = document.querySelectorAll('[data-close-button]')
    const overlay = document.getElementById('overlays')

    openModalBtn.forEach(button => {
        const modal1 = document.querySelector(""#modal"")
        openModal(modal1)
    })

    function openModal(modal1) {
        if (modal1 == null) return
        modal1.classList.add('active')
        overlay.classList.add('active')
    }
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
