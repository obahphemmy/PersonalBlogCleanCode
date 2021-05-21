#pragma checksum "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Shared\_LoggedInUserPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b935e285756b71520287458612b90a11bc95feed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__LoggedInUserPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_LoggedInUserPartial.cshtml")]
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
#line 1 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Presentation.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Presentation.Web.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Presentation.Web.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.ApplicationCore.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.ApplicationCore.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b935e285756b71520287458612b90a11bc95feed", @"/Areas/Admin/Views/Shared/_LoggedInUserPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa48b64e526b074ebebff16601d2ffd24e87806", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__LoggedInUserPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Shared\_LoggedInUserPartial.cshtml"
   
    var user = await userManager.GetUserAsync(User);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ul class=""navbar-nav"">
    <li class=""navbar-item dropdown header-notification"">
        <a class=""navbar-nav-link dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
           aria-expanded=""false"">
            <i class=""far fa-bell""></i>
            <div class=""item-title d-md-none text-16 mg-l-10"">Notification</div>
            <span>8</span>
        </a>

        <div class=""dropdown-menu dropdown-menu-right"">
            <div class=""item-header"">
                <h6 class=""item-title"">03 Notifiacations</h6>
            </div>
            <div class=""item-content"">
                <div class=""media"">
                    <div class=""item-icon bg-skyblue"">
                        <i class=""fas fa-check""></i>
                    </div>
                    <div class=""media-body space-sm"">
                        <div class=""post-title"">Complete Today Task</div>
                        <span>1 Mins ago</span>
                    </div>
                </div>
             ");
            WriteLiteral(@"   <div class=""media"">
                    <div class=""item-icon bg-orange"">
                        <i class=""fas fa-calendar-alt""></i>
                    </div>
                    <div class=""media-body space-sm"">
                        <div class=""post-title"">Director Metting</div>
                        <span>20 Mins ago</span>
                    </div>
                </div>
                <div class=""media"">
                    <div class=""item-icon bg-violet-blue"">
                        <i class=""fas fa-cogs""></i>
                    </div>
                    <div class=""media-body space-sm"">
                        <div class=""post-title"">Update Password</div>
                        <span>45 Mins ago</span>
                    </div>
                </div>
            </div>
        </div>
    </li>
    <li class=""navbar-item dropdown header-admin"">
        <a class=""navbar-nav-link dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
           aria-expanded");
            WriteLiteral("=\"false\">\r\n            <div class=\"admin-title\">\r\n                <h5 class=\"item-title\">");
#nullable restore
#line 54 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Shared\_LoggedInUserPartial.cshtml"
                                  Write(user.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Shared\_LoggedInUserPartial.cshtml"
                                                  Write(user.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <span>Admin</span>\r\n            </div>\r\n            <div class=\"admin-img\"");
            BeginWriteAttribute("style", " style=\"", 2376, "\"", 2525, 9);
            WriteAttributeValue("", 2384, "background-image:url(", 2384, 21, true);
#nullable restore
#line 57 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Shared\_LoggedInUserPartial.cshtml"
WriteAttributeValue("", 2405, user.ProfilePhotoUrl, 2405, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2426, ");", 2426, 2, true);
            WriteAttributeValue(" ", 2428, "background-position:center;", 2429, 28, true);
            WriteAttributeValue(" ", 2456, "background-size:", 2457, 17, true);
            WriteAttributeValue(" ", 2473, "cover;", 2474, 7, true);
            WriteAttributeValue(" ", 2480, "width:40px;", 2481, 12, true);
            WriteAttributeValue(" ", 2492, "height:40px;", 2493, 13, true);
            WriteAttributeValue(" ", 2505, "border-radius:100px", 2506, 20, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            </div>\r\n        </a>\r\n        <div class=\"dropdown-menu dropdown-menu-right\">\r\n            <div class=\"item-header\">\r\n                <h6 class=\"item-title\">");
#nullable restore
#line 63 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Shared\_LoggedInUserPartial.cshtml"
                                  Write(user.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Shared\_LoggedInUserPartial.cshtml"
                                                  Write(user.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
            </div>
            <div class=""item-content"">
                <ul class=""settings-list"">
                    <li><a href=""#""><i class=""flaticon-user""></i>My Profile</a></li>
                    <li><a href=""#""><i class=""flaticon-list""></i>Task</a></li>
                    <li><a href=""#""><i class=""flaticon-chat-comment-oval-speech-bubble-with-text-lines""></i>Message</a></li>
                    <li><a href=""#""><i class=""flaticon-gear-loading""></i>Account Settings</a></li>
                    <li><a href=""/admin/account/logout""><i class=""flaticon-turn-off""></i>Log Out</a></li>
                </ul>
            </div>
        </div>
    </li>
</ul>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
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
