#pragma checksum "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7d4d46df9e7ecdf0c72cf5cf3c5ee10a78d8f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7d4d46df9e7ecdf0c72cf5cf3c5ee10a78d8f7", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""text-center"">Usuários cadastrados no sistema</h1>

<table class=""table"">
  <thead class=""thead-light"">
    <tr>
      <th scope=""col"">Nome</th>
      <th scope=""col"">Login</th>
      <th scope=""col"">Tipo</th>
      <th scope=""col"">Ações</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 15 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
     foreach (Usuario u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr scope=\"row\">\r\n        <td>");
#nullable restore
#line 18 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
       Write(u.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
       Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
         if(u.Tipo == Usuario.ADMIN) {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>Administrador</td>\r\n");
#nullable restore
#line 23 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>Padrão</td>\r\n");
#nullable restore
#line 25 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <td>\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 606, "\"", 635, 2);
            WriteAttributeValue("", 613, "EditarUsuario?Id=", 613, 17, true);
#nullable restore
#line 28 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 630, u.Id, 630, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">EDITAR</a>\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 715, 2);
            WriteAttributeValue("", 692, "ExcluirUsuario?id=", 692, 18, true);
#nullable restore
#line 29 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 710, u.Id, 710, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">EXCLUIR</a>\r\n        </td>\r\n      </tr>    \r\n");
#nullable restore
#line 32 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\UC07\ATIVIDADE 02\UC07_ATV02-HIROSHI IASSUNICHI\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n<a href=\"/Usuario/RegistrarUsuario\" class=\"btn btn-secondary\">Registrar Novo Usuário</a> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
