#pragma checksum "C:\Users\Jakub\source\repos\KarMenago\Views\Home\GetListOfModels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1985d75ffafe2ed08f28bc24e0f351da84f0193c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetListOfModels), @"mvc.1.0.view", @"/Views/Home/GetListOfModels.cshtml")]
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
#line 1 "C:\Users\Jakub\source\repos\KarMenago\Views\_ViewImports.cshtml"
using KarMenago;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jakub\source\repos\KarMenago\Views\_ViewImports.cshtml"
using KarMenago.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1985d75ffafe2ed08f28bc24e0f351da84f0193c", @"/Views/Home/GetListOfModels.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60d7d2c994d5a4e6f4c9d1e506b582760324299", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetListOfModels : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <ul>\r\n");
#nullable restore
#line 4 "C:\Users\Jakub\source\repos\KarMenago\Views\Home\GetListOfModels.cshtml"
         foreach (var CarModel in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
#nullable restore
#line 7 "C:\Users\Jakub\source\repos\KarMenago\Views\Home\GetListOfModels.cshtml"
           Write(Html.ActionLink(CarModel,"GetCarByModel","Home",new { model = CarModel}, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 9 "C:\Users\Jakub\source\repos\KarMenago\Views\Home\GetListOfModels.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
