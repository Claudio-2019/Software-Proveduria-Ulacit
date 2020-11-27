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
        [Route("api/creacionLogin/UpdateUsers/{id}")]
        public async Task<IActionResult> UpdateAdministrator([FromBody] CreacionLoginModel login)
        {
            if (login == null)
            {
                return BadRequest();
            }
            else if (login.tipoUsuario == "Administrador")
            {

                await database.UpdateAdministrator(login);
                return Created("Usuario Actualizado!!", true);

            }
            else if (login.tipoUsuario == "Comprador")
            {

                await database.UpdateComprador(login);
                return Created("Usuario Actualizado!!", true);

            }
            else if (login.tipoUsuario == "Jefe")
            {

                await database.UpdateJefe(login);
                return Created("Usuario Actualizado!!", true);

            }
            else if (login.tipoUsuario == "Financiero")
            {
                await database.UpdateFinanciero(login);
                return Created("Usuario Actualizado!!", true);
            }

            return Created("Database updated!!", true);
        }

        //delete para borrar notif
        [HttpPost]
        [Route("api/creacionLogin/DeleteLogin")]
        public async Task<IActionResult> DeleteLogin([FromBody] CreacionLoginModel deleteLogin)
        {
            if (deleteLogin._id == String.Empty)
            {
                return NoContent();

            }
            else if(deleteLogin.tipoUsuario == "Comprador")
            {
                await database.DeleteComprador(deleteLogin._id);
                return Ok("Comprador eliminado del sistema");
            }
            else if (deleteLogin.tipoUsuario == "Administrador")
            {
                await database.DeleteAdministrator(deleteLogin._id);
                return Ok("Administrador eliminado del sistema");
            }
            else if (deleteLogin.tipoUsuario == "Jefe")
            {
                await database.DeleteJefe(deleteLogin._id);
                return Ok("Jefe eliminado del sistema");

            }
            else if (deleteLogin.tipoUsuario == "Financiero")
            {
                await database.DeleteFinanciero(deleteLogin._id);
                return Ok("Financiero eliminado del sistema");
            }
            else
            {
                return NotFound("No se encontro el usuario a eliminar!");
            }
        }
    }
}
