#pragma checksum "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "246557b4db8f25e3d65ef72ce0341a47d520fce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 1 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
using EX2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246557b4db8f25e3d65ef72ce0341a47d520fce9", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
  
    Layout = "Masterpage";
    ViewBag.Title = "Lista de Usuarios";

#line default
#line hidden
            BeginContext(98, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(103, 20, false);
#line 7 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
Write(TempData["mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 262, true);
            WriteLiteral(@"</h2>
<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Email</th>
            <th>Senha</th>
            <th>Data de Nascimento</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
     foreach (var item in ViewData["usuarios"] as List<UsuarioModel>) {

#line default
#line hidden
            BeginContext(458, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(489, 7, false);
#line 22 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(496, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(520, 9, false);
#line 23 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(529, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(553, 10, false);
#line 24 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(563, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(587, 10, false);
#line 25 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
           Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(597, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(621, 39, false);
#line 26 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
           Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(660, 43, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 703, "\"", 737, 2);
            WriteAttributeValue("", 710, "/Usuario/Editar?id=", 710, 19, true);
#line 28 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 729, item.Id, 729, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(738, 88, true);
            WriteLiteral(">Editar</a>\r\n                <a href=\"#\">Excluir</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "C:\Users\43127523890\Documents\WEBMVC\EX2\Views\Usuario\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(833, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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