#pragma checksum "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576486f6d064ca63bf384f3db729933c323f5a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__ExternalLoginsListPartial), @"mvc.1.0.view", @"/Views/Account/_ExternalLoginsListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/_ExternalLoginsListPartial.cshtml", typeof(AspNetCore.Views_Account__ExternalLoginsListPartial))]
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
#line 1 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore;

#line default
#line hidden
#line 2 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore.Models;

#line default
#line hidden
#line 3 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576486f6d064ca63bf384f3db729933c323f5a45", @"/Views/Account/_ExternalLoginsListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ba4a9a887ba63883abe820b8b9fdd9e64e99964", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__ExternalLoginsListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExternalLoginListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(133, 49, true);
            WriteLiteral("<h4>Use another service to log in.</h4>\r\n<hr />\r\n");
            EndContext();
#line 6 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
  
    var schemes = await SchemeProvider.GetAllSchemesAsync();
    var loginProviders = schemes.ToList();
    if (!loginProviders.Any())
    {

#line default
#line hidden
            BeginContext(331, 331, true);
            WriteLiteral(@"        <div>
            <p>
                There are no external authentication services configured. See <a href=""http://go.microsoft.com/fwlink/?LinkId=313242"">this article</a>
                for details on setting up this ASP.NET application to support logging in via external services.
            </p>
        </div>
");
            EndContext();
#line 17 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(686, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(694, 546, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f67d8997d034482a021bc1e098c4a7d", async() => {
                BeginContext(843, 63, true);
                WriteLiteral("\r\n            <div id=\"socialLoginList\">\r\n                <p>\r\n");
                EndContext();
#line 23 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
                     foreach (var p in loginProviders)
                    {

#line default
#line hidden
                BeginContext(985, 69, true);
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1054, "\"", 1066, 1);
#line 25 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
WriteAttributeValue("", 1059, p.Name, 1059, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1067, 16, true);
                WriteLiteral(" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1083, "\"", 1098, 1);
#line 25 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
WriteAttributeValue("", 1091, p.Name, 1091, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1099, "\"", 1140, 6);
                WriteAttributeValue("", 1107, "Log", 1107, 3, true);
                WriteAttributeValue(" ", 1110, "in", 1111, 3, true);
                WriteAttributeValue(" ", 1113, "using", 1114, 6, true);
                WriteAttributeValue(" ", 1119, "your", 1120, 5, true);
#line 25 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
WriteAttributeValue(" ", 1124, p.Name, 1125, 7, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1132, "account", 1133, 8, true);
                EndWriteAttribute();
                BeginContext(1141, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1143, 6, false);
#line 25 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
                                                                                                                                                        Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1149, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 26 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
                    }

#line default
#line hidden
                BeginContext(1183, 50, true);
                WriteLiteral("                </p>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
                                                                           WriteLiteral(ViewBag.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1240, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Account\_ExternalLoginsListPartial.cshtml"
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthenticationSchemeProvider SchemeProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
