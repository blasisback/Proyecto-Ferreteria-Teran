#pragma checksum "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d93f0f0dcbe95993eebceef9424a519b1287a21f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_ReporteCategoria), @"mvc.1.0.view", @"/Views/Categorias/ReporteCategoria.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d93f0f0dcbe95993eebceef9424a519b1287a21f", @"/Views/Categorias/ReporteCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf47935cb244184506c8032d185b186e0f196d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_ReporteCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp_BotoneraLozanoSAC.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
  
    ViewData["Title"] = "ReporteCategoria";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ReporteCategoria</h1>
 <div class=""row mb-2"">
                    <div class=""col-sm-12"">
                        <button class=""btn btn-info float-left"" onclick=""printData()"">
                            <i class=""fas fa-print""></i> Imprimir
                        </button>
                    </div>
                </div>
<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d93f0f0dcbe95993eebceef9424a519b1287a21f4258", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table  id=\"tbdata\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
           Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
           Write(Html.DisplayFor(modelItem => item.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n          \r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Categorias\ReporteCategoria.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
function printData() {


    var divToPrint = document.getElementById(""tbdata"" );

    var style = ""<style>"";
    style= style +""table{ background-color:green}"";
    style = style + ""table {width: 100%;font: 17px Calibri;}"";
    style = style + ""table, th, td {border: solid 1px #DDD; border-collapse: collapse;"";
    style = style + ""padding: 2px 3px;text-align: center;}"";
    style = style + ""</style>"";

    newWin = window.open("""");


    newWin.document.write(style);
    newWin.document.write(""<h3>Reporte de Categoria por tienda</h3>"");
    newWin.document.write(divToPrint.outerHTML);
    newWin.print();
    newWin.close();
}
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp_BotoneraLozanoSAC.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591