#pragma checksum "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45e108507f3d6998b498867f3c0b7616eeab2b23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Details), @"mvc.1.0.view", @"/Views/Usuarios/Details.cshtml")]
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
#line 1 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\_ViewImports.cshtml"
using WebApp_BotoneraLozanoSAC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\_ViewImports.cshtml"
using WebApp_BotoneraLozanoSAC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e108507f3d6998b498867f3c0b7616eeab2b23", @"/Views/Usuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf47935cb244184506c8032d185b186e0f196d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp_BotoneraLozanoSAC.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
  
    ViewData["Title"] = "Detalle_Usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e108507f3d6998b498867f3c0b7616eeab2b233959", async() => {
                WriteLiteral("\r\n\r\n<br />\r\n\r\n\r\n<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">Mantenimiento</li>\r\n        <li class=\"breadcrumb-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e108507f3d6998b498867f3c0b7616eeab2b234405", async() => {
                    WriteLiteral("Usuarios");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
        <li class=""breadcrumb-item""><a href=""#"">Detalles </a></li>
    </ol>
</nav>


 <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-header bg-success text-white"">
                    Detalles del Usuario
                </div>

                <div class=""card-body"">

<div>
    
    <dl class=""row justify-content-center"">
        <dt class=""col-sm-4 text-center text-dark bg-warning"">
            ");
#nullable restore
#line 34 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 37 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            ");
#nullable restore
#line 40 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 43 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            ");
#nullable restore
#line 46 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 49 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Correo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            ");
#nullable restore
#line 52 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Clave));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 55 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Clave));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            Estado\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 61 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Activo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            Tipo de Documento\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 68 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoDocumento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            Numero Documento\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 74 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroDocumento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            ");
#nullable restore
#line 77 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 80 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            ");
#nullable restore
#line 83 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 86 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt class=\"col-sm-4 text-center text-dark bg-warning\">\r\n            Rol\r\n        </dt>\r\n        <dd class=\"col-sm-5 text-secondary\">\r\n            ");
#nullable restore
#line 93 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdRolNavigation.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp_BotoneraLozanoSAC.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
