using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.Models
{
    public class LoginComprador
    {
        public ObjectId _id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
