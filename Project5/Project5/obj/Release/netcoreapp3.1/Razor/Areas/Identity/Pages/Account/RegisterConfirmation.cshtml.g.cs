#pragma checksum "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa8069942d732326c80a706fed612225b255f57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\_ViewImports.cshtml"
using プロジェクト5.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\_ViewImports.cshtml"
using プロジェクト5.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using プロジェクト5.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa8069942d732326c80a706fed612225b255f57", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0c62c0bd51412f0db38e892ab9d9b23ccf5632", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b2a1f78026f2b689947899361b99a4db655bf30", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    Está aplicación aún no posee un mecanismo para enviar correos de confirmación, por favor <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 301, "\"", 335, 1);
#nullable restore
#line 12 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 308, Model.EmailConfirmationUrl, 308, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">haga click aquí para confirmar su correo</a>\r\n</p>\r\n");
#nullable restore
#line 14 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
#nullable restore
#line 20 "D:\Proyectos\ProyectoCaso5\事例5プロジェクト\プロジェクト5\プロジェクト5\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
