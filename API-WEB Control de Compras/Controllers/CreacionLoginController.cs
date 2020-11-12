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
        [Route("api/creacionLogin/GetAllLogin")]
        public async Task<IActionResult> GetAllLogin()
        {
            return Ok(await database.getAllLogin());
        }

        //get por id
        [HttpGet]
        [Route("api/creacionLogin/GetLogin/{id}")]
        public async Task<IActionResult> GetLogin(string id)
        {
            return Ok(await database.getLoginWithId(id));
        }

        //post para agregar
        [HttpPost]
        [Route("api/creacionLogin/InsertarLogin")]
        public async Task<IActionResult> InsertarLogin([FromBody] CreacionLoginModel NewUser)
        {
            if (NewUser == null)
            {
                return BadRequest();
            }
            else
            {
                await database.InsertarLogin(NewUser);

            }
            return Created("Login Insertado!!", true);
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
                login._id = new ObjectId(id);

                await database.UpdateLogin(login);

            }
            return Created("Login Actualizado!!", true);
        }

        //delete para borrar notif
        [HttpDelete]
        [Route("api/creacionLogin/DeleteLogin/{id}")]
        public async Task<IActionResult> DeleteLogin(string id)
        {
            if (id == String.Empty)
            {
                return NoContent();

            }
            else
            {
                await database.DeleteLogin(id);
                return Ok();
            }
        }
    }
}
