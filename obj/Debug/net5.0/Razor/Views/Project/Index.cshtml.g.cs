#pragma checksum "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63570e7de5acab7e133e9f9dddd7040ab2450552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "E:\Software Department\ProjectManagement\ProjectManagement\Views\_ViewImports.cshtml"
using ProjectManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Software Department\ProjectManagement\ProjectManagement\Views\_ViewImports.cshtml"
using ProjectManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63570e7de5acab7e133e9f9dddd7040ab2450552", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707ed085060d81e1a092e876778245b43e0d1ef1", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63570e7de5acab7e133e9f9dddd7040ab24505524958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-12\">\r\n\r\n    <!-- /.card -->\r\n    <div class=\"card\">\r\n\r\n        <div class=\"card-header border-0\">\r\n            <button class=\"btn btn-primary\" style=\"border-radius:20px 5px;\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 368, "\"", 426, 3);
            WriteAttributeValue("", 378, "location.href=\'", 378, 15, true);
#nullable restore
#line 17 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
WriteAttributeValue("", 393, Url.Action("Create", "Project"), 393, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 425, "\'", 425, 1, true);
            EndWriteAttribute();
            WriteLiteral("><b>Create</b></button>\r\n            <hr />\r\n            <center>  <h1 class=\"card-title\"><b>Project List</b></h1></center>\r\n");
            WriteLiteral(@"
            <hr />
        </div>
        <div class=""card-body table-responsive p-0"">
            <table class=""table table-striped table-valign-middle"">

                <thead>
                    <tr>
                        <th>
                            Sl No
                        </th>
                        <th>
                            ");
#nullable restore
#line 40 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Project Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 43 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Project Initial Budget"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 46 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Project Final Budget"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 49 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Project Start Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 52 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Project End Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 55 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Project Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 58 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Project Attachment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 61 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       Write(Html.DisplayName("Bureau Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 67 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                       int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                     foreach (var item in @ViewBag.Project)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
#nullable restore
#line 72 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                                   i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 73 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 76 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 79 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(item.ProjectInitialBudget);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 82 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(item.ProjectFinalBudget);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 85 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(item.ProjectStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(item.ProjectEndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 91 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(item.ProjectDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                              \r\n                                <a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 3539, "\"", 3593, 2);
            WriteAttributeValue("", 3546, "/File/ProjectAttachment/", 3546, 24, true);
#nullable restore
#line 95 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
WriteAttributeValue("", 3570, item.ProjectAttachment, 3570, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 95 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                                                                                                                                     Write(item.ProjectAttachment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 99 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                           Write(item.BureauName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63570e7de5acab7e133e9f9dddd7040ab245055215311", async() => {
                WriteLiteral("Edit");
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
#line 102 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                                                       WriteLiteral(item.ProjectId);

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
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63570e7de5acab7e133e9f9dddd7040ab245055217523", async() => {
                WriteLiteral("Details");
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
#line 103 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                                                          WriteLiteral(item.ProjectId);

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
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63570e7de5acab7e133e9f9dddd7040ab245055219741", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                                                         WriteLiteral(item.ProjectId);

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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 107 "E:\Software Department\ProjectManagement\ProjectManagement\Views\Project\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <!-- /.card -->\r\n</div>\r\n");
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
