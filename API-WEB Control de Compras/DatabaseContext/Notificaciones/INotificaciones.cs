using API_WEB_Control_de_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.Notificaciones
{
    interface INotificaciones
    {
        Task InsertarNotificacion(NotificacionModel notificacion);
        Task UpdateNotificacion(NotificacionModel notificacion);
        Task DeleteNotificacion(string id);
        Task<NotificacionModel> getNotificacionWithId(string id);
        Task<List<NotificacionModel>> getAllNotificaciones();
    }
}
