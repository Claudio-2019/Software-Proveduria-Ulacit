using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.Notificaciones;
using API_WEB_Control_de_Compras.DatabaseContext.SolicitudDeCompras;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> ReportCompra([FromBody] SolicitudCompraModel reporte)
        {

            SolicitudCompraModel CompraActual = new SolicitudCompraModel();

            CompraActual = new SolicitudCompraModel
            {
                titulo = reporte.titulo,
                nombreArticulo = reporte.nombreArticulo,
                tipoArticulo = reporte.tipoArticulo,
                cantidad = reporte.cantidad,
                monto = reporte.monto,
                total = reporte.total,
                correoElectronico = reporte.correoElectronico,
                descripcion = reporte.descripcion,
                fechaRegistro = DateTime.Now,
                telefono = reporte.telefono,
            };

            return await NewCompradorReport.GetPdf("DatabaseContext/SolicitudDeCompras/TemplateReport/ReportCompraView.cshtml", CompraActual);
        }

        [HttpGet]
        [Route("api/Compras/ObtenerComprasActuales")]
        public async Task<IActionResult> ObtenerComprasActuales()
        {
            return Ok(await database.GetAllSolicitudCompra());
        }

        [HttpPost]
        [Route("api/Compras/DeleteCompras")]
        public async Task<IActionResult> BorrarCompra([FromBody] SolicitudCompraModel sol) {

            if (sol._id == String.Empty)
            {
                return BadRequest();
            }
            else {
                await database.DeleteSolicitudCompra(sol._id);
                return Ok("good");
            }
            
        }
    }
}
