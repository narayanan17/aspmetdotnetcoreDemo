#pragma checksum "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d33a2c2864c9bf2a1233926c3d85cb1c50590c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Details), @"mvc.1.0.view", @"/Views/Store/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Details.cshtml", typeof(AspNetCore.Views_Store_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d33a2c2864c9bf2a1233926c3d85cb1c50590c", @"/Views/Store/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ba4a9a887ba63883abe820b8b9fdd9e64e99964", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Album>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
  
    ViewBag.Title = "Album - " + Model.Title;

#line default
#line hidden
            BeginContext(70, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(77, 11, false);
#line 7 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(88, 22, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 110, "\"", 128, 1);
#line 10 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
WriteAttributeValue("", 116, Model.Title, 116, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 129, "\"", 167, 1);
#line 10 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
WriteAttributeValue("", 135, Url.Content(@Model.AlbumArtUrl), 135, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(168, 81, true);
            WriteLiteral(" />\r\n</p>\r\n\r\n<div id=\"album-details\">\r\n    <p>\r\n        <em>Genre:</em>\r\n        ");
            EndContext();
            BeginContext(250, 16, false);
#line 16 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
   Write(Model.Genre.Name);

#line default
#line hidden
            EndContext();
            BeginContext(266, 55, true);
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <em>Artist:</em>\r\n        ");
            EndContext();
            BeginContext(322, 17, false);
#line 20 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
   Write(Model.Artist.Name);

#line default
#line hidden
            EndContext();
            BeginContext(339, 61, true);
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <em>Price:</em>\r\n        <label>");
            EndContext();
            BeginContext(401, 11, false);
#line 24 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(412, 52, true);
            WriteLiteral("</label>\r\n    </p>\r\n    <p class=\"button\">\r\n        ");
            EndContext();
            BeginContext(464, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ead6c8710a744ee6b9cce0fa04113d3f", async() => {
                BeginContext(550, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Store\Details.cshtml"
                                                                  WriteLiteral(Model.AlbumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(565, 18, true);
            WriteLiteral("\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Album> Html { get; private set; }
    }
}
#pragma warning restore 1591
