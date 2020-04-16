#pragma checksum "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f10d487719b139dccad0671b833f8915fca54c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisplayObjects_Details), @"mvc.1.0.view", @"/Views/DisplayObjects/Details.cshtml")]
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
#line 1 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10d487719b139dccad0671b833f8915fca54c27", @"/Views/DisplayObjects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0021bd08ba069bd3f9a9eba953f746aee9124a0d", @"/Views/_ViewImports.cshtml")]
    public class Views_DisplayObjects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Backend.Models.DisplayObject>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>DisplayObject</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 32 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
         if (Model.Type == Backend.Models.Interfaces.Type.Video)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 36 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.YouTubeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 39 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
           Write(Html.DisplayFor(model => model.YouTubeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Card Url\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 45 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
           Write(Html.DisplayFor(model => model.ImageUrls));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 47 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Images\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 55 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
                 foreach (var url in Model.ImageUrls.Split(';'))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 1601, "\"", 1611, 1);
#nullable restore
#line 57 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
WriteAttributeValue("", 1607, url, 1607, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"article-image-preview\" />\r\n");
#nullable restore
#line 58 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n");
#nullable restore
#line 60 "D:\Me\00. Classes\00. Programming\06. TV App Development\MyApplication\Backend\Views\DisplayObjects\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n\r\n\r\n<style>\r\n    .article-image-preview {\r\n        max-height: 300px;\r\n        max-width: 300px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Backend.Models.DisplayObject> Html { get; private set; }
    }
}
#pragma warning restore 1591
