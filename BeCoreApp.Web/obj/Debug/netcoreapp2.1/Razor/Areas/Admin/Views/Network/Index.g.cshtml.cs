#pragma checksum "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ee19e8f54e4113b8d62f961b423dd780a6fb92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Network_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Network/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Network/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Network_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ee19e8f54e4113b8d62f961b423dd780a6fb92", @"/Areas/Admin/Views/Network/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Network_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetworkViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/network/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/network/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml"
  
    ViewData["Title"] = "Affiliate";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(87, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(93, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd50daa9315341bdb9a983a03d494c8c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml"
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
                BeginContext(183, 116, true);
                WriteLiteral("\r\n    <script>\r\n        var networkObj = new NetworkController();\r\n        networkObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(320, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(326, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a68e77b416845e29d30044a2f90f298", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 14 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(426, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(431, 335, true);
            WriteLiteral(@"
<div class=""app-content icon-content"">
    <div class=""section business-management"">
        <div class=""page-header"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-package mr-1""></i> Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(767, 17, false);
#line 22 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(784, 637, true);
            WriteLiteral(@"</li>
            </ol>
            <div class=""mt-3 mt-lg-0""></div>
        </div>
        <!-- row opened -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card overflow-hidden"">
                    <div class=""card-body"">
                        <div class=""mt-lg-0 d-xl-block mb-5"">
                            <div class=""input-group"">
                                <span class=""mb-0 font-weight-semibold h6"" style=""padding-top:15px;padding-right:3px;"">Referral Link: </span>
                                <input type=""text"" readonly class=""form-control"" id=""txtReferlink""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1421, "\"", 1447, 1);
#line 34 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml"
WriteAttributeValue("", 1429, Model.ReferalLink, 1429, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1448, 786, true);
            WriteLiteral(@">
                                <span class=""input-group-append"">
                                    <button class=""btn btn-green-ct"" id=""btnCopyReferlink"" type=""button"">
                                        <i class=""fa fa-copy""></i>
                                    </button>
                                </span>
                            </div>
                        </div>
                        <div class=""myTab"">
                            <ul class=""nav  nav-tabs m-0"" id=""myTab"" role=""tablist"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active show nav-link-network"" data-id=""1"" id=""home-tab"" data-toggle=""tab"" href=""#f1"" role=""tab"" aria-controls=""home"" aria-selected=""false"">F1 - ");
            EndContext();
            BeginContext(2235, 13, false);
#line 45 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml"
                                                                                                                                                                                                  Write(Model.TotalF1);

#line default
#line hidden
            EndContext();
            BeginContext(2248, 45, true);
            WriteLiteral("</a>\r\n                                </li>\r\n");
            EndContext();
            BeginContext(2910, 1769, true);
            WriteLiteral(@"                            </ul>
                            <div class=""tab-content  p-3 border"" id=""myTabContent"">

                                <div class=""tab-pane fade p-0 active show"" id=""f1"" role=""tabpanel"" aria-labelledby=""home-tab"">
                                    <div class=""table-responsive product-datatable"">
                                        <div id=""example_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
                                            <div class=""row"">
                                                <div class=""col-sm-12"">
                                                    <table id=""example"" class=""table table-striped table-bordered dataTable no-footer"" role=""grid"" aria-describedby=""example_info"">
                                                        <thead>
                                                            <tr>
                                                                <th>FullName</th>
                                      ");
            WriteLiteral(@"                          <th>Email</th>
                                                                <th>Verify Email</th>
                                                                <th>Created Date</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody id=""tbl-content-1""></tbody>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

");
            EndContext();
            BeginContext(7958, 149, true);
            WriteLiteral("\r\n                                <div id=\"example_wrapper\" class=\"dataTables_wrapper dt-bootstrap4 no-footer\">\r\n                                    ");
            EndContext();
            BeginContext(8108, 37, false);
#line 123 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Network\Index.cshtml"
                               Write(await Component.InvokeAsync("Paging"));

#line default
#line hidden
            EndContext();
            BeginContext(8145, 466, true);
            WriteLiteral(@"
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- row closed -->
    </div>
</div>
<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <td>{{FullName}}</td>
        <td>{{Email}}</td>
        <td>{{{EmailConfirmed}}}</td>
        <td>{{{DateCreated}}}</td>
    </tr>
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetworkViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
