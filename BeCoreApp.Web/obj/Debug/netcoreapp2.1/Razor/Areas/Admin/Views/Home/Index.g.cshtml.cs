#pragma checksum "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b83674e2f25904b682701ff8350dccdff06e2b69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83674e2f25904b682701ff8350dccdff06e2b69", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeCoreApp.Application.ViewModels.System.NotifyViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Overview";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(125, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(310, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(328, 1024, true);
                WriteLiteral(@"
    <style>
        .card-title {
            width: 100%;
            text-align: center;
        }

        div#demo {
            font-size: 43px;
            font-weight: 800;
            font-family: 'Coda Caption', sans-serif !important;
            box-shadow: 0px 0px 35px #dcdcdc;
            border-radius: 10px;
            margin-top: 10px;
            margin-bottom: 10px;
            background: linear-gradient( 45deg, #ff0057, #3ac3d359);
            box-shadow: -10px 10px 13px #ad1457;
        }

            div#demo > .down-time {
                color: #ffffff;
                position: relative;
                margin-right: 8px;
            }

        span.down-time-unit {
            position: absolute;
            top: -5px;
            padding-left: 3px;
            color: black;
        }

        #NotifySale {
            font-weight: 900;
            color: #09d0ea;
            text-align: left;
            font-size: 24px;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(1355, 315, true);
            WriteLiteral(@"
<div class=""app-content icon-content"">
    <div class=""section"">
        <div class=""page-header"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-package mr-1""></i> Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(1671, 17, false);
#line 61 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 199, true);
            WriteLiteral("</li>\r\n            </ol>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12 col-lg-12\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n\r\n");
            EndContext();
#line 69 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
                         if (Model != null)
                        {

#line default
#line hidden
            BeginContext(1959, 89, true);
            WriteLiteral("                            <h2 class=\"mb-5 mt-5 font-weight-bold text-center text-dark\">");
            EndContext();
            BeginContext(2049, 10, false);
#line 71 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
                                                                                    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2059, 193, true);
            WriteLiteral("</h2>\r\n                            <div class=\"item-card9-desc mb-3 \">\r\n                                <a href=\"#\" class=\"mr-2\"><span class=\"\"><i class=\"fa fa-calendar-o text-muted mr-1\"></i> ");
            EndContext();
            BeginContext(2253, 41, false);
#line 73 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                    Write(Model.DateModified.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2294, 221, true);
            WriteLiteral("</span></a>\r\n                                <a href=\"#\"><span class=\"\"> <i class=\"fa fa-user\"></i> Admin</span></a>\r\n                            </div>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(2516, 27, false);
#line 77 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
                           Write(Html.Raw(Model.MildContent));

#line default
#line hidden
            EndContext();
            BeginContext(2543, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 79 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2665, 147, true);
            WriteLiteral("                            <h2 class=\"mb-5 mt-5 font-weight-bold text-center text-dark\" style=\"text-shadow: -3px 1px 2px #fe2c55;\">Updating</h2>\r\n");
            EndContext();
#line 83 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2839, 112, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeCoreApp.Application.ViewModels.System.NotifyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
