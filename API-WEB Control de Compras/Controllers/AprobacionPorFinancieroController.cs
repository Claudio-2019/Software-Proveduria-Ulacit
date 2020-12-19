using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.AprobacionPorFinanciero;
using API_WEB_Control_de_Compras.DatabaseContext.CreacionLogin;
using API_WEB_Control_de_Compras.DatabaseContext.Notificaciones;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace API_WEB_Control_de_Compras.Controllers
{
    public class AprobacionPorFinancieroController : Controller
    {
        private NotificacionEmail notificacion = new NotificacionEmail();
        
        private IAprobacionPorFinanciero database = new AprobacionPorFinancieroCollection();
        private ICreacionLogin jefes = new CreacionLoginCollection();

        //get todos
        [HttpGet]
        [Route("api/aprobacionPorFinanciero/GetAllAprobaciones")]
        public async Task<IActionResult> GetAllAprobaciones()
        {
            return Ok(await database.getAllAprobacionesPorFinanciero());
        }

        //get por id
        [HttpGet]
        [Route("api/aprobacionPorFinanciero/GetAprobacion/{id}")]
        public async Task<IActionResult> GetAprobacion(string id)
        {
            return Ok(await database.getAprobacionesPorFinancieroWithId(id));
        }

        //post para agregar
        [HttpPost]
        [Route("api/aprobacionPorFinanciero/InsertAprobacion")]
        public async Task<IActionResult> InsertAprobacion([FromBody] AprobacionPorFinancieroModel aprobacion)
        {
            var test = aprobacion.titulo;
            if (aprobacion == null)
            {
                return BadRequest();
            }
            else
            {
                await notificacion.NotificarAprobacionFinanciero(aprobacion.correoElectronico);
                return Ok("Se aprobo la solicitud de compra, se ha enviado una notificacion de correo electronico");
            }
            return Created("Aprobacion Insertada!!", true);
        }

        //put para hacer update a aprobacion
        [HttpPut]
        [Route("api/aprobacionPorFinanciero/UpdateAprobacion/{id}")]
        public async Task<IActionResult> UpdateAprobacion([FromBody] AprobacionPorFinancieroModel aprobacion, string id)
        {
            if (aprobacion == null)
            {
                return BadRequest();
            }
            else
            {
                aprobacion._id = new ObjectId(id);

                await database.UpdateAprobacionPorFinanciero(aprobacion);

            }
            return Created("Aprobacion Actualizada!!", true);
        }

        //delete para borrar aprobacion
       
        [HttpPost]
        [Route("api/aprobacionPorFinanciero/DeleteAprobacion")]
        public async Task<IActionResult> DeleteAprobacion([FromBody] SolicitudCompraModel sol)
        {
            var usersJefes = jefes.getAllJefes();

            if (sol._id == String.Empty)
            {
                return NoContent();

            }
            else
            {
                await database.DeleteAprobacionPorFinanciero(sol._id);
                await notificacion.NotificarRechazoSolicitudFinanciero(sol.correoElectronico);
                
                foreach(var UserJefes in usersJefes.Result.ToList())
                {
                    await Task.Run(() =>
                    {

                        MailMessage notificacion = new MailMessage();
                        SmtpClient servicioSMTP = new SmtpClient();
                        notificacion.From = new MailAddress("claudiogh33@gmail.com");
                        notificacion.To.Add(new MailAddress(UserJefes.correoElectronico));
                        notificacion.Subject = "SOLICITUD APROBADA";
                        notificacion.Body = "<h2>SE APROBO UNA SOLICITUD POR EL DEPARTAMENTO FINANCIERO!</h2>";
                        notificacion.IsBodyHtml = true;
                        servicioSMTP.Port = 587;
                        servicioSMTP.Host = "smtp.gmail.com";
                        servicioSMTP.EnableSsl = true;
                        servicioSMTP.UseDefaultCredentials = false;
                        servicioSMTP.Credentials = new NetworkCredential("claudiogh33@gmail.com", "IT.s0p0rt3.MBS1998.");
                        servicioSMTP.DeliveryMethod = SmtpDeliveryMethod.Network;
                        servicioSMTP.Send(notificacion);

                    });
                }


                return Ok();
                
            }
        }
    }
}
