#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3118f3ac8308e9174efc8711f526efe77de4f87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Midterm_Partial_MultipleChoice), @"mvc.1.0.view", @"/Views/Midterm/Partial/MultipleChoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Midterm/Partial/MultipleChoice.cshtml", typeof(AspNetCore.Views_Midterm_Partial_MultipleChoice))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3118f3ac8308e9174efc8711f526efe77de4f87", @"/Views/Midterm/Partial/MultipleChoice.cshtml")]
    public class Views_Midterm_Partial_MultipleChoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Midterm.Models.MultipleChoiceQuestion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 43, true);
            WriteLiteral("\n    <h2 class = \"control-label\" >\n        ");
            EndContext();
            BeginContext(89, 8, false);
#line 4 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml"
   Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(97, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(100, 14, false);
#line 4 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml"
              Write(Model.Question);

#line default
#line hidden
            EndContext();
            BeginContext(114, 11, true);
            WriteLiteral("\n    </h2>\n");
            EndContext();
#line 6 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml"
     foreach (string item in Model.Choices)
    {

#line default
#line hidden
            BeginContext(175, 49, true);
            WriteLiteral("        <div class = \"form-control\">\n            ");
            EndContext();
            BeginContext(225, 32, false);
#line 9 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml"
       Write(Html.RadioButton(item, Model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(257, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(259, 4, false);
#line 9 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml"
                                         Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(263, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 11 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml"
    }

#line default
#line hidden
            BeginContext(285, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(290, 66, false);
#line 12 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/MultipleChoice.cshtml"
Write(Html.ValidationMessageFor(i=>i.ID,"",new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(356, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Midterm.Models.MultipleChoiceQuestion> Html { get; private set; }
    }
}
#pragma warning restore 1591
