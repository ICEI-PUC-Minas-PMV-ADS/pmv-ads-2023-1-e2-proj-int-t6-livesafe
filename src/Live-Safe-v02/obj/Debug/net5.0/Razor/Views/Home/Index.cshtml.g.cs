#pragma checksum "C:\Users\Felipe\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-livesafe\src\Live-Safe-v02\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d394f1f4a8877378c158a5407c5c601a73a0a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Felipe\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-livesafe\src\Live-Safe-v02\Views\_ViewImports.cshtml"
using Live_Safe_v02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felipe\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-livesafe\src\Live-Safe-v02\Views\_ViewImports.cshtml"
using Live_Safe_v02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d394f1f4a8877378c158a5407c5c601a73a0a3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c78ef4a9e97f120c362c0889a75de6ad333e3c12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulário"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formulário-pesquisa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Felipe\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-livesafe\src\Live-Safe-v02\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d394f1f4a8877378c158a5407c5c601a73a0a34418", async() => {
                WriteLiteral(@"
    <main>
        <div class=""caixa-pesquisa"">
            <h1 class=""título"" id=""título-principal"">Segurança para todos</h1>
            <h2 class=""subtitulo"" id=""subtitulo-principal"">Verifique se seu e-mail ou telefone foi vazado</h2>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d394f1f4a8877378c158a5407c5c601a73a0a34939", async() => {
                    WriteLiteral("\r\n                <input type=\"text\" id=\"pesquisa-campo\" name=\"pesquisa\" placeholder=\"E-mail, telefone e CPF\">\r\n                <button id=\"submit-pesquisa\">Verificar</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div id=""resultado"">
                <div id=""resLeak"" class=""container""></div>
                <div id=""resOk"" class=""container""></div>
                <div id=""no-input"" class=""container""></div>
            </div>
        </div>
        <div id=""dicas"" class=""caixa-pesquisa div-video"">
            <section class=""section-video"">
                <h2 class=""título titulo-video"">Dicas de segurança</h2>
                <iframe class=""Video"" width=360"" height=""615"" src=""https://www.youtube.com/embed/QFdkggG34wo""
                        title=""YouTube video player"" frameborder=""0""
                        allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture""
                        allowfullscreen></iframe>
            </section>
            <section class=""section-list"">
                <h2 id=""subtitulo-Lista-de-dicas"" class=""título"">Como proteger senhas nas redes sociais</h2>
                <ol class=""Lista-de-dicas"">
                   ");
                WriteLiteral(@" <li class=""Lista-de-dicas-item"">✔ Instale um antivirus deixe sempre atualizado</li>
                    <li class=""Lista-de-dicas-item"">
                        ✔ Configure opções de privacidade com poucas informações visiveis para pessoas que você não conhece
                    </li>
                    <li class=""Lista-de-dicas-item"">✔ Não preencha formularia com premios e dinheiro em troca de informações</li>
                    <li class=""Lista-de-dicas-item"">
                        ✔ Quando abrir um link em rede social, verifique que o dominio está correto, e não uma pagina falsa
                    </li>
                    <li class=""Lista-de-dicas-item"">✔ Não seguir pessoas desconhecidas e aceitar pessoas desconhecidas nas redes sociais</li>
                    <li class=""Lista-de-dicas-item"">✔ Use senhas seguras com combinações de letras maiusculas e minusculas, caracteres e números</li>
                    <li class=""Lista-de-dicas-item"">✔ Busque nas redes sociais informações sobre arqu");
                WriteLiteral("ivos que considere suspeito</li>\r\n                </ol>\r\n            </section>\r\n        </div>\r\n    </main>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
