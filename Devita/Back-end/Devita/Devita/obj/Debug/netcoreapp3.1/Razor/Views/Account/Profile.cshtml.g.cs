#pragma checksum "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8f717ccc25afe996fe55a78c95ee3de3313084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8f717ccc25afe996fe55a78c95ee3de3313084", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69538c11e4bedd16e9a92c407a781c3506112d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OrderProductTablePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div id=""profile-order"">
    <!--Main start-->
    <main>

        <div class=""container"">
            <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link active"" id=""pills-home-tab"" data-bs-toggle=""pill""
                            data-bs-target=""#pills-home"" type=""button"" role=""tab"" aria-controls=""pills-home""
                            aria-selected=""true"">
                        <i class=""fas fa-address-card pe-3""></i>Profile
                    </button>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link"" id=""pills-profile-tab"" data-bs-toggle=""pill""
                            data-bs-target=""#pills-profile"" type=""button"" role=""tab"" aria-controls=""pills-profile""
                            aria-selected=""false"">
                        <i class=""fas fa-lock pe-3""></i>Password
                    </but");
            WriteLiteral(@"ton>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link"" id=""pills-contact-tab"" data-bs-toggle=""pill""
                            data-bs-target=""#pills-contact"" type=""button"" role=""tab"" aria-controls=""pills-contact""
                            aria-selected=""false"">
                        <i class=""fas fa-truck pe-3""></i>Order
                    </button>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8f717ccc25afe996fe55a78c95ee3de33130846928", async() => {
                WriteLiteral("<i class=\"fas fa-sign-out pe-3\"></i>Log out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n            <div class=\"tab-content\" id=\"pills-tabContent\">\r\n                <div class=\"tab-pane fade show active\" id=\"pills-home\" role=\"tabpanel\" aria-labelledby=\"pills-home-tab\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
               Write(await Html.PartialAsync("_MemberUpdateFormPartial", Model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"tab-pane fade\" id=\"pills-profile\" role=\"tabpanel\" aria-labelledby=\"pills-profile-tab\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
               Write(await Html.PartialAsync("_MemberUpdatePasswordPartial", Model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"tab-pane fade\" id=\"pills-contact\" role=\"tabpanel\" aria-labelledby=\"pills-contact-tab\">\r\n");
            WriteLiteral(@"                    <section id=""order"">
                        <div class=""order"">
                            <div class=""title"">
                                <h3><i class=""fas fa-truck pe-3""></i>Order</h3>
                            </div>
                            <div class=""content"">
                                <div class=""container first-container col-sm-12 pull-left"">
                                    <table class=""table table-condensed"">
                                        <thead>
                                            <tr>
                                                <th></th>
                                                <th>#</th>
                                                <th>Fullname</th>
                                                <th>Date</th>
                                                <th>Price</th>
                                                <th>Status</th>
                                            </tr>
                        ");
            WriteLiteral("                </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 118 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                             foreach (var item in Model.Orders)
                                            {
                                                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <tr class=""sub-container"">
                                                    <td>
                                                        <button type=""button"" class=""btn exploder"" style=""background-color: #0363CD;"">
                                                            <i class=""fas fa-search"" style=""color: #FFFFFF;""></i>
                                                        </button>
                                                    </td>
                                                    <td>");
#nullable restore
#line 127 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 128 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 129 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                   Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 130 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                   Write(item.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        <span class=\"badge\"");
            BeginWriteAttribute("style", " style=\"", 8030, "\"", 8262, 9);
            WriteAttributeValue("", 8038, "background-color:", 8038, 17, true);
#nullable restore
#line 132 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
WriteAttributeValue("", 8055, (int)(item.Status) == 1?"#F29339":"", 8055, 39, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
WriteAttributeValue(" ", 8094, (int)(item.Status) == 2?"#5CB85C":"", 8095, 39, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
WriteAttributeValue("  ", 8134, (int)(item.Status) == 3?"red":"", 8136, 35, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
WriteAttributeValue(" ", 8171, (int)(item.Status) == 4?"#cf142b":"", 8172, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8211, ";", 8211, 1, true);
            WriteAttributeValue(" ", 8212, "font-family:", 8213, 13, true);
            WriteAttributeValue(" ", 8225, "\'Rubik\',sans-serif;", 8226, 20, true);
            WriteAttributeValue(" ", 8245, "font-weight:400;", 8246, 17, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                                            ");
#nullable restore
#line 134 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                        Write((int)(item.Status) == 1?"Pending":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 134 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                                                                Write((int)(item.Status) == 2?"Accepted":"");

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 134 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                                                                                                          Write((int)(item.Status) == 3?"Rejected":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 134 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                                                                                                                                                                   Write((int)(item.Status) == 4?"Canceled":"");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </span>\r\n                                                    </td>\r\n                                                </tr>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e8f717ccc25afe996fe55a78c95ee3de331308416670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 138 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

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
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\husey\Desktop\FinalProjectFull\Devita\Back-end\Devita\Devita\Views\Account\Profile.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                        </tbody>
                                    </table>
                                </div>

                            </div>

                        </div>

                    </section>
                </div>
            </div>
        </div>





    </main>
    <!--Main end-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
