#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c894c5f6f1fbda428331d205fcd690c2af2f905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Midterm_TakeTest), @"mvc.1.0.view", @"/Views/Midterm/TakeTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Midterm/TakeTest.cshtml", typeof(AspNetCore.Views_Midterm_TakeTest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c894c5f6f1fbda428331d205fcd690c2af2f905", @"/Views/Midterm/TakeTest.cshtml")]
    public class Views_Midterm_TakeTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Midterm.Models.TestQuestion>>
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
#line 2 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
  
    ViewBag.Title = "TakeTest";

#line default
#line hidden
            BeginContext(85, 818, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d32f3c276aec4ddf86f286a68e5f7e2a", async() => {
                BeginContext(91, 57, true);
                WriteLiteral("\n    <header>\n        <h1>HHEditorFor</h1>\n    </header>\n");
                EndContext();
#line 9 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
 using (Html.BeginForm("TakeTest", "Midterm", FormMethod.Post))
{
    

#line default
#line hidden
                BeginContext(219, 23, false);
#line 11 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
#line 12 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
     foreach(var item in Model)
    {
        

#line default
#line hidden
#line 14 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
         if (item is Midterm.Models.TrueFalseQuestion)
        {
            

#line default
#line hidden
                BeginContext(359, 39, false);
#line 16 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
       Write(Html.Partial("Partial/TrueFalse", item));

#line default
#line hidden
                EndContext();
#line 16 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
                                                    ;
        }
        else if (item is Midterm.Models.MultipleChoiceQuestion)
        {
            

#line default
#line hidden
                BeginContext(497, 44, false);
#line 20 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
       Write(Html.Partial("Partial/MultipleChoice", item));

#line default
#line hidden
                EndContext();
#line 20 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
                                                         
        }
        else if (item is Midterm.Models.ShortAnswerQuestion)
        {
            

#line default
#line hidden
                BeginContext(636, 41, false);
#line 24 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
       Write(Html.Partial("Partial/ShortAnswer", item));

#line default
#line hidden
                EndContext();
#line 24 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
                                                      
        }
        else if (item is Midterm.Models.LongAnswerQuestion)
        {
            

#line default
#line hidden
                BeginContext(771, 40, false);
#line 28 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
       Write(Html.Partial("Partial/LongAnswer", item));

#line default
#line hidden
                EndContext();
#line 28 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
                                                     
        }

#line default
#line hidden
#line 29 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
         
    }

#line default
#line hidden
                BeginContext(828, 66, true);
                WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n");
                EndContext();
#line 32 "/Users/paulwyatt/Desktop/CST465TermProject/Midterm/Views/Midterm/TakeTest.cshtml"
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
            BeginContext(903, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Midterm.Models.TestQuestion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
