#pragma checksum "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39fb4ecd7fddf10fe71f850033c5ed2ae03438ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projeto_Index), @"mvc.1.0.view", @"/Views/Projeto/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\_ViewImports.cshtml"
using ControleStarter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\_ViewImports.cshtml"
using ControleStarter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39fb4ecd7fddf10fe71f850033c5ed2ae03438ef", @"/Views/Projeto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1afe0c3e9d5de2db4020a72383e1fcda423181", @"/Views/_ViewImports.cshtml")]
    public class Views_Projeto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleStarter.Models.Projeto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoProjeto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aps-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Projeto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
  
    Layout = "_LayoutMenuLateral";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"d-flex justify-content-center\">\n    <div class=\"card\" style=\"width: auto;\">\n        <div class=\"card-body\">\n            <img src=\"/images/AVALIACAO.png\" alt=\"logo-AVALIACAO\" width=\"200\" border=\"0\">\n            <hr>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39fb4ecd7fddf10fe71f850033c5ed2ae03438ef4650", async() => {
                WriteLiteral("Inserir novo Projeto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<br><br>

            <script>
                $(document).ready( function () {
                    $('#projetos').DataTable({
                        ""info"": false,
                        ""search"": false,
                        ""language"": {
                            ""lenghtMenu"" : ""Mostrando _MENU_ registros"",
                            ""zeroRecords"": ""Desculpe, nada foi encontrado"",
                            ""info"": ""Mostando página _PAGE_ de _PAGES_"",
                            ""infoEmpty"": ""Nenhum registro disponível"",
                            ""paginate"": {
                                ""first"":    ""Primeiro"",
                                ""last"":     ""Último"",
                                ""next"":     ""Próximo"",
                                ""previous"": ""Anterior""
                            }
                        }
                    });
            } );
            </script>

            <table id=""projetos"" class=""table table-striped table-bordered"">
                <thead>
   ");
            WriteLiteral(@"                 <tr>
                        <th>Nome do Starter</th>
                        <th>Módulo</th>
                        <th>Avaliação</th>
                        <th>Ações</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 45 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
                     foreach (var projeto in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 48 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
                           Write(projeto.Starter.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 49 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
                           Write(projeto.Modulo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 50 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
                           Write(projeto.Avaliacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 2096, "\"", 2136, 2);
            WriteAttributeValue("", 2103, "Projeto/EditarProjeto/", 2103, 22, true);
#nullable restore
#line 52 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
WriteAttributeValue("", 2125, projeto.Id, 2125, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> \n                                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 2215, "\"", 2249, 2);
            WriteAttributeValue("", 2222, "/Projeto/Apagar/", 2222, 16, true);
#nullable restore
#line 53 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
WriteAttributeValue("", 2238, projeto.Id, 2238, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Apagar</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 56 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Projeto\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleStarter.Models.Projeto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
