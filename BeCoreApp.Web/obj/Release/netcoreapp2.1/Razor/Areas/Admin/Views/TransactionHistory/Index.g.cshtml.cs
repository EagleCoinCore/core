#pragma checksum "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\TransactionHistory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30a7a88d4dda0805d95defd19241dfae7d1a67d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TransactionHistory_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TransactionHistory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/TransactionHistory/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_TransactionHistory_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30a7a88d4dda0805d95defd19241dfae7d1a67d", @"/Areas/Admin/Views/TransactionHistory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TransactionHistory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/transaction-history/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/transaction-history/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\TransactionHistory\Index.cshtml"
  
    ViewData["Title"] = "Transfer History";

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(68, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(74, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6320e84bc3964d79b5360913451c496e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 5 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\TransactionHistory\Index.cshtml"
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
                BeginContext(186, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(208, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(214, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7163d1d6b2f44825bd22f33fda801b16", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(290, 149, true);
                WriteLiteral("\r\n    <script>\r\n        var transactionHistoryObj = new TransactionHistoryController();\r\n        transactionHistoryObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(442, 350, true);
            WriteLiteral(@"<div class=""app-content icon-content"">
    <div class=""section"">
        <!-- Page-header opened -->
        <div class=""page-header"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-package mr-1""></i> Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(793, 17, false);
#line 20 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\TransactionHistory\Index.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(810, 3227, true);
            WriteLiteral(@"</li>
            </ol>
            <div class=""mt-3 mt-lg-0"">
            </div>
        </div>
        <!-- Page-header closed -->
        <!-- row opened -->
        <div class=""row"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div class=""card-title"">Transfer history</div>
                        <div class=""card-options"">
                            <a href=""#"" class=""card-options-collapse"" data-toggle=""card-collapse""><i class=""fe fe-chevron-up""></i></a>
                            <a href=""#"" class=""card-options-fullscreen"" data-toggle=""card-fullscreen""><i class=""fe fe-maximize""></i></a>
                            <a href=""#"" class=""card-options-remove"" data-toggle=""card-remove""><i class=""fe fe-x""></i></a>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive product-datatable"">");
            WriteLiteral(@"
                            <div id=""example_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12 col-md-8"">
                                        <div id=""example_filter"" class=""dataTables_filter"">
                                            <label>Search:<input type=""search"" id=""txt-search-keyword"" class=""form-control form-control-sm"" placeholder="""" aria-controls=""example""></label>
                                        </div>
                                    </div>
                                    <div class=""col-sm-12 col-md-4"">
                                        <div class=""dataTables_component"">
                                            <button id=""btn-create"" type=""button"" class=""btn btn-sm btn-success "" data-toggle=""modal"" data-target="".bd-example-modal-lg""><i class=""fa fa-plus""></i> Create Verify</button>
                                        </div>
       ");
            WriteLiteral(@"                             </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <table id=""example"" class=""table table-striped table-bordered dataTable no-footer"" role=""grid"" aria-describedby=""example_info"">
                                            <thead>
                                                <tr>
                                                    <th>Image</th>
                                                    <th>Amount (billion billion)</th>
                                                    <th>Type</th>
                                                    <th>Created Date</th>
                                                    <th>#</th>
                                                </tr>
                                            </thead>
                                            <tbody id=""tbl-content""></tbody>
           ");
            WriteLiteral("                             </table>\r\n                                    </div>\r\n                                </div>\r\n                                ");
            EndContext();
            BeginContext(4038, 37, false);
#line 69 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\TransactionHistory\Index.cshtml"
                           Write(await Component.InvokeAsync("Paging"));

#line default
#line hidden
            EndContext();
            BeginContext(4075, 607, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <td>{{{Image}}}</td>
        <td>{{Amount}}BB</td>
        <td>{{{Type}}}</td>
        <td>{{CreatedDate}}</td>
        <td>
            <a href=""#"" data-id=""{{Id}}"" class=""btn-view btn btn-warning btn-sm mb-2 mb-xl-0 text-white"" data-toggle=""tooltip"" data-original-title=""Cập Nhật""><i class=""fa fa-eye""></i></a>
        </td>
    </tr>
</script>
");
            EndContext();
            BeginContext(4683, 29, false);
#line 90 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\TransactionHistory\Index.cshtml"
Write(Html.Partial("_AddEditModal"));

#line default
#line hidden
            EndContext();
            BeginContext(4712, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4715, 26, false);
#line 91 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\TransactionHistory\Index.cshtml"
Write(Html.Partial("_ViewModal"));

#line default
#line hidden
            EndContext();
            BeginContext(4741, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
