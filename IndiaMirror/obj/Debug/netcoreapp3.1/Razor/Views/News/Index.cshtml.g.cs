#pragma checksum "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9cd3c0078fe2a05d0a641fb637b18a44c869c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IndiaMirror.Pages.Views.News.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
namespace IndiaMirror.Pages.Views.News
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
#line 1 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\_ViewImports.cshtml"
using IndiaMirror;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
using IndiaMirror.Dataclasses;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e9cd3c0078fe2a05d0a641fb637b18a44c869c1", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c646f747b32c579d847bc8ecc5e91f394ec5cf", @"/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e9cd3c0078fe2a05d0a641fb637b18a44c869c13241", async() => {
                WriteLiteral(@"
    <nav class=""navbar fixed-top navbar-expand-lg navbar-dark  bg-dark"">
        <div class=""container-fluid"">
            <a class=""navbar-brand"" href=""#"">NewsDaily</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                    data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                    <li class='nav-item'><a class='nav-link' href=""/News""> Home</a></li>
                    <li class='nav-item'><a class='nav-link' href=""?Category=business""> Business</a></li>
                    <li class='nav-item'><a class='nav-link' href=""?Category=entertainment""> Entertainment</a></li>
                    <li class='nav-item'><a class='");
                WriteLiteral(@"nav-link' href=""?Category=health""> Health</a></li>
                    <li class='nav-item'><a class='nav-link' href=""?Category=science""> Science</a></li>
                    <li class='nav-item'><a class='nav-link' href=""?Category=sports""> Sports</a></li>
                    <li class='nav-item'><a class='nav-link' href=""?Category=technology""> Technology</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class='container' style=""margin-top: 55px;"">
        <div class='row'>
");
#nullable restore
#line 30 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
             foreach (Articles article in ViewBag.articles)
            {

                String author = article.author == null ? "UnKnown" : article.author;
                if (author.Length == 0)
                    author = "UnKnown";
                String imageurl = article.urlToImage == null ? "https://i.ytimg.com/vi/l05CkIE39CA/maxresdefault.jpg" : article.urlToImage;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class='col-md-4'>
                    <div class='my-3'>
                        <div class=""card"">
                            <div style=""display:flex; position:absolute; justify-content:flex-end; right:0"">
                                <span class="" badge rounded-pill bg-danger"" style=""left:85%; z-index:1"">
                                    ");
#nullable restore
#line 42 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
                               Write(article.source.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n                            <img");
                BeginWriteAttribute("src", " src=", 2523, "", 2537, 1);
#nullable restore
#line 45 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
WriteAttributeValue("", 2528, imageurl, 2528, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\" />\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 47 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
                                                  Write(article.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5> Inbox\r\n                                <p class=\"card-text\">");
#nullable restore
#line 48 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
                                                Write(article.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"card-text\">\r\n                                    <small class=\"text-primary\">\r\n                                        By ");
#nullable restore
#line 51 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
                                      Write(author);

#line default
#line hidden
#nullable disable
                WriteLiteral(" on ");
#nullable restore
#line 51 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
                                                 Write(article.publishedAt);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </small>\r\n                                </p>\r\n                                <a rel=\"noreferrer\"");
                BeginWriteAttribute("href", " href=", 3119, "", 3137, 1);
#nullable restore
#line 54 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
WriteAttributeValue("", 3125, article.url, 3125, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" class=\"btn btn-sm btn-dark\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 59 "E:\SEM-5\wad_Lab\IndiaMirror\IndiaMirror\Views\News\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n    </div\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
