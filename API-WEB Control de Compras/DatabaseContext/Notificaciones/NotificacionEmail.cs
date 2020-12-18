using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.Notificaciones
{
    public class NotificacionEmail
    {
        public async Task NotificarSolicitante(string CorreoElectronico)
        {

            await Task.Run(() =>
            {

                MailMessage notificacion = new MailMessage();
                SmtpClient servicioSMTP = new SmtpClient();
                notificacion.From = new MailAddress("claudiogh33@gmail.com");
                notificacion.To.Add(new MailAddress(CorreoElectronico));
                notificacion.Subject = "Notificacion de Compra";
                notificacion.Body = "<h3 >Su Solicitud de compra ha sido recibida por el departamento,</h3>" +
                "<br>"+"<h4>La misma sera procesada por el jefe </h4>"+"<br>"+"<button href='www.google.com'>iniciar google</button>" ;
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
        public async Task NotificarAprobacionJefe(string CorreoElectronico)
        {

            await Task.Run(() =>
            {

                MailMessage notificacion = new MailMessage();
                SmtpClient servicioSMTP = new SmtpClient();
                notificacion.From = new MailAddress("claudiogh33@gmail.com");
                notificacion.To.Add(new MailAddress(CorreoElectronico));
                notificacion.Subject = "Notificacion de Compra";
                notificacion.Body = "Solicitud de compra recibida, debera esperar para su aprobacion final";

                servicioSMTP.Port = 587;
                servicioSMTP.Host = "smtp.gmail.com";
                servicioSMTP.EnableSsl = true;
                servicioSMTP.UseDefaultCredentials = false;
                servicioSMTP.Credentials = new NetworkCredential("claudiogh33@gmail.com", "IT.s0p0rt3.MBS1998.");
                servicioSMTP.DeliveryMethod = SmtpDeliveryMethod.Network;
                servicioSMTP.Send(notificacion);

            });
        }
        public async Task NotificarAprobacionFinanciero(string CorreoElectronico)
        {

            await Task.Run(() =>
            {

                MailMessage notificacion = new MailMessage();
                SmtpClient servicioSMTP = new SmtpClient();
                notificacion.From = new MailAddress("claudiogh33@gmail.com");
                notificacion.To.Add(new MailAddress(CorreoElectronico));
                notificacion.Subject = "Notificacion de Compra";
                notificacion.Body = "<h3 >Su Solicitud de compra ha sido recibida por el departamento,</h3>" +
                 "<br>" + "<h4>La misma sera procesada por el jefe </h4>" + "<br>" + "<button href=www.google.com>iniciar google</button>";
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
    }
}
