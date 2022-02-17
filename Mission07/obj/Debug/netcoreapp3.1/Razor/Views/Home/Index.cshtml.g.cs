#pragma checksum "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d69d4dbef5f317e903a0f61b1ffb3b6ac87dffff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mission07.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace Mission07.Views.Home
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
#line 4 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/_ViewImports.cshtml"
using Mission07.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/_ViewImports.cshtml"
using Mission07.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69d4dbef5f317e903a0f61b1ffb3b6ac87dffff", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eda96e4c0468a51f7f57a36c82741e80ce01fcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Mission07.Infrastructure.PaginationTagHelper __Mission07_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>The Book Collection</h1>\n\n<div class=\"container\">\n");
#nullable restore
#line 6 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
     foreach (Book b in Model.Books)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bg-dark text-white p-2\">\n            <h3>");
#nullable restore
#line 9 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
           Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </div>\n        <div class=\"card card-outline-primary m-1 p-1\">\n            <ul>\n                <li>Author: ");
#nullable restore
#line 13 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
                       Write(b.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Publisher: ");
#nullable restore
#line 14 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
                          Write(b.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>ISBN: ");
#nullable restore
#line 15 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
                     Write(b.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Classification/Category: ");
#nullable restore
#line 16 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
                                        Write(b.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 16 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
                                                          Write(b.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Number of Pages: ");
#nullable restore
#line 17 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
                                Write(b.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Price: $");
#nullable restore
#line 18 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
                       Write(b.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ul>\n        </div>\n        <br />\n");
#nullable restore
#line 22 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69d4dbef5f317e903a0f61b1ffb3b6ac87dffff6149", async() => {
            }
            );
            __Mission07_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Mission07.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Mission07_Infrastructure_PaginationTagHelper);
#nullable restore
#line 24 "/Users/jacob.poor98/Documents/GitHub/Mission07/Mission07/Views/Home/Index.cshtml"
__Mission07_Infrastructure_PaginationTagHelper.PageBook = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-book", __Mission07_Infrastructure_PaginationTagHelper.PageBook, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Mission07_Infrastructure_PaginationTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
