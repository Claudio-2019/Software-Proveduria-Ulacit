using API_Inventario.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Inventario.DatabaseContext.Login
{
    public class LoginCollection : ILoginAuth
    {
        internal DatabaseLogin repositorio = new DatabaseLogin();

        private IMongoCollection<LoginModel> Collection;

        public LoginCollection()
        {
            Collection = repositorio.database.GetCollection<LoginModel>("Login");

        }

        public async Task<List<LoginModel>> GetAuthenticationLogin()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }
    }
}
