using API_WEB_Control_de_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.SolicitudDeCompras
{
    interface ISolicitudCompra
    {
        Task InsertarSolicitudCompra(SolicitudCompraModel solicitudcompra);
        Task UpdateSolicitudCompra(SolicitudCompraModel solicitudcompra);
        Task DeleteSolicitudCompra(string id);
        Task<SolicitudCompraModel> GetSolicitudCompraWithId(string id);
        Task<List<SolicitudCompraModel>> GetAllSolicitudCompra();
    }
}
