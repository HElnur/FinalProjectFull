#pragma checksum "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9383735232c276f0b74fb6671f1a71629281a7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\_ViewImports.cshtml"
using Devita.Extentions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9383735232c276f0b74fb6671f1a71629281a7b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69538c11e4bedd16e9a92c407a781c3506112d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductTabSliderCarousel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BestProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TopHeadPhonePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/_bestOwlCarousel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<!--Hero start-->
<section id=""hero"">
    <div id=""carouselExampleIndicators"" class=""carousel slide carousel-fade"" data-bs-ride=""carousel"">
        <div class=""carousel-indicators"">
            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""0""
                    class=""item-dot active"" aria-current=""true"" aria-label=""Slide 1""></button>
            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""1"" class=""item-dot""
                    aria-label=""Slide 2""></button>
            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""2"" class=""item-dot""
                    aria-label=""Slide 3""></button>
        </div>
        <div class=""carousel-inner"">
");
#nullable restore
#line 19 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item d-flex align-items-center active\"");
            BeginWriteAttribute("style", " style=\"", 1030, "\"", 1093, 4);
            WriteAttributeValue("", 1038, "background-image:", 1038, 17, true);
            WriteAttributeValue(" ", 1055, "url(\'/uploads/slider/", 1056, 22, true);
#nullable restore
#line 22 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
WriteAttributeValue("", 1077, item.BgImage, 1077, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1090, "\');", 1090, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-lg-6 d-flex align-items-center"">
                                <div class=""text"">



                                    <div class=""shoppingBtn"">
                                        <a href=""#"">Shopping now</a>
                                    </div>

                                </div>
                            </div>

                            <div class=""col-lg-6 d-flex justify-content-center align-items-center"">
                                <div class=""images"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9383735232c276f0b74fb6671f1a71629281a7b8976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1822, "~/uploads/slider/", 1822, 17, true);
#nullable restore
#line 39 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1839, item.Image, 1839, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 48 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

    </div>
</section>
<!--Hero end-->
<!--Main start-->
<main>
    <!--Wrapper start-->
    <section id=""wrapper"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-12 p-0 position-relative"">
                    <img src=""/assets/image/wrapper_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6019, "\"", 6025, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"hover-box position-absolute\"></div>\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-12 p-0 position-relative\">\r\n                    <img src=\"/assets/image/wrapper_2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6252, "\"", 6258, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""hover-box position-absolute""></div>

                </div>
            </div>
        </div>
    </section>
    <!--Wrapper end-->
    <!--Products start-->
    <section id=""products"">
        <div class=""container"" style=""width: 80%;"">
            <div class=""row"">
                <div class=""products-options"">
                    <div class=""options d-flex justify-content-center align-items-center"">
                        <ul class=""nav nav-pills d-flex px-2"" id=""pills-tab"" role=""tablist"">
                            <li class=""nav-item"" role=""presentation"">
                                <button class=""nav-link active"" id=""pills-home-tab"" data-bs-toggle=""pill""
                                        data-bs-target=""#pills-home"" type=""button"" role=""tab"" aria-controls=""pills-home""
                                        aria-selected=""true"">
                                    New Arrivals
                                </button>
                    ");
            WriteLiteral(@"        </li>
                            <li class=""nav-item"" role=""presentation"">
                                <button class=""nav-link"" id=""pills-profile-tab"" data-bs-toggle=""pill""
                                        data-bs-target=""#pills-profile"" type=""button"" role=""tab""
                                        aria-controls=""pills-profile"" aria-selected=""false"">
                                    Featured
                                </button>
                            </li>
                            <li class=""nav-item"" role=""presentation"">
                                <button class=""nav-link"" id=""pills-contact-tab"" data-bs-toggle=""pill""
                                        data-bs-target=""#pills-contact"" type=""button"" role=""tab""
                                        aria-controls=""pills-contact"" aria-selected=""false"">
                                    Top Rate
                                </button>
                            </li>
                        </ul>");
            WriteLiteral(@"
                    </div>
                    <div class=""tab-content mt-5"" id=""pills-tabContent"">


                        <div class=""tab-pane fade show new-arrivals active"" id=""pills-home"" role=""tabpanel""
                             aria-labelledby=""pills-home-tab"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9383735232c276f0b74fb6671f1a71629281a7b14559", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 179 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.NewProducts;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"tab-pane fade featured\" id=\"pills-profile\" role=\"tabpanel\"\r\n                             aria-labelledby=\"pills-profile-tab\">\r\n                            ");
#nullable restore
#line 184 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("_ProductTabSliderCarousel", Model.FeaturedProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"tab-pane fade top-rate\" id=\"pills-contact\" role=\"tabpanel\"\r\n                             aria-labelledby=\"pills-contact-tab\">\r\n                            ");
#nullable restore
#line 188 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("_ProductTabSlider", Model.TopRates));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--Products end-->
    <!--Home static start-->
    <section id=""home-static"" class=""d-flex align-items-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""text"">
                        <div class=""title"">
                            <h3>
                                Stay Connected When You’re Away
                                <br>
                                From Your Phone
                            </h3>
                        </div>

                        <div class=""desc"">
                            <p>
                                Start the year off strong and explore how to track your activities,
                                <br>
                                health, and fitness with Apple Watch and iPhone.
                       ");
            WriteLiteral(@"     </p>
                        </div>

                        <div class=""price"">
                            <span>$128.00</span>
                        </div>

                        <div class=""discoverBtn"">
                            <a href=""#"">
                                DISCOVER NOW
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--Home static end-->
    <!--Best selling products start-->
    <section id=""best-selling"">
        <div class=""container"">
            <div class=""row"">

                <div class=""options d-flex justify-content-between align-items-center"">
                    <div class=""title"">
                        <h3>Best Selling Products</h3>
                    </div>

                </div>

                <div class=""tab-content mt-5"" id=""pills-tabContent"">
                    <div class=""tab-pane fade show active smar");
            WriteLiteral("t-phone\" id=\"pills-home\" role=\"tabpanel\"\r\n                         aria-labelledby=\"pills-home-tab\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9383735232c276f0b74fb6671f1a71629281a7b19487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 248 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.BestProducts;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            </div>
        </div>
    </section>
    <!--Best selling products end-->
    <!--Top headphones start-->
    <section id=""top-headphones"">
        <div class=""container"">
            <div class=""row"">

                <div class=""options d-flex justify-content-between align-items-center"">
                    <div class=""title"">
                        <h3>Top Headphones</h3>
                    </div>

                </div>

                <div class=""tab-content mt-5"" id=""pills-tabContent"">
                    <div class=""tab-pane fade show active smart-phone"" id=""pills-home"" role=""tabpanel""
                         aria-labelledby=""pills-home-tab"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9383735232c276f0b74fb6671f1a71629281a7b21864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 274 "C:\Users\husey\Desktop\Devita\Back-end\Devita\Devita\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.TopHeadphonesProduct;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!--Top headphones end-->\r\n</main>\r\n<!--Main end-->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!--Best owl carousel-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9383735232c276f0b74fb6671f1a71629281a7b23762", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
