#pragma checksum "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Feedback\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da89fdac50170f3221af3cc8977d13f5e730328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Feedback_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Feedback/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Feedback/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Feedback_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da89fdac50170f3221af3cc8977d13f5e730328", @"/Areas/Admin/Views/Feedback/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Feedback_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/feedback/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/feedback/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Feedback\Index.cshtml"
  
    ViewData["Title"] = "Yêu cầu";

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(59, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(65, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d37eee41850b47abb74d57ddd27f77cc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 5 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Feedback\Index.cshtml"
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
                BeginContext(166, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(188, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(194, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7e7f8a99b7d40e2ad44621005644057", async() => {
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
                BeginContext(259, 119, true);
                WriteLiteral("\r\n    <script>\r\n        var feedbackObj = new FeedbackController();\r\n        feedbackObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(381, 357, true);
            WriteLiteral(@"
<div class=""app-content icon-content"">
    <div class=""section"">
        <!-- Page-header opened -->
        <div class=""page-header"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-package mr-1""></i> Trang Chủ</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(739, 17, false);
#line 21 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Feedback\Index.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(756, 3591, true);
            WriteLiteral(@"</li>
            </ol>
            <div class=""mt-3 mt-lg-0"">
                <div class=""d-flex align-items-center flex-wrap text-nowrap"">
                    <button type=""button"" class=""btn btn-success btn-icon-text mr-2 mb-2 mb-md-0""><i class=""fe fe-download""></i>Import</button>
                    <button type=""button"" class=""btn btn-secondary btn-icon-text mr-2 mb-2 mb-md-0""><i class=""fe fe-printer""></i>Print</button>
                    <button type=""button"" class=""btn btn-primary btn-icon-text mb-2 mb-md-0""><i class=""fe fe-download-cloud ""></i>Download</button>
                </div>
            </div>
        </div>
        <!-- Page-header closed -->
        <!-- row opened -->
        <div class=""row"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div class=""card-title"">Danh Sách Bài Viết</div>
                        <div class=""card-options"">
                            <a ");
            WriteLiteral(@"href=""#"" class=""card-options-collapse"" data-toggle=""card-collapse""><i class=""fe fe-chevron-up""></i></a>
                            <a href=""#"" class=""card-options-fullscreen"" data-toggle=""card-fullscreen""><i class=""fe fe-maximize""></i></a>
                            <a href=""#"" class=""card-options-remove"" data-toggle=""card-remove""><i class=""fe fe-x""></i></a>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive product-datatable"">
                            <div id=""example_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12 col-md-8"">
                                        <div id=""example_filter"" class=""dataTables_filter"">
                                            <label>Tìm Kiếm:<input type=""search"" id=""txt-search-keyword"" class=""form-control form-control-sm"" placeholder="""" a");
            WriteLiteral(@"ria-controls=""example""></label>
                                        </div>
                                    </div>
                                    <div class=""col-sm-12 col-md-4""></div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <table id=""example"" class=""table table-striped table-bordered dataTable no-footer"" role=""grid"" aria-describedby=""example_info"">
                                            <thead>
                                                <tr>
                                                    <th>Tiêu Đề</th>
                                                    <th>Họ Tên</th>
                                                    <th>Phone</th>
                                                    <th>Email</th>
                                                    <th>Trạng Thái</th>
                                               ");
            WriteLiteral(@"     <th>Người CN</th>
                                                    <th>Ngày CN</th>
                                                    <th>Chức Năng</th>
                                                </tr>
                                            </thead>
                                            <tbody id=""tbl-content""></tbody>
                                        </table>
                                    </div>
                                </div>
                                ");
            EndContext();
            BeginContext(4348, 37, false);
#line 74 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Feedback\Index.cshtml"
                           Write(await Component.InvokeAsync("Paging"));

#line default
#line hidden
            EndContext();
            BeginContext(4385, 1063, true);
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
        <td>{{Title}}</td>
        <td>{{{FullName}}}</td>
        <td>{{Phone}}</td>
        <td>{{Email}}</td>
        <td width=""90"">{{{Type}}}</td>
        <td width=""80"">{{ModifiedBy}}</td>
        <td width=""100"">{{ModifiedDate}}</td>
        <td width=""120"">
            <a href=""#"" data-id=""{{Id}}"" class=""btn-edit btn btn-info btn-sm mb-2 mb-xl-0 text-white""><i class=""fa fa-eye""></i></a>
            <a href=""#"" data-id=""{{Id}}"" class=""btn-change-type btn btn-primary btn-sm mb-2 mb-xl-0 text-white"" data-toggle=""tooltip"" data-original-title=""Xem""><i class=""fa fa-edit""></i></a>
            <a href=""#"" data-id=""{{Id}}"" class=""btn-delete btn btn-danger btn-sm mb-xl-0 text-white"" data-toggle=""tooltip"" data-original-title=""Xóa""><i class=""fa fa-trash-o""></i></a>");
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</script>\r\n");
            EndContext();
            BeginContext(5449, 29, false);
#line 100 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Feedback\Index.cshtml"
Write(Html.Partial("_AddEditModal"));

#line default
#line hidden
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