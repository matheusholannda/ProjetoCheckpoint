#pragma checksum "C:\Users\35711103822\Desktop\Projeto Check Point\Views\Pages\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd24ed1c29f3c21883a90c0a1f5278dfa197f354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Faq), @"mvc.1.0.view", @"/Views/Pages/Faq.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pages/Faq.cshtml", typeof(AspNetCore.Views_Pages_Faq))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd24ed1c29f3c21883a90c0a1f5278dfa197f354", @"/Views/Pages/Faq.cshtml")]
    public class Views_Pages_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\35711103822\Desktop\Projeto Check Point\Views\Pages\Faq.cshtml"
   Layout = "MasterPageDeslogado"; 

#line default
#line hidden
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(58, 52, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/faq.css\"> \r\n");
                EndContext();
            }
            );
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(115, 1826, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f9ce4c841f34403bb637a7be66b1c41", async() => {
                BeginContext(121, 1813, true);
                WriteLiteral(@"
    <main>
        <section id=""faq"">
            <h1>Perguntas Frequentes</h1>
            <div class=""quest"">
                <ul>
                    <li>
                        Pergunta 1
                        <div>
                            <span>Resposta 1</span>
                        </div>
                    </li>
                    <li>
                        Pergunta 2
                        <div>
                            <span>Resposta 2</span>
                        </div>
                    </li>
                    <li>
                        Pergunta 3
                        <div>
                            <span>Resposta 3</span>
                        </div>
                    </li>
                    <li>
                        Pergunta 4
                        <div>
                            <span>Resposta 4</span>
                        </div>
                    </li>
                </ul>
            </div>
            <span cla");
                WriteLiteral(@"ss=""endereco"">Alameda Barão de Limeira, 539</span>
        </section>
    </main>
    <footer>
        <div id=""plus"">
            <div class=""contain"">
                <h2>Não foi útil?</h2>
                <br>
                <br>
                <textarea></textarea>
                <div id=""btn"">
                    <div class=""btn"">Enviar</div>
                </div>
            </div>
            <div class=""img2"">
                <img src=""/imagens/icones/tel.png"" alt="""">
            </div>
        </div>
    </footer>
    </div>
    </div>
    <div id=""chat"">
        <div class=""chat"">
            <p>Fale Conosco</p>
        </div>
        <div class=""cx"">
            <img src=""/imagens/icones/chat.png"" alt=""Chat"">
        </div>
    </div>
");
                EndContext();
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
