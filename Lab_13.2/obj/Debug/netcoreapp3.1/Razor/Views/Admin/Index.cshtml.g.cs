#pragma checksum "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411232c385b14af7567a23ee806680bceb7975d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411232c385b14af7567a23ee806680bceb7975d2", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7fd528cb60011606cd04103f15ea356a7280ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoffeeTable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<b style=\"color:red;\">");
#nullable restore
#line 9 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml"
                 Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml"
 foreach (CoffeeTable prod in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 13 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml"
   Write(prod.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <button><a");
            BeginWriteAttribute("href", " href=\"", 222, "\"", 266, 2);
            WriteAttributeValue("", 229, "/Admin/Edit?ProductID=", 229, 22, true);
#nullable restore
#line 14 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml"
WriteAttributeValue("", 251, prod.ProductID, 251, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></button> <button><a");
            BeginWriteAttribute("href", " href=\"", 296, "\"", 342, 2);
            WriteAttributeValue("", 303, "/Admin/Delete?ProductID=", 303, 24, true);
#nullable restore
#line 14 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml"
WriteAttributeValue("", 327, prod.ProductID, 327, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></button>\r\n    <br />\r\n");
#nullable restore
#line 16 "C:\Users\BBURCH\DevBuildProjects\Lab_13.2\Lab_13.2\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<a href=\"/Admin/Add\">Add A New Product</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoffeeTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
