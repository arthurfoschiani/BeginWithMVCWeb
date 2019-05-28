#pragma checksum "c:\Users\cesar.felipe\Documents\aulas-senai\curso_tecnico\1s2019-T1\C#\TURMAS\Hamburgueria_Manha\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7911b19e5fb5e805413814e700f6592baf44e17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "c:\Users\cesar.felipe\Documents\aulas-senai\curso_tecnico\1s2019-T1\C#\TURMAS\Hamburgueria_Manha\Views\_ViewImports.cshtml"
using Hamburgueria_Manha;

#line default
#line hidden
#line 2 "c:\Users\cesar.felipe\Documents\aulas-senai\curso_tecnico\1s2019-T1\C#\TURMAS\Hamburgueria_Manha\Views\_ViewImports.cshtml"
using Hamburgueria_Manha.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7911b19e5fb5e805413814e700f6592baf44e17", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de7fa908a568c51a60502d109ce07fc8c93150c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 2 "c:\Users\cesar.felipe\Documents\aulas-senai\curso_tecnico\1s2019-T1\C#\TURMAS\Hamburgueria_Manha\Views\Home\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(71, 3996, true);
            WriteLiteral(@"    <div id=""logo_area"">
        <img src=""img/logotipo_mcbonalds.png"" alt=""Logotipo do McBonalds muito legal"" title=""logo"" />

        <hgroup>
            <h1>McBonald's</h1>
            <h2>O melhor hamburguer do Universo</h2>
        </hgroup>
    </div>
    
</header>
<main>
    <section id=""banner"">
        <div class=""section-container"">
            <p>Peça o seu
                <br />
                <strong class=""banner_destaque"">FURIOSO!</strong>
                <br />
                <span class=""up-text"">por apenas</span>
                <strong class=""banner_destaque preco"">R$9,99</strong>
            </p>
            <div class=""filler""></div>
            <img src=""img/furioso_banner.jpg"" alt=""Foto do Hamburguer Furioso"" title=""FURIOSO!"" />
        </div>
    </section>

    <section id=""hamburgueres"">
        <div class=""section-container"">
            <h2>Hamburgueres</h2>
            <div class=""flex-group food-section"">
                <div>
                   ");
            WriteLiteral(@" <img src=""img/hamburguer_black.jpg"" alt=""Foto do Hamburguer Emo"" title=""Gótico Suave"" />
                    <p>R$12,99</p>
                    <p>Black Burguer</p>
                </div>
                <div>
                    <img src=""img/hamburguer_combo.jpg"" alt=""Foto do nosso combo"" title=""Super combo!"" />
                    <p>R$19,99</p>
                    <p>Combo da Hora</p>
                </div>
                <div>
                    <img src=""img/hamburguer_vegan.jpg"" alt=""Foto do Hamburguer Vegano"" title=""Não é hamburguer!"" />
                    <p>R$10,99</p>
                    <p>Vegeburguer</p>
                </div>
            </div>
            <a href=""hamburgueres.html"">Clique aqui para ver todos!</a>
        </div>
    </section>

    <section id=""shakes"">
        <div class=""section-container"">
            <h2>Shakes</h2>

            <div class=""flex-group food-section"">
                <div>
                    <img src=""img/shake_biscoito.jpg"" alt=");
            WriteLiteral(@"""Foto do Milkshake sabor Biscoito ou Bolacha?""
                        title=""Biscoito ou Bolacha?"" />
                    <p>R$7,99</p>
                    <p>Biscoito</p>
                </div>
                <div>
                    <img src=""img/shake_chocolate.jpg"" alt=""Foto do Milkshake de chocolate, dur""
                        title=""Nada de novo debaixo do Sol"" />
                    <p>R$8,99</p>
                    <p>Chocolate</p>
                </div>
                <div>
                    <img src=""img/shake_morango.jpg"" alt=""Foto do Milkshake de morando, que não pode faltar!""
                        title=""Mais um clichê"" />
                    <p>R$9,99</p>
                    <p>Morango</p>
                </div>
            </div>
            <a>Clique aqui para ver todos!</a>
        </div>
    </section>

    <section id=""historia"">
        <div class=""section-container"">
            <div class=""flex-group"">
                <h2>Nossa <br /> História</h2>
   ");
            WriteLiteral(@"             <p>Nascida da ousada ideia dos dois fundadores Carlos Tsukamoto e Cesar Sportore, desde 2012, a
                    Hamburgueria
                    McBonald's vem oferecendo os melhores lanches pelos menores preços!</p>
            </div>
            <a href=""#"">Conte-me mais!</a>
        </div>
    </section>

    <section id=""local"">
        <div class=""section-container"">
            <iframe
                src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
                width=""1366"" height=""450"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
        </div>
    </section>
</main>");
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
