#pragma checksum "D:\Proyectos\ProyectoCaso5\プロジェクト5\プロジェクト5\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d038c86591b32263bc762a95044d97e1433e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(プロジェクト5.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace プロジェクト5.Pages
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
#line 1 "D:\Proyectos\ProyectoCaso5\プロジェクト5\プロジェクト5\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\ProyectoCaso5\プロジェクト5\プロジェクト5\Pages\_ViewImports.cshtml"
using プロジェクト5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\ProyectoCaso5\プロジェクト5\プロジェクト5\Pages\_ViewImports.cshtml"
using プロジェクト5.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d038c86591b32263bc762a95044d97e1433e69", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b62a7c4bcd49a5f161f3f617dd97398d99d8f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Proyectos\ProyectoCaso5\プロジェクト5\プロジェクト5\Pages\Index.cshtml"
  
    ViewData["Title"] = "I-SPORT by MALIX FC";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Bienvenido a ");
#nullable restore
#line 7 "D:\Proyectos\ProyectoCaso5\プロジェクト5\プロジェクト5\Pages\Index.cshtml"
                Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<br />
<br />
    <div class=""slider"">
        <div><img width=""1000"" src=""/images/1.png"" class=""imagen"" alt=""Slider_1""></div>
        <div><img width=""1000"" src=""/images/2.png"" class=""imagen"" alt=""Slider_2""></div>
        <div><img width=""1000"" src=""/images/3.png"" class=""imagen"" alt=""Slider_3""></div>
        <div><img width=""1000"" src=""/images/4.png"" class=""imagen"" alt=""Slider_4""></div>
        <div><img width=""1000"" src=""/images/5.png"" class=""imagen"" alt=""Slider_5""></div>
        <div><img width=""1000"" src=""/images/6.png"" class=""imagen"" alt=""Slider_6""></div>
        <div><img width=""1000"" src=""/images/7.png"" class=""imagen"" alt=""Slider_7""></div>
        <div><img width=""1000"" src=""/images/8.png"" class=""imagen"" alt=""Slider_8""></div>
        <div><img width=""1000"" src=""/images/9.png"" class=""imagen"" alt=""Slider_9""></div>
        <div><img width=""1000"" src=""/images/10.png"" class=""imagen"" alt=""Slider_10""></div>
    </div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/bxslider/4.2.12/jquery.bxslider.min.js""></script>
    <script>
        $(document).ready(function () {
            $('.slider').bxSlider({
                auto: true
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
