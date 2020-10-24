using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.Models
{
    public class AprobacionPorFinancieroModel
    {
        public ObjectId _id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public int monto { get; set; }
        public string correoElectronico { get; set; }
        public string nombreArticulo { get; set; }
        public bool estadoActual { get; set; }
    }
}
