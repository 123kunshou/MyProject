#pragma checksum "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c070e379376e7247d7fc0b54ff67f24dd48b41a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__EditUserModal), @"mvc.1.0.view", @"/Views/Users/_EditUserModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/_EditUserModal.cshtml", typeof(AspNetCore.Views_Users__EditUserModal))]
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
#line 1 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
using MyProject.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c070e379376e7247d7fc0b54ff67f24dd48b41a0", @"/Views/Users/_EditUserModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45dedcaf4e1504efb39e7e531688e53514e7d112", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__EditUserModal : MyProject.Web.Views.MyProjectRazorPage<MyProject.Web.Models.Users.EditUserModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("UserEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Users/_EditUserModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(129, 98, false);
#line 6 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditUser"))));

#line default
#line hidden
            EndContext();
            BeginContext(227, 34, true);
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n    ");
            EndContext();
            BeginContext(261, 4303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347ee9368cb7488fa212f626040e1883", async() => {
                BeginContext(334, 40, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 374, "\"", 396, 1);
#line 10 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 382, Model.User.Id, 382, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(397, 167, true);
                WriteLiteral(" />\r\n        <ul class=\"nav nav-tabs tab-nav-right\" role=\"tablist\">\r\n            <li role=\"presentation\" class=\"active\"><a href=\"#edit-user-details\" data-toggle=\"tab\">");
                EndContext();
                BeginContext(565, 16, false);
#line 12 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                             Write(L("UserDetails"));

#line default
#line hidden
                EndContext();
                BeginContext(581, 92, true);
                WriteLiteral("</a></li>\r\n            <li role=\"presentation\"><a href=\"#edit-user-roles\" data-toggle=\"tab\">");
                EndContext();
                BeginContext(674, 14, false);
#line 13 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                            Write(L("UserRoles"));

#line default
#line hidden
                EndContext();
                BeginContext(688, 469, true);
                WriteLiteral(@"</a></li>
        </ul>
        <div class=""tab-content"">
            <div role=""tabpanel"" class=""tab-pane animated fadeIn active"" id=""edit-user-details"">

                <div class=""row clearfix"" style=""margin-top:10px;"">
                    <div class=""col-sm-12"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""username"" type=""text"" name=""UserName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1157, "\"", 1185, 1);
#line 22 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 1165, Model.User.UserName, 1165, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1186, 144, true);
                WriteLiteral(" required maxlength=\"32\" minlength=\"2\" class=\"validate form-control\">\r\n                                <label for=\"username\" class=\"form-label\">");
                EndContext();
                BeginContext(1331, 13, false);
#line 23 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                    Write(L("UserName"));

#line default
#line hidden
                EndContext();
                BeginContext(1344, 406, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row clearfix"">
                    <div class=""col-sm-6"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""name"" type=""text"" name=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1750, "\"", 1774, 1);
#line 33 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 1758, Model.User.Name, 1758, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1775, 126, true);
                WriteLiteral(" required maxlength=\"32\" class=\"validate form-control\">\r\n                                <label for=\"name\" class=\"form-label\">");
                EndContext();
                BeginContext(1902, 9, false);
#line 34 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(1911, 342, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""surname"" type=""text"" name=""Surname""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2253, "\"", 2280, 1);
#line 41 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 2261, Model.User.Surname, 2261, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2281, 129, true);
                WriteLiteral(" required maxlength=\"32\" class=\"validate form-control\">\r\n                                <label for=\"surname\" class=\"form-label\">");
                EndContext();
                BeginContext(2411, 12, false);
#line 42 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                   Write(L("Surname"));

#line default
#line hidden
                EndContext();
                BeginContext(2423, 417, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row clearfix"">
                    <div class=""col-sm-12"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""email"" type=""email"" name=""EmailAddress""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2840, "\"", 2872, 1);
#line 52 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 2848, Model.User.EmailAddress, 2848, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2873, 119, true);
                WriteLiteral(" maxlength=\"256\" class=\"validate form-control\">\r\n                                <label for=\"email\" class=\"form-label\">");
                EndContext();
                BeginContext(2993, 17, false);
#line 53 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                 Write(L("EmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(3010, 424, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row clearfix"">
                    <div class=""col-sm-12"">
                        <div class=""form-group form-float"">
                            <div class="""">
                                <input id=""IsActive"" type=""checkbox"" name=""IsActive"" value=""true"" ");
                EndContext();
                BeginContext(3436, 36, false);
#line 63 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                              Write(Model.User.IsActive ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(3473, 99, true);
                WriteLiteral(" class=\"form-control\" />\r\n                                <label for=\"IsActive\" class=\"form-label\">");
                EndContext();
                BeginContext(3573, 13, false);
#line 64 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                    Write(L("IsActive"));

#line default
#line hidden
                EndContext();
                BeginContext(3586, 322, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div role=""tabpanel"" class=""tab-pane animated fadeIn"" id=""edit-user-roles"">
                <div class=""row"">
                    <div class=""col-sm-12 "">
");
                EndContext();
#line 74 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                         foreach (var role in Model.Roles)
                        {

#line default
#line hidden
                BeginContext(3995, 118, true);
                WriteLiteral("                            <div class=\"col-sm-6\">\r\n                                <input type=\"checkbox\" name=\"role\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4113, "\"", 4141, 1);
#line 77 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4121, role.NormalizedName, 4121, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4142, "\"", 4167, 1);
#line 77 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4150, role.Description, 4150, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4168, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4186, "\"", 4224, 1);
#line 77 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4191, string.Format("role{0}",role.Id), 4191, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4225, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4228, 41, false);
#line 77 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                                                                                                               Write(Model.UserIsInRole(role) ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(4270, 43, true);
                WriteLiteral(" />\r\n                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 4313, "\"", 4352, 1);
#line 78 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4319, string.Format("role{0}",role.Id), 4319, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4353, "\"", 4378, 1);
#line 78 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4361, role.DisplayName, 4361, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4379, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(4381, 9, false);
#line 78 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                                    Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4390, 46, true);
                WriteLiteral("</label>\r\n                            </div>\r\n");
                EndContext();
#line 80 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                        }

#line default
#line hidden
                BeginContext(4463, 94, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4564, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(4577, 74, false);
#line 89 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(4651, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(4655, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6bd1bf686e4d2a9ffff5604dffeb2a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 91 "G:\MyProject\src\MyProject.Web.Mvc\Views\Users\_EditUserModal.cshtml"
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
            BeginContext(4751, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProject.Web.Models.Users.EditUserModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
