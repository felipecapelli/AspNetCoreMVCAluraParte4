#pragma checksum "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a03fc4927426b8b1eaf074da789aebb3846227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 1 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 4 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\_ViewImports.cshtml"
using CasaDoCodigo.IdentityServer.Quickstart.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a03fc4927426b8b1eaf074da789aebb3846227", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54679e4c731870408eb29d950d73cc3d9386f945", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("PostLogoutRedirectUri"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "External", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Challenge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 95, true);
            WriteLiteral("\n<div class=\"login-page\">\n    <div class=\"page-header\">\n        <h1>Login</h1>\n    </div>\n\n    ");
            EndContext();
            BeginContext(117, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b41dae5eff9a4caa9301fcd4a631a824", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(154, 25, true);
            WriteLiteral("\n\n    <div class=\"row\">\n\n");
            EndContext();
#line 12 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
         if (Model.EnableLocalLogin)
        {

#line default
#line hidden
            BeginContext(226, 295, true);
            WriteLiteral(@"            <div class=""col-sm-6"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">Local Login</h3>
                    </div>
                    <div class=""panel-body"">

                        ");
            EndContext();
            BeginContext(521, 1692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "441b3825c3f844a2a575bcda0f667916", async() => {
                BeginContext(545, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(574, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e764a3b43118438f872b34cc38b8a4b0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 22 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(617, 134, true);
                WriteLiteral("\n\n                            <fieldset>\n                                <div class=\"form-group\">\n                                    ");
                EndContext();
                BeginContext(751, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "681480cb526743438d259110069edd4b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 26 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(785, 37, true);
                WriteLiteral("\n                                    ");
                EndContext();
                BeginContext(822, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8dc116e7ac2e4de6937ded33f91759aa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 27 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("autofocus", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(902, 133, true);
                WriteLiteral("\n                                </div>\n                                <div class=\"form-group\">\n                                    ");
                EndContext();
                BeginContext(1035, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09263ccb2114425387826297efdae362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 30 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1069, 37, true);
                WriteLiteral("\n                                    ");
                EndContext();
                BeginContext(1106, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7951b6bc093f4886853601b82fd47122", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 31 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1211, 40, true);
                WriteLiteral("\n                                </div>\n");
                EndContext();
#line 33 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                                 if (Model.AllowRememberLogin)
                                {

#line default
#line hidden
                BeginContext(1348, 84, true);
                WriteLiteral("                    <div class=\"form-group login-remember\">\n                        ");
                EndContext();
                BeginContext(1432, 187, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29ea496cb5d64364b12d32f94f582f41", async() => {
                    BeginContext(1463, 29, true);
                    WriteLiteral("\n                            ");
                    EndContext();
                    BeginContext(1492, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73caf33d0b9c4abf885e0499c3904e00", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberLogin);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1523, 88, true);
                    WriteLiteral("\n                            <strong>Remember My Login</strong>\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 36 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberLogin);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1619, 27, true);
                WriteLiteral("\n                    </div>");
                EndContext();
#line 40 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                          }

#line default
#line hidden
                BeginContext(1648, 558, true);
                WriteLiteral(@"
                                <div>
                                    <p>The default users are alice/bob, password: Pass123$</p>
                                </div>

                                <div class=""form-group"">
                                    <button class=""btn btn-primary"" name=""button"" value=""login"">Login</button>
                                    <button class=""btn btn-default"" name=""button"" value=""cancel"">Cancel</button>
                                </div>
                            </fieldset>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2213, 74, true);
            WriteLiteral("\n                        <div>\n                            ...or click to ");
            EndContext();
            BeginContext(2287, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c63b302c4a4c54a3488577da8ff2e1", async() => {
                BeginContext(2406, 15, true);
                WriteLiteral("<b>register</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                                                                                                      WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2425, 113, true);
            WriteLiteral(" a new user.\n                        </div>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 58 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
        }

#line default
#line hidden
            BeginContext(2548, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 60 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
         if (Model.VisibleExternalProviders.Any())
        {

#line default
#line hidden
            BeginContext(2610, 350, true);
            WriteLiteral(@"            <div class=""col-md-6 col-sm-6 external-providers"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">External Login</h3>
                    </div>
                    <div class=""panel-body"">
                        <ul class=""list-inline"">
");
            EndContext();
#line 69 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                             foreach (var provider in Model.VisibleExternalProviders)
                            {

#line default
#line hidden
            BeginContext(3076, 73, true);
            WriteLiteral("                                <li>\n                                    ");
            EndContext();
            BeginContext(3149, 426, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc4f29fb80a486f9fcdd7d4857dd818", async() => {
                BeginContext(3472, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3514, 20, false);
#line 77 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                                   Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(3534, 37, true);
                WriteLiteral("\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-provider", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                                               WriteLiteral(provider.AuthenticationScheme);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["provider"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-provider", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["provider"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                                                WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3575, 39, true);
            WriteLiteral("\n                                </li>\n");
            EndContext();
#line 80 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
                            }

#line default
#line hidden
            BeginContext(3644, 99, true);
            WriteLiteral("                        </ul>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 85 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
        }

#line default
#line hidden
            BeginContext(3753, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 87 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
         if (!Model.EnableLocalLogin && !Model.VisibleExternalProviders.Any())
        {

#line default
#line hidden
            BeginContext(3843, 191, true);
            WriteLiteral("            <div class=\"alert alert-warning\">\n                <strong>Invalid login request</strong>\n                There are no login schemes configured for this client.\n            </div>\n");
            EndContext();
#line 93 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo.IdentityServer\Views\Account\Login.cshtml"
        }

#line default
#line hidden
            BeginContext(4044, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
