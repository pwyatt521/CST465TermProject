#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/EditorTemplates/OSDropdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd3da239c13b5eef71265696f18738eb37a24ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_OSDropdown), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/OSDropdown.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/OSDropdown.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_OSDropdown))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd3da239c13b5eef71265696f18738eb37a24ff", @"/Views/Shared/EditorTemplates/OSDropdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710bef30620f5b45d41ddf5acb7a43e3a27d1566", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_OSDropdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 105, false);
#line 2 "/Users/paulwyatt/Desktop/CST465TermProject/Lab4/Views/Shared/EditorTemplates/OSDropdown.cshtml"
Write(Html.DropDownListFor(m=>m, new SelectList(Lab4.Models.ComputerModel.OSTypes), new{@class="form-control"}));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
