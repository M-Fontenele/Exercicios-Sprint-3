#pragma checksum "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78f188f6ce7db5747fb9dc1890806a3903526bb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Eventospublicos), @"mvc.1.0.view", @"/Views/Home/Eventospublicos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Eventospublicos.cshtml", typeof(AspNetCore.Views_Home_Eventospublicos))]
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
#line 1 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\_ViewImports.cshtml"
using RoleTop;

#line default
#line hidden
#line 2 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\_ViewImports.cshtml"
using RoleTop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78f188f6ce7db5747fb9dc1890806a3903526bb5", @"/Views/Home/Eventospublicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Eventospublicos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 608, true);
            WriteLiteral(@"<main>
    <section id=""pedidos-table"">
                    <table>
                        <thead>
                            <tr>
                                <th>Nome do evento</th>
                                <th>Plano</th>
                                <th>Tipo</th>
                                <th>Dia</th>
                                <th>Descrição</th>
                                <th>Estado</th>
                            </tr>
                        </thead>
                        <tfoot>

                        </tfoot>
                        <tbody>
");
            EndContext();
#line 18 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                             foreach (var item in Model.Agendar)
                            {

#line default
#line hidden
            BeginContext(705, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(784, 17, false);
#line 21 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                   Write(item.NomeDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(801, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(849, 21, false);
#line 22 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                   Write(item.PlanoEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(870, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(918, 17, false);
#line 23 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                   Write(item.TipoDeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(935, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(983, 16, false);
#line 24 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                   Write(item.DiaDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(999, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1047, 20, false);
#line 25 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                   Write(item.DescricaoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 26 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                     if(item.Status == 0)
                                    {

#line default
#line hidden
            BeginContext(1172, 75, true);
            WriteLiteral("                                        <td class=\"amarelo\">Pendente</td>\r\n");
            EndContext();
#line 29 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1286, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 30 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                     if(item.Status == 1)
                                    {

#line default
#line hidden
            BeginContext(1384, 71, true);
            WriteLiteral("                                        <td class=\"verde\">Aceito</td>\r\n");
            EndContext();
#line 33 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1494, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 34 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                     if(item.Status == 2)
                                    {

#line default
#line hidden
            BeginContext(1592, 76, true);
            WriteLiteral("                                        <td class=\"vermelho\">Recusado</td>\r\n");
            EndContext();
#line 37 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1707, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 39 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Home\Eventospublicos.cshtml"
                            }

#line default
#line hidden
            BeginContext(1777, 71, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
