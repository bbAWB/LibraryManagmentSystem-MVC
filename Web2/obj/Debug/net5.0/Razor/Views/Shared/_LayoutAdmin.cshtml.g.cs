#pragma checksum "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8dad87911078cb24d2acf74bd03b955f79cb4d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8dad87911078cb24d2acf74bd03b955f79cb4d5", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a99f252aceaa0db8765de081319c8cee2862b5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/FontAwsome/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-starter.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8dad87911078cb24d2acf74bd03b955f79cb4d54844", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>");
#nullable restore
#line 6 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Shared\_LayoutAdmin.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 9 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Shared\_LayoutAdmin.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Web2</title>\n  \n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8dad87911078cb24d2acf74bd03b955f79cb4d55766", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8dad87911078cb24d2acf74bd03b955f79cb4d56942", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8dad87911078cb24d2acf74bd03b955f79cb4d58118", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script src=\"https://kit.fontawesome.com/84b847aa9b.js\" crossorigin=\"anonymous\"></script>\n     <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css\">\n    <title>");
#nullable restore
#line 16 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Shared\_LayoutAdmin.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Abrehot</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8dad87911078cb24d2acf74bd03b955f79cb4d510459", async() => {
                WriteLiteral(@"

    <div class=""superNav border-bottom py-2 bg-light"">
    <div class=""container"">
      <div class=""row"">
      
      
      </div>
    </div>
  </div>
  <nav class=""navbar navbar-expand-lg bg-white sticky-top navbar-light p-3 shadow-sm"">
    <div class=""container"">
     
   
      
      <div class="" collapse navbar-collapse"" id=""navbarNavDropdown"">
       <a class=""navbar-brand"" href=""index.html"">
                        <span class=""fa fa-pencil-square-o""></span> Abrehot
                    </a>
        <ul class=""navbar-nav ms-auto "">
          <li class=""nav-item"">
                <a class=""nav-link mx-2 text-uppercase"" href=""/Admin/Index"">Home</a>
          </li>
          <li class=""nav-item"">
                <a class=""nav-link mx-2 text-uppercase"" href=""/Admin/ManageAdministrators"">Manage Librarians</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link mx-2 text-uppercase"" href=""/Member/ManageMembers"">Manage Library Members</a>
          </li>
          <li class=""nav-");
                WriteLiteral(@"item"">
            <a class=""nav-link mx-2 text-uppercase"" href=""/Book/Index"">Manage Books</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link mx-2 text-uppercase"" href=""/Transaction/AdminViewAll"">Manage Transactions</a>
          </li>
        </ul>
        <ul class=""navbar-nav ms-auto "">
       
          <li class=""nav-item"">
            <a class=""nav-link mx-2 text-uppercase"" href=""/Admin/UserAccount""><i class=""fa-solid fa-circle-user me-1""></i> Account</a>
          </li>
          <li class=""nav-item"">
            <a class=""btn btn-primary"" href=""/Home/Logout""> Logout</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>
    <style>
    a {
    font-size:14px;
    font-weight:700
    }
    .superNav {
    font-size:13px;
    }
    .form-control {
    outline:none !important;
    box-shadow: none !important;
    }
</style>



    <div>
        ");
#nullable restore
#line 83 "D:\pdf\web2\Assignment-mvc-main\Web2\Views\Shared\_LayoutAdmin.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
     <script>
      // When the user scrolls down 20px from the top of the document, show the button
      window.onscroll = function () {
        scrollFunction()
      };

      function scrollFunction() {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
          document.getElementById(""movetop"").style.display = ""block"";
        } else {
          document.getElementById(""movetop"").style.display = ""none"";
        }
      }

      // When the user clicks on the button, scroll to the top of the document
      function topFunction() {
        document.body.scrollTop = 0;
        document.documentElement.scrollTop = 0;
      }
    </script>
    <!-- //move top -->
    <script>
      $(function () {
        $('.navbar-toggler').click(function () {
          $('body').toggleClass('noscroll');
        })
      });
    </script>
  </section>
  <!-- //footer -->
</footer>

<!-- jQuery JS -->
<!-- <script src=""assets/js/jquery-3.4.1.slim.min.js""></script> -->
<!-- j");
                WriteLiteral(@"Query JS -->
<script src=""assets/js/jquery-1.9.1.min.js""></script>

<!-- Template JavaScript -->

<!-- owl carousel -->
<script src=""assets/js/owl.carousel.js""></script>

<!-- script for testimonials -->
<script>
  $(document).ready(function () {
    $('.owl-testimonials').owlCarousel({
      loop: false,
      margin: 0,
      nav: false,
      responsiveClass: true,
      autoplay: true,
      autoplayTimeout: 5000,
      autoplaySpeed: 1000,
      autoplayHoverPause: false,
      responsive: {
        0: {
          items: 1,
          nav: false
        },
        480: {
          items: 1,
          nav: false
        },
        667: {
          items: 1,
          nav: false
        },
        1000: {
          items: 1,
          nav: false
        }
      }
    })
  })
</script>
<!-- //testimonials owlcarousel -->

<!-- logos for customers -->
<script>
  $(document).ready(function () {
    $('.owl-logos').owlCarousel({
      loop: true,
      margin: 0,
      nav: false,
      responsiveClass: true,
 ");
                WriteLiteral(@"     autoplay: true,
      autoplayTimeout: 5000,
      autoplaySpeed: 1000,
      autoplayHoverPause: false,
      responsive: {
        0: {
          items: 2,
          nav: false
        },
        480: {
          items: 2,
          nav: false
        },
        667: {
          items: 3,
          nav: false
        },
        1000: {
          items: 4,
          nav: false
        }
      }
    })
  })
</script>
<!-- //logos owlcarousel -->

<!-- courses for customers -->
<script>
  $(document).ready(function () {
    $('.owl-courses').owlCarousel({
      loop: true,
      margin: 30,
      nav: false,
      responsiveClass: true,
      autoplay: true,
      autoplayTimeout: 5000,
      autoplaySpeed: 1000,
      autoplayHoverPause: false,
      responsive: {
        0: {
          items: 1
        },
        600: {
          items: 2
        },
        1000: {
          items: 3
        }
      }
    })
  })
</script>
<!-- //courses owlcarousel -->

<!-- magnific popup -->
<script src=""assets/js/jq");
                WriteLiteral(@"uery.magnific-popup.min.js""></script>
<script>
  $(document).ready(function () {
    $('.popup-with-zoom-anim').magnificPopup({
      type: 'inline',

      fixedContentPos: false,
      fixedBgPos: true,

      overflowY: 'auto',

      closeBtnInside: true,
      preloader: false,

      midClick: true,
      removalDelay: 300,
      mainClass: 'my-mfp-zoom-in'
    });

    $('.popup-with-move-anim').magnificPopup({
      type: 'inline',

      fixedContentPos: false,
      fixedBgPos: true,

      overflowY: 'auto',

      closeBtnInside: true,
      preloader: false,

      midClick: true,
      removalDelay: 300,
      mainClass: 'my-mfp-slide-bottom'
    });
  });
</script>

<!-- responsive tabs -->
<script src=""assets/js/easyResponsiveTabs.js""></script>

<!--Plug-in Initialisation-->
<script type=""text/javascript"">
  $(document).ready(function () {
    //Horizontal Tab
    $('#parentHorizontalTab').easyResponsiveTabs({
      type: 'default', //Types: default, vertical, accordion
      width: 'auto', //");
                WriteLiteral(@"auto or any width like 600px
      fit: true, // 100% fit in a container
      tabidentify: 'hor_1', // The tab groups identifier
      activate: function (event) { // Callback function if tab is switched
        var $tab = $(this);
        var $info = $('#nested-tabInfo');
        var $name = $('span', $info);
        $name.text($tab.text());
        $info.show();
      }
    });
  });
</script>

<!-- stats number counter-->
<script src=""assets/js/jquery.waypoints.min.js""></script>
<script src=""assets/js/jquery.countup.js""></script>
<script>
  $('.counter').countUp();
</script>
<!-- //stats number counter -->

<!-- disable body scroll which navbar is in active -->
<script>
  $(function () {
    $('.navbar-toggler').click(function () {
      $('body').toggleClass('noscroll');
    })
  });
</script>
<!-- disable body scroll which navbar is in active -->

<!--/MENU-JS-->
<script>
  $(window).on(""scroll"", function () {
    var scroll = $(window).scrollTop();

    if (scroll >= 80) {
      $(""#site-header"").addCl");
                WriteLiteral(@"ass(""nav-fixed"");
    } else {
      $(""#site-header"").removeClass(""nav-fixed"");
    }
  });

  //Main navigation Active Class Add Remove
  $("".navbar-toggler"").on(""click"", function () {
    $(""header"").toggleClass(""active"");
  });
  $(document).on(""ready"", function () {
    if ($(window).width() > 991) {
      $(""header"").removeClass(""active"");
    }
    $(window).on(""resize"", function () {
      if ($(window).width() > 991) {
        $(""header"").removeClass(""active"");
      }
    });
  });
</script>
<!--//MENU-JS-->


<!--theme switcher dark and light mode script-->

<!--//theme switcher dark and light mode script-->


<!-- Bootstrap JS -->

");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
