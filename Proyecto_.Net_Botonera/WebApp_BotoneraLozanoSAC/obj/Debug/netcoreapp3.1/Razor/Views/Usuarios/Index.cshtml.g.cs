#pragma checksum "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46ba1474db3c289ddd1a2a75632f7abd726e3c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ba1474db3c289ddd1a2a75632f7abd726e3c6d", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf47935cb244184506c8032d185b186e0f196d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp_BotoneraLozanoSAC.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mr-auto p-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ba1474db3c289ddd1a2a75632f7abd726e3c6d6450", async() => {
                WriteLiteral(@"
    
<br />
<nav aria-label=""breadcrumb"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#"">Mantenimiento</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Usuarios</li>
    </ol>
</nav>

<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""card"">
            <div class=""card-header bg-dark text-white"">
                Lista de Usuarios
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ba1474db3c289ddd1a2a75632f7abd726e3c6d7307", async() => {
                    WriteLiteral("<input type=\"submit\" value=\"Agregar Nuevo\" class=\"btn btn-sm btn-success\" onclick=\"abrirPopUpForm(null)\"><i class=\"fa fa-plus\" aria-hidden=\"true\"></i>");
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
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ba1474db3c289ddd1a2a75632f7abd726e3c6d8780", async() => {
                    WriteLiteral("\r\n                    <div class=\"form-actions no-color d-flex text-center justify-content-center align-items-center\">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ba1474db3c289ddd1a2a75632f7abd726e3c6d9192", async() => {
                        WriteLiteral("Todos los registros");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        <input class=\"p-2 form-control col-md-4\" type=\"text\" name=\"searchString\"");
                    BeginWriteAttribute("value", " value=\"", 1325, "\"", 1359, 1);
#nullable restore
#line 33 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1333, ViewData["CurrentFilter"], 1333, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input class=\"p-1 btn btn-success btn-lg m-2\" style=\"height:100%;\" type=\"submit\" value=\"Buscar\"/>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""row mt-3"">
                    <div class=""col-sm-12"">
                        <table id=""tbdata"" class=""table-success table table-striped table-bordered nowrap compact"" style=""width:100%"">                            
                            <thead>
                                <tr>
                                    
                                    <th>Rol</th>
                                    <th>Nombre</th>
                                    <th>Apellidos</th>
                                    <th>E-mail</th>
                                    <th>Clave</th>
                                    <th>Tipo Documento</th>
                                    <th>Número Documento</th>                                    
                                    <th class=""text-center"">Acciones</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 55 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                 if (ViewBag.Producto == 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p class=\"alert-warning\"><strong><i class=\"bi bi-search\"></i> \"No se encontraron resultados en su búsqueda\"</strong></p>\r\n");
#nullable restore
#line 58 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                 if (ViewBag.Producto == 1)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                     foreach (var item in Model)

                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 67 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.IdRolNavigation.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 70 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 73 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 76 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 79 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Clave));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 82 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TipoDocumento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 85 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.NumeroDocumento));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </td>


                                            <td>
                                                <div class=""col text-center"">
                                                    <button type=""button"" class=""btn btn-sm btn-primary"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ba1474db3c289ddd1a2a75632f7abd726e3c6d18837", async() => {
                    WriteLiteral("<i class=\"bi bi-pencil\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                                                                                                                                    WriteLiteral(item.IdUsuario);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button> |\r\n                                                    <button type=\"button\" class=\"btn btn-sm btn-success\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ba1474db3c289ddd1a2a75632f7abd726e3c6d21462", async() => {
                    WriteLiteral("<i class=\"bi bi-card-list\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                                                                                                                                       WriteLiteral(item.IdUsuario);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button> |\r\n                                                    <button type=\"button\" class=\"btn btn-sm btn-danger\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ba1474db3c289ddd1a2a75632f7abd726e3c6d24092", async() => {
                    WriteLiteral("<i class=\"bi bi-trash-fill\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                                                                                                                                     WriteLiteral(item.IdUsuario);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button>\r\n\r\n                                                </div>\r\n\r\n\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 100 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\blasi\Downloads\Herramientas-Final\PROYECTO FINAL\WebApp_BotoneraLozanoSAC\Views\Usuarios\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp_BotoneraLozanoSAC.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
