#pragma checksum "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a58ef3897df428ee3d19c7a1d92f035cbebf776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Borrow_Index), @"mvc.1.0.view", @"/Views/Borrow/Index.cshtml")]
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
#line 1 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\_ViewImports.cshtml"
using Web2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\_ViewImports.cshtml"
using Web2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a58ef3897df428ee3d19c7a1d92f035cbebf776", @"/Views/Borrow/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a99f252aceaa0db8765de081319c8cee2862b5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Borrow_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web2.Models.Book>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top card-img-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a-cleanup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<style>\n    .row{\n        margin-top:70px;\n    }\n</style>\n<div class=\"row\">\n");
#nullable restore
#line 14 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
     foreach (var item in Model)
    {
        var photoPath = "~/images/" + (item.BookImg ?? "no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-3\">\n            <div class=\"card my-2 store-card\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a58ef3897df428ee3d19c7a1d92f035cbebf7765422", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a58ef3897df428ee3d19c7a1d92f035cbebf7765695", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                  WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    <div class=\"card-body\" style=\"height: 6em;\">\n                        <h5 class=\"mb-3\">");
#nullable restore
#line 22 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                    Write(item.BookTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                    </div>\n                    <div class=\"card-body\">\n                        <span class=\"card-text\">");
#nullable restore
#line 25 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                           Write(item.BookTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                          <span class=\"card-text\">");
#nullable restore
#line 26 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                             Write(item.BookCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span class=\"card-text\">");
#nullable restore
#line 27 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                           Write(item.BookAuthor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                            <span class=\"card-text\">");
#nullable restore
#line 28 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                               Write(item.BookPublisher);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span class=\"card-text\">");
#nullable restore
#line 29 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                           Write(item.BookIsbn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span class=\"card-text\">");
#nullable restore
#line 30 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                           Write(item.BookCopyright);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span class=\"card-text\">");
#nullable restore
#line 31 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                           Write(item.BookDateAdded);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                        <span class=\"card-text\">");
#nullable restore
#line 32 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                           Write(item.BookStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
                                                                                   WriteLiteral(item.BookTblId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n            </div>\n\n    <a> ");
#nullable restore
#line 38 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
   Write(Html.ActionLink("Requested", "Requested", "Borrow", null, new { @class = "nav-item btn-sm btn-primary text-light", style = "text-decoration:none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\n\n\n\n\n\n\n\n\n             \n        </div>\n");
#nullable restore
#line 50 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Borrow\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web2.Models.Book>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
