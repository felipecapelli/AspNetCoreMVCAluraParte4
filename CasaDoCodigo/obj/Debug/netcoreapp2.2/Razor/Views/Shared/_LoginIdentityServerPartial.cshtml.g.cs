#pragma checksum "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Shared\_LoginIdentityServerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f72bda19120a266831d334aa76b489c1145aa696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginIdentityServerPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginIdentityServerPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoginIdentityServerPartial.cshtml", typeof(AspNetCore.Views_Shared__LoginIdentityServerPartial))]
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
#line 1 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo;

#line default
#line hidden
#line 2 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo.Models;

#line default
#line hidden
#line 3 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72bda19120a266831d334aa76b489c1145aa696", @"/Views/Shared/_LoginIdentityServerPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5764b985c14b19f76680672d581de467d30433a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginIdentityServerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Conta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Shared\_LoginIdentityServerPartial.cshtml"
  
    string nomeUsuario = User.FindFirst("name")?.Value;
    var claims = User.Claims.ToList();

#line default
#line hidden
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Shared\_LoginIdentityServerPartial.cshtml"
 if (!string.IsNullOrWhiteSpace(nomeUsuario))
{

#line default
#line hidden
            BeginContext(259, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(263, 342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72bda19120a266831d334aa76b489c1145aa6965491", async() => {
                BeginContext(312, 94, true);
                WriteLiteral("\r\n        <ul class=\"nav navbar-nav navbar-right\">\r\n            <li>\r\n                <a>Olá, ");
                EndContext();
                BeginContext(407, 11, false);
#line 16 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Shared\_LoginIdentityServerPartial.cshtml"
                   Write(nomeUsuario);

#line default
#line hidden
                EndContext();
                BeginContext(418, 180, true);
                WriteLiteral(" !</a>\r\n            </li>\r\n            <li>\r\n                <button type=\"submit\" class=\"btn btn-link navbar-btn navbar-link\">Sair</button>\r\n            </li>\r\n        </ul>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(605, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Shared\_LoginIdentityServerPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(619, 58, true);
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li>");
            EndContext();
            BeginContext(677, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72bda19120a266831d334aa76b489c1145aa6968382", async() => {
                BeginContext(722, 6, true);
                WriteLiteral("Entrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(732, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 29 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Shared\_LoginIdentityServerPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591