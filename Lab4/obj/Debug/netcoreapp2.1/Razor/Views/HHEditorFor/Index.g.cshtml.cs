#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "680c96b3c1c06832a46b99dad230cba47b73cf2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HHEditorFor_Index), @"mvc.1.0.view", @"/Views/HHEditorFor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HHEditorFor/Index.cshtml", typeof(AspNetCore.Views_HHEditorFor_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680c96b3c1c06832a46b99dad230cba47b73cf2b", @"/Views/HHEditorFor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710bef30620f5b45d41ddf5acb7a43e3a27d1566", @"/Views/_ViewImports.cshtml")]
    public class Views_HHEditorFor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab4.Models.ComputerModel>
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
#line 2 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
  
    ViewBag.Title = "HHEditorFor";

#line default
#line hidden
            BeginContext(73, 2227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9d2bafe8b8846d58cf5af9009e2bb3e", async() => {
                BeginContext(79, 99, true);
                WriteLiteral("\n    <header>\n        <h1>HHEditorFor</h1>\n    </header>\n    <p>Please fill out the form below</p>\n");
                EndContext();
#line 10 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
     using (Html.BeginForm(FormMethod.Post))
    {
        

#line default
#line hidden
                BeginContext(238, 23, false);
#line 12 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(262, 45, true);
                WriteLiteral("        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(308, 56, false);
#line 14 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.LabelFor(m=>m.Name, new {@class = "control-label"}));

#line default
#line hidden
                EndContext();
                BeginContext(364, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(378, 77, false);
#line 15 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.EditorFor(m=>m.Name, new {htmlAttributes = new {@class="form-control"}}));

#line default
#line hidden
                EndContext();
                BeginContext(455, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(469, 36, false);
#line 16 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Name));

#line default
#line hidden
                EndContext();
                BeginContext(505, 61, true);
                WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(567, 60, false);
#line 19 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.LabelFor(m=>m.Password, new {@class = "control-label"}));

#line default
#line hidden
                EndContext();
                BeginContext(627, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(641, 81, false);
#line 20 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.EditorFor(m=>m.Password, new {htmlAttributes = new {@class="form-control"}}));

#line default
#line hidden
                EndContext();
                BeginContext(722, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(736, 40, false);
#line 21 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(776, 61, true);
                WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(838, 61, false);
#line 24 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.LabelFor(m=>m.IPAddress, new {@class = "control-label"}));

#line default
#line hidden
                EndContext();
                BeginContext(899, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(913, 82, false);
#line 25 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.EditorFor(m=>m.IPAddress, new {htmlAttributes = new {@class="form-control"}}));

#line default
#line hidden
                EndContext();
                BeginContext(995, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1009, 41, false);
#line 26 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.ValidationMessageFor(m=>m.IPAddress));

#line default
#line hidden
                EndContext();
                BeginContext(1050, 61, true);
                WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(1112, 60, false);
#line 29 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.LabelFor(m=>m.Location, new {@class = "control-label"}));

#line default
#line hidden
                EndContext();
                BeginContext(1172, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1186, 81, false);
#line 30 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.EditorFor(m=>m.Location, new {htmlAttributes = new {@class="form-control"}}));

#line default
#line hidden
                EndContext();
                BeginContext(1267, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1281, 40, false);
#line 31 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Location));

#line default
#line hidden
                EndContext();
                BeginContext(1321, 61, true);
                WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(1383, 54, false);
#line 34 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.LabelFor(m=>m.OS, new {@class = "control-label"}));

#line default
#line hidden
                EndContext();
                BeginContext(1437, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1451, 109, false);
#line 35 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.DropDownListFor(m=>m.OS, new SelectList(Lab4.Models.ComputerModel.OSTypes), new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1560, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1574, 34, false);
#line 36 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.ValidationMessageFor(m=>m.OS));

#line default
#line hidden
                EndContext();
                BeginContext(1608, 61, true);
                WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(1670, 63, false);
#line 39 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.LabelFor(m=>m.Description, new {@class = "control-label"}));

#line default
#line hidden
                EndContext();
                BeginContext(1733, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1747, 84, false);
#line 40 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.EditorFor(m=>m.Description, new {htmlAttributes = new {@class="form-control"}}));

#line default
#line hidden
                EndContext();
                BeginContext(1831, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1845, 43, false);
#line 41 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1888, 61, true);
                WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(1950, 69, false);
#line 44 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.LabelFor(m=>m.SupportedMonitors, new {@class = "control-label"}));

#line default
#line hidden
                EndContext();
                BeginContext(2019, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(2033, 105, false);
#line 45 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.EditorFor(m=>m.SupportedMonitors, new {htmlAttributes = new {@class="form-control", type="number"}}));

#line default
#line hidden
                EndContext();
                BeginContext(2138, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(2152, 49, false);
#line 46 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
       Write(Html.ValidationMessageFor(m=>m.SupportedMonitors));

#line default
#line hidden
                EndContext();
                BeginContext(2201, 86, true);
                WriteLiteral("\n        </div>\n        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n");
                EndContext();
#line 49 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/HHEditorFor/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab4.Models.ComputerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
