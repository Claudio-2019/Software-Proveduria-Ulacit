using API_WEB_Control_de_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.CreacionLogin
{
    interface ICreacionLogin
    {
        Task InsertarLogin(CreacionLoginModel login);
        Task UpdateLogin(CreacionLoginModel login);
        Task DeleteLogin(string id);
        Task<CreacionLoginModel> getLoginWithId(string id);
        Task<List<CreacionLoginModel>> getAllLogin();

    }
}
