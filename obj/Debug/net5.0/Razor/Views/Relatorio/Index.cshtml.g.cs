#pragma checksum "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Relatorio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "181b2ec1b5b15dded5da0822d36e46e4d0ae4fbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorio_Index), @"mvc.1.0.view", @"/Views/Relatorio/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181b2ec1b5b15dded5da0822d36e46e4d0ae4fbe", @"/Views/Relatorio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1afe0c3e9d5de2db4020a72383e1fcda423181", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\monte\Downloads\Arquivos Stefany\desafiomvc-master\Views\Relatorio\Index.cshtml"
  
    Layout = "_LayoutMenuLateral";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-center"">
    <div class=""card"" style=""width: auto;"">
        <div class=""card-body"">
            <img src=""/images/RELATORIOS.jpg"" alt=""logo-RELATORIOS"" width=""300"" border=""0"">
        </div>
    </div>
</div> 
<br>
<div class=""d-flex justify-content-center"">
  <div class=""col-sm-2"">
    <div class=""card"" style=""width: auto;"">
        <img src=""/images/Relatorios1.png"" alt=""computador com relat??rios"" max-width=""100%"" max-height=""100%"" border=""0"">
      <div class=""card-body"">
        <p class=""card-title"">Para gerar uma lista de Starters de acordo com a Turma, clique no bot??o abaixo.</p>
        <div class=""d-flex justify-content-center"">
          <a class=""btn btn-primary"" href=""../Relatorio/SelecionaTurma"" id=""popular-banco"">Lista de Starters por Turma</a>
        </div>
      </div>
    </div>
  </div>
  <div class=""col-sm-2"">
    <div class=""card"" style=""width: auto;"">
        <img src=""/images/Relatorios2.png"" alt=""relat??rio amplicado com lupa"" max-width=""100%"" max-he");
            WriteLiteral(@"ight=""100%"" border=""0"">
      <div class=""card-body"">
        <p class=""card-title"">Para gerar uma lista de avalia????os dos projetos por Starter, clique no bot??o abaixo.</p>
        <div class=""d-flex justify-content-center"">
          <a class=""btn btn-primary"" href=""../Relatorio/SelecionaStarter"" id=""popular-banco"">Avalia????os dos projetos por Starter</a>
        </div>
      </div>
    </div>
  </div>
</div>");
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
