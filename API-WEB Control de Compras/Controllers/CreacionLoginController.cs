using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.CreacionLogin;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace API_WEB_Control_de_Compras.Controllers
{
    public class CreacionLoginController : Controller
    {
        private ICreacionLogin database = new CreacionLoginCollection();

        //get todos
        [HttpGet]
        [Route("api/creacionLogin/ListaAdministradores")]
        public async Task<IActionResult> ListaAdministradores()
        {
            return Ok(await database.getAllAdministradores());
        }
        [HttpGet]
        [Route("api/creacionLogin/ListaCompradores")]
        public async Task<IActionResult> ListaCompradores()
        {
            return Ok(await database.getAllCompradores());
        }
        [HttpGet]
        [Route("api/creacionLogin/ListaJefes")]
        public async Task<IActionResult> ListaJefes()
        {
            return Ok(await database.getAllJefes());
        }
        [HttpGet]
        [Route("api/creacionLogin/ListaFinancieros")]
        public async Task<IActionResult> ListaFinancieros()
        {
            return Ok(await database.getAllFinancieros());
        }

        //get por id
        //[HttpGet]
        //[Route("api/creacionLogin/GetLogin/{id}")]
        //public async Task<IActionResult> GetLogin(string id)
        //{
        //    return Ok(await database.getLoginWithId(id));
        //}

        //post para agregar
        [HttpPost]
        [Route("api/creacionLogin/InsertarUsuario")]
        public async Task<IActionResult> InsertarUsuario([FromBody] CreacionLoginModel NewUser)
        {
            if (NewUser == null)
            {
                return BadRequest();
            }
            else if (NewUser.tipoUsuario == "Comprador")
            {
                await database.InsertarComprador(NewUser);

            }
            else if (NewUser.tipoUsuario == "Administrador")
            {
                await database.InsertarAdmin(NewUser);

            }
            else if (NewUser.tipoUsuario == "Jefe")
            {
                await database.InsertarJefe(NewUser);

            }
            else if (NewUser.tipoUsuario == "Financiero")
            {
                await database.InsertarFinanciero(NewUser);

            }

            return Ok("Usuario creado en la base de datos");



        }

        //put para hacer update a login
        [HttpPut]
        [Route("api/creacionLogin/UpdateLogin/{id}")]
        public async Task<IActionResult> UpdateLogin([FromBody] CreacionLoginModel login, string id)
        {
            if (login == null)
            {
                return BadRequest();
            }
            else
            {
                login._id = id;

                await database.UpdateLogin(login);

            }
            return Created("Login Actualizado!!", true);
        }

        ////delete para borrar notif
        //[HttpDelete]
        //[Route("api/creacionLogin/DeleteLogin/{id}")]
        //public async Task<IActionResult> DeleteLogin(string id)
        //{
        //    if (id == String.Empty)
        //    {
        //        return NoContent();

        //    }
        //    else
        //    {
        //        await database.DeleteLogin(id);
        //        return Ok();
        //    }
        //}
    }
}
