#pragma checksum "C:\xampp\htdocs\EMSPROJECT\EmployeeManagementSystem\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1bf97a1fdde3f3d0443be3ae01e6d3951ab15c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1bf97a1fdde3f3d0443be3ae01e6d3951ab15c", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d74a7592af933458469e08f9ca7634db2dc2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\xampp\htdocs\EMSPROJECT\EmployeeManagementSystem\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Department";
    Layout = "_AdminLayout";

#line default
#line hidden
            WriteLiteral(@"
                <div class=""my-breadcrumb"">
                    <ul>
                        <li>Organic Deurali Farm</li>
                        <li><i class=""fa fa-angle-double-right""></i></li>
                        <li>Manage Department</li>
                    </ul>
                </div>
                <div class=""crud-view-wrapper"">
                    <div class=""crud-view-wrapper-parent"">
                        <div class=""crud-view-wrapper-child"">
                            <div class=""add-new-btn"">
                                <a href=""Department/Create"" class=""btn btn-outline-success"">Add New Department <i class=""fa fa-arrow-right""></i></a>
                            </div>
                        </div>
                        <div class=""crud-view-wrapper-child"">
                            <div class=""oparation-title"">
                                <h3>Manage Department</h3>
                            </div>
                        </div>
                    </d");
            WriteLiteral(@"iv>
                    <!-- view table -->
                    <table class=""table table-hover table-bordered mt-4"">
                        <thead>
                            <tr>
                                <th scope=""col"">S.N</th>
                                <th scope=""col"">Fname</th>
                                <th scope=""col"">Lname</th>
                                <th scope=""col"">DOB</th>
                                <th scope=""col"">Address</th>
                                <th scope=""col"">Email</th>
                                <th scope=""col"">Phone</th>
                                <th scope=""col"">Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th scope=""row"">1</th>
                                <td>Prabesh</td>
                                <td>Rijal</td>
                                <td>5-2-2021</td>
                ");
            WriteLiteral(@"                <td>Pokhara, Nepal</td>
                                <td>prabeshrijal5@gmail.com</td>
                                <td>98754552</td>
                                <td class=""my-action-icons"">
                                    <ul>
                                        <li class=""mr-3""><a href=""Department/Views""><i class=""fa fa-eye""></i></a></li>
                                        <li class=""mr-3""><a href=""Department/Edit""><i class=""fa fa-pen""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-trash""></i></a></li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">2</th>
                                <td>Praful</td>
                                <td>Tamrakar</td>
                                <td>5-2-2021</td>
                                <td>Pokhara, Nepal</td>
 ");
            WriteLiteral(@"                               <td>prafultamrakar5@gmail.com</td>
                                <td>98754552</td>
                                <td class=""my-action-icons"">
                                    <ul>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-eye""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-pen""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-trash""></i></a></li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">3</th>
                                <td>Vivek</td>
                                <td>Gurung</td>
                                <td>5-2-2021</td>
                                <td>Pokhara, Nepal</td>
                                <td>vivekgurung5@gmail.com</td>
        ");
            WriteLiteral(@"                        <td>98754552</td>
                                <td class=""my-action-icons"">
                                    <ul>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-eye""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-pen""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-trash""></i></a></li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">4</th>
                                <td>Vivek</td>
                                <td>Gurung</td>
                                <td>5-2-2021</td>
                                <td>Pokhara, Nepal</td>
                                <td>vivekgurung5@gmail.com</td>
                                <td>98754552</td>
                                ");
            WriteLiteral(@"<td class=""my-action-icons"">
                                    <ul>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-eye""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-pen""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-trash""></i></a></li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">5</th>
                                <td>Vivek</td>
                                <td>Gurung</td>
                                <td>5-2-2021</td>
                                <td>Pokhara, Nepal</td>
                                <td>vivekgurung5@gmail.com</td>
                                <td>98754552</td>
                                <td class=""my-action-icons"">
                                    <ul>
   ");
            WriteLiteral(@"                                     <li class=""mr-3""><a href=""#""><i class=""fa fa-eye""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-pen""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-trash""></i></a></li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">6</th>
                                <td>Vivek</td>
                                <td>Gurung</td>
                                <td>5-2-2021</td>
                                <td>Pokhara, Nepal</td>
                                <td>vivekgurung5@gmail.com</td>
                                <td>98754552</td>
                                <td class=""my-action-icons"">
                                    <ul>
                                        <li class=""mr-3""><a href=""#""><i class=");
            WriteLiteral(@"""fa fa-eye""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-pen""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-trash""></i></a></li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <th scope=""row"">7</th>
                                <td>Vivek</td>
                                <td>Gurung</td>
                                <td>5-2-2021</td>
                                <td>Pokhara, Nepal</td>
                                <td>vivekgurung5@gmail.com</td>
                                <td>98754552</td>
                                <td class=""my-action-icons"">
                                    <ul>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-eye""></i></a></li>
                                        <li clas");
            WriteLiteral(@"s=""mr-3""><a href=""#""><i class=""fa fa-pen""></i></a></li>
                                        <li class=""mr-3""><a href=""#""><i class=""fa fa-trash""></i></a></li>
                                    </ul>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <!-- view table -->
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
