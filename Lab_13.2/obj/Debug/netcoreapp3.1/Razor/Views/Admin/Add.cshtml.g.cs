#pragma checksum "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91dada839787b3811d41df8e655d7edaf4701fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Add), @"mvc.1.0.view", @"/Views/Admin/Add.cshtml")]
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
#line 1 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\_ViewImports.cshtml"
using Lab_13._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\_ViewImports.cshtml"
using Lab_13._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91dada839787b3811d41df8e655d7edaf4701fda", @"/Views/Admin/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7fd528cb60011606cd04103f15ea356a7280ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/SaveNew"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml"
Write(ViewBag.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91dada839787b3811d41df8e655d7edaf4701fda4069", async() => {
                WriteLiteral("\r\n    Product Name: <input type=\"text\" name=\"productName\"");
                BeginWriteAttribute("value", " value=\"", 131, "\"", 159, 1);
#nullable restore
#line 4 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml"
WriteAttributeValue("", 139, ViewBag.ProductName, 139, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> <br />\r\n\r\n    Product Description: <input type=\"text\" name=\"productDescription\"");
                BeginWriteAttribute("value", " value=\"", 243, "\"", 271, 1);
#nullable restore
#line 6 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml"
WriteAttributeValue("", 251, ViewBag.Description, 251, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> <br />\r\n    Product Price: <input type=\"text\" name=\"productPrice\"");
                BeginWriteAttribute("value", " value=\"", 341, "\"", 363, 1);
#nullable restore
#line 7 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml"
WriteAttributeValue("", 349, ViewBag.Price, 349, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> <br />\r\n    Product Category: <input type=\"text\" name=\"productCategory\"");
                BeginWriteAttribute("value", " value=\"", 439, "\"", 464, 1);
#nullable restore
#line 8 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml"
WriteAttributeValue("", 447, ViewBag.Category, 447, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> <br />\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 511, "\"", 537, 1);
#nullable restore
#line 9 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml"
WriteAttributeValue("", 519, ViewBag.ProductID, 519, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 569, "\"", 594, 1);
#nullable restore
#line 11 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Add.cshtml"
WriteAttributeValue("", 577, ViewBag.PageName, 577, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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