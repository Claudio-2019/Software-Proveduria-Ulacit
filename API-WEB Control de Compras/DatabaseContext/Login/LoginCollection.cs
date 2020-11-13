using API_WEB_Control_de_Compras.DatabaseContext.Login;
using API_WEB_Control_de_Compras.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.Login
{
    public class LoginCollection : ILoginAuth
    {
        internal DatabaseConfig repositorio = new DatabaseConfig();

        private IMongoCollection<LoginModel> CollectionLoginSystem;
        private IMongoCollection<LoginComprador> CollectionCompradores;
        private IMongoCollection<LoginJefe> CollectionJefe;
        private IMongoCollection<LoginFinanciero> CollectionFinanciero;

        public LoginCollection()
        {
            CollectionLoginSystem = repositorio.database.GetCollection<LoginModel>("Login");

            CollectionCompradores = repositorio.database.GetCollection<LoginComprador>("Compradores");

            CollectionJefe = repositorio.database.GetCollection<LoginJefe>("Jefes");

            CollectionFinanciero = repositorio.database.GetCollection<LoginFinanciero>("Financieros");

        }

        public async Task<List<LoginComprador>> GetAuthenticationComprador()
        {
            return await CollectionCompradores.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<LoginFinanciero>> GetAuthenticationFinanciero()
        {
            return await CollectionFinanciero.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<LoginJefe>> GetAuthenticationJefe()
        {
            return await CollectionJefe.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<LoginModel>> GetAuthenticationSystem()
        {
            return await CollectionLoginSystem.FindAsync(new BsonDocument()).Result.ToListAsync();
        }
    }
}
