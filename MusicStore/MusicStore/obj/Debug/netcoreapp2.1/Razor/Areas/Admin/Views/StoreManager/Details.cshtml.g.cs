#pragma checksum "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a7e15cd34442f3ce67f61e651ffa8a00578993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_StoreManager_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/StoreManager/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/StoreManager/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_StoreManager_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a7e15cd34442f3ce67f61e651ffa8a00578993", @"/Areas/Admin/Views/StoreManager/Details.cshtml")]
    public class Areas_Admin_Views_StoreManager_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicStore.Models.Album>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(73, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Album</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(193, 47, false);
#line 14 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Artist.Name));

#line default
#line hidden
            EndContext();
            BeginContext(240, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 43, false);
#line 18 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Artist.Name));

#line default
#line hidden
            EndContext();
            BeginContext(329, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 46, false);
#line 22 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre.Name));

#line default
#line hidden
            EndContext();
            BeginContext(421, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 42, false);
#line 26 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre.Name));

#line default
#line hidden
            EndContext();
            BeginContext(509, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(555, 41, false);
#line 30 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(596, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(642, 37, false);
#line 34 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(679, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(725, 41, false);
#line 38 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(766, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(812, 37, false);
#line 42 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(849, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(895, 47, false);
#line 46 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(942, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(988, 43, false);
#line 50 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1079, 59, false);
#line 56 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.AlbumId }));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1147, 40, false);
#line 57 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Areas\Admin\Views\StoreManager\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicStore.Models.Album> Html { get; private set; }
    }
}
#pragma warning restore 1591
