#pragma checksum "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210164141faccc217e976a80b8acb4e6c8bf7cc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Checkout), @"mvc.1.0.view", @"/Views/Order/Checkout.cshtml")]
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
#line 1 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita.Extentions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210164141faccc217e976a80b8acb4e6c8bf7cc9", @"/Views/Order/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69538c11e4bedd16e9a92c407a781c3506112d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckOutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn deleteBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "signin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    decimal TotalPrice = 0;
    decimal SalePrice = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div id=""cart"">
    <main>
        <section id=""breadcrumb"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""breadcrumb"">
                            <ul class=""d-flex"">
                                <li>
                                    <a href=""#"">Home</a>
                                </li>

                                <li>
                                    <a href=""#"" class=""active"">
                                        Cart
                                    </a>
                                </li>
                            </ul>
                        </div>

                        <div class=""title"">
                            <h3>Cart</h3>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id=""product-table"">
            <div class=""container"">
                <");
            WriteLiteral(@"div class=""row"">
                    <div class=""prod-table"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">IMAGES</th>
                                    <th scope=""col"">PRODUCT</th>
                                    <th scope=""col"">PRICE</th>
                                    <th scope=""col"">QUANTITY</th>
                                    <th scope=""col"">TOTAL</th>
                                    <th scope=""col"">DELETE</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 54 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                 foreach (var item in Model.CheckoutItems)
                                {
                                    SalePrice = item.Product.DiscountPercent > 0 ? (item.Product.SalePrice * (1 - item.Product.DiscountPercent / 100)) : item.Product.SalePrice;
                                    TotalPrice = SalePrice * item.Count;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "210164141faccc217e976a80b8acb4e6c8bf7cc99066", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2365, "~/uploads/products/", 2365, 19, true);
#nullable restore
#line 61 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
AddHtmlAttributeValue("", 2384, item.Product.ProductImages.FirstOrDefault(x => x.PosterStatus==true).Image, 2384, 75, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </th>\r\n                                        <td>");
#nullable restore
#line 63 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 64 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                         if (item.Product.DiscountPercent > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>$");
#nullable restore
#line 66 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                             Write((item.Product.SalePrice * (1 - item.Product.DiscountPercent/100)).ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 67 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"

                                        }

                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>$");
#nullable restore
#line 72 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                            Write(item.Product.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 73 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 75 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                       Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>$");
#nullable restore
#line 76 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                        Write(TotalPrice.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210164141faccc217e976a80b8acb4e6c8bf7cc913490", async() => {
                WriteLiteral("<i class=\"fas fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                                                                                                          WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 80 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n\r\n\r\n                    </div>\r\n\r\n                    <div class=\"return-shop d-flex\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210164141faccc217e976a80b8acb4e6c8bf7cc916569", async() => {
                WriteLiteral("RETURN TO SHOP");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button type=""button"" class=""btn ms-3"" style=""background-color: #0363CD; color: #FFFFFF; font-family: 'Rubik', sans-serif; font-weight: 400; "" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
                                Order
                            </button>
");
#nullable restore
#line 96 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210164141faccc217e976a80b8acb4e6c8bf7cc918875", async() => {
                WriteLiteral("Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 100 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    ");
#nullable restore
#line 102 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Order\Checkout.cshtml"
               Write(await Html.PartialAsync("_CheckOutFormPartial", Model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
