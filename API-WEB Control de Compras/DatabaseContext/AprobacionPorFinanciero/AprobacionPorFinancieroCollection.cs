using API_WEB_Control_de_Compras.DatabaseContext.Login;
using API_WEB_Control_de_Compras.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.AprobacionPorFinanciero
{
    public class AprobacionPorFinancieroCollection : IAprobacionPorFinanciero
    {
            internal DatabaseConfig repositorio = new DatabaseConfig();

            private IMongoCollection<AprobacionPorFinancieroModel> Collection;

            public AprobacionPorFinancieroCollection()
            {
                Collection = repositorio.database.GetCollection<AprobacionPorFinancieroModel>("AprobacionPorFinanciero");
            }

            public async Task<List<AprobacionPorFinancieroModel>> getAllAprobacionesPorFinanciero()
            {
                return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
            }

            public async Task<AprobacionPorFinancieroModel> getAprobacionesPorFinancieroWithId(string id)
            {

                return await Collection.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
            }

            public async Task InsertarAprobacionPorFinanciero(AprobacionPorFinancieroModel aprobacion)
            {
                await Collection.InsertOneAsync(aprobacion);
            }

            public async Task UpdateAprobacionPorFinanciero(AprobacionPorFinancieroModel aprobacion)
            {
                var FiltroId = Builders<AprobacionPorFinancieroModel>.Filter.Eq(dato => dato._id, aprobacion._id);

                await Collection.ReplaceOneAsync(FiltroId, aprobacion);
            }

            public async Task DeleteAprobacionPorFinanciero(string id)
            {
                var FiltroConsulta = Builders<AprobacionPorFinancieroModel>.Filter.Eq(s => s._id, new ObjectId(id));

                await Collection.DeleteOneAsync(FiltroConsulta);

            }
        }
    }

}
}
