#pragma checksum "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1307aad2f78ea56f563033e69c5070aec0544bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(プロジェクト5.Pages.Player.Pages_Player_Details), @"mvc.1.0.razor-page", @"/Pages/Player/Details.cshtml")]
namespace プロジェクト5.Pages.Player
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1307aad2f78ea56f563033e69c5070aec0544bf", @"/Pages/Player/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b62a7c4bcd49a5f161f3f617dd97398d99d8f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Player_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Jugadores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h4>Jugador</h4>\r\n    <hr />\r\n");
#nullable restore
#line 7 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
     if(Model.Jugador.CreatedAT != null)
    {
        var imgPath = $"~/images/{(string.IsNullOrEmpty(Model.Jugador.FotoJug) ? "" : Model.Jugador.FotoJug)}";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.FotoJug));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d1307aad2f78ea56f563033e69c5070aec0544bf5165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
          WriteLiteral(imgPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.NomJug));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.NomJug));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.ApellidoP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.ApellidoP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.ApellidoM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.ApellidoM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.FechNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.FechNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.Equipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.Equipo.NomEquip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 57 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
             if (Model.Jugador.Status == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Activo</p>\r\n");
#nullable restore
#line 60 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Inactivo</p>\r\n");
#nullable restore
#line 64 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.CreatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.CreatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jugador.UpdatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jugador.UpdatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
#nullable restore
#line 79 "D:\Proyectos\ProyectoCaso5\Project5\Project5\Pages\Player\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1307aad2f78ea56f563033e69c5070aec0544bf13829", async() => {
                WriteLiteral("Volver a jugadores");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<プロジェクト5.Pages.Player.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<プロジェクト5.Pages.Player.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<プロジェクト5.Pages.Player.DetailsModel>)PageContext?.ViewData;
        public プロジェクト5.Pages.Player.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
