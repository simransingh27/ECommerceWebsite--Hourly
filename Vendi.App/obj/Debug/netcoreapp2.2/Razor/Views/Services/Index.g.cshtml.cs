#pragma checksum "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5870654d3b7844b900b1cd95f6f096a6e4232ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Services/Index.cshtml", typeof(AspNetCore.Views_Services_Index))]
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
#line 1 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\_ViewImports.cshtml"
using Vendi.App;

#line default
#line hidden
#line 2 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\_ViewImports.cshtml"
using Vendi.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5870654d3b7844b900b1cd95f6f096a6e4232ff", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94808d38cdc2b238ca5fee90e2ba2b49d35994dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendi.App.Models.ServiceModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/Vendi/loading_icon.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/InfiniteScroll/mustache.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 1669, true);
            WriteLiteral(@"
<style>
    .ServiceCard {
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        max-width: 300px;
        margin: 15px;
        text-align: center;
        font-family: arial;
    }

    .Servicetitle {
        color: grey;
        font-size: 18px;
    }

    .btn-Service {
        border: none;
        outline: 0;
        display: inline-block;
        padding: 8px;
        color: white;
        background-color: #fbb710;
        text-align: center;
        cursor: pointer;
        width: 100%;
        font-size: 18px;
        margin-bottom: auto;
    }

        .btn-Service:hover {
            background-color: black;
        }

    .modal-backdrop {
        top: 2px;
        right: 5px;
        bottom: 1px;
        left: 1px;
        z-index: 1030;
        background-color: ghostwhite;
        position: unset;
    }
</style>





<div class=""amado_product_area section-padding-100"">
    <div class=""container-fluid"">
        <div class=""row"">
       ");
            WriteLiteral(@"     <div class=""col-12"">
                <div class=""product-topbar d-xl-flex align-items-end justify-content-between"">
                    <!-- Total Products -->
                    <div class=""total-products"">
                        <div class=""view d-flex"">
                            <a href=""/Services/ServiceMap""><i class=""fa fa-map-marker""></i></a>
                            <a href=""/Services/Index""><i class=""fa fa-th-large""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>




        <div class=""row"">
            <input id=""CategoryId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1801, "\"", 1826, 1);
#line 75 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Services\Index.cshtml"
WriteAttributeValue("", 1809, Model.CategoryId, 1809, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1827, 145, true);
            WriteLiteral(" hidden  />\r\n            <!--Code-->\r\n            <div id=\"ServiceDataDiv\"></div>\r\n            <div align=\"center\" id=\"loader\">\r\n                ");
            EndContext();
            BeginContext(1972, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5870654d3b7844b900b1cd95f6f096a6e4232ff7281", async() => {
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
            EndContext();
            BeginContext(2039, 164, true);
            WriteLiteral("\r\n            </div>\r\n            <!--Code Ends-->\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n<!-- Service Details Area End -->\r\n<!-- MY Java script -->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2221, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 96 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Services\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2291, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2299, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5870654d3b7844b900b1cd95f6f096a6e4232ff9304", async() => {
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
                EndContext();
                BeginContext(2354, 2306, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
          
            var serviceCardTemplate,
                isLoading = false,
                pageNumber = 0,
                serviceData = {
                    services: []
                };

            function appendServiceData(data) {
                $.get('/pages/ServiceCardTemplate.html',
                    function (template) {
                        console.log('Templ');
                        console.log(template);
                        serviceCardTemplate = template;
                    }
                );
                $(document).ajaxStop(function () {
                    var renderedPage = Mustache.to_html(serviceCardTemplate, data);
                    $(""#ServiceDataDiv"").append(renderedPage);
                    //the name of the temple{{Products}}
                    data.servcies = [];
                });
            }
            var mycategoryId = $(""#CategoryId"").val();
            function ");
                WriteLiteral(@"getServiceData() {
                if (!isLoading) {
                    $(""#loader"").show();
                    isLoading = true;
                    pageNumber++;
                    $.get(""/Servcies/GetServices?pageSize=2&currentPage="" +
                        pageNumber + ""&id=""+mycategoryId,
                        function (data) {
                            if (data != '') {
                                console.log(data);
                                serviceData.services = data.results;
                                console.log('Results');
                                console.log(serviceData.services);
                                appendServiceData(serviceData);
                            }
                            isLoading = false;
                            $(""#loader"").hide();
                        });
                }
            };

            $(window).scroll(function () {
                if ($(window).scrollTop() == $(document).height() - $(window");
                WriteLiteral(@").height()) {
                    getServiceData("""", 1);
                }
            });

            // Initialise page
            var initPage = function () {
                getServiceData("""", 1);
            }();
        })
    </script>

");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendi.App.Models.ServiceModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591