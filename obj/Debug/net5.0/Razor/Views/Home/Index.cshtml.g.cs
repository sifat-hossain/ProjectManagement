#pragma checksum "F:\Github\ProjectManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c73806bba3cdf7f950f6c6bdf7cb9d55335fbff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\Github\ProjectManagement\Views\_ViewImports.cshtml"
using ProjectManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Github\ProjectManagement\Views\_ViewImports.cshtml"
using ProjectManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c73806bba3cdf7f950f6c6bdf7cb9d55335fbff8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707ed085060d81e1a092e876778245b43e0d1ef1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Github\ProjectManagement\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<center>
    <section class=""content"">
        <div class=""container-fluid"">
            <!-- Small boxes (Stat box) -->
            <div class=""row"">
                <div class=""col-lg-3 col-6"">
                    <!-- small box -->
                    <div class=""small-box bg-success "">
                        <div class=""inner"">
                            <h3>5</h3>

                            <p>Completed Project</p>
                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-bag""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-3 col-6"">
                    <!-- small box -->
                    <div class=""small-box bg-info"">
                        <div class=""inner"">
                         ");
            WriteLiteral("   <h3>");
#nullable restore
#line 29 "F:\Github\ProjectManagement\Views\Home\Index.cshtml"
                           Write(ViewBag.ProjectAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                            <p>Project Under Development</p>
                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-stats-bars""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-3 col-6"">
                    <!-- small box -->
                    <div class=""small-box bg-warning"">
                        <div class=""inner"">
                            <h3>50</h3>

                            <p>Product Will be Expired in this Year</p>
                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-rig");
            WriteLiteral(@"ht""></i></a>
                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-3 col-6"">
                    <!-- small box -->
                    <div class=""small-box bg-danger"">
                        <div class=""inner"">
                            <h3>2</h3>

                            <p><b>Project PG will be Expired within 6 Month </b></p>
                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-pie-graph""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                    </div>
                </div>
                <div class=""col-lg-3 col-6"">
                    <!-- small box -->
                    <div class=""small-box bg-danger"">
                        <div class=""inner"">
                            <h3>3</h3>

                            <p>Project Warr");
            WriteLiteral(@"anty will be Expired within 6 Month</p>
                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-pie-graph""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                    </div>
                </div>
                <!-- ./col -->
            </div>
            <!-- /.row -->
            <!-- Main row -->
            <div class=""col-lg-12"">

                <!-- /.card -->
                <div class=""card"">
                    <div class=""card-header border-0"">
                        <center>  <h1 class=""card-title""><b>Project List</b></h1></center>
");
            WriteLiteral(@"                    </div>
                    <div class=""card-body table-responsive p-0"">
                        <table class=""table table-striped table-valign-middle"">
                            <thead>
                                <tr>
                                    <th>Sl No.</th>
                                    <th>Project Name</th>
                                    <th>Contract Date</th>
                                    <th>Warranty Expired Date</th>
                                    <th>PG Expired Date</th>
                                    <th>Remarks</th>
                                    <th>Action</th>

                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>Project Management system</td>
                                    <td>01 August, 2021</td>
                             ");
            WriteLiteral(@"       <td>20 August, 2025</td>
                                    <td>20 Semptember, 2023</td>
                                    <td>This System is used for manage all the Project </td>
                                    <td>Details</td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>Test Project Data 2021</td>
                                    <td>01 August, 2021</td>
                                    <td>20 August, 2025</td>
                                    <td>20 Semptember, 2023</td>
                                    <td>This System is used for manage all the Project </td>
                                    <td>Details</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col-md-6 -");
            WriteLiteral("->\r\n        </div>\r\n    </section>\r\n</center>");
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
