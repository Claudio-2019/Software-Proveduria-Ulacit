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
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement]
        public string nombre { get; set; }
        [BsonElement]
        public string apellidos { get; set; }
        [BsonElement]
        public string correoElectronico { get; set; }
        [BsonElement]
        public string contrasena { get; set; }
        [BsonElement]
        public string tipoUsuario { get; set; }
        [BsonElement]
        public string nombreJefe { get; set; }

    }
}
