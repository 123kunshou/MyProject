#pragma checksum "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a91cba6c15af2571dab6adf8811d5a42a87222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
using Abp.Collections.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1a91cba6c15af2571dab6adf8811d5a42a87222", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b203b3f0805b4f117ac3d0d294f9ef72921dac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : MyProject.Web.Views.MyProjectRazorPage<Abp.Web.Mvc.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 172, true);
            WriteLiteral("<div class=\"row\">\n    <section class=\"col-lg-12\">\n        <div class=\"panel panel-warning\">\n            <div class=\"panel-heading\">\n                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(248, 23, false);
#line 7 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                                   Write(Model.ErrorInfo.Message);

#line default
#line hidden
            EndContext();
            BeginContext(271, 102, true);
            WriteLiteral("</h3>\n            </div>\n            <div class=\"panel-body\">\n                <p>\n                    ");
            EndContext();
            BeginContext(375, 98, false);
#line 11 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                Write(!string.IsNullOrEmpty(Model.ErrorInfo.Details) ? Model.ErrorInfo.Details : Model.ErrorInfo.Message);

#line default
#line hidden
            EndContext();
            BeginContext(474, 22, true);
            WriteLiteral("\n                </p>\n");
            EndContext();
#line 14 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                 if (!Model.ErrorInfo.ValidationErrors.IsNullOrEmpty())
                {

#line default
#line hidden
            BeginContext(631, 25, true);
            WriteLiteral("                    <ul>\n");
            EndContext();
#line 17 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                         foreach (var validationError in Model.ErrorInfo.ValidationErrors)
                        {

#line default
#line hidden
            BeginContext(773, 65, true);
            WriteLiteral("                            <li>\n                                ");
            EndContext();
            BeginContext(839, 23, false);
#line 20 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                           Write(validationError.Message);

#line default
#line hidden
            EndContext();
            BeginContext(862, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                                 if (validationError.Members != null && validationError.Members.Any())
                                {
                                    

#line default
#line hidden
            BeginContext(1042, 1, true);
            WriteLiteral("(");
            EndContext();
            BeginContext(1044, 42, false);
#line 23 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                                      Write(string.Join(", ", validationError.Members));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 1, true);
            WriteLiteral(")");
            EndContext();
#line 23 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                                                                                              
                                }

#line default
#line hidden
            BeginContext(1129, 34, true);
            WriteLiteral("                            </li>\n");
            EndContext();
#line 26 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                        }

#line default
#line hidden
            BeginContext(1189, 26, true);
            WriteLiteral("                    </ul>\n");
            EndContext();
#line 28 "D:\个人开发\MyProject\src\MyProject.Web.Mvc\Views\Shared\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(1233, 56, true);
            WriteLiteral("            </div>\n        </div>\n    </section>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Web.Mvc.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
