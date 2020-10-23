using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Inventario.Models
{
    public class LoginModel
    {
        public ObjectId _id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
