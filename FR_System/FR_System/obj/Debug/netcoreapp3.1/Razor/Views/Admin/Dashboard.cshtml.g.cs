#pragma checksum "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16066a00981d36430c1292e6fea1ec264da830c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dashboard), @"mvc.1.0.view", @"/Views/Admin/Dashboard.cshtml")]
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
#nullable restore
#line 1 "E:\proj\FR_Team50\FR_System\FR_System\Views\_ViewImports.cshtml"
using FR_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\proj\FR_Team50\FR_System\FR_System\Views\_ViewImports.cshtml"
using FR_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Dashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16066a00981d36430c1292e6fea1ec264da830c8", @"/Views/Admin/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9eb7095bd7e9c801be11298e89ddeb35f09fd4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FR_System.Models.Admin>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"sticky-header header-section \">\r\n\t\t\t\r\n\t\t\t\t<div class=\"header-right\">\r\n\t\t\t\t<div class=\"profile_details\">\t\t\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li class=\"dropdown profile_details_drop\">\r\n\r\n\t\t\t\t\t\t\t\t\t<div class=\"user-name\">\r\n\t\t\t\t\t\t\t\t\t\t<p>Admin ID:");
#nullable restore
#line 16 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Dashboard.cshtml"
                                               Write(Model.AdminId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t<p>Admin Name:");
#nullable restore
#line 17 "E:\proj\FR_Team50\FR_System\FR_System\Views\Admin\Dashboard.cshtml"
                                                 Write(Model.AdminName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
									</div>
									<div class=""clearfix""></div>	
						</li>
					</ul>
				</div>
				<div class=""clearfix""> </div>				
			</div>
			<div class=""clearfix""> </div>	
</div>
		<!-- //header-ends -->
		<!-- main content start-->
		<div id=""page-wrapper"" style=""padding:5em 2em 2.5em"">
			<div class=""main-page"">
				<h2 class=""title1"">Welcome to Admin Dasboard</h2>
				<div class=""blank-page widget-shadow scroll"" id=""style-2 div1"">
					<ul>
						<li>You can add,delete,modify and see details of plane</li>
						<li>You can add,delete,modify and see details of flights</li>
						<li>View user details</li>
					</ul>
				</div>
			</div>
		</div>
   



");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FR_System.Models.Admin> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
