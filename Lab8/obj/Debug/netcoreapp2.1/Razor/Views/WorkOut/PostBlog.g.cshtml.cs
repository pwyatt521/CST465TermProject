#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627f57a865cda103248adc03e166d5be58378402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOut_PostBlog), @"mvc.1.0.view", @"/Views/WorkOut/PostBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkOut/PostBlog.cshtml", typeof(AspNetCore.Views_WorkOut_PostBlog))]
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
#line 1 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/_ViewImports.cshtml"
using Lab8;

#line default
#line hidden
#line 2 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/_ViewImports.cshtml"
using Lab8.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627f57a865cda103248adc03e166d5be58378402", @"/Views/WorkOut/PostBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOut_PostBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Models.WorkOutModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
  
    ViewData["Title"] = "PostBlog";

#line default
#line hidden
            BeginContext(73, 1355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4cec6fda784d9d87480d5d102b1f7f", async() => {
                BeginContext(79, 38, true);
                WriteLiteral("\n    <h1>\n        Post Blog\n    </h1>\n");
                EndContext();
#line 9 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
 using (Html.BeginForm("PostBlog", "WorkOut", FormMethod.Post))
{
    

#line default
#line hidden
                BeginContext(188, 23, false);
#line 11 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(217, 62, false);
#line 12 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.PostedBy, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(285, 63, false);
#line 13 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
Write(Html.TextBoxFor(m=>m.PostedBy, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(354, 42, false);
#line 14 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.PostedBy));

#line default
#line hidden
                EndContext();
                BeginContext(397, 41, true);
                WriteLiteral("    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(439, 59, false);
#line 16 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WName, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(498, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(508, 60, false);
#line 17 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.TextBoxFor(m=>m.WName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(568, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(578, 39, false);
#line 18 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WName));

#line default
#line hidden
                EndContext();
                BeginContext(617, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(671, 66, false);
#line 21 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WDescription, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(737, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(747, 68, false);
#line 22 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.TextAreaFor(m=>m.WDescription, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(815, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(825, 46, false);
#line 23 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WDescription));

#line default
#line hidden
                EndContext();
                BeginContext(871, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(925, 61, false);
#line 26 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WRating, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(986, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(996, 61, false);
#line 27 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.EditorFor(m=>m.WRating, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1057, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1067, 41, false);
#line 28 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WRating));

#line default
#line hidden
                EndContext();
                BeginContext(1108, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(1162, 59, false);
#line 31 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.WDate, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1221, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1231, 59, false);
#line 32 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.EditorFor(m=>m.WDate, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1290, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1300, 39, false);
#line 33 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.WDate));

#line default
#line hidden
                EndContext();
                BeginContext(1339, 80, true);
                WriteLiteral("\n    </div>\n   <button type=\"submit\" class=\"btn btn-primary\">Post Blog</button>\n");
                EndContext();
#line 36 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/WorkOut/PostBlog.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Models.WorkOutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
