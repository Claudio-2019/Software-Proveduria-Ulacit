﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.Models
{
    public class LoginJefe
    {
        public ObjectId _id { get; set; }
        public string CorreoElectronico { get; set; }
        public string contraseña { get; set; }
    }
}
