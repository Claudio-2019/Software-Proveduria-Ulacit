using API_WEB_Control_de_Compras.DatabaseContext.Login;
using API_WEB_Control_de_Compras.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.SolicitudDeCompras
{
    public class SolicitudCompra : ISolicitudCompra
    {
        internal DatabaseConfig repositorio = new DatabaseConfig();

        private IMongoCollection<SolicitudCompraModel> Collection;


        public SolicitudCompra()
        {
            Collection = repositorio.database.GetCollection<SolicitudCompraModel>("SolicitudCompra");

        }

        public async Task<List<SolicitudCompraModel>> getAllSolicitudCompra()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<SolicitudCompraModel> getSolicitudCompraWithId(string id)
        {

            return await Collection.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
        }

        public async Task InsertarSolicitudCompra(SolicitudCompraModel solicitudcompra)
        {
            await Collection.InsertOneAsync(solicitudcompra);
        }

        public async Task UpdateSolicitudCompra(SolicitudCompraModel solicitudcompra)
        {
            var FiltroId = Builders<SolicitudCompraModel>.Filter.Eq(dato => dato._id, solicitudcompra._id);

            await Collection.ReplaceOneAsync(FiltroId, solicitudcompra);
        }

        public async Task DeleteSolicitudCompra(string id)
        {
            var FiltroConsulta = Builders<SolicitudCompraModel>.Filter.Eq(s => s._id, new ObjectId(id));

            await Collection.DeleteOneAsync(FiltroConsulta);

        }
    }
}
