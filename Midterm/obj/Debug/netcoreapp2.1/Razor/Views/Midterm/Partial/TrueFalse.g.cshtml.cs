#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/TrueFalse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d70f8354a6e51367f9d11722fc2aaca26c90f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Midterm_Partial_TrueFalse), @"mvc.1.0.view", @"/Views/Midterm/Partial/TrueFalse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Midterm/Partial/TrueFalse.cshtml", typeof(AspNetCore.Views_Midterm_Partial_TrueFalse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d70f8354a6e51367f9d11722fc2aaca26c90f5", @"/Views/Midterm/Partial/TrueFalse.cshtml")]
    public class Views_Midterm_Partial_TrueFalse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Midterm.Models.TrueFalseQuestion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 43, true);
            WriteLiteral("\n    <h2 class = \"control-label\" >\n        ");
            EndContext();
            BeginContext(84, 8, false);
#line 4 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/TrueFalse.cshtml"
   Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(92, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(95, 14, false);
#line 4 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/TrueFalse.cshtml"
              Write(Model.Question);

#line default
#line hidden
            EndContext();
            BeginContext(109, 15, true);
            WriteLiteral("\n    </h2>\n    ");
            EndContext();
            BeginContext(125, 117, false);
#line 6 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/TrueFalse.cshtml"
Write(Html.DropDownListFor(m=>m.Answer, new SelectList(Midterm.Models.TrueFalseQuestion.TOrF), new {@class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(242, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(248, 66, false);
#line 7 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/Partial/TrueFalse.cshtml"
Write(Html.ValidationMessageFor(i=>i.ID,"",new {@class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(314, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Midterm.Models.TrueFalseQuestion> Html { get; private set; }
    }
}
#pragma warning restore 1591