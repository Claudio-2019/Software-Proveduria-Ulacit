using API_WEB_Control_de_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.Login
{
    interface ILoginAuth
    {
        Task<List<LoginModel>> GetAuthenticationSystem();
        Task<List<LoginJefe>> GetAuthenticationJefe();
        Task<List<LoginComprador>> GetAuthenticationComprador();
        Task<List<LoginFinanciero>> GetAuthenticationFinanciero();
    }
}
