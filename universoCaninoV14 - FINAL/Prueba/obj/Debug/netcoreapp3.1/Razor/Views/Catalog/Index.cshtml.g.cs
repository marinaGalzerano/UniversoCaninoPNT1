#pragma checksum "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e73b0ec52a1b0ce6c99ff80e77c2135d7b23e8ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Index), @"mvc.1.0.view", @"/Views/Catalog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73b0ec52a1b0ce6c99ff80e77c2135d7b23e8ad", @"/Views/Catalog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51658264bb9676655f4de4bc0355ca28be8fdbaf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Catalog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prueba.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ProductBuy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"TwoPanelCatalog\">\r\n \r\n\r\n    <div class=\"RightPanel\">\r\n        <div class=\"ProductGrid\">\r\n");
#nullable restore
#line 11 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"Product\">\r\n                        <img");
            BeginWriteAttribute("src", " src=", 315, "", 361, 1);
#nullable restore
#line 14 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
WriteAttributeValue("", 320, Html.DisplayFor(modelItem => item.Image), 320, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"DataProduct\">\r\n                            <h3 class=\"ProductTitle\">");
#nullable restore
#line 16 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p class=\"ProductDescription\">");
#nullable restore
#line 17 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Descr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"ProductPrice\">Precio: <span class=\"Price\">$");
#nullable restore
#line 18 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e73b0ec52a1b0ce6c99ff80e77c2135d7b23e8ad7064", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 22 "C:\Proyectos\Sistemas\ORT\2do Cuat\01 - Programación de Nuevas Tecnologías\Ejercicios\09 - TP Final (entrega)\universoCaninoV12\Prueba\Views\Catalog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prueba.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
