#pragma checksum "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Home/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c95a74b6633671769d3df8008258050260140be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c95a74b6633671769d3df8008258050260140be", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abaa12ea07c7a56f38d5931fbcad96dcb6ca3fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"text-center card\">\n    <div class=\"container my-2\">\n\n        <div class=\"row card-header align-card\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 210, "\"", 262, 1);
#nullable restore
#line 10 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Home/Contact.cshtml"
WriteAttributeValue("", 216, Url.Content("~/Image/icons/contact_icon.png"), 216, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""60"" height=""60"">
            <h1 class=""header-title"">Contact Us</h1>
        </div>
        <br />
        <address>
            King's Own Institute <br>
            Send us an e_mail: <a href=""mailto:reception@koi.edu.au"">KOI Reception e_mail</a>.<br>
            17 O'Connell St, Sydney NSW 2000<br>
            AUSTRALIA
        </address>

        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3312.961045527749!2d151.20722291494968!3d-33.864894780657366!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6b12afe81b9bb8b9%3A0x9a81e3d0456af3dc!2sKing&#39;s%20Own%20Institute!5e0!3m2!1sen!2sau!4v1643351003859!5m2!1sen!2sau"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 965, "\"", 983, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\n\n    </div>\n </div>\n\n");
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
