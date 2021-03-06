#pragma checksum "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999fead3a3c56ce47b1a4b31e2bfce55dbe951d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organiser_Index), @"mvc.1.0.view", @"/Views/Organiser/Index.cshtml")]
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
#line 1 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
using SeminarManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
using SeminarManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999fead3a3c56ce47b1a4b31e2bfce55dbe951d7", @"/Views/Organiser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abaa12ea07c7a56f38d5931fbcad96dcb6ca3fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Organiser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SeminarManagementSystem.Models.Organiser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
  
    ViewData["Title"] = "Organiser";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"card\">\n        <div class=\"card-body\">\n\n            <div class=\"row card-header align-card\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 257, "\"", 311, 1);
#nullable restore
#line 11 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
WriteAttributeValue("", 263, Url.Content("~/Image/icons/organiser_icon.png"), 263, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""60"" height=""60"">
                <h1 class=""header-title"">Organiser</h1>
            </div>

            <table id=""grid"" class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">
                            ");
#nullable restore
#line 19 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.organiser_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th scope=\"col\">\n                            ");
#nullable restore
#line 22 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.organiser_DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th scope=\"col\">Options</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 28 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 32 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.organiser_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 35 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.organiser_DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999fead3a3c56ce47b1a4b31e2bfce55dbe951d77221", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 38 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                                                       WriteLiteral(item.organiserID);

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
            WriteLiteral(" |\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999fead3a3c56ce47b1a4b31e2bfce55dbe951d79420", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                                                          WriteLiteral(item.organiserID);

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
            WriteLiteral(" |\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999fead3a3c56ce47b1a4b31e2bfce55dbe951d711625", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                                                         WriteLiteral(item.organiserID);

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
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 43 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <div class=""container d-flex flex-column col-md-8"" id=""create-button"">

                <div class=""row flex-column"">
                    <button type=""button""
                            class=""col-4 align-self-end btn btn-primary btn-lg""
                            value=""Create""");
            BeginWriteAttribute("onclick", "\n                            onclick=\"", 2111, "\"", 2199, 3);
            WriteAttributeValue("", 2149, "location.href=\'", 2149, 15, true);
#nullable restore
#line 52 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
WriteAttributeValue("", 2164, Url.Action("Create", "Organiser"), 2164, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2198, "\'", 2198, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2230, "\"", 2272, 1);
#nullable restore
#line 53 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Index.cshtml"
WriteAttributeValue("", 2236, Url.Content("~/Image/new_icon.png"), 2236, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"25\" height=\"25\">\n                        New Organiser\n                    </button>\n                </div>\n\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SeminarManagementSystem.Models.Organiser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
