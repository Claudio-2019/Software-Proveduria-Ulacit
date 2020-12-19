using System;
using System.Collections.Generic;
using System.IO;
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
                "<br>"+"<h4>La misma sera procesada por el jefe </h4>"+"<br>" ;
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
        public async Task NotificarRechazoSolicitudJefe(string CorreoElectronico)
        {

            await Task.Run(() =>
            {

                MailMessage notificacion = new MailMessage();
                SmtpClient servicioSMTP = new SmtpClient();
                notificacion.From = new MailAddress("claudiogh33@gmail.com");
                notificacion.To.Add(new MailAddress(CorreoElectronico));
                notificacion.Subject = "Solicitud de Rechazo";
                
                notificacion.Body = "Lo sentimos, su solicitud ha sido rechazada por la jefatura encargada!"; 
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
        public async Task NotificarRechazoSolicitudFinanciero(string CorreoElectronico)
        {

            await Task.Run(() =>
            {

                MailMessage notificacion = new MailMessage();
                SmtpClient servicioSMTP = new SmtpClient();
                notificacion.From = new MailAddress("claudiogh33@gmail.com");
                notificacion.To.Add(new MailAddress(CorreoElectronico));
                notificacion.Subject = "Notificacion del departamento financiero";

                notificacion.Body = "Lo sentimos, su solicitud ha sido rechazada por el departamente financiero!!";
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
                notificacion.Subject = "APROBACION DE COMPRA";
                notificacion.IsBodyHtml = true;
                notificacion.Body = "<h2>FELICITACIONES, SU SOLICITUD DE COMPRA FUE APROBADA POR LA JEFATURA CORRESPONDIENTE, SERA NOTIFICADO POR ESTE MEDIO ACERCA DEL STATUS DE APROBACION POR EL DEPARTAMENTO FINANCIERO</h2>";
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
                notificacion.Subject = "SOLICITUD APROBADA";
                notificacion.Body = "<h2>FELICITACIONES, SU SOLICITUD DE COMPRA FUE APROBADA POR EL DEPARTAMENTO FINANCIERO, SERA CONTACTADO VIA TELEFONO O CORREO ELECTRONICO PARA CONOCER EL ESTADO DE LA SOLICITUD</h2>";
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
