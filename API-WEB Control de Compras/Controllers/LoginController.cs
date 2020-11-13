using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.Login;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace API_WEB_Control_de_Compras.Controllers
{
    public class LoginController : Controller
    {
        private ILoginAuth database = new LoginCollection();

        [HttpPost]
        [Route("api/Login/CrearAutenticacion")]
        public async Task<Boolean> CrearAutenticacion([FromBody] LoginModel loginConnectionAuth)
        {

            var sesion = await database.GetAuthenticationSystem();

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
        [HttpPost]
        [Route("api/Login/AutenticacionJefe")]
        public async Task<Boolean> AutenticacionJefe([FromBody] LoginJefe loginConnectionAuth)
        {

            var sesion = await database.GetAuthenticationJefe();

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
        [HttpPost]
        [Route("api/Login/AutenticacionComprador")]
        public async Task<Boolean> AutenticacionComprador([FromBody] LoginComprador loginConnectionAuth)
        {

            var sesion = await database.GetAuthenticationComprador();

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
        [HttpPost]
        [Route("api/Login/AutenticacionFinanciero")]
        public async Task<Boolean> AutenticacionFinanciero([FromBody] LoginFinanciero loginConnectionAuth)
        {

            var sesion = await database.GetAuthenticationFinanciero();

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
