#pragma checksum "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "056d923e7fd80ad6de4948f6805651db267d90cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Wallet_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Wallet/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Wallet/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Wallet_Index))]
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
#line 2 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
using BeCoreApp.Utilities.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056d923e7fd80ad6de4948f6805651db267d90cc", @"/Areas/Admin/Views/Wallet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Wallet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalletViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery-qrcode-master/src/jquery.qrcode.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery-qrcode-master/src/qrcode.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/wallet/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/wallet/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-7 h-7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/tronlogonew.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/usdt-logo-300.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
  
    ViewData["Title"] = "Wallet";


#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(123, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(129, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2cf1fde36b45549575bead2a43d8f3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
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
                BeginContext(226, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(232, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50477a9f217477d99e3bfed2c13bfc1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 9 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
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
                BeginContext(322, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(328, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411b7878e3df41d89a3857b0b9f0e855", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 10 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
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
                BeginContext(417, 113, true);
                WriteLiteral("\r\n    <script>\r\n        var walletObj = new WalletController();\r\n        walletObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(551, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(557, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04cd6aef9ee7407981aa4dc2c52ff032", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 18 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
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
                BeginContext(656, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(661, 317, true);
            WriteLiteral(@"
<div class=""app-content icon-content"">
    <div class=""section"">

        <div class=""page-header"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-package mr-1""></i> Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(979, 17, false);
#line 27 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(996, 757, true);
            WriteLiteral(@"</li>
            </ol>
        </div>

        <div class=""row"">
            <div class=""col-xl-4 col-lg-4 col-md-12 col-xl-4 offset-xl-2 offset-lg-2"">
                <div class=""col-sm-12 col-md-12 col-lg-12 col-xl-12"">
                    <div class=""card res-tabs responsible-tabs"">
                        <div class=""card-body"">
                            <div class=""d-flex no-block align-items-center"">
                                <div>
                                    <h5 class=""text-dark"">Wallet TRX</h5>
                                    <h5 class=""m-0 numberFormat walletTrxDeposit""></h5>
                                </div>
                                <div class=""ml-auto"">
                                    ");
            EndContext();
            BeginContext(1753, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f34f5e6e735c42c89ff8966176d44704", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1805, 1198, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""card-body p-0"">
                            <div class=""tab-menu-heading border-top-0 border-left-0 border-right-0 pt-0 pl-0 pr-0"">
                                <div class=""tabs-menu1"">
                                    <ul class=""nav"">
                                        <li><a href=""#tab-trx-1"" class=""active"" data-toggle=""tab"">TRX Deposit</a></li>
                                        <li><a href=""#tab-trx-2"" data-toggle=""tab"">TRX Withdraw</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""tab-content"">
                                <div class=""tab-pane active"" id=""tab-trx-1"">
                                    <div class=""col-lg-12 col-md-12 p-3"">
                                        <label class=""mt-2"">Wallet Address TRX<");
            WriteLiteral("/label>\r\n                                        <div class=\"input-group mb-3\">\r\n                                            <input type=\"text\" class=\"form-control pt-5 pb-5\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3003, "\"", 3031, 1);
#line 60 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
WriteAttributeValue("", 3011, Model.TRXPublishKey, 3011, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3032, 957, true);
            WriteLiteral(@" id=""txtTRXPublishKey"">
                                            <span class=""input-group-addon-right bg-light"" id=""btnCopyTRXPublishKey""><i class=""fa fa-clipboard fs-21""></i></span>
                                        </div>
                                        <p class=""fs-16 mb-1 mt-2""><strong>Scan QR Code</strong></p>
                                        <div class=""row bg-white"">
                                            <div class=""col-12 col-xl-12 col-lg-12 col-md-12 col-sm-12 mt-1"">
                                                <div style=""text-align:center;padding-bottom:20px;"" class=""qr-code"" id=""qrcodeTRXPublishKey""></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""tab-pane"" id=""tab-trx-2"">
                                    ");
            EndContext();
            BeginContext(3989, 1741, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a82fb1a1e43d44ec94a91f774dd593fe", async() => {
                BeginContext(3995, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4038, 23, false);
#line 73 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(4061, 1662, true);
                WriteLiteral(@"
                                        <div class=""col-lg-12 col-md-12 p-3"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"">Wallet TRX Balance</label>
                                                <input type=""text"" readonly class=""form-control numberFormat"" id=""trxBalance"" value=""0"">
                                            </div>

                                            <div class=""form-group"">
                                                <label class=""form-control-label"">TRX Amount</label>
                                                <input type=""text"" class=""form-control numberFormat"" value=""0"" id=""txtAmount"">
                                            </div>
                                            <div class=""form-group"">
                                                <label class=""form-control-label"">Address Receiving</label>
                                        ");
                WriteLiteral(@"        <input type=""text"" class=""form-control"" id=""txtAddressReceiving"">
                                            </div>
                                            <div class=""text-center"">
                                                <button class=""btn btn-green-ct mt-4"" type=""button""
                                                        id=""btnWithdrawTRX"">
                                                    Withdraw Now
                                                </button>
                                            </div>
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5730, 859, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-4 col-lg-4 col-md-12 col-xl-4"">
                <div class=""col-sm-12 col-md-12 col-lg-12 col-xl-12"">
                    <div class=""card res-tabs responsible-tabs"">
                        <div class=""card-body"">
                            <div class=""d-flex no-block align-items-center"">
                                <div>
                                    <h5 class=""text-dark"">Wallet Tether TRC20</h5>
                                    <h5 class=""m-0 numberFormat walletUsdtTrc20Deposit""></h5>
                                </div>
                                <div class=""ml-auto"">
                                    ");
            EndContext();
            BeginContext(6589, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "78929aa37698433a97d3ccd4f0f0e5ec", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6643, 1228, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""card-body p-0"">
                            <div class=""tab-menu-heading border-top-0 border-left-0 border-right-0 pt-0 pl-0 pr-0"">
                                <div class=""tabs-menu1"">
                                    <ul class=""nav"">
                                        <li><a href=""#tab-usdt-1"" class=""active"" data-toggle=""tab"">Tether TRC20 Deposit</a></li>
                                        <li><a href=""#tab-usdt-2"" data-toggle=""tab"">Tether TRC20 Withdraw</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""tab-content"">
                                <div class=""tab-pane active"" id=""tab-usdt-1"">
                                    <div class=""col-lg-12 col-md-12 p-3"">
                                        <label class=""mt-2");
            WriteLiteral("\">Wallet Address Tether TRC20</label>\r\n                                        <div class=\"input-group mb-3\">\r\n                                            <input type=\"text\" class=\"form-control pt-5 pb-5\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7871, "\"", 7905, 1);
#line 130 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
WriteAttributeValue("", 7879, Model.USDTTRC20PublishKey, 7879, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7906, 976, true);
            WriteLiteral(@" id=""txtUSDTTRC20PublishKey"">
                                            <span class=""input-group-addon-right bg-light"" id=""btnCopyUSDTTRC20PublishKey""><i class=""fa fa-clipboard fs-21""></i></span>
                                        </div>
                                        <p class=""fs-16 mb-1 mt-2""><strong>Scan QR Code</strong></p>
                                        <div class=""row bg-white"">
                                            <div class=""col-12 col-xl-12 col-lg-12 col-md-12 col-sm-12 mt-1"">
                                                <div style=""text-align:center;padding-bottom:20px;"" class=""qr-code"" id=""qrcodeUSDTTRC20PublishKey""></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""tab-pane"" id=""tab-usdt-2"">
                                    ");
            EndContext();
            BeginContext(8882, 1624, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e850e4fb36940b593dddf9e39d0807e", async() => {
                BeginContext(8888, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(8931, 23, false);
#line 143 "C:\TongHop\Others\EagleCoin\BeCoreApp.Web\Areas\Admin\Views\Wallet\Index.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(8954, 1545, true);
                WriteLiteral(@"
                                        <div class=""col-lg-12 col-md-12 p-3"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"">Wallet USDT TRC20 Balance</label>
                                                <input type=""text"" readonly class=""form-control numberFormat"" id=""usdttrc20Balance"" value=""0"">
                                            </div>

                                            <div class=""form-group"">
                                                <label class=""form-control-label"">USDT TRC20 Amount</label>
                                                <input type=""text"" class=""form-control numberFormat"" value=""0"" id=""txtAmountUSDTTRC20"">
                                            </div>
                                            <div class=""form-group"">
                                                <label class=""form-control-label"">Address Receiving</label>
           ");
                WriteLiteral(@"                                     <input type=""text"" class=""form-control"" id=""txtAddressReceivingUSDTTRC20"">
                                            </div>
                                            <div class=""text-center"">
                                                <button class=""btn btn-green-ct mt-4"" type=""button"" id=""btnWithdrawUSDTTRC20"">Withdraw Now</button>
                                            </div>
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10506, 296, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<style>
    .numberFormat {
        font-weight: bold
    }
</style>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalletViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591