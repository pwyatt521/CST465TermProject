#pragma checksum "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a55524f652bc10706f916788ec11f5a9bf118b28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
using Lab8.Areas.Identity.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a55524f652bc10706f916788ec11f5a9bf118b28", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUserToRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(150, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
            BeginContext(189, 27, true);
            WriteLiteral("<h2>\n    Create Role\n</h2>\n");
            EndContext();
            BeginContext(216, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08deb5e7b9de458cad6911c0d22abd3e", async() => {
                BeginContext(269, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(275, 23, false);
#line 13 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(298, 215, true);
                WriteLiteral("\n    <label for=\"RoleName\" class=\"control-label\">Role Name</label>\n    <input type=\"text\" id=\"RoleName\" name=\"RoleName\" class=\"form-control\" />\n    <button type=\"Submit\" class=\"btn btn-default\">Create Role</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(520, 32, true);
            WriteLiteral("\n<h2>\n    Delete Role\n</h2>\n    ");
            EndContext();
            BeginContext(552, 369, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8129a0adb49f4519aa4ee15afb6ffa1b", async() => {
                BeginContext(605, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(615, 23, false);
#line 22 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(638, 79, true);
                WriteLiteral("\n        <label for=\"RoleName\" class=\"control-label\">Role Name</label>\n        ");
                EndContext();
                BeginContext(718, 116, false);
#line 24 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
   Write(Html.DropDownList("RoleName", new SelectList(RoleMan.Roles.ToList()), "Select Role",new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(834, 80, true);
                WriteLiteral("\n        <button type=\"Submit\" class=\"btn btn-default\">Delete Role</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(921, 43, true);
            WriteLiteral("\n    <h2>\n    Delete User\n    </h2>\n       ");
            EndContext();
            BeginContext(964, 369, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f384492df1a48309c2184bd99d0314d", async() => {
                BeginContext(1017, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1027, 23, false);
#line 31 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(1050, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1060, 62, false);
#line 32 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
   Write(Html.Label("Email", "Email", new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1122, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1132, 114, false);
#line 33 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
   Write(Html.DropDownList("Email", new SelectList(UserMan.Users.ToList()), "Select User", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1246, 80, true);
                WriteLiteral("\n        <button type=\"Submit\" class=\"btn btn-default\">Delete User</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1333, 41, true);
            WriteLiteral("\n    <h2>\n    Add User to Role\n    </h2>\n");
            EndContext();
            BeginContext(1374, 613, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d26b2eec094c41c685b484bf0cf6011e", async() => {
                BeginContext(1444, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1450, 23, false);
#line 40 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(1473, 9, true);
                WriteLiteral("\n    <!--");
                EndContext();
                BeginContext(1483, 40, false);
#line 41 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
   Write(Html.Hidden("Email", User.Identity.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1523, 8, true);
                WriteLiteral("-->\n    ");
                EndContext();
                BeginContext(1532, 62, false);
#line 42 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
Write(Html.Label("Email", "Email", new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1594, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1600, 114, false);
#line 43 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
Write(Html.DropDownList("Email", new SelectList(UserMan.Users.ToList()), "Select User", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1714, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1720, 68, false);
#line 44 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
Write(Html.Label("RoleName", "RoleName", new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1788, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1794, 116, false);
#line 45 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
Write(Html.DropDownList("RoleName", new SelectList(RoleMan.Roles.ToList()), "Select Role",new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1910, 70, true);
                WriteLiteral("\n    <button type=\"submit\" class=\"btn btn-primary\">Join Role</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1987, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 48 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
 foreach (var role in RoleMan.Roles.ToList()){

#line default
#line hidden
            BeginContext(2035, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(2044, 9, false);
#line 49 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
   Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2053, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
#line 50 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
     foreach(var user in UserMan.GetUsersInRoleAsync(role.Name).Result)
    {

#line default
#line hidden
            BeginContext(2137, 13, true);
            WriteLiteral("        <div>");
            EndContext();
            BeginContext(2151, 13, false);
#line 52 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
        Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2164, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 53 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
    }

#line default
#line hidden
#line 53 "/Users/paulwyatt/Desktop/CST465TermProject/Lab8/Views/Admin/Index.cshtml"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Lab8Model> UserMan { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> RoleMan { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
