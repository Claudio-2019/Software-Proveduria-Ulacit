using API_Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Inventario.DatabaseContext.Login
{
    interface ILoginAuth
    {
        Task<List<LoginModel>> GetAuthenticationLogin();
    }
}
