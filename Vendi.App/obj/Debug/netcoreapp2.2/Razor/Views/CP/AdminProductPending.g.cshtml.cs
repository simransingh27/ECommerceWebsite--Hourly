#pragma checksum "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5ffb7e50b27bb13085d173810e8bec36ad579c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CP_AdminProductPending), @"mvc.1.0.view", @"/Views/CP/AdminProductPending.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CP/AdminProductPending.cshtml", typeof(AspNetCore.Views_CP_AdminProductPending))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5ffb7e50b27bb13085d173810e8bec36ad579c", @"/Views/CP/AdminProductPending.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94808d38cdc2b238ca5fee90e2ba2b49d35994dc", @"/Views/_ViewImports.cshtml")]
    public class Views_CP_AdminProductPending : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vendi.Data.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
  
    ViewData["Title"] = "AdminProductPending";
    Layout = "~/Views/Shared/_CPLayout.cshtml";

#line default
#line hidden
            BeginContext(144, 308, true);
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">

            <br />

            <table class=""table table-hover "">
                <thead>
                    <tr>
                        <th>
                            ");
            EndContext();
            BeginContext(453, 47, false);
#line 17 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(500, 93, true);
            WriteLiteral("\r\n                        </th>\r\n\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(594, 41, false);
#line 21 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(635, 93, true);
            WriteLiteral("\r\n                        </th>\r\n\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(729, 44, false);
#line 25 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(773, 152, true);
            WriteLiteral("\r\n                        </th>\r\n\r\n\r\n\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(998, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1095, 46, false);
#line 38 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1247, 40, false);
#line 42 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1393, 43, false);
#line 46 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 113, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n\r\n\r\n\r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1549, "\"", 1590, 3);
            WriteAttributeValue("", 1559, "ApproveProduct(", 1559, 15, true);
#line 53 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
WriteAttributeValue("", 1574, item.ProductId, 1574, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1589, ")", 1589, 1, true);
            EndWriteAttribute();
            BeginContext(1591, 98, true);
            WriteLiteral("><i style=\"color:#4272d7;\" class=\"fa fa-check fa-2x\"></i></a>  |\r\n                                ");
            EndContext();
            BeginContext(1689, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5ffb7e50b27bb13085d173810e8bec36ad579c8241", async() => {
                BeginContext(1744, 62, true);
                WriteLiteral("<i style=\"color:#4272d7;\" class=\"fa fa-info-circle fa-2x\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                                                          WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1810, 38, true);
            WriteLiteral(" |\r\n                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1848, "\"", 1888, 3);
            WriteAttributeValue("", 1858, "DeleteProduct(", 1858, 14, true);
#line 55 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
WriteAttributeValue("", 1872, item.ProductId, 1872, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1887, ")", 1887, 1, true);
            EndWriteAttribute();
            BeginContext(1889, 129, true);
            WriteLiteral("><i style=\"color:#4272d7;\" class=\"fa fa-trash fa-2x\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\CP\AdminProductPending.cshtml"
                    }

#line default
#line hidden
            BeginContext(2041, 1446, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>


<script>
    function DeleteProduct(id) {
        var r = confirm(""Are you sure to delete the pending request for this Vendor."");
        if (r) {
            $.ajax({
                url: ""/DeleteProduct/"" + id,
                type: ""GET"",
                contentType: ""application/json;charset=utf-8"",
                dataType: ""json"",

                success: function (result) {

                    console.log(result);
                    location.reload();
                },
                error: function (errormessage) {
                    alert(errormessage);
                }
            });
        }
        location.reload();

    }

    function ApproveProduct(id) {
        var r = confirm(""Are you sure to Approve the pending request for this Vendor."");
        if (r) {
            $.ajax({
                url: ""/ApproveProduct/"" + id,
                type: ""GET"",
                ");
            WriteLiteral(@"contentType: ""application/json;charset=utf-8"",
                dataType: ""json"",

                success: function (result) {

                    console.log(result);
                    location.reload();
                },
                error: function (errormessage) {
                    alert(errormessage);
                }
            });
        }
        location.reload();

    }
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vendi.Data.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591