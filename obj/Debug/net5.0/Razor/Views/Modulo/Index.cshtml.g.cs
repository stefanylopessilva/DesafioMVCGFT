#pragma checksum "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d945b6e9e15154dbf013998a3d9ec2bd27fc4c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Modulo_Index), @"mvc.1.0.view", @"/Views/Modulo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d945b6e9e15154dbf013998a3d9ec2bd27fc4c1", @"/Views/Modulo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1afe0c3e9d5de2db4020a72383e1fcda423181", @"/Views/_ViewImports.cshtml")]
    public class Views_Modulo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleStarter.Models.Modulo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoModulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aps-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Modulo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml"
  
    Layout = "_LayoutMenuLateral";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"d-flex justify-content-center\">\n    <div class=\"card\" style=\"width: auto;\">\n        <div class=\"card-body\">\n            <img src=\"/images/MODULOS.png\" alt=\"logo-MODULOS\" width=\"200\" border=\"0\">\n            <hr>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d945b6e9e15154dbf013998a3d9ec2bd27fc4c14637", async() => {
                WriteLiteral("Inserir novo Módulo");
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
                    $('#modulos').DataTable({
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

            <table id=""modulos"" class=""table table-striped table-bordered"">
                <thead>
     ");
            WriteLiteral("               <tr>\n                        <th>Nome</th>\n                        <th>Projeto</th>\n                        <th>Ações</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 44 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml"
                     foreach (var modulo in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 47 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml"
                           Write(modulo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 48 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml"
                           Write(modulo.Projeto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1962, "\"", 1999, 2);
            WriteAttributeValue("", 1969, "Modulo/EditarModulo/", 1969, 20, true);
#nullable restore
#line 50 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml"
WriteAttributeValue("", 1989, modulo.Id, 1989, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> \n                                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 2078, "\"", 2110, 2);
            WriteAttributeValue("", 2085, "/Modulo/Apagar/", 2085, 15, true);
#nullable restore
#line 51 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml"
WriteAttributeValue("", 2100, modulo.Id, 2100, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Apagar</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 54 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Modulo\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleStarter.Models.Modulo>> Html { get; private set; }
    }
}
#pragma warning restore 1591