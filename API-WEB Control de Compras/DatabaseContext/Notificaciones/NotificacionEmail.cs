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
                notificacion.Body ="Solicitud de compra recibida, debera esperar para su aprobacion final" ;

                servicioSMTP.Port = 587;
                servicioSMTP.Host = "smtp.gmail.com";
                servicioSMTP.EnableSsl = true;
                servicioSMTP.UseDefaultCredentials = false;
                servicioSMTP.Credentials = new NetworkCredential("claudiogh33@gmail.com", "Sangabriel8468B9.");
                servicioSMTP.DeliveryMethod = SmtpDeliveryMethod.Network;
                servicioSMTP.Send(notificacion);

            });
        }
    }
}
