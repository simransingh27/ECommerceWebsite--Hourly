#pragma checksum "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8674a9eab51e95f82d09fe52b7bb16e87ec8f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Checkout.cshtml", typeof(AspNetCore.Views_Cart_Checkout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8674a9eab51e95f82d09fe52b7bb16e87ec8f85", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94808d38cdc2b238ca5fee90e2ba2b49d35994dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendi.App.Models.CheckOutModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/img/core-img/paypal.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/complete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("paymentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 367, true);
            WriteLiteral(@"
<div class=""cart-table-area section-padding-100"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12 col-lg-8"">
                <div class=""checkout_details_area mt-50 clearfix"">

                    <div class=""cart-title"">
                        <h2>Checkout</h2>
                    </div>

                    ");
            EndContext();
            BeginContext(410, 2372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8674a9eab51e95f82d09fe52b7bb16e87ec8f856295", async() => {
                BeginContext(441, 153, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <input id=\"OrderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 594, "\"", 616, 1);
#line 16 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 602, Model.OrderId, 602, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(617, 98, true);
                WriteLiteral(" hidden/>\r\n                                <input type=\"text\" class=\"form-control\" id=\"first_name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 715, "\"", 739, 1);
#line 17 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 723, Model.FirstName, 723, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(740, 216, true);
                WriteLiteral(" placeholder=\"First Name\" required>\r\n                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <input type=\"text\" class=\"form-control\" id=\"last_name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 956, "\"", 979, 1);
#line 20 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 964, Model.LastName, 964, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(980, 230, true);
                WriteLiteral(" placeholder=\"Last Name\" required>\r\n                            </div>\r\n                            <div class=\"col-12 mb-3\">\r\n                                <input type=\"email\" class=\"form-control\" id=\"email\" placeholder=\"Email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1210, "\"", 1230, 1);
#line 23 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 1218, Model.Email, 1218, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1231, 212, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-12 mb-3\">\r\n                                <input type=\"text\" class=\"form-control mb-3\" id=\"street_address\" placeholder=\"Address\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1443, "\"", 1464, 1);
#line 26 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 1451, Model.Street, 1451, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1465, 54, true);
                WriteLiteral(">\r\n                                <input id=\"counrty\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1519, "\"", 1541, 1);
#line 27 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 1527, Model.Country, 1527, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1542, 61, true);
                WriteLiteral(" hidden/>\r\n                                <input id=\"county\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1603, "\"", 1624, 1);
#line 28 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 1611, Model.County, 1611, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1625, 202, true);
                WriteLiteral(" hidden/>\r\n                            </div>\r\n                            <div class=\"col-12 mb-3\">\r\n                                <input type=\"text\" class=\"form-control\" id=\"city\" placeholder=\"Town\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1827, "\"", 1846, 1);
#line 31 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 1835, Model.City, 1835, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1847, 203, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <input type=\"text\" class=\"form-control\" id=\"zipCode\" placeholder=\"PostCode\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2050, "\"", 2073, 1);
#line 34 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 2058, Model.PostCode, 2058, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2074, 218, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <input type=\"number\" class=\"form-control\" id=\"phone_number\" min=\"0\" placeholder=\"Phone No\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2292, "\"", 2313, 1);
#line 37 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 2300, Model.Mobile, 2300, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2314, 58, true);
                WriteLiteral(">\r\n                                <input id=\"total_order\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2372, "\"", 2397, 1);
#line 38 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 2380, Model.TotalOrder, 2380, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2398, 377, true);
                WriteLiteral(@" hidden/>
                            </div>
                            <div class=""col-12 mb-3"">
                                <textarea name=""comment"" class=""form-control w-100"" id=""comment""  cols=""30"" rows=""10"" placeholder=""Leave a comment about your order"" required></textarea>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2782, 279, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-12 col-lg-4"">
                <div class=""cart-summary"">
                    <h5>Cart Total</h5>
                    <ul class=""summary-table"">
                        <li><span>total:</span> <span >£ ");
            EndContext();
            BeginContext(3062, 16, false);
#line 51 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
                                                    Write(Model.TotalOrder);

#line default
#line hidden
            EndContext();
            BeginContext(3078, 143, true);
            WriteLiteral("</span></li>\r\n                        \r\n                    </ul>\r\n\r\n                    <div class=\"payment-method\">\r\n                        ");
            EndContext();
            BeginContext(3221, 910, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8674a9eab51e95f82d09fe52b7bb16e87ec8f8515702", async() => {
                BeginContext(3227, 762, true);
                WriteLiteral(@"
                            <!-- Cash on delivery -->
                            <div class=""custom-control custom-radio mr-sm-2"">
                                <input type=""radio"" name=""payment"" class=""custom-control-input"" id=""cod"" value=""1"" onclick=""Cod();"">
                                <label class=""custom-control-label"" for=""cod"">Cash on Delivery</label>
                            </div>
                            <!-- Paypal -->
                            <div class=""custom-control custom-radio mr-sm-2"">
                                <input type=""radio"" name=""payment"" class=""custom-control-input"" id=""paypal"" value=""2"" onclick=""Paypal();"">
                                <label class=""custom-control-label"" for=""paypal"">Paypal ");
                EndContext();
                BeginContext(3989, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8674a9eab51e95f82d09fe52b7bb16e87ec8f8516883", async() => {
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
                EndContext();
                BeginContext(4054, 70, true);
                WriteLiteral("</label>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4131, 345, true);
            WriteLiteral(@"
                    </div>
                    <div class=""cart-btn"">
                        <a onclick=""PayProductByCash()"" href=""#"" id=""checkout-btn"" class=""btn amado-btn w-100"">Checkout</a>

                        <div id=""paypal-button-container"">
                            <!--Car CheckOutByCard -->
                            ");
            EndContext();
            BeginContext(4476, 497, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8674a9eab51e95f82d09fe52b7bb16e87ec8f8519794", async() => {
                BeginContext(4532, 434, true);
                WriteLiteral(@"
                                <!-- all other fields you want to collect, e.g. name and shipping address -->
                                <div id='paymentSection'></div>
                                <div>
                                    <input type=""button"" class=""btn amado-btn w-100"" value=""Place Order"" onclick=""Worldpay.submitTemplateForm()"" />
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4973, 243, true);
            WriteLiteral("\r\n                            <!--ENds Card-->\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- ##### Main Content Wrapper End ##### -->\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5234, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 95 "C:\Users\44782\Source\Repos\bluulabs-uk\vendi\Vendi.App\Views\Cart\Checkout.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(5304, 4959, true);
                WriteLiteral(@"
    <script>
        function Cod() {
             $(""#checkout-btn"").show();
             $(""#paypal-button-container"").hide();
        }
        function Paypal() {
            $(""#checkout-btn"").hide();
            $(""#paypal-button-container"").show();
        }
        function PayProductByCash() {
            // to create order , check the radio if cod create order or after payment done...
            //Create order for cash start
            var CheckoutObj = {
                OrderId:$('#OrderId').val(),
                Total: $('#total_order').val()            
            };
            console.log(CheckoutObj);
            $.ajax({
                url: ""/Payment/PayProductByCash"",
                data: JSON.stringify(CheckoutObj),
                type: ""POST"",
                contentType: ""application/json;charset=utf-8"",
                dataType: ""json"",
                success: function (result) {
                    console.log(result);
                    var id = resu");
                WriteLiteral(@"lt.msg;
                    if (result.flag) {
                        alert('Your Order Has Been Successfully ' + result.msg);
                        url = ""/Order/OrderConfirmation/"" + id;
                        $(location).attr(""href"", url);
                    }
                },
                error: function (result) {
                    alert(result.msg);
                }
            });
            //Create order for cash Ends
        }
        $(document).ready(function () {

            $(""#paypal-button-container"").hide();
            $(""#checkout-btn"").hide();

        });
    </script>

    <script src=""https://cdn.worldpay.com/v1/worldpay.js""></script>

    <script type='text/javascript'>
        window.onload = function () {
            Worldpay.useTemplateForm({
                'clientKey': 'T_C_5941ca98-ea6b-4b50-9b5f-057548c97330',
                'form': 'paymentForm',
                'paymentSection': 'paymentSection',
                'display': 'inline',");
                WriteLiteral(@"
                'reusable': true,
                'callback': function (obj) {
                    if (obj && obj.token) {
                        // var _el = document.createElement('input');
                        //  _el.value = obj.token;
                        //  _el.type = 'hidden';
                        //   _el.name = 'token';
                        console.log('First Token');
                        console.log(obj);
                        //   document.getElementById('paymentForm').appendChild(_el);
                        //   document.getElementById('paymentForm').submit();
                        CardDateObj = {
                            Token: obj.token,
                            PaymentMethod: obj.paymentMethod,
                            Reusable: obj.reusable,
                            OrderId:$('#OrderId').val(),
                            FirstName: $('#first_name').val(),
                            LastName: $('#last_name').val(),
                       ");
                WriteLiteral(@"     Email: $('#email').val(),
                            Country: $('#counrty').val(),
                            County: $('#county').val(),
                            Street: $('#street_address').val(),
                            City: $('#city').val(),
                            PostCode: $('#zipCode').val(),
                            Mobile: $('#phone_number').val(),
                            Comment: $('#comment').val(),
                            TotalOrder: $('#total_order').val()
                        };
                        console.log('My Obj Token');
                        console.log(CardDateObj);
                        $.ajax({
                            url: ""/Payment/PayProductByCard"",
                            data: JSON.stringify(CardDateObj),
                            type: ""POST"",
                            contentType: ""application/json;charset=utf-8"",
                            dataType: ""json"",
                            success: function (resu");
                WriteLiteral(@"lt) {
                                console.log(result);
                                if (result.flag) {
                                    var id = result.msg;
                                    alert('Your Order Has Been Successfully ' + result.msg);
                                    url = ""/Order/OrderConfirmation/"" + id;
                                    $(location).attr(""href"", url);
                                }
                                else {
                                    alert(result.msg);
                                }
                            },
                            error: function (result) {
                                alert(result.msg);
                            }
                        });

                    }
                }
            });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendi.App.Models.CheckOutModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591