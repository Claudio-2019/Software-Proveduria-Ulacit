using API_WEB_Control_de_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.CreacionLogin
{
    interface ICreacionLogin
    {
        Task InsertarAdmin(CreacionLoginModel login);
        Task InsertarComprador(CreacionLoginModel login);
        Task InsertarJefe(CreacionLoginModel login);
        Task InsertarFinanciero(CreacionLoginModel login);
        Task UpdateComprador(CreacionLoginModel login);
        Task UpdateAdministrator(CreacionLoginModel login);
        Task UpdateJefe(CreacionLoginModel login);
        Task UpdateFinanciero(CreacionLoginModel login);
        Task DeleteAdministrator(string id);
        Task DeleteComprador(string id);
        Task DeleteJefe(string id);
        Task DeleteFinanciero(string id);
        //Task<CreacionLoginModel> getLoginWithId(string id);
        Task<List<CreacionLoginModel>> getAllAdministradores();
        Task<List<CreacionLoginModel>> getAllCompradores();
        Task<List<CreacionLoginModel>> getAllJefes();
        Task<List<CreacionLoginModel>> getAllFinancieros();

    }
}
