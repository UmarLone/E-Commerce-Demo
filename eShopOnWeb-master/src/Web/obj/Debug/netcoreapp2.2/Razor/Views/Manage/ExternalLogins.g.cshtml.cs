#pragma checksum "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73666b20f2c64ee02c2f600bbea27cce584e8417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.Web.Pages.Manage.Views_Manage_ExternalLogins), @"mvc.1.0.view", @"/Views/Manage/ExternalLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ExternalLogins.cshtml", typeof(Microsoft.eShopWeb.Web.Pages.Manage.Views_Manage_ExternalLogins))]
namespace Microsoft.eShopWeb.Web.Pages.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#line 2 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#line 4 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#line 5 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.Pages;

#line default
#line hidden
#line 6 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
#line 1 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73666b20f2c64ee02c2f600bbea27cce584e8417", @"/Views/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d260bd13a7f7d1b0143d034151ea04de3e5ffda", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3290b6ac67a9a81540f7bbe5f2c69ec45f3e9a", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExternalLoginsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";
    ViewData.AddActivePage(ManageNavPages.ExternalLogins);

#line default
#line hidden
            BeginContext(155, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73666b20f2c64ee02c2f600bbea27cce584e84177755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusMessage);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(251, 76, true);
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
             foreach (var login in Model.CurrentLogins)
            {

#line default
#line hidden
            BeginContext(399, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(446, 19, false);
#line 15 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                   Write(login.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(465, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 17 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                         if (Model.ShowRemoveButton)
                        {

#line default
#line hidden
            BeginContext(579, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(607, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73666b20f2c64ee02c2f600bbea27cce584e841711040", async() => {
                BeginContext(652, 77, true);
                WriteLiteral("\r\n                                <div>\r\n                                    ");
                EndContext();
                BeginContext(729, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73666b20f2c64ee02c2f600bbea27cce584e841711500", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 21 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(804, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(842, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73666b20f2c64ee02c2f600bbea27cce584e841713595", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(913, 83, true);
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 996, "\"", 1060, 7);
                WriteAttributeValue("", 1004, "Remove", 1004, 6, true);
                WriteAttributeValue(" ", 1010, "this", 1011, 5, true);
#line 23 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1015, login.LoginProvider, 1016, 20, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1036, "login", 1037, 6, true);
                WriteAttributeValue(" ", 1042, "from", 1043, 5, true);
                WriteAttributeValue(" ", 1047, "your", 1048, 5, true);
                WriteAttributeValue(" ", 1052, "account", 1053, 8, true);
                EndWriteAttribute();
                BeginContext(1061, 86, true);
                WriteLiteral(">Remove</button>\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1154, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1240, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1270, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 30 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                        }

#line default
#line hidden
            BeginContext(1306, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1371, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 36 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#line 37 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(1445, 61, true);
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(1506, 460, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73666b20f2c64ee02c2f600bbea27cce584e841719805", async() => {
                BeginContext(1573, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 44 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
                BeginContext(1709, 81, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1790, "\"", 1812, 1);
#line 46 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1798, provider.Name, 1798, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1813, "\"", 1868, 6);
                WriteAttributeValue("", 1821, "Log", 1821, 3, true);
                WriteAttributeValue(" ", 1824, "in", 1825, 3, true);
                WriteAttributeValue(" ", 1827, "using", 1828, 6, true);
                WriteAttributeValue(" ", 1833, "your", 1834, 5, true);
#line 46 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1838, provider.DisplayName, 1839, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1860, "account", 1861, 8, true);
                EndWriteAttribute();
                BeginContext(1869, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1871, 20, false);
#line 46 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1891, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 47 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                }

#line default
#line hidden
                BeginContext(1921, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1966, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
