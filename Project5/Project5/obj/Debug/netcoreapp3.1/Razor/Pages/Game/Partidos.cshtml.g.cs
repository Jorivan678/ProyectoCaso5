#pragma checksum "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03e454a6a3c646b8207a37e4dceae7e52109ea1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(プロジェクト5.Pages.Game.Pages_Game_Partidos), @"mvc.1.0.razor-page", @"/Pages/Game/Partidos.cshtml")]
namespace プロジェクト5.Pages.Game
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
#line 1 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\_ViewImports.cshtml"
using プロジェクト5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\_ViewImports.cshtml"
using プロジェクト5.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e454a6a3c646b8207a37e4dceae7e52109ea1c", @"/Pages/Game/Partidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b62a7c4bcd49a5f161f3f617dd97398d99d8f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Game_Partidos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AgregarPartido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/GameResult/Resultados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jspdf.debug.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
  
    ViewData["Title"] = "Partidos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div class=\"d-flex justify-content-end p-2\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c7719", async() => {
                WriteLiteral("Agregar Partido");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c9051", async() => {
                WriteLiteral("Ver resultados de los partidos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<div class=""col-md-6 col-md-offset-2"">
    <section>
        <h4>Nota:</h4>
        <div>
            <p>
                Un Equipo puede tener hasta 11 resultados, porque los resultados son por cada jugador(local) del partido.
            </p>
        </div>
    </section>
</div>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">
                Identificador del partido
            </th>
            <th scope=""col"">
                ");
#nullable restore
#line 29 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].FechPart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 32 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].TiemJugado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 35 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].Estadio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                Equipo Local\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 41 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].TotalJugLc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                Equipo Visitante\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 47 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].TotalJugVis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 50 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 53 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].CreatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 56 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Partido[0].UpdatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\"></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 62 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
         foreach (var item in Model.Partido)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechPart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.TiemJugado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estadio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Equipo.NomEquip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalJugLc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.EquipoSub.Equipo.NomEquip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalJugVis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 89 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                 if (item.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Activo</td>\r\n");
#nullable restore
#line 92 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Inactivo</td>\r\n");
#nullable restore
#line 96 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 98 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayFor(modelItem => item.UpdatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c18135", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c20388", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 106 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c22874", async() => {
                WriteLiteral("\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c23152", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c23433", async() => {
                        WriteLiteral("All");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 112 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TeamPlayer);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 112 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Player;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Filter\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""Reporte"">
    <table class=""table table-dark"">
        <colgroup>
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
            <col width=""20%"">
        </colgroup>
        <thead class=""thead-dark"">
            <tr class='warning'>
                <th>");
#nullable restore
#line 135 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].Partido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 136 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].Jugador));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 137 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].Jugador.ApellidoP));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 138 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].Jugador.ApellidoM));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 139 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].Goles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 140 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].Asistencias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 141 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].AutoGoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 142 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
               Write(Html.DisplayNameFor(model => model.ResultadoPartido[0].Penales));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Tarjetas amarillas</th>\r\n                <th>Tarjetas rojas</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 148 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
             foreach (var item in Model.ResultadoPartido)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 151 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdPartido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 153 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Jugador.NomJug));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 155 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Jugador.ApellidoP));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 157 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Jugador.ApellidoM));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 159 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Goles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 161 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Asistencias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 163 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AutoGoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 165 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Penales));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 167 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TarjAmarilla));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 169 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TarjRoja));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 171 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Game\Partidos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<button onclick=\"javascript:demoFromHTML();\">Exportar reporte</button>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e454a6a3c646b8207a37e4dceae7e52109ea1c34288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        function demoFromHTML() {
            var pdf = new jsPDF('letter');
            // source can be HTML-formatted string, or a reference
            // to an actual DOM element from which the text will be scraped.
            source = $('#Reporte')[0];
            // we support special element handlers. Register them with jQuery-style
            // ID selector for either ID or node name. (""#iAmID"", ""div"", ""span"" etc.)
            // There is no support for any other type of selectors
            // (class, of compound) at this time.
            specialElementHandlers = {
                // element with id of ""bypass"" - jQuery style selector
                '#bypassme': function (element, renderer) {
                    // true = ""handled elsewhere, bypass text extraction""
                    return true
                }
            };
            margins = {
                top: 40,
                bottom: 20,
                left: 50,
      ");
                WriteLiteral(@"          width: 500
            };
            // all coords and widths are in jsPDF instance's declared units
            // 'inches' in this case
            pdf.fromHTML(
                source, // HTML string or DOM elem ref.
                margins.left, // x coord
                margins.top, { // y coord
                'width': margins.width, // max width of content on PDF
                'elementHandlers': specialElementHandlers
            },
                function (dispose) {
                    // dispose: object with X, Y of the last line add to the PDF
                    //          this allow the insertion of new lines after html
                    pdf.save('Reporte jugadores.pdf');
                }, margins);
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<プロジェクト5.Pages.Game.PartidoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<プロジェクト5.Pages.Game.PartidoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<プロジェクト5.Pages.Game.PartidoModel>)PageContext?.ViewData;
        public プロジェクト5.Pages.Game.PartidoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
