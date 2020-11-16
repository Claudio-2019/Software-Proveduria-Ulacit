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

        private IMongoCollection<CreacionLoginModel> CollectionLoginSystem;
        private IMongoCollection<CreacionLoginModel> CollectionCompradores;
        private IMongoCollection<CreacionLoginModel> CollectionJefe;
        private IMongoCollection<CreacionLoginModel> CollectionFinanciero;

        public LoginCollection()
        {
            CollectionLoginSystem = repositorio.database.GetCollection<CreacionLoginModel>("Administradores");

            CollectionCompradores = repositorio.database.GetCollection<CreacionLoginModel>("Compradores");

            CollectionJefe = repositorio.database.GetCollection<CreacionLoginModel>("Jefes");

            CollectionFinanciero = repositorio.database.GetCollection<CreacionLoginModel>("Financieros");

        }

        public async Task<List<CreacionLoginModel>> GetAuthenticationComprador()
        {
            return await CollectionCompradores.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<CreacionLoginModel>> GetAuthenticationFinanciero()
        {
            return await CollectionFinanciero.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<CreacionLoginModel>> GetAuthenticationJefe()
        {
            return await CollectionJefe.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<CreacionLoginModel>> GetAuthenticationSystem()
        {
            return await CollectionLoginSystem.FindAsync(new BsonDocument()).Result.ToListAsync();
        }
    }
}
