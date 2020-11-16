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
        private List<string> rolActual = new List<string>();
        private readonly ArrayList listaAdministradores = new ArrayList();
        private readonly ArrayList listaCompradores = new ArrayList();
        private readonly ArrayList listaJefes = new ArrayList();
        private readonly ArrayList listaFinancieros = new ArrayList();

        [HttpPost]
        [Route("api/Login/CrearAutenticacion")]
        public async Task<IActionResult> CrearAutenticacion([FromBody] LoginModel loginConnectionAuth)
        {
            string[] roles = { "Administrador", "Comprador", "Jefe", "Financiero" };
            var sesionAdministradores = await database.GetAuthenticationSystem();
            var sesionComprador = await database.GetAuthenticationComprador();
            var sesionJefe = await database.GetAuthenticationJefe();
            var sesionFinanciero = await database.GetAuthenticationFinanciero();

            foreach (var datos in sesionAdministradores)
            {
                listaAdministradores.Add(datos.Username);
                listaAdministradores.Add(datos.Password);
            }
            foreach (var datos in sesionComprador)
            {
                listaCompradores.Add(datos.Username);
                listaCompradores.Add(datos.Password);
            }
            foreach (var datos in sesionJefe)
            {
                listaJefes.Add(datos.Username);
                listaJefes.Add(datos.Password);
            }
            foreach (var datos in sesionFinanciero)
            {
                listaFinancieros.Add(datos.Username);
                listaFinancieros.Add(datos.Password);
            }

            if (loginConnectionAuth == null)
            {
                return NoContent();
            }
            else
            {
                if (listaAdministradores.Contains(loginConnectionAuth.Username) && listaAdministradores.Contains(loginConnectionAuth.Password))
                {
                    rolActual.Add(roles[0]);
                    return Ok(rolActual);
                }
                else if (listaCompradores.Contains(loginConnectionAuth.Username) && listaCompradores.Contains(loginConnectionAuth.Password))
                {
                    rolActual.Add(roles[1]);
                    return Ok(rolActual);
                }
                else if (listaJefes.Contains(loginConnectionAuth.Username) && listaJefes.Contains(loginConnectionAuth.Password))
                {
                    rolActual.Add(roles[2]);
                    return Ok(rolActual);
                }
                else if (listaFinancieros.Contains(loginConnectionAuth.Username) && listaFinancieros.Contains(loginConnectionAuth.Password))
                {
                    rolActual.Add(roles[3]);
                    return Ok(rolActual);
                }
                else
                {
                    return NoContent();
                }
            }

        }

    }
}
