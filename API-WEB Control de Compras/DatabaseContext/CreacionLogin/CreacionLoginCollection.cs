using API_Inventario.Models;
using API_WEB_Control_de_Compras.DatabaseContext.Login;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.CreacionLogin
{
    public class CreacionLoginCollection
    {

        internal DatabaseConfig repositorio = new DatabaseConfig();

        private IMongoCollection<LoginModel> Collection;

        public CreacionLoginCollection()
        {
            Collection = repositorio.database.GetCollection<LoginModel>("Creacion login");
        }

        public async Task<List<LoginModel>> getAllLogin()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<LoginModel> getLoginWithId(string id)
        {

            return await Collection.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
        }

        public async Task InsertarLogin(LoginModel login)
        {
            await Collection.InsertOneAsync(login);
        }

        public async Task UpdateNotificacion(LoginModel login)
        {
            var FiltroId = Builders<LoginModel>.Filter.Eq(dato => dato._id, login._id);

            await Collection.ReplaceOneAsync(FiltroId, login);
        }

        public async Task DeleteNotificacion(string id)
        {
            var FiltroConsulta = Builders<LoginModel>.Filter.Eq(s => s._id, new ObjectId(id));

            await Collection.DeleteOneAsync(FiltroConsulta);

        }

    }
}
