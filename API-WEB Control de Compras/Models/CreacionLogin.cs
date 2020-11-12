using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.Models
{
    public class CreacionLoginModel
    {
        public ObjectId _id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correoElectronico { get; set; }
        public string contraseña { get; set; }
        public string tipoUsuario { get; set; }
        public string nombreJefe { get; set; }

    }
}
