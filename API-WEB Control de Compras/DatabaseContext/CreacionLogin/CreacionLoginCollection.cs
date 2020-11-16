using API_WEB_Control_de_Compras.Models;
using API_WEB_Control_de_Compras.DatabaseContext.Login;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.CreacionLogin
{
    public class CreacionLoginCollection : ICreacionLogin
    {

        internal DatabaseConfig repositorio = new DatabaseConfig();

        private IMongoCollection<CreacionLoginModel> Collection;

        public CreacionLoginCollection()
        {
            Collection = repositorio.database.GetCollection<CreacionLoginModel>("Usuarios");
        }

        public async Task<List<CreacionLoginModel>> getAllLogin()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<CreacionLoginModel> getLoginWithId(string id)
        {

            return await Collection.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
        }

        public async Task InsertarLogin(CreacionLoginModel login)
        {
            await Collection.InsertOneAsync(login);
        }

        public async Task UpdateLogin(CreacionLoginModel login)
        {
            var FiltroId = Builders<CreacionLoginModel>.Filter.Eq(dato => dato._id, login._id);

            await Collection.ReplaceOneAsync(FiltroId, login);
        }

        public async Task DeleteLogin(string id)
        {
            var FiltroConsulta = Builders<CreacionLoginModel>.Filter.Eq(s => ObjectId.Parse(s._id), new ObjectId(id));

            await Collection.DeleteOneAsync(FiltroConsulta);

        }

        
    }
}
