#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a923f7c72a02d720849c096d916a3158e6bde8d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adventure_PostBlog), @"mvc.1.0.view", @"/Views/Adventure/PostBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adventure/PostBlog.cshtml", typeof(AspNetCore.Views_Adventure_PostBlog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a923f7c72a02d720849c096d916a3158e6bde8d7", @"/Views/Adventure/PostBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Adventure_PostBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Models.AdventureModel>
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
#line 2 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
  
    ViewData["Title"] = "PostBlog";

#line default
#line hidden
            BeginContext(75, 1126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d46a9c8790e148169af2114ce304ac64", async() => {
                BeginContext(81, 38, true);
                WriteLiteral("\n    <h1>\n        Post Blog\n    </h1>\n");
                EndContext();
#line 9 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
 using (Html.BeginForm("PostBlog", "Adventure", FormMethod.Post))
{
    

#line default
#line hidden
                BeginContext(192, 23, false);
#line 11 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(221, 62, false);
#line 12 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
Write(Html.LabelFor(m=>m.PostedBy, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(289, 63, false);
#line 13 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
Write(Html.TextBoxFor(m=>m.PostedBy, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(358, 42, false);
#line 14 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
Write(Html.ValidationMessageFor(m => m.PostedBy));

#line default
#line hidden
                EndContext();
                BeginContext(401, 41, true);
                WriteLiteral("    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(443, 59, false);
#line 16 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.AName, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(502, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(512, 60, false);
#line 17 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.TextBoxFor(m=>m.AName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(572, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(582, 39, false);
#line 18 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.AName));

#line default
#line hidden
                EndContext();
                BeginContext(621, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(675, 66, false);
#line 21 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.ADescription, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(741, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(751, 68, false);
#line 22 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.TextAreaFor(m=>m.ADescription, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(819, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(829, 46, false);
#line 23 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.ADescription));

#line default
#line hidden
                EndContext();
                BeginContext(875, 53, true);
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">    \n        ");
                EndContext();
                BeginContext(929, 61, false);
#line 26 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.LabelFor(m=>m.ARating, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(990, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1000, 61, false);
#line 27 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.EditorFor(m=>m.ARating, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1061, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1071, 41, false);
#line 28 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
   Write(Html.ValidationMessageFor(m => m.ARating));

#line default
#line hidden
                EndContext();
                BeginContext(1112, 80, true);
                WriteLiteral("\n    </div>\n   <button type=\"submit\" class=\"btn btn-primary\">Post Blog</button>\n");
                EndContext();
#line 31 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Adventure/PostBlog.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Models.AdventureModel> Html { get; private set; }
    }
}
#pragma warning restore 1591