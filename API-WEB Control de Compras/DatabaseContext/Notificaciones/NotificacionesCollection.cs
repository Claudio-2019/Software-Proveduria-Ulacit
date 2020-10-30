using API_WEB_Control_de_Compras.DatabaseContext.Login;
using API_WEB_Control_de_Compras.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace API_WEB_Control_de_Compras.DatabaseContext.Notificaciones
{
    public class NotificacionesCollection : INotificaciones
    {

        internal DatabaseConfig repositorio = new DatabaseConfig();

        private IMongoCollection<NotificacionModel> Collection;

        public NotificacionesCollection() { 
            Collection = repositorio.database.GetCollection<NotificacionModel>("Notificaciones");
        }

        public async Task<List<NotificacionModel>> getAllNotificaciones() {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync(); 
        }

        public async Task<NotificacionModel> getNotificacionWithId(string id)
        {

            return await Collection.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
        }

        public async Task InsertarNotificacion(NotificacionModel notificacion)
        {
            await Collection.InsertOneAsync(notificacion);
        }

        public async Task UpdateNotificacion(NotificacionModel notificacion)
        {
            var FiltroId = Builders<NotificacionModel>.Filter.Eq(dato => dato._id, notificacion._id);

            await Collection.ReplaceOneAsync(FiltroId, notificacion);
        }

        public async Task DeleteNotificacion(string id)
        {
            var FiltroConsulta = Builders<NotificacionModel>.Filter.Eq(s => s._id, new ObjectId(id));

            await Collection.DeleteOneAsync(FiltroConsulta);

        }
    }
}
