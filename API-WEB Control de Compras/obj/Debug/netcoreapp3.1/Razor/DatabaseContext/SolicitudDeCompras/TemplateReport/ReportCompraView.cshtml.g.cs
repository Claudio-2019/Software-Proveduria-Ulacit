#pragma checksum "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4402d819eb57d0b41d4094513f16878037cbec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.DatabaseContext_SolicitudDeCompras_TemplateReport_ReportCompraView), @"mvc.1.0.view", @"/DatabaseContext/SolicitudDeCompras/TemplateReport/ReportCompraView.cshtml")]
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
#line 1 "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml"
using Wkhtmltopdf.NetCore.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4402d819eb57d0b41d4094513f16878037cbec", @"/DatabaseContext/SolicitudDeCompras/TemplateReport/ReportCompraView.cshtml")]
    public class DatabaseContext_SolicitudDeCompras_TemplateReport_ReportCompraView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API_WEB_Control_de_Compras.Models.SolicitudCompraModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad4402d819eb57d0b41d4094513f16878037cbec3408", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad4402d819eb57d0b41d4094513f16878037cbec4605", async() => {
                WriteLiteral(@"

    <table class=""table table-striped"">

        <thead>
            <th>Titulo de la compra</th>
            <th>Articulo solicitado</th>
            <th>Tipo de Articulo</th>
            <th>Cantidad Total ponderada</th>
            <th>Monto Total Ponderado por cada Articulo</th>
            <th>Monto Total a pagar</th>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 26 "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml"
               Write(Model.titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml"
               Write(Model.nombreArticulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml"
               Write(Model.tipoArticulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml"
               Write(Model.cantidad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml"
               Write(Model.monto);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\ClaudioPC\Desktop\PROYECTO APROBACION DE COMPRAS\Software-Proveduria-Ulacit\API-WEB Control de Compras\DatabaseContext\SolicitudDeCompras\TemplateReport\ReportCompraView.cshtml"
               Write(Model.total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n\r\n           \r\n        </tbody>\r\n\r\n    </table>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API_WEB_Control_de_Compras.Models.SolicitudCompraModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
