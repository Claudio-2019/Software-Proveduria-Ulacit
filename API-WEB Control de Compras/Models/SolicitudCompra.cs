using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.Models
{
    public class SolicitudCompraModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement]
        public string titulo { get; set; }
        [BsonElement]
        public string descripcion { get; set; }
        [BsonElement]
        public int cantidad { get; set; }
        [BsonElement]
        public int monto { get; set; }
        [BsonElement]
        public double total { get; set; }
        [BsonElement]
        public string correoElectronico { get; set; }
        [BsonElement]
        public int telefono { get; set; }
        [BsonElement]
        public string nombreArticulo { get; set; }
        [BsonElement]
        public string tipoArticulo { get; set; }
        [BsonElement]
        public DateTime fechaRegistro { get; set; }
       
    }
}
