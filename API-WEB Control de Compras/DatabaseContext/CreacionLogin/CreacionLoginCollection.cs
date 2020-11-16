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

        private IMongoCollection<CreacionLoginModel> CollectionCompradores;
        private IMongoCollection<CreacionLoginModel> CollectionAdministradores;
        private IMongoCollection<CreacionLoginModel> CollectionJefes;
        private IMongoCollection<CreacionLoginModel> CollectionFinancieros;

        public CreacionLoginCollection()
        {
            CollectionAdministradores = repositorio.database.GetCollection<CreacionLoginModel>("Administradores");
            CollectionCompradores = repositorio.database.GetCollection<CreacionLoginModel>("Compradores");
            CollectionJefes = repositorio.database.GetCollection<CreacionLoginModel>("Jefes");
            CollectionFinancieros = repositorio.database.GetCollection<CreacionLoginModel>("Financieros");
        }

        public async Task<List<CreacionLoginModel>> getAllAdministradores()
        {
            return await CollectionAdministradores.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<CreacionLoginModel>> getAllCompradores()
        {
            return await CollectionCompradores.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<CreacionLoginModel>> getAllJefes()
        {
            return await CollectionJefes.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<List<CreacionLoginModel>> getAllFinancieros()
        {
            return await CollectionFinancieros.FindAsync(new BsonDocument()).Result.ToListAsync();
        }
        public async Task InsertarComprador(CreacionLoginModel login)
        {
            await CollectionCompradores.InsertOneAsync(login);
        }
        public async Task InsertarAdmin(CreacionLoginModel login)
        {
            await CollectionAdministradores.InsertOneAsync(login);
        }
        public async Task InsertarJefe(CreacionLoginModel login)
        {
            await CollectionJefes.InsertOneAsync(login);

        }
        public async Task InsertarFinanciero(CreacionLoginModel login)
        {
            await CollectionFinancieros.InsertOneAsync(login);
        }

       
    }
}
