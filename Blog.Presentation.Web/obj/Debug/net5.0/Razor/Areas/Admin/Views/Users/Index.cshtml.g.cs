#pragma checksum "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5459f31d81b7a53ed2ed35ed85972b18f8ed93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b5459f31d81b7a53ed2ed35ed85972b18f8ed93", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa48b64e526b074ebebff16601d2ffd24e87806", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mg-b-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dashboard-content-one"">
    <!-- Breadcubs Area Start Here -->
    <div class=""breadcrumbs-area"">
        <h3>Users</h3>
        <ul>
            <li>
                <a href=""/admin/dashboard"">Dashboard</a>
            </li>
            <li>All Users</li>
        </ul>
    </div>
    <!-- Breadcubs Area End Here -->
    <!-- Teacher Table Area Start Here -->
    <div class=""card height-auto"">
        <div class=""card-body"">
            <div class=""heading-layout1"">
                <div class=""item-title"">
                    <h3>All Users Data</h3>
                </div>
                
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b5459f31d81b7a53ed2ed35ed85972b18f8ed935759", async() => {
                WriteLiteral(@"
                <div class=""row gutters-8"">
                    <div class=""col-3-xxxl col-xl-3 col-lg-3 col-12 form-group"">
                        <input type=""text"" placeholder=""Search by ID ..."" class=""form-control"">
                    </div>
                    <div class=""col-4-xxxl col-xl-4 col-lg-3 col-12 form-group"">
                        <input type=""text"" placeholder=""Search by Name ..."" class=""form-control"">
                    </div>
                    <div class=""col-4-xxxl col-xl-3 col-lg-3 col-12 form-group"">
                        <input type=""text"" placeholder=""Search by Phone ..."" class=""form-control"">
                    </div>
                    <div class=""col-1-xxxl col-xl-2 col-lg-3 col-12 form-group"">
                        <button type=""submit"" class=""fw-btn-fill btn-gradient-yellow"">SEARCH</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""table-responsive"">
                <table class=""table display data-table text-nowrap"">
                    <thead>
                        <tr>
                            <th>Photo</th>
                            <th>Firstname</th>
                            <th>Lastname</th>
                            <th>E-mail</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 56 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
                     if (Model.Users.Count<ApplicationUserDTO>() > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
                         foreach (var user in Model.Users)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 2441, "\"", 2468, 1);
#nullable restore
#line 62 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2447, user.ProfilePhotoUrl, 2447, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"student\" class=\"img-fluid rounded-circle\" width=\"60\"></td>\r\n                            <td>");
#nullable restore
#line 63 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
                           Write(user.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
                           Write(user.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td>
                                <div class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""
                                       aria-expanded=""false"">
                                        <span class=""flaticon-more-button-of-three-dots""></span>
                                    </a>
                                    <div class=""dropdown-menu dropdown-menu-right"">
                                        <a class=""dropdown-item"" href=""#"">
                                            <i class=""fas fa-times text-orange-red""></i>Close
                                        </a>
                                        <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 3447, "\"", 3480, 2);
            WriteAttributeValue("", 3454, "/admin/users/edit/", 3454, 18, true);
#nullable restore
#line 76 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 3472, user.Id, 3472, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""fas fa-cogs text-dark-pastel-green""></i>Edit
                                        </a>
                                        <a class=""dropdown-item"" href=""#"">
                                            <i class=""fas fa-redo-alt text-orange-peel""></i>Refresh
                                        </a>
                                    </div>
                                </div>
                            </td>
                        </tr>
");
#nullable restore
#line 86 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"


                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Users\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
