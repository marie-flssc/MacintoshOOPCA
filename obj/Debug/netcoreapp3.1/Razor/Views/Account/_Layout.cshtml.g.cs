#pragma checksum "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/Account/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67fc3b6895de07c9fbd5920f42e09c8793e31070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__Layout), @"mvc.1.0.view", @"/Views/Account/_Layout.cshtml")]
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
#line 1 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/_ViewImports.cshtml"
using Macintosh_OOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/_ViewImports.cshtml"
using Macintosh_OOP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67fc3b6895de07c9fbd5920f42e09c8793e31070", @"/Views/Account/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716a2e89b7ccbb09e0cf15a449da4ea92953fe1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc3b6895de07c9fbd5920f42e09c8793e310703221", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>");
#nullable restore
#line 5 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/Account/_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </title>>\n    <link");
                BeginWriteAttribute("href", " href=\"", 133, "\"", 181, 1);
#nullable restore
#line 6 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/Account/_Layout.cshtml"
WriteAttributeValue("", 140, Url.Content("~/styles/font-awesome.css"), 140, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"texte/css\" />\n    <link");
                BeginWriteAttribute("href", " href=\"", 229, "\"", 270, 1);
#nullable restore
#line 7 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/Account/_Layout.cshtml"
WriteAttributeValue("", 236, Url.Content("~/styles/style.css"), 236, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\n    <link");
                BeginWriteAttribute("href", " href=\"", 317, "\"", 347, 1);
#nullable restore
#line 8 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/Account/_Layout.cshtml"
WriteAttributeValue("", 324, Url.Content("~/fonts"), 324, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\n    <link");
                BeginWriteAttribute("href", " href=\"", 378, "\"", 418, 1);
#nullable restore
#line 9 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/Account/_Layout.cshtml"
WriteAttributeValue("", 385, Url.Content("~/images/bann.jpg"), 385, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc3b6895de07c9fbd5920f42e09c8793e310706188", async() => {
                WriteLiteral("\n    <div>\n        ");
#nullable restore
#line 13 "/Users/zoeharris/School/S4/OOP/final_project/MacintoshOOPCA/Views/Account/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
