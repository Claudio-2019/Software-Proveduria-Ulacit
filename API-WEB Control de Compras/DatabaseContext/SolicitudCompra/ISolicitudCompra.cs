using API_WEB_Control_de_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.SolicitudCompra
{
    interface ISolicitudCompra
    {
        Task InsertarSolicitudCompra(SolicitudCompraModel solicitudcompra);
        Task UpdateSolicitudCompran(SolicitudCompraModel solicitudcompra);
        Task DeleteSolicitudCompra(string id);
        Task<SolicitudCompraModel> getSolicitudCompraWithId(string id);
        Task<List<SolicitudCompraModel>> getAllSolicitudCompra();
    }
}
