#pragma checksum "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a33dae774f6a84dfdee76b48705fe69c2b824a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Article), @"mvc.1.0.view", @"/Views/Blog/Article.cshtml")]
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
#line 1 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\_ViewImports.cshtml"
using Blog.Presentation.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\_ViewImports.cshtml"
using Blog.Presentation.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\_ViewImports.cshtml"
using Blog.ApplicationCore.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a33dae774f6a84dfdee76b48705fe69c2b824a", @"/Views/Blog/Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e5bbd315006900d55ac540f50f8659edb03129", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post-details/comment-01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post-details/comment-02.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
  
    ViewData["Title"] = "Article";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--====== Post Details Start ======-->\r\n<section class=\"post-details-area\">\r\n    <div class=\"container container-1000\">\r\n        <div class=\"post-details\">\r\n            <div class=\"entry-header\">\r\n                <h2 class=\"title\">");
#nullable restore
#line 11 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                             Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <ul class=\"post-meta\">\r\n                    <li>");
#nullable restore
#line 13 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                   Write(Model.Article.ArticleDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><a href=\"#\">");
#nullable restore
#line 14 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                               Write(Model.Article.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                </ul>\r\n                <p class=\"short-desc\">\r\n                    ");
#nullable restore
#line 17 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
               Write(Model.Article.Body.Substring(0, 300));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...\r\n                </p>\r\n            </div>\r\n            <div class=\"entry-media text-center\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 735, "\"", 771, 1);
#nullable restore
#line 21 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
WriteAttributeValue("", 741, Model.Article.ArticleImageUrl, 741, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" class=\"img-fluid\">\r\n            </div>\r\n            <div class=\"entry-content\" style=\"white-space: pre-line; font-size: 20px;\">\r\n                \r\n                ");
#nullable restore
#line 25 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
           Write(Model.Article.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
            <div class=""entry-footer"">

                <div class=""social-share"">
                    <span>Share:</span>
                    <a href=""#""><i class=""fab fa-instagram""></i></a>
                    <a href=""#""><i class=""fas fa-heart""></i></a>
                    <a href=""#""><i class=""fab fa-facebook-f""></i></a>
                    <a href=""#""><i class=""fab fa-twitter""></i></a>
                </div>
                <div class=""post-author"">
                    <div class=""author-img"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 1534, "\"", 1569, 1);
#nullable restore
#line 39 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
WriteAttributeValue("", 1540, Model.Article.ArthorImageUrl, 1540, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1570, "\"", 1597, 1);
#nullable restore
#line 39 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
WriteAttributeValue("", 1576, Model.Article.Author, 1576, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <h5><a href=\"#\">");
#nullable restore
#line 41 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                               Write(Model.Article.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                    <p>Article Writer</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"post-nav\">\r\n\r\n");
#nullable restore
#line 47 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                 if (Model.Previous != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"prev-post\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 1996, 2);
            WriteAttributeValue("", 1967, "/blog/article/", 1967, 14, true);
#nullable restore
#line 51 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
WriteAttributeValue("", 1981, Model.Previous, 1981, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-angle-left\"></i></a><span class=\"title\">Previous Post</span>\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                 if (Model.Next != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"next-post\">\r\n                        <span class=\"title\">Next Post</span><a");
            BeginWriteAttribute("href", " href=\"", 2296, "\"", 2328, 2);
            WriteAttributeValue("", 2303, "/blog/article/", 2303, 14, true);
#nullable restore
#line 59 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
WriteAttributeValue("", 2317, Model.Next, 2317, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-angle-right\"></i></a>\r\n                    </div>\r\n");
#nullable restore
#line 61 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n\r\n            <div class=\"related-posts\">\r\n                <h4 class=\"related-title\">Related Articles</h4>\r\n                <div class=\"related-loop row justify-content-center\">\r\n\r\n\r\n");
#nullable restore
#line 71 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                     if (Model.RelatedArticles != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                         foreach (var article in Model.RelatedArticles)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-6 col-md-6 col-sm-10\">\r\n                        <div class=\"related-post-box\">\r\n                            <div class=\"thumb\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3014, "\"", 3044, 1);
#nullable restore
#line 79 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
WriteAttributeValue("", 3020, article.ArticleImageUrl, 3020, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" class=\"img-fluid\">\r\n                            </div>\r\n                            <h5 class=\"title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3196, "\"", 3228, 2);
            WriteAttributeValue("", 3203, "/blog/article/", 3203, 14, true);
#nullable restore
#line 82 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
WriteAttributeValue("", 3217, article.Id, 3217, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 83 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                               Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h5>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 88 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\CodebitsAcademy\Cohort003\ClassSessions\ASP.NET Core MVC\CodebitsBlog\Blog.Presentation.Web\Views\Blog\Article.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""comment-template"">
            <h4 class=""template-title"">04 Comments</h4>

            <ul class=""comment-list"">
                <li>
                    <div class=""comment-body"">
                        <div class=""comment-author"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62a33dae774f6a84dfdee76b48705fe69c2b824a15966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""comment-content"">
                            <h6 class=""comment-author"">Zhon Andarson</h6>
                            <p>
                                Coding is used in almost all aspects of life and work now, be it directly or
                                indirectly. It’s not just for companies in the tech sector. “An increasing number of
                                businesses rely on computer code,
                            </p>
                            <div class=""comment-footer"">
                                <span class=""date""> 10:35pm, 27 jan 2015.</span>
                                <a href=""#"" class=""reply-link"">Reply</a>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class=""comment-body"">
                        <div class=""comment-author"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62a33dae774f6a84dfdee76b48705fe69c2b824a18105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""comment-content"">
                            <h6 class=""comment-author"">Andro Smith Doe</h6>
                            <p>
                                Coding is used in almost all aspects of life and work now, be it directly or
                                indirectly. It’s not just for companies in the tech sector. “An increasing number of
                                businesses rely on computer code,
                            </p>
                            <div class=""comment-footer"">
                                <span class=""date""> 10:35pm, 27 jan 2015.</span>
                                <a href=""#"" class=""reply-link"">Reply</a>
                            </div>
                        </div>
                    </div>
                </li>
            </ul>

            <h4 class=""template-title"">Leave your comment</h4>
            <div class=""comment-form"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62a33dae774f6a84dfdee76b48705fe69c2b824a20235", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <input type=""text"" placeholder=""Enter your name"">
                        </div>
                        <div class=""col-sm-6"">
                            <input type=""email"" placeholder=""Your Email"">
                        </div>
                        <div class=""col-12"">
                            <textarea placeholder=""Your message here""></textarea>
                        </div>
                        <div class=""col-12"">
                            <button type=""submit"">Post <i class=""far fa-arrow-right""></i></button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--====== Post Details End ======-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
