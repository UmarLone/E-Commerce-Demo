#pragma checksum "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "949f1cf9e4ac63c63d95a9fccf4c7113d877156f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.Web.Pages.Shared.Pages_Shared__pagination), @"mvc.1.0.view", @"/Pages/Shared/_pagination.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_pagination.cshtml", typeof(Microsoft.eShopWeb.Web.Pages.Shared.Pages_Shared__pagination))]
namespace Microsoft.eShopWeb.Web.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#line 2 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#line 4 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#line 5 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.Pages;

#line default
#line hidden
#line 6 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"949f1cf9e4ac63c63d95a9fccf4c7113d877156f", @"/Pages/Shared/_pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d260bd13a7f7d1b0143d034151ea04de3e5ffda", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginationInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 155, true);
            WriteLiteral("\r\n<div class=\"esh-pager\">\r\n\t<div class=\"container-fluid\">\r\n\t\t<article class=\"esh-pager-wrapper row\">\r\n\t\t\t<nav>\r\n\t\t\t\t<div class=\"col-md-2 col-xs-12\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(187, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949f1cf9e4ac63c63d95a9fccf4c7113d877156f5906", async() => {
                BeginContext(381, 23, true);
                WriteLiteral("\r\n\t\t\t\t\t\tPrevious\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 197, "esh-pager-item-left", 197, 19, true);
            AddHtmlAttributeValue(" ", 216, "esh-pager-item--navigable", 217, 26, true);
            AddHtmlAttributeValue(" ", 242, "esh-pager-item", 243, 15, true);
#line 8 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
AddHtmlAttributeValue(" ", 257, Model.Previous, 258, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
                              WriteLiteral(Model.ActualPage - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(408, 108, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t\t<div class=\"col-md-8 col-xs-12\">\r\n\t\t\t\t\t<span class=\"esh-pager-item\">\r\n\t\t\t\t\t\tShowing ");
            EndContext();
            BeginContext(517, 18, false);
#line 18 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
                           Write(Model.ItemsPerPage);

#line default
#line hidden
            EndContext();
            BeginContext(535, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(540, 16, false);
#line 18 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
                                                  Write(Model.TotalItems);

#line default
#line hidden
            EndContext();
            BeginContext(556, 17, true);
            WriteLiteral(" products - Page ");
            EndContext();
            BeginContext(575, 20, false);
#line 18 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
                                                                                     Write(Model.ActualPage + 1);

#line default
#line hidden
            EndContext();
            BeginContext(596, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(600, 16, false);
#line 18 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
                                                                                                              Write(Model.TotalPages);

#line default
#line hidden
            EndContext();
            BeginContext(616, 83, true);
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t        \r\n\t\t\t\t<div class=\"col-md-2 col-xs-12\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(699, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949f1cf9e4ac63c63d95a9fccf4c7113d877156f10909", async() => {
                BeginContext(882, 19, true);
                WriteLiteral("\r\n\t\t\t\t\t\tNext\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 709, "esh-pager-item-right", 709, 20, true);
            AddHtmlAttributeValue(" ", 729, "esh-pager-item--navigable", 730, 26, true);
            AddHtmlAttributeValue(" ", 755, "esh-pager-item", 756, 15, true);
#line 23 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
AddHtmlAttributeValue(" ", 770, Model.Next, 771, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\Predator\Desktop\Demo\E-Commerce-Demo\eShopOnWeb-master\src\Web\Pages\Shared\_pagination.cshtml"
                              WriteLiteral(Model.ActualPage + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(905, 58, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</nav>\r\n\t\t</article>\r\n\t</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginationInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
