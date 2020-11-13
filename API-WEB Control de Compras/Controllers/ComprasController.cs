using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.SolicitudDeCompras;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_WEB_Control_de_Compras.Controllers
{
    public class ComprasController : Controller
    {
        private ISolicitudCompra database = new SolicitudCompra();

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
            return Ok(await database.getAllSolicitudCompra());
        }
    }
}
