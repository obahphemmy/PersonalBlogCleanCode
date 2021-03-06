#pragma checksum "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb88808533233ac13a03bb4e32fbd3d85c9a7c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Articles_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Articles/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb88808533233ac13a03bb4e32fbd3d85c9a7c8", @"/Areas/Admin/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa48b64e526b074ebebff16601d2ffd24e87806", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
  
    ViewData["Title"] = "Articles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dashboard-content-one"">
    <!-- Breadcubs Area Start Here -->
    <div class=""breadcrumbs-area"">
        <h3>Articles</h3>
        <ul>
            <li>
                <a href=""/admin/dashboard"">Dashboard</a>
            </li>
            <li>All Articles</li>
        </ul>
    </div>
    <!-- Breadcubs Area End Here -->
    <!-- Teacher Table Area Start Here -->
    <div class=""card height-auto"">
        <div class=""card-body"">
            <div class=""heading-layout1"">
                <div class=""item-title"">
                    <h3>All Articles</h3>
                </div>
                <div class=""dropdown"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
                       aria-expanded=""false"">...</a>

                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""fas fa-times text-orange-red""></i>Close
          ");
            WriteLiteral(@"              </a>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""fas fa-cogs text-dark-pastel-green""></i>Edit
                        </a>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""fas fa-redo-alt text-orange-peel""></i>Refresh
                        </a>
                    </div>
                </div>
            </div>
            
            <div class=""table-responsive"">
                <table class=""table display data-table text-wrap"" data-page-length='10'>
                    <thead>
                        <tr>
                            <th>Photo</th>
                            <th>Title</th>
                            <th>Extract</th>
                            <th>Category</th>
                            <th>Author</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 57 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                         if (Model.Articles != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                             foreach (var article in Model.Articles)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\">\r\n                                <div");
            BeginWriteAttribute("style", " style=\"", 2408, "\"", 2532, 7);
            WriteAttributeValue("", 2416, "width:65px;", 2416, 11, true);
            WriteAttributeValue(" ", 2427, "height:65px;", 2428, 13, true);
            WriteAttributeValue(" ", 2440, "background-image:url(", 2441, 22, true);
#nullable restore
#line 64 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
WriteAttributeValue("", 2462, article.ArticleImageUrl, 2462, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2486, ");", 2486, 2, true);
            WriteAttributeValue(" ", 2488, "background-size:cover;", 2489, 23, true);
            WriteAttributeValue(" ", 2511, "border-radius:100px;", 2512, 21, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 66 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 67 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(article.Body.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(article.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(article.Author);

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
            BeginWriteAttribute("href", " href=\"", 3570, "\"", 3609, 2);
            WriteAttributeValue("", 3577, "/admin/articles/edit/", 3577, 21, true);
#nullable restore
#line 80 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
WriteAttributeValue("", 3598, article.Id, 3598, 11, false);

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
#line 90 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Areas\Admin\Views\Articles\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
