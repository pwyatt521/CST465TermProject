#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/ShortAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fd52e2a6a78c4f88d2ddc5afdec4c6883c1a0be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Midterm_Partial_ShortAnswer), @"mvc.1.0.view", @"/Views/Midterm/Partial/ShortAnswer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Midterm/Partial/ShortAnswer.cshtml", typeof(AspNetCore.Views_Midterm_Partial_ShortAnswer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd52e2a6a78c4f88d2ddc5afdec4c6883c1a0be", @"/Views/Midterm/Partial/ShortAnswer.cshtml")]
    public class Views_Midterm_Partial_ShortAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Midterm.Models.ShortAnswerQuestion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 43, true);
            WriteLiteral("\n    <h2 class = \"control-label\" >\n        ");
            EndContext();
            BeginContext(86, 8, false);
#line 4 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/ShortAnswer.cshtml"
   Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(94, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(97, 14, false);
#line 4 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/ShortAnswer.cshtml"
              Write(Model.Question);

#line default
#line hidden
            EndContext();
            BeginContext(111, 15, true);
            WriteLiteral("\n    </h2>\n    ");
            EndContext();
            BeginContext(127, 57, false);
#line 6 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/ShortAnswer.cshtml"
Write(Html.TextBoxFor(m=>m.Answer, new {@class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(184, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(190, 66, false);
#line 7 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/ShortAnswer.cshtml"
Write(Html.ValidationMessageFor(i=>i.ID,"",new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(256, 9, true);
            WriteLiteral("\n    <br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Midterm.Models.ShortAnswerQuestion> Html { get; private set; }
    }
}
#pragma warning restore 1591
