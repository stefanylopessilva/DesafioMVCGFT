#pragma checksum "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92932c9a53214eabab4cbe44248bf40440a8de16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tecnologia_Index), @"mvc.1.0.view", @"/Views/Tecnologia/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92932c9a53214eabab4cbe44248bf40440a8de16", @"/Views/Tecnologia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1afe0c3e9d5de2db4020a72383e1fcda423181", @"/Views/_ViewImports.cshtml")]
    public class Views_Tecnologia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleStarter.Models.Tecnologia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaTecnologia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aps-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Tecnologia"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml"
  
    Layout = "_LayoutMenuLateral";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"d-flex justify-content-center\">\n    <div class=\"card\" style=\"width: auto;\">\n        <div class=\"card-body\">\n            <img src=\"/images/TECNOLOGIAS.png\" alt=\"logo-TECNOLOGIAS\" width=\"200\" border=\"0\">\n            <hr>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92932c9a53214eabab4cbe44248bf40440a8de164681", async() => {
                WriteLiteral("Inserir nova Tecnologia");
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
                    $('#tecnologias').DataTable({
                        ""info"": false,
                        ""search"": false,
                        ""language"": {
                            ""lenghtMenu"" : ""Mostrando _MENU_ registros"",
                            ""zeroRecords"": ""Desculpe, nada foi encontrado"",
                            ""info"": ""Mostando p??gina _PAGE_ de _PAGES_"",
                            ""infoEmpty"": ""Nenhum registro dispon??vel"",
                            ""paginate"": {
                                ""first"":    ""Primeiro"",
                                ""last"":     ""??ltimo"",
                                ""next"":     ""Pr??ximo"",
                                ""previous"": ""Anterior""
                            }
                        }
                    });
            });
            </script>

            <table id=""tecnologias"" class=""table table-striped table-bordered"">
                <thead");
            WriteLiteral(">\n                    <tr>\n                        <th>Nome</th>\n                        <th>Descri????o</th>\n                        <th>A????es</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 44 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml"
                     foreach (var tecnologia in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 47 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml"
                           Write(tecnologia.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 48 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml"
                           Write(tecnologia.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2058, 2);
            WriteAttributeValue("", 2016, "Tecnologia/EditarTecnologia/", 2016, 28, true);
#nullable restore
#line 50 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml"
WriteAttributeValue("", 2044, tecnologia.Id, 2044, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> \n                                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 2137, "\"", 2177, 2);
            WriteAttributeValue("", 2144, "/Tecnologia/Apagar/", 2144, 19, true);
#nullable restore
#line 51 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml"
WriteAttributeValue("", 2163, tecnologia.Id, 2163, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Apagar</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 54 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Tecnologia\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleStarter.Models.Tecnologia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
