using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.Notificaciones;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace API_WEB_Control_de_Compras.Controllers
{
    public class NotificacionController : Controller
    {
        private INotificaciones database = new NotificacionesCollection();

        //get todos
        [HttpGet]
        [Route("api/notificaciones/GetAllNotificaciones")]
        public async Task<IActionResult> GetAllNotificaciones()
        {
            return Ok(await database.getAllNotificaciones());
        }

        //get por id
        [HttpGet]
        [Route("api/notificaciones/GetNotificacion/{id}")]
        public async Task<IActionResult> GetNotificacion(string id)
        {
            return Ok(await database.getNotificacionWithId(id));
        }

        //post para agregar
        [HttpPost]
        [Route("api/notificaciones/InsertNotificacion")]
        public async Task<IActionResult> InsertNotificacion([FromBody] NotificacionModel notificacion)
        {
            if (notificacion == null)
            {
                return BadRequest();
            }
            else
            {
                await database.InsertarNotificacion(notificacion);

            }
            return Created("Notificacion Insertada!!", true);
        }

        //put para hacer update a notif
        [HttpPut]
        [Route("api/notificaciones/UpdateNotificacion/{id}")]
        public async Task<IActionResult> UpdateNotificacion([FromBody] NotificacionModel notificacion, string id)
        {
            if (notificacion == null)
            {
                return BadRequest();
            }
            else
            {
                notificacion._id = new ObjectId(id);

                await database.UpdateNotificacion(notificacion);

            }
            return Created("Notificacion Actualizada!!", true);
        }

        //delete para borrar notif
        [HttpDelete]
        [Route("api/notificaciones/DeleteNotificacion/{id}")]
        public async Task<IActionResult> DeleteNotificacion(string id)
        {
            if (id == String.Empty)
            {
                return NoContent();

            }
            else
            {
                await database.DeleteNotificacion(id);
                return Ok();
            }
        }

    }
}
