#pragma checksum "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe58dae7430c552d94826765f009a172d4cb324c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Product), @"mvc.1.0.view", @"/Views/Catalog/Product.cshtml")]
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
#line 1 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\_ViewImports.cshtml"
using Prueba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\_ViewImports.cshtml"
using Prueba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe58dae7430c552d94826765f009a172d4cb324c", @"/Views/Catalog/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51658264bb9676655f4de4bc0355ca28be8fdbaf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Catalog_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prueba.Models.Product>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Product.cshtml"
  
    ViewData["Title"] = "Item";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"ItemContainer\">\r\n    <div class=\"ItemContent\">\r\n        <div class=\"Images\">\r\n            <div class=\"ActualImage\">\r\n                <div><img");
            BeginWriteAttribute("src", " src=", 226, "", 269, 1);
#nullable restore
#line 10 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Product.cshtml"
WriteAttributeValue("", 231, Html.DisplayFor(model => model.Image), 231, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n        <span class=\"Separator\"></span>\r\n        <div class=\"ItemData\">\r\n            <div class=\"ItemTitle\">");
#nullable restore
#line 15 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Product.cshtml"
                              Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <p class=\"ItemDescription\">");
#nullable restore
#line 16 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Product.cshtml"
                                  Write(Html.DisplayFor(model => model.Descr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"ItemPrice\">Price $");
#nullable restore
#line 17 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Product.cshtml"
                                     Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"ABM_Button\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe58dae7430c552d94826765f009a172d4cb324c6000", async() => {
                WriteLiteral("Back to Catalog");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prueba.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
