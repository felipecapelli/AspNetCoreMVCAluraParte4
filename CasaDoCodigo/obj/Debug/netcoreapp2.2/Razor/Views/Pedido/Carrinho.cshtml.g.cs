#pragma checksum "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bb896a66a473e65d9ee1916b5ab86974891510d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrinho), @"mvc.1.0.view", @"/Views/Pedido/Carrinho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Carrinho.cshtml", typeof(AspNetCore.Views_Pedido_Carrinho))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb896a66a473e65d9ee1916b5ab86974891510d", @"/Views/Pedido/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5764b985c14b19f76680672d581de467d30433a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "buscaprodutos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/carrinho.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
  
    ViewData["Title"] = "Carrinho";

#line default
#line hidden
            BeginContext(67, 24, true);
            WriteLiteral("\n<h3>Meu Carrinho</h3>\n\n");
            EndContext();
            BeginContext(91, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb896a66a473e65d9ee1916b5ab86974891510d6052", async() => {
                BeginContext(133, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(141, 93, true);
            WriteLiteral("\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div class=\"pull-right\">\n            ");
            EndContext();
            BeginContext(234, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb896a66a473e65d9ee1916b5ab86974891510d7997", async() => {
                BeginContext(288, 48, true);
                WriteLiteral("\n                Adicionar Produtos\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(340, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(353, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb896a66a473e65d9ee1916b5ab86974891510d9506", async() => {
                BeginContext(402, 48, true);
                WriteLiteral("\n                Preencher Cadastro\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(454, 603, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<br />
<div class=""panel panel-default"">
    <div class=""panel-heading"">

        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">
");
            EndContext();
#line 45 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
         foreach (var item in Model.Itens)
        {

#line default
#line hidden
            BeginContext(1110, 53, true);
            WriteLiteral("            <div class=\"row row-center linha-produto\"");
            EndContext();
            BeginWriteAttribute("item-id", " item-id=\"", 1163, "\"", 1181, 1);
#line 47 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1173, item.Id, 1173, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1182, 94, true);
            WriteLiteral(">\n                <div class=\"col-md-3\">\n                    <img class=\"img-produto-carrinho\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1276, "\"", 1331, 3);
            WriteAttributeValue("", 1282, "/images/produtos/large_", 1282, 23, true);
#line 49 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1305, item.Produto.Codigo, 1305, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 1327, ".jpg", 1327, 4, true);
            EndWriteAttribute();
            BeginContext(1332, 65, true);
            WriteLiteral(" />\n                </div>\n                <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1399, 17, false);
#line 51 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                                  Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 60, true);
            WriteLiteral("</div>\n                <div class=\"col-md-2 text-center\">R$ ");
            EndContext();
            BeginContext(1479, 18, false);
#line 52 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                                                 Write(item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(1498, 479, true);
            WriteLiteral(@"</div>
                <div class=""col-md-2 text-center"">
                    <div class=""input-group"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default""
                                    onclick=""carrinho.clickDecremento(this)"">
                                <span class=""glyphicon-minus""></span>
                            </button>
                        </span>
                        <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1977, "\"", 2003, 1);
#line 61 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1985, item.Quantidade, 1985, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2004, 643, true);
            WriteLiteral(@"
                               class=""form-control text-center"" 
                               onblur=""carrinho.updateQuantidade(this)""/>
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default""
                                    onclick=""carrinho.clickIncremento(this)"">
                                <span class=""glyphicon-plus""></span>
                            </button>
                        </span>
                    </div>
                </div>
                <div class=""col-md-2"">
                    R$ <span class=""pull-right"" subtotal>
                        ");
            EndContext();
            BeginContext(2649, 36, false);
#line 74 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                    Write(item.Quantidade * item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(2686, 71, true);
            WriteLiteral("\n                    </span>\n                </div>\n            </div>\n");
            EndContext();
#line 78 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"

        }

#line default
#line hidden
            BeginContext(2768, 168, true);
            WriteLiteral("\n    </div>\n    <div class=\"panel-footer\">\n        <div class=\"row\">\n            <div class=\"col-md-10\">\n                <span numero-itens>\n                    Total: ");
            EndContext();
            BeginContext(2938, 19, false);
#line 86 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                       Write(Model.Itens.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2958, 183, true);
            WriteLiteral("\n                    itens\n                </span>\n            </div>\n            <div class=\"col-md-2\">\n                Total: R$ <span class=\"pull-right\" total>\n                    ");
            EndContext();
            BeginContext(3143, 11, false);
#line 92 "C:\Users\felip\Desktop\CURSOS ALURA\AspNetCore-parte4\CasaDoCodigo\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(3155, 169, true);
            WriteLiteral("\n                </span>\n            </div>\n        </div>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div class=\"pull-right\">\n            ");
            EndContext();
            BeginContext(3324, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb896a66a473e65d9ee1916b5ab86974891510d17626", async() => {
                BeginContext(3378, 48, true);
                WriteLiteral("\n                Adicionar Produtos\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3430, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(3443, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb896a66a473e65d9ee1916b5ab86974891510d19139", async() => {
                BeginContext(3492, 48, true);
                WriteLiteral("\n                Preencher Cadastro\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3544, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3597, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3602, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb896a66a473e65d9ee1916b5ab86974891510d20854", async() => {
                    BeginContext(3633, 6, true);
                    WriteLiteral("\n\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3648, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
