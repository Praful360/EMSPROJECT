#pragma checksum "C:\xampp\htdocs\EMSPROJECT\EmployeeManagementSystem\Views\Department\Views.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a705355436268a6c08eb093f580a9a0950402d06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Views), @"mvc.1.0.view", @"/Views/Department/Views.cshtml")]
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
#line 1 "C:\xampp\htdocs\EMSPROJECT\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem;

#line default
#line hidden
#line 2 "C:\xampp\htdocs\EMSPROJECT\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a705355436268a6c08eb093f580a9a0950402d06", @"/Views/Department/Views.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d74a7592af933458469e08f9ca7634db2dc2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Views : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\xampp\htdocs\EMSPROJECT\EmployeeManagementSystem\Views\Department\Views.cshtml"
  
    ViewData["Title"] = "Department";
    Layout = "_AdminLayout";

#line default
#line hidden
            WriteLiteral(@"<div class=""my-breadcrumb"">
    <ul>
        <li>Organic Deurali Farm</li>
        <li><i class=""fa fa-angle-double-right""></i></li>
        <li>View All Information</li>
    </ul>
</div>
<div class=""crud-view-wrapper"">
    <div class=""crud-view-wrapper-parent"">
        <div class=""crud-view-wrapper-child"">
            <div class=""add-new-btn"">
                <a href=""/Department"" class=""btn btn-outline-success""><i class=""fa fa-arrow-left""></i> Back</a>
            </div>
        </div>
        <div class=""crud-view-wrapper-child"">
            <div class=""oparation-title"">
                <h3>View Information</h3>
            </div>
        </div>
    </div>
    <!-- view-details -->
    <div class=""view-box-wrapper"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""view-box-wrapper-parent"">
                        <div class=""view-box-wrapper-child"">
                            <div class=""info-im");
            WriteLiteral("age\">\r\n                                <img src=\"../../images/img-test2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1176, "\"", 1182, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""view-box-wrapper-child"">
                            <div class=""info-details"">
                                <ul>
                                    <li><span>First Name:</span> Prabesh</li>
                                    <li><span>Last Name:</span> Rijal</li>
                                    <li><span>Email:</span> prabeshrijal67@gmail.com</li>
                                    <li><span>Phone:</span> 980655845</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- view-details -->
</div>
<script src=""js/custom.js""></script>
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
