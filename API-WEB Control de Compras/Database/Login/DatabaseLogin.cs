using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.Login
{
    public class DatabaseLogin
    {
        public MongoClient cliente;

        public IMongoDatabase database;

        public DatabaseLogin()
        {
            cliente = new MongoClient("mongodb+srv://AdminCompras:Ah4CjDYDA55gONr5@usernamesdb.8qftc.gcp.mongodb.net/UsernamesDB?retryWrites=true&w=majority");

            database = cliente.GetDatabase("ComprasAprobaciones");
        }
    }
}
