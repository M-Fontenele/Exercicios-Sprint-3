#pragma checksum "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e83dc54d6ef02e0963945293ded5373bbb9481ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83dc54d6ef02e0963945293ded5373bbb9481ac", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 48, true);
            WriteLiteral("<main>\n        <h2>Pede aí, jovem!</h2>\n        ");
            EndContext();
            BeginContext(95, 2127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83dc54d6ef02e0963945293ded5373bbb9481ac4162", async() => {
                BeginContext(158, 183, true);
                WriteLiteral("\n            <div>\n                <label for=\"nome\">Nome Completo</label>\n                <br />\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 341, "", 367, 1);
#line 8 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 348, Model.Cliente.Nome, 348, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(367, 213, true);
                WriteLiteral(" />\n            </div>\n\n            <div>\n                <label for=\"endereco\">Endereço</label>\n                <br />\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"endereco\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 580, "", 610, 1);
#line 14 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 587, Model.Cliente.Endereco, 587, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(610, 225, true);
                WriteLiteral(" />\n            </div>\n\n            <div>\n                <label for=\"telefone\">Telefone para contato</label>\n                <br />\n                <input id=\"telefone\" type=\"text\" placeholder=\"11 12345 6789\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 835, "", 865, 1);
#line 20 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 842, Model.Cliente.Telefone, 842, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(865, 174, true);
                WriteLiteral(" />\n            </div>\n\n            <div>\n                <label for=\"email\">E-mail</label>\n                <br />\n                <input id=\"email\" type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1039, "", 1066, 1);
#line 26 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1046, Model.Cliente.Email, 1046, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1066, 244, true);
                WriteLiteral(" />\n            </div>\n\n            <div class=\"double-field\">\n                <div>\n                    <label for=\"hamburguer\">Hamburguer</label>\n                    <select id=\"hamburguer\" name=\"hamburguer\" required>\n                        ");
                EndContext();
                BeginContext(1310, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83dc54d6ef02e0963945293ded5373bbb9481ac7377", async() => {
                    BeginContext(1345, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1363, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 34 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                         foreach (var hamburguer in Model.Hamburgueres)
                        {

#line default
#line hidden
                BeginContext(1462, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1490, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83dc54d6ef02e0963945293ded5373bbb9481ac9860", async() => {
                    BeginContext(1524, 15, false);
#line 36 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                        Write(hamburguer.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1539, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1545, 16, false);
#line 36 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                                             Write(hamburguer.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                               WriteLiteral(hamburguer.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1570, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 37 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"

                        }

#line default
#line hidden
                BeginContext(1598, 214, true);
                WriteLiteral("                    </select>\n                </div>\n                <div>\n                    <label for=\"shake\">Shake</label>\n                    <select id=\"shake\" name=\"shake\" required>\n                        ");
                EndContext();
                BeginContext(1812, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83dc54d6ef02e0963945293ded5373bbb9481ac12889", async() => {
                    BeginContext(1847, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1865, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 45 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                         foreach (var shake in Model.Shakes)
                        {

#line default
#line hidden
                BeginContext(1953, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1981, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83dc54d6ef02e0963945293ded5373bbb9481ac15362", async() => {
                    BeginContext(2010, 10, false);
#line 47 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                   Write(shake.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2020, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2026, 11, false);
#line 47 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                                   Write(shake.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                               WriteLiteral(shake.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2046, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 48 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2073, 142, true);
                WriteLiteral("                    </select>\n                </div>\n            </div>\n            <input type=\"submit\" value=\"Finalizar pedido!\" />\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 4 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\McBonaldsMVC\Views\Pedido\Index.cshtml"
AddHtmlAttributeValue("", 123, Url.Action("Registrar","Pedido"), 123, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2222, 13, true);
            WriteLiteral("\n\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
