using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.Models
{
    public class NotificacionModel
    {
        public ObjectId _id { get; set; }
        public string sujeto { get; set; }
        public string correoElectronico { get; set; }
        public string descripcion { get; set; }
        public string compra { get; set; }
        public string aprobador { get; set; }
        public bool estado { get; set; }
    }
}
