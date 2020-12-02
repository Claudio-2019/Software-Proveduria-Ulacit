using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_WEB_Control_de_Compras.DatabaseContext.AprobacionPorFinanciero;
using API_WEB_Control_de_Compras.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace API_WEB_Control_de_Compras.Controllers
{
    public class AprobacionPorFinancieroController : Controller
    {
        private IAprobacionPorFinanciero database = new AprobacionPorFinancieroCollection();

        //get todos
        [HttpGet]
        [Route("api/aprobacionPorFinanciero/GetAllAprobaciones")]
        public async Task<IActionResult> GetAllAprobaciones()
        {
            return Ok(await database.getAllAprobacionesPorFinanciero());
        }

        //get por id
        [HttpGet]
        [Route("api/aprobacionPorFinanciero/GetAprobacion/{id}")]
        public async Task<IActionResult> GetAprobacion(string id)
        {
            return Ok(await database.getAprobacionesPorFinancieroWithId(id));
        }

        //post para agregar
        [HttpPost]
        [Route("api/aprobacionPorFinanciero/InsertAprobacion")]
        public async Task<IActionResult> InsertAprobacion([FromBody] AprobacionPorFinancieroModel aprobacion)
        {
            var test = aprobacion.titulo;
            if (aprobacion == null)
            {
                return BadRequest();
            }
            else
            {
                await database.InsertarAprobacionPorFinanciero(aprobacion);

            }
            return Created("Aprobacion Insertada!!", true);
        }

        //put para hacer update a aprobacion
        [HttpPut]
        [Route("api/aprobacionPorFinanciero/UpdateAprobacion/{id}")]
        public async Task<IActionResult> UpdateAprobacion([FromBody] AprobacionPorFinancieroModel aprobacion, string id)
        {
            if (aprobacion == null)
            {
                return BadRequest();
            }
            else
            {
                aprobacion._id = new ObjectId(id);

                await database.UpdateAprobacionPorFinanciero(aprobacion);

            }
            return Created("Aprobacion Actualizada!!", true);
        }

        //delete para borrar aprobacion
        [HttpDelete]
        [Route("api/aprobacionPorFinanciero/DeleteAprobacion/{id}")]
        public async Task<IActionResult> DeleteAprobacion(string id)
        {
            if (id == String.Empty)
            {
                return NoContent();

            }
            else
            {
                await database.DeleteAprobacionPorFinanciero(id);
                return Ok();
            }
        }
    }
}
