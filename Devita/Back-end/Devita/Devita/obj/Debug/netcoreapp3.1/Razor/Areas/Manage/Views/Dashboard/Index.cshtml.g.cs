#pragma checksum "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4890e108e577a4cfc8d3a16e94089be91ff2ea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\_ViewImports.cshtml"
using Devita.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\_ViewImports.cshtml"
using Devita.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\_ViewImports.cshtml"
using Devita.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4890e108e577a4cfc8d3a16e94089be91ff2ea2", @"/Areas/Manage/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c50db41a8bd976928a6b3170bc011fb8a8105f77", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-body"">
    <!-- row -->
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""row"">
                    <div class=""col-xl-12"">
                        <div class=""row"">
                            <div class=""col-xl-12"">
                                <div class=""row"">
                                    <div class=""col-xl-6 col-sm-6"">
                                        <div class=""card"">
                                            <div class=""card-body d-flex px-4 pb-0 justify-content-between"">
                                                <div>
                                                    <h4 class=""fs-18 font-w600 mb-4 text-nowrap"">Total Clients</h4>
                                                    <div class=""d-flex align-items-center"">
                                                        <h2 class=""fs-32 font-w700 mb-0"">");
#nullable restore
#line 22 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\Dashboard\Index.cshtml"
                                                                                    Write(ViewBag.UsersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                                        <span class=""d-block ms-4"">
                                                            <svg width=""21"" height=""11"" viewbox=""0 0 21 11"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                                                <path d=""M1.49217 11C0.590508 11 0.149368 9.9006 0.800944 9.27736L9.80878 0.66117C10.1954 0.29136 10.8046 0.291359 11.1912 0.661169L20.1991 9.27736C20.8506 9.9006 20.4095 11 19.5078 11H1.49217Z"" fill=""#09BD3C""></path>
                                                            </svg>
                                                            <small class=""d-block fs-16 font-w400 text-success"">+0,5%</small>
                                                        </span>
                                                    </div>
                                                </div>
                                                <div id=""columnChart""></div>
                                      ");
            WriteLiteral(@"      </div>
                                        </div>
                                    </div>
                                    <div class=""col-xl-6 col-sm-6"">
                                        <div class=""card"">
                                            <div class=""card-body d-flex px-4 pb-0 justify-content-between"">
                                                <div>
                                                    <h4 class=""fs-18 font-w600 mb-4 text-nowrap"">Total Products</h4>
                                                    <div class=""d-flex align-items-center"">
                                                        <h2 class=""fs-32 font-w700 mb-0"">");
#nullable restore
#line 41 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\Dashboard\Index.cshtml"
                                                                                    Write(ViewBag.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                                        <span class=""d-block ms-4"">
                                                            <svg width=""21"" height=""11"" viewbox=""0 0 21 11"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                                                <path d=""M1.49217 11C0.590508 11 0.149368 9.9006 0.800944 9.27736L9.80878 0.66117C10.1954 0.29136 10.8046 0.291359 11.1912 0.661169L20.1991 9.27736C20.8506 9.9006 20.4095 11 19.5078 11H1.49217Z"" fill=""#09BD3C""></path>
                                                            </svg>
                                                            <small class=""d-block fs-16 font-w400 text-success"">+0,5%</small>
                                                        </span>
                                                    </div>
                                                </div>
                                                <div id=""columnChart""></div>
                                      ");
            WriteLiteral(@"      </div>
                                        </div>
                                    </div>
                                    <div class=""col-xl-6 col-sm-6"">
                                        <div class=""card"">
                                            <div class=""card-body d-flex px-4  justify-content-between"">
                                                <div>
                                                    <div");
            BeginWriteAttribute("class", " class=\"", 4250, "\"", 4258, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <h2 class=\"fs-32 font-w700\">");
#nullable restore
#line 59 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\Dashboard\Index.cshtml"
                                                                               Write(ViewBag.TotalOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"$</h2>
                                                        <span class=""fs-18 font-w500 d-block"">Total Orders</span>
                                                        
                                                    </div>
                                                </div>
                                                <div id=""NewCustomers""></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-xl-6 col-sm-6"">
                                        <div class=""card"">
                                            <div class=""card-body d-flex px-4  justify-content-between"">
                                                <div>
                                                    <div");
            BeginWriteAttribute("class", " class=\"", 5231, "\"", 5239, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <h2 class=\"fs-32 font-w700\">");
#nullable restore
#line 73 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\Dashboard\Index.cshtml"
                                                                               Write(ViewBag.TotalOrderMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h2>\r\n                                                        <span class=\"d-block\" style=\"font-size: 18px; color: #17A2B8;\">Monthly Orders<br />");
#nullable restore
#line 74 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Areas\Manage\Views\Dashboard\Index.cshtml"
                                                                                                                                      Write(ViewBag.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                        
                                                    </div>
                                                </div>
                                                <div id=""NewCustomers1""></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>


                        </div>


                    </div>
                    
                </div>
            </div>
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
