#pragma checksum "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e7f48259695e5971239d678152bc67474363bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo__Avaliacoes), @"mvc.1.0.view", @"/Views/Catalogo/_Avaliacoes.cshtml")]
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
#line 1 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\_ViewImports.cshtml"
using SkyCommerce.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\_ViewImports.cshtml"
using SkyCommerce.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e7f48259695e5971239d678152bc67474363bb", @"/Views/Catalogo/_Avaliacoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b28dd728e3ad0af0593557eebacddfc0f3674521", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo__Avaliacoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SkyCommerce.Models.Avaliacao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row review-item\">\n    <div class=\"col-lg-3 col-sm-3  left\">\n        <div class=\"review-item-user\">\n            <div class=\"review-item-user-profile\">\n                <img class=\"img-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 254, "\"", 260, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 261, "\"", 280, 1);
#nullable restore
#line 7 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
WriteAttributeValue("", 267, Model.Imagem, 267, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </div>\n            <div class=\"user-name\">\n                <p>");
#nullable restore
#line 10 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
              Write(Model.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                <small>");
#nullable restore
#line 11 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
                  Write(DateTime.Now.Subtract(Model.DataAvaliacao).Humanize());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </div>\n\n        </div>\n    </div>\n\n    <div class=\"col-lg-9  col-sm-9 right\">\n\n\n        <div class=\"rating commentRating\">\n            <p>\n");
#nullable restore
#line 22 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
                 for (int i = 0; i < Model.Nota; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span><i class=\"fa fa-star\"></i></span>\n");
#nullable restore
#line 25 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
                 for (var i = Model.Nota; i < 5; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span><i class=\"fa fa-star-o\"></i></span>\n");
#nullable restore
#line 29 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <span class=\"ratingInfo\">\n                    <span> / </span> <a data-target=\"#modal-review\" data-toggle=\"modal\"> ");
#nullable restore
#line 32 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
                                                                                    Write(Model.Nota.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n                </span>\n            </p>\n        </div>\n        <h5 class=\"reviewUserTitle\"><strong>");
#nullable restore
#line 36 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
                                       Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5>\n\n        <p class=\"commentText\">\n            ");
#nullable restore
#line 39 "P:\Projects\IdentityServer_4\SkyCommerce.Loja\SkyCommerce.Site\Views\Catalogo\_Avaliacoes.cshtml"
       Write(Model.Comentario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n\n\n    </div>\n\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkyCommerce.Models.Avaliacao> Html { get; private set; }
    }
}
#pragma warning restore 1591
