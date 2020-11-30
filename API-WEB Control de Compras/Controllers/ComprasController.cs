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

namespace API_WEB_Control_de_Compras.Controllers
{
    public class ComprasController : Controller
    {
        private ISolicitudCompra database = new SolicitudCompra();
        private NotificacionEmail emailNotify = new NotificacionEmail();

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
