#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05588eda7a850a4afd94bd2538318ff21826b99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Submission), @"mvc.1.0.view", @"/Views/Shared/Submission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Submission.cshtml", typeof(AspNetCore.Views_Shared_Submission))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05588eda7a850a4afd94bd2538318ff21826b99e", @"/Views/Shared/Submission.cshtml")]
    public class Views_Shared_Submission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab4.Models.ComputerModel>
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
            BeginContext(33, 1275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29b3eb3542c45d68e3aff247bb1021a", async() => {
                BeginContext(39, 85, true);
                WriteLiteral("\n<div class=\"row\">\n  <div class=\"col-sm-4\">\n      <div>\n          <span>Name: </span>");
                EndContext();
                BeginContext(125, 10, false);
#line 6 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                        Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(135, 59, true);
                WriteLiteral("\n      </div>\n      <div>\n          <span>Password: </span>");
                EndContext();
                BeginContext(195, 14, false);
#line 9 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                            Write(Model.Password);

#line default
#line hidden
                EndContext();
                BeginContext(209, 60, true);
                WriteLiteral("\n      </div>\n      <div>\n          <span>IPAddress: </span>");
                EndContext();
                BeginContext(270, 15, false);
#line 12 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                             Write(Model.IPAddress);

#line default
#line hidden
                EndContext();
                BeginContext(285, 59, true);
                WriteLiteral("\n      </div>\n      <div>\n          <span>Location: </span>");
                EndContext();
                BeginContext(345, 14, false);
#line 15 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                            Write(Model.Location);

#line default
#line hidden
                EndContext();
                BeginContext(359, 53, true);
                WriteLiteral("\n      </div>\n      <div>\n          <span>OS: </span>");
                EndContext();
                BeginContext(413, 8, false);
#line 18 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                      Write(Model.OS);

#line default
#line hidden
                EndContext();
                BeginContext(421, 62, true);
                WriteLiteral("\n      </div>\n      <div>\n          <span>Description: </span>");
                EndContext();
                BeginContext(484, 17, false);
#line 21 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                               Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(501, 68, true);
                WriteLiteral("\n      </div>\n      <div>\n          <span>SupportedMonitors: </span>");
                EndContext();
                BeginContext(570, 23, false);
#line 24 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                                     Write(Model.SupportedMonitors);

#line default
#line hidden
                EndContext();
                BeginContext(593, 54, true);
                WriteLiteral("\n      </div>\n  </div>\n  <div class=\"col-sm-4\">\n      ");
                EndContext();
                BeginContext(648, 24, false);
#line 28 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.LabelFor(m=>m.Name));

#line default
#line hidden
                EndContext();
                BeginContext(672, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(680, 26, false);
#line 29 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.DisplayFor(m=>m.Name));

#line default
#line hidden
                EndContext();
                BeginContext(706, 18, true);
                WriteLiteral("\n      <br>\n      ");
                EndContext();
                BeginContext(725, 28, false);
#line 31 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.LabelFor(m=>m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(753, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(761, 30, false);
#line 32 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.DisplayFor(m=>m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(791, 18, true);
                WriteLiteral("\n      <br>\n      ");
                EndContext();
                BeginContext(810, 29, false);
#line 34 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.LabelFor(m=>m.IPAddress));

#line default
#line hidden
                EndContext();
                BeginContext(839, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(847, 31, false);
#line 35 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.DisplayFor(m=>m.IPAddress));

#line default
#line hidden
                EndContext();
                BeginContext(878, 18, true);
                WriteLiteral("\n      <br>\n      ");
                EndContext();
                BeginContext(897, 28, false);
#line 37 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.LabelFor(m=>m.Location));

#line default
#line hidden
                EndContext();
                BeginContext(925, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(933, 30, false);
#line 38 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.DisplayFor(m=>m.Location));

#line default
#line hidden
                EndContext();
                BeginContext(963, 18, true);
                WriteLiteral("\n      <br>\n      ");
                EndContext();
                BeginContext(982, 22, false);
#line 40 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.LabelFor(m=>m.OS));

#line default
#line hidden
                EndContext();
                BeginContext(1004, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(1012, 24, false);
#line 41 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.DisplayFor(m=>m.OS));

#line default
#line hidden
                EndContext();
                BeginContext(1036, 18, true);
                WriteLiteral("\n      <br>\n      ");
                EndContext();
                BeginContext(1055, 31, false);
#line 43 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.LabelFor(m=>m.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1086, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(1094, 33, false);
#line 44 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.DisplayFor(m=>m.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1127, 18, true);
                WriteLiteral("\n      <br>\n      ");
                EndContext();
                BeginContext(1146, 37, false);
#line 46 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.LabelFor(m=>m.SupportedMonitors));

#line default
#line hidden
                EndContext();
                BeginContext(1183, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(1191, 39, false);
#line 47 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
 Write(Html.DisplayFor(m=>m.SupportedMonitors));

#line default
#line hidden
                EndContext();
                BeginContext(1230, 34, true);
                WriteLiteral("\n  </div>\n  <div class=\"col-sm-4\">");
                EndContext();
                BeginContext(1265, 22, false);
#line 49 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/Submission.cshtml"
                   Write(Html.DisplayForModel());

#line default
#line hidden
                EndContext();
                BeginContext(1287, 14, true);
                WriteLiteral("</div>\n</div>\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab4.Models.ComputerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591