#pragma checksum "D:\EMSPROJECT\EmployeeManagementSystem\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a9f9717f44421dd09f63e6e9d6caa38e8a23450"
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
#line 1 "D:\EMSPROJECT\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EMSPROJECT\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9f9717f44421dd09f63e6e9d6caa38e8a23450", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d74a7592af933458469e08f9ca7634db2dc2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\EMSPROJECT\EmployeeManagementSystem\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""employee-management-system-main-wrapper"">
    <!-- navigation section -->
    <section class=""main-navigation-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <ul>
                        <li>
                            <a href=""#""><img src=""../images/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 422, "\"", 428, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        </li>
                        <li>
                            <!-- hamburger -->
                        </li>
                        <li><p>Deurali Organic Farm</p></li>
                        <li><input type=""text"" placeholder=""Search here.....""><i class=""fa fa-search""></i></li>
                        <li><a href=""#""><i class=""fa fa-bell""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-comment""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""profile-picture-wrapper"">
            <img src=""../images/img-test2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1088, "\"", 1094, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""active-status-icon"">
                <div class=""active-icon""></div>
            </div>
        </div>
    </section>
    <!-- navigation section -->
    <!-- dashboard -->
    <section class=""main-dashboard-section"">
        <div class=""dashboard-parent"">
            <!-- side-menu -->
            <div class=""dashboard-childs"">
                <!-- manage-department -->
                <ul>
                    <li><a href=""#"" class=""text-white""><i class=""fa fa-database mr-2""></i> Main</a></li>
                    <li><a href=""department/department.html""><i class=""fa fa-building mr-3""></i> Department</a></li>
                    <li><a href=""#""><i class=""fa fa-user mr-3""></i> Employee</a></li>
                    <li><a href=""#""><i class=""fa fa-money-bill mr-3""></i> Salary</a></li>
                    <li><a href=""#""><i class=""fa fa-align-center mr-3""></i> Leaves</a></li>
                    <li><a href=""#""><i class=""fa fa-clipboard mr-3""></i> Designation</a></li>");
            WriteLiteral(@"
                    <li><a href=""#""><i class=""fa fa-list-alt mr-3""></i> Vacancy</a></li>
                    <li><a href=""#""><i class=""fa fa-chart-area mr-3""></i> Reports</a></li>
                </ul>
                <!-- manage-department -->
            </div>
            <!-- side-menu -->
            <!-- main-display -->
            <!-- ------------------------------ -->
            <div class=""dashboard-childs"">
                <div class=""welcome-admin"">
                    <h1>Welcome Admin!</h1>
                </div>
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""main-report-wrapper"">
                                <div class=""main-report-icon"">
                                    <i class=""fa fa-building""></i>
                                </div>
                                <div class=""main-report-info"">
                                    <h3>83</h3>
");
            WriteLiteral(@"                                    <p>Departments</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""main-report-wrapper"">
                                <div class=""main-report-icon"">
                                    <i class=""fa fa-list-alt""></i>
                                </div>
                                <div class=""main-report-info"">
                                    <h3>12</h3>
                                    <p>Vacancies</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""main-report-wrapper"">
                                <div class=""main-report-icon"">
                                    <i class=""fa fa-align-center""></i>
                                </div>
               ");
            WriteLiteral(@"                 <div class=""main-report-info"">
                                    <h3>16</h3>
                                    <p>Leave Letters</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""main-report-wrapper"">
                                <div class=""main-report-icon"">
                                    <i class=""fa fa-user""></i>
                                </div>
                                <div class=""main-report-info"">
                                    <h3>18</h3>
                                    <p>Adsent Employees</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""my-graph-report"">
                         ");
            WriteLiteral(@"       <div id=""chart_div""></div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""my-graph-report"">
                                <div id=""chart_div2""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- main-display -->
        </div>
    </section>
    <!-- dashboard -->
</section>
<script src=""js/custom.js""></script>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawVisualization);

      function drawVisualization() {
        // Some raw data (not necessarily accurate)
        var data = google.visualization.arrayToDataTable([
          ['Month', 'Bolivia', 'Ecuador', 'Madagascar', 'Papua New Guine");
            WriteLiteral(@"a', 'Rwanda', 'Average'],
          ['2004/05',  165,      938,         522,             998,           450,      614.6],
          ['2005/06',  135,      1120,        599,             1268,          288,      682],
          ['2006/07',  157,      1167,        587,             807,           397,      623],
          ['2007/08',  139,      1110,        615,             968,           215,      609.4],
          ['2008/09',  136,      691,         629,             1026,          366,      569.6]
        ]);

        var options = {
          title : 'Monthly Employee Attendance Report',
          vAxis: {title: 'Cups'},
          hAxis: {title: 'Month'},
          seriesType: 'bars',
          series: {5: {type: 'line'}}
        };

        var chart = new google.visualization.ComboChart(document.getElementById('chart_div'));
        chart.draw(data, options);
      }
</script>
<script type=""text/javascript"">
        google.charts.load('current', {'packages':['corechart']});
        goog");
            WriteLiteral(@"le.charts.setOnLoadCallback(drawChart);

        function drawChart() {
          var data = google.visualization.arrayToDataTable([
            ['Age', 'Weight'],
            [ 8,      12],
            [ 4,      5.5],
            [ 11,     14],
            [ 4,      5],
            [ 3,      3.5],
            [ 6.5,    7]
          ]);

          var options = {
            title: 'Production Report',
            hAxis: {title: 'Age', minValue: 0, maxValue: 15},
            vAxis: {title: 'Weight', minValue: 0, maxValue: 15},
            legend: 'none'
          };

          var chart = new google.visualization.ScatterChart(document.getElementById('chart_div2'));

          chart.draw(data, options);
        }
</script>");
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
