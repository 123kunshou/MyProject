#pragma checksum "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acbeada61d85bdaf9e2d83c52c8e3571dfd5c017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Index.cshtml", typeof(AspNetCore.Views_Roles_Index))]
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
#line 1 "G:\MyProject\src\MyProject.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
using MyProject.Web.Startup;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbeada61d85bdaf9e2d83c52c8e3571dfd5c017", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45dedcaf4e1504efb39e7e531688e53514e7d112", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : MyProject.Web.Views.MyProjectRazorPage<MyProject.Web.Models.Roles.RoleListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Roles/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Roles/Index.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("roleCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
  
    ViewBag.CurrentPageName = PageNames.Roles; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(204, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(210, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "418c5e4788c141fdb8ab343b128d560b", async() => {
                    BeginContext(243, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(253, 87, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d83ac736e10a4cdda128c189ac02e96e", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 9 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(340, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(360, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(368, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebb9b2efb734cd9b9fb8f85cfde9fc7", async() => {
                    BeginContext(408, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(418, 91, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db1d67b9f93c4b7dbe5f3519aecdc1cf", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 13 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(509, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(529, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(534, 191, true);
            WriteLiteral("<div class=\"row clearfix\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2>\r\n                    ");
            EndContext();
            BeginContext(726, 10, false);
#line 21 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
               Write(L("Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(736, 594, true);
            WriteLiteral(@"
                </h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a id=""RefreshButton"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">refresh</i>");
            EndContext();
            BeginContext(1331, 12, false);
#line 29 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                  Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 283, true);
            WriteLiteral(@"</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body table-responsive"">
                <table class=""table"">
                    <thead>
                    <tr>
                        <th>");
            EndContext();
            BeginContext(1627, 13, false);
#line 38 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("RoleName"));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1676, 16, false);
#line 39 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("DisplayName"));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1728, 12, false);
#line 40 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 93, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 44 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                     foreach (var role in Model.Roles)
                    {

#line default
#line hidden
            BeginContext(1912, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1975, 9, false);
#line 47 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1984, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2024, 16, false);
#line 48 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2040, 498, true);
            WriteLiteral(@"</td>
                            <td class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">menu</i>
                                </a>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a href=""#"" class=""waves-effect waves-block edit-role"" data-role-id=""");
            EndContext();
            BeginContext(2539, 7, false);
#line 54 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                        Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2546, 85, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#RoleEditModal\"><i class=\"material-icons\">edit</i>");
            EndContext();
            BeginContext(2632, 9, false);
#line 54 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                                     Write(L("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(2641, 122, true);
            WriteLiteral("</a></li>\r\n                                    <li><a href=\"#\" class=\"waves-effect waves-block delete-role\" data-role-id=\"");
            EndContext();
            BeginContext(2764, 7, false);
#line 55 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                          Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2771, 18, true);
            WriteLiteral("\" data-role-name=\"");
            EndContext();
            BeginContext(2790, 9, false);
#line 55 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                    Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2799, 44, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>");
            EndContext();
            BeginContext(2844, 11, false);
#line 55 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                          Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(2855, 116, true);
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 59 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2994, 699, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <button type=""button"" class=""btn btn-primary btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#RoleCreateModal"">
                    <i class=""material-icons"">add</i>
                </button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""RoleCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""RoleCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">
                    <span>");
            EndContext();
            BeginContext(3694, 18, false);
#line 74 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                     Write(L("CreateNewRole"));

#line default
#line hidden
            EndContext();
            BeginContext(3712, 106, true);
            WriteLiteral("</span>\r\n                </h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(3818, 2967, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "049d4e2984174979b3ac1492bda51fdc", async() => {
                BeginContext(3893, 449, true);
                WriteLiteral(@"
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <input id=""rolename"" type=""text"" name=""Name"" required maxlength=""32"" minlength=""2"" class=""validate form-control"">
                                    <label for=""rolename"" class=""form-label"">");
                EndContext();
                BeginContext(4343, 13, false);
#line 84 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(4356, 608, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <input id=""displayname"" type=""text"" name=""DisplayName"" required maxlength=""32"" minlength=""2"" class=""validate form-control"">
                                    <label for=""displayname"" class=""form-label"">");
                EndContext();
                BeginContext(4965, 16, false);
#line 95 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                           Write(L("DisplayName"));

#line default
#line hidden
                EndContext();
                BeginContext(4981, 573, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <textarea id=""role-description"" name=""Description"" class=""validate form-control""></textarea>
                                    <label for=""role-description"" class=""form-label"">");
                EndContext();
                BeginContext(5555, 20, false);
#line 106 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                Write(L("RoleDescription"));

#line default
#line hidden
                EndContext();
                BeginContext(5575, 277, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <h4>");
                EndContext();
                BeginContext(5853, 16, false);
#line 114 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(L("Permissions"));

#line default
#line hidden
                EndContext();
                BeginContext(5869, 7, true);
                WriteLiteral("</h4>\r\n");
                EndContext();
#line 115 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                             foreach (var permission in Model.Permissions)
                            {

#line default
#line hidden
                BeginContext(5983, 132, true);
                WriteLiteral("                                <div class=\"col-sm-6\">\r\n                                    <input type=\"checkbox\" name=\"permission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6115, "\"", 6139, 1);
#line 118 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6123, permission.Name, 6123, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6140, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 6158, "\"", 6190, 2);
                WriteAttributeValue("", 6163, "permission-", 6163, 11, true);
#line 118 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6174, permission.Name, 6174, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6191, 65, true);
                WriteLiteral(" checked=\"checked\" />\r\n                                    <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 6256, "\"", 6289, 2);
                WriteAttributeValue("", 6262, "permission-", 6262, 11, true);
#line 119 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6273, permission.Name, 6273, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6290, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(6292, 22, false);
#line 119 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(permission.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(6314, 50, true);
                WriteLiteral("</label>\r\n                                </div>\r\n");
                EndContext();
#line 121 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(6395, 212, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">");
                EndContext();
                BeginContext(6608, 11, false);
#line 125 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                   Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(6619, 94, true);
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(6714, 9, false);
#line 126 "G:\MyProject\src\MyProject.Web.Mvc\Views\Roles\Index.cshtml"
                                                                              Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(6723, 55, true);
                WriteLiteral("</button>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6785, 316, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""RoleEditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""RoleEditModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">

        </div>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProject.Web.Models.Roles.RoleListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
