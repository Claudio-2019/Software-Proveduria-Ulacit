using API_Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.CreacionLogin
{
    interface ICreacionLogin
    {
        Task InsertarLogin(LoginModel login);
        Task UpdateLogin(LoginModel login);
        Task DeleteLogin(string id);
        Task<LoginModel> getLoginWithId(string id);
        Task<List<LoginModel>> getAllLogin();

    }
}
