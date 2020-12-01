using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.Notificaciones;
using API_WEB_Control_de_Compras.DatabaseContext.SolicitudDeCompras;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Mvc;
using Wkhtmltopdf.NetCore;

namespace API_WEB_Control_de_Compras.Controllers
{
    public class ComprasController : Controller
    {
        readonly IGeneratePdf NewCompradorReport;
        private ISolicitudCompra database = new SolicitudCompra();
        private NotificacionEmail emailNotify = new NotificacionEmail();
        private CompraReport reporte = new CompraReport();

        public ComprasController(IGeneratePdf pdf)
        {
            NewCompradorReport = pdf;
        }

        [HttpPost]
        [Route("api/Compras/CrearCompra")]
        public async Task<IActionResult> CrearCompra([FromBody] SolicitudCompraModel solicitud)
        {
            double CostoTotal = solicitud.cantidad * solicitud.monto;

            if (solicitud != null)
            {
                solicitud.total = CostoTotal;

                solicitud.fechaRegistro = DateTime.Now;

                await database.InsertarSolicitudCompra(solicitud);

                await emailNotify.NotificarSolicitante(solicitud.correoElectronico);

                return Ok("Se ha creado la solicitud de compra");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("api/Compras/ReportCompra")]
        public async Task<IActionResult> ReportCompra()
        {

            SolicitudCompraModel CompraActual;

            var CompraReport = new SolicitudCompraModel()
            {
                titulo = CompraActual.titulo,
                nombreArticulo = CompraActual.nombreArticulo,
                tipoArticulo = CompraActual.tipoArticulo,
                cantidad = CompraActual.cantidad,
                monto = CompraActual.monto,
                total = CompraActual.total,
                correoElectronico = CompraActual.correoElectronico,
                descripcion = CompraActual.descripcion,
                fechaRegistro = DateTime.Now,
                telefono = CompraActual.telefono,


            };

            return await NewCompradorReport.GetPdf("DatabaseContext/SolicitudDeCompras/TemplateReport/ReportCompraView.cshtml", CompraReport);
        }





        [HttpGet]
        [Route("api/Compras/ObtenerComprasActuales")]
        public async Task<IActionResult> ObtenerComprasActuales()
        {
            return Ok(await database.getAllSolicitudCompra());
        }
    }
}
