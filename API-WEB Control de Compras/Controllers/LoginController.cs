using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API_Inventario.DatabaseContext.Login;
using API_Inventario.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace API_Inventario.Controllers
{
    public class LoginController : Controller
    {
        private ILoginAuth database = new LoginCollection();

        [HttpPost]
        [Route("api/Login/CrearAutenticacion")]
        public async Task<Boolean> CrearAutenticacion([FromBody] LoginModel loginConnectionAuth)
        {

            var sesion = await database.GetAuthenticationLogin();

            ArrayList lista = new ArrayList();

            foreach (var datos in sesion)
            {
                lista.Add(datos.Username);
                lista.Add(datos.Password);
            }

            if (loginConnectionAuth == null)
            {
                return false;
            }
            else 
            {
                if (lista.Contains(loginConnectionAuth.Username) && lista.Contains(loginConnectionAuth.Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           

        }
    }
}
