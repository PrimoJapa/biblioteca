#pragma checksum "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8ab617b7bf962ad417afddc0c3da66360a93b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ab617b7bf962ad417afddc0c3da66360a93b5e", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formAlign"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empr??stimos";
    string Classe = "";

    int FiltroPorPag = Int32.Parse(ViewData["emprestimosPorPagina"].ToString());
    int PaginaAtual = Int32.Parse(ViewData["PaginaAtual"].ToString());
    
    int NumEmprestimosPorPag = (Model.Count < FiltroPorPag ? Model.Count : FiltroPorPag);
    int NumTotalDePag = 0;
    if (NumEmprestimosPorPag > 0)
    {
        NumTotalDePag = Model.Count / NumEmprestimosPorPag + (Model.Count % NumEmprestimosPorPag == 0 ? 0 : 1);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .formAlign {\r\n        display: flex;\r\n    }\r\n</style>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div id=\"SeletorPaginas\" class=\"text-right\">\r\n");
#nullable restore
#line 26 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
              if (Model.Count > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"lead\">P??gina:</span>\r\n");
#nullable restore
#line 28 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
             for (int i = 1; i <= NumTotalDePag; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 927, "\"", 969, 2);
            WriteAttributeValue("", 934, "/Emprestimo/Listagem?PaginaAtual=", 934, 33, true);
#nullable restore
#line 31 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 967, i, 967, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" role=\"button\">");
#nullable restore
#line 31 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </span>\r\n");
#nullable restore
#line 33 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
             }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("              <thead>\r\n                <tr>\r\n                   <th></th>\r\n                </tr>\r\n              </thead>\r\n");
#nullable restore
#line 39 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e9524", async() => {
                WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <select name=\"TipoFiltro\" class=\"form-control\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e9908", async() => {
                    WriteLiteral("Usu??rio");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e11148", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
        </div>
        <div>
            <select name=""itensPorPagina"" id=""itensPorPagina"" class=""form-control""> 
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e12696", async() => {
                    WriteLiteral("10 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e13939", async() => {
                    WriteLiteral("20 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e15182", async() => {
                    WriteLiteral("30 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e16425", async() => {
                    WriteLiteral("50 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ab617b7bf962ad417afddc0c3da66360a93b5e17668", async() => {
                    WriteLiteral("Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary mb-2\" style=\"margin-left: 10px;\">Pesquisar</button>\r\n");
#nullable restore
#line 61 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
          if (Model.Count > 0) {
        
        }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("             <a class=\"btn btn-outline-success mb-2\" style=\"margin-left: 10px;\" href=\"/Emprestimo/Cadastro\">Cadastrar Emprestimo</a>\r\n");
#nullable restore
#line 65 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <table class=\"table table-striped\"> \r\n");
#nullable restore
#line 73 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
             if (Model.Count > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">Id</th>
                        <th scope=""col"">Usuario</th>
                        <th scope=""col"">Data Empr??stimo</th>
                        <th scope=""col"">Data Devolu????o</th>
                        <th scope=""col"">Livro</th>
                        <th scope=""col"">Autor</th>
                        <th scope=""col"">Devolvido</th>
                        <th scope=""col"">A????o</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 87 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     for(int i = (PaginaAtual - 1) * NumEmprestimosPorPag; i < (NumEmprestimosPorPag * PaginaAtual < Model.Count ? NumEmprestimosPorPag * PaginaAtual : Model.Count); i++) {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                         if((System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao) > 0)){
                            Classe = "bg-danger text-white font-weight-bold";

                            if(Model[i].Devolvido == true) {
                                Classe = "bg-light text-dark";
                            } else {
                                Classe = "bg-danger text-white font-weight-bold";
                            }

                        } else {
                            Classe = "";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3956, "\"", 3971, 1);
#nullable restore
#line 100 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3964, Classe, 3964, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td class=\"font-weight-bold\">");
#nullable restore
#line 101 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                    Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 102 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 103 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 104 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 105 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 106 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 108 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if (@Model[i].Devolvido == true && (System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao)) < 0 ||@Model[i].Devolvido == true && (System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao)) == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-success font-weight-bold\">Devolvido</p> \r\n");
#nullable restore
#line 111 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                } 

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if(@Model[i].Devolvido == true && (System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao)) > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-warning font-weight-bold\">Devolvido com Atraso</p>\r\n");
#nullable restore
#line 114 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                } 

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if(Model[i].Devolvido == false && (System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao)) < 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-info font-weight-bold\">Em espera</p>\r\n");
#nullable restore
#line 117 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if(Model[i].Devolvido == false && (System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao)) > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"font-weight-bold\">Pendente</p>\r\n");
#nullable restore
#line 120 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 5735, "\"", 5773, 2);
            WriteAttributeValue("", 5742, "/Emprestimo/Edicao/", 5742, 19, true);
#nullable restore
#line 122 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 5761, Model[i].Id, 5761, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 124 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n");
#nullable restore
#line 126 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <thead>\r\n                    <tr>\r\n                        <th>Empr??stimo n??o encontrado! Revise o filtro.</th>\r\n                    </tr>\r\n                </thead>\r\n");
#nullable restore
#line 134 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"SeletorPaginas\" class=\"text-center\">\r\n");
#nullable restore
#line 140 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
     if (Model.Count > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"lead\">P??gina:</span>\r\n");
#nullable restore
#line 142 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
     for (int i = 1; i <= NumTotalDePag; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 6380, "\"", 6422, 2);
            WriteAttributeValue("", 6387, "/Emprestimo/Listagem?PaginaAtual=", 6387, 33, true);
#nullable restore
#line 145 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 6420, i, 6420, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" role=\"button\">");
#nullable restore
#line 145 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </span>\r\n");
#nullable restore
#line 147 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
     }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <thead>\r\n          <tr>\r\n            <th></th>\r\n          </tr>\r\n        </thead>\r\n");
#nullable restore
#line 153 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Emprestimo\Listagem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
