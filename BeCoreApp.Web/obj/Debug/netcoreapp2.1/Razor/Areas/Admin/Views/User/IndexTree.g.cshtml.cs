#pragma checksum "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\User\IndexTree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16332776468f538d34a4433940a76d5be77cb0ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_IndexTree), @"mvc.1.0.view", @"/Areas/Admin/Views/User/IndexTree.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/IndexTree.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_IndexTree))]
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
#line 1 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp;

#line default
#line hidden
#line 3 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models;

#line default
#line hidden
#line 4 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 6 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.System;

#line default
#line hidden
#line 7 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.BlockChain;

#line default
#line hidden
#line 8 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.Valuesshare;

#line default
#line hidden
#line 9 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Data.Entities;

#line default
#line hidden
#line 1 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\User\IndexTree.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 2 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\User\IndexTree.cshtml"
using BeCoreApp.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16332776468f538d34a4433940a76d5be77cb0ae", @"/Areas/Admin/Views/User/IndexTree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_IndexTree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jQuery-EasyUI/jquery.easyui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/user/indextree.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jQuery-EasyUI/themes/bootstrap/easyui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jQuery-EasyUI/themes/icon.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\User\IndexTree.cshtml"
  
    ViewData["Title"] = "Th??nh Vi??n";

#line default
#line hidden
            BeginContext(173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(192, 272, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jstree/3.2.1/jstree.min.js""></script>
    <script src=""https://code.jquery.com/ui/1.11.4/jquery-ui.js""></script>
    <script src=""https://rawgit.com/adamjimenez/jstree-table/master/jstreetable.js""></script>
    ");
                EndContext();
                BeginContext(464, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee7c8f1a216b47f9951f36dda836d88a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(528, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(536, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fcddadfd285414a9a201e3916c5781e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 14 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\User\IndexTree.cshtml"
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
                BeginContext(627, 131, true);
                WriteLiteral("\r\n    <script>\r\n        var customerTreeObj = new CustomerTreeController();\r\n        customerTreeObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(761, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(779, 125, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/jstree/3.2.1/themes/default/style.min.css\" />\r\n    ");
                EndContext();
                BeginContext(904, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a136282442a4f0b8eda9f3a117b2624", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(984, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(990, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bdf13e54f05649299756c462d85befcf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1058, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1063, 357, true);
            WriteLiteral(@"
<div class=""app-content icon-content"">
    <div class=""section"">
        <!-- Page-header opened -->
        <div class=""page-header"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-package mr-1""></i> Trang Ch???</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(1421, 17, false);
#line 33 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\User\IndexTree.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1438, 908, true);
            WriteLiteral(@"</li>
            </ol>
        </div>
        <!-- Page-header closed -->
        <!-- row opened -->
        <div class=""row"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""table-responsive product-datatable"">
                            <div id=""example_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12"" style=""margin-top:15px;"">
                                        <div id=""jstree""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
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
