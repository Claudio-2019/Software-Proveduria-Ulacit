using API_WEB_Control_de_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.AprobacionPorFinanciero
{
    interface IAprobacionPorFinanciero
    {

namespace API_WEB_Control_de_Compras.DatabaseContext.Notificaciones
    {
        interface INotificaciones
        {
            Task InsertarAprobacionPorFinanciero(AprobacionPorFinancieroModel aprobacion);
            Task UpdateAprobacionPorFinanciero(AprobacionPorFinancieroModel aprobacion);
            Task DeleteAprobacionPorFinanciero(string id);
            Task<AprobacionPorFinancieroModel> getAprobacionesPorFinancieroWithId(string id);
            Task<List<AprobacionPorFinancieroModel>> getAllAprobacionesPorFinanciero();
        }
    }

}
}
