#pragma checksum "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39489004cde156b938586b1ce7f14989b068e261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kardexes_Index), @"mvc.1.0.view", @"/Views/Kardexes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39489004cde156b938586b1ce7f14989b068e261", @"/Views/Kardexes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf47935cb244184506c8032d185b186e0f196d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Kardexes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp_BotoneraLozanoSAC.Models.Kardex>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mr-auto p-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39489004cde156b938586b1ce7f14989b068e2614892", async() => {
                WriteLiteral(@"


    <br />
    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">Kardex</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Lista Kardex</li>
        </ol>
    </nav>


    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-header bg-dark text-white"">
                    Listado de Entradas y Salidas de Productos
                </div>
                <br />
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39489004cde156b938586b1ce7f14989b068e2615717", async() => {
                    WriteLiteral(@"

                    <div class=""text-center"">


                        <input class=""p-2 form-control col-4"" type=""text"" name=""EA"" value=""1"" hidden />

                        <input class=""btn btn-success col-4"" style=""height:100%;"" type=""submit"" value=""Entrada"" />
                    </div>


                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <p></p>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39489004cde156b938586b1ce7f14989b068e2617812", async() => {
                    WriteLiteral(@"
                    <div class=""text-center"">
                        <input class=""p-2 form-control col-4"" type=""text"" name=""EA"" value=""0"" hidden />
                        <input class=""btn btn-danger  col-4"" style=""height:100%;"" type=""submit"" value=""Salida"" />
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <br />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39489004cde156b938586b1ce7f14989b068e2619893", async() => {
                    WriteLiteral("\r\n\r\n                    <div class=\"form-actions no-color d-flex text-center justify-content-center align-items-center\">\r\n\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39489004cde156b938586b1ce7f14989b068e26110313", async() => {
                        WriteLiteral("Mostrar todo");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\r\n                        <input class=\"p-2 form-control col-md-4\" style=\"height: 35px;border-color:black\" type=\"date\" name=\"date\"");
                    BeginWriteAttribute("value", " value=\"", 1868, "\"", 1876, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input class=\"p-1 btn btn-success btn-lg m-2\" style=\"height:100%;\" type=\"submit\" value=\"Buscar\" />\r\n\r\n                    </div>\r\n\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                <table class=""table-success table table-striped table-bordered nowrap compact"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th>
                                Fecha
                            </th>
                            <th>
                                Salida
                            </th>
                            <th>
                                Entrada
                            </th>
                            <th>
                                Saldo
                            </th>
                            <th>
                                Precio Venta
                            </th>
                            <th>
                                Precio compra
                            </th>
                            <th>
                                ");
#nullable restore
#line 82 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </th>
                            <th>
                                Nombre Producto
                            </th>
                            <th>
                                Documento
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 93 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 97 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FechaRegistro));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 100 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SalidaCantidad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 103 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EntradaCantidad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 106 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SaldoCantidad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 109 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PrecioUnitarioVenta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 112 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PrecioUnitarioCompra));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 115 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 118 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IdProductoNavigation.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 121 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DocumentoNavigation.Codigo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 124 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                Totales:\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 130 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                           Write(ViewBag.sumKardexSalida);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 133 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Kardexes\Index.cshtml"
                           Write(ViewBag.sumKardexEntrada);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp_BotoneraLozanoSAC.Models.Kardex>> Html { get; private set; }
    }
}
#pragma warning restore 1591