using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.model
{
    public class Stock
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("id_producto")]
        public string ProductoId { get; set; }
        [BsonElement("real")]
        public int Real { get; set; }
        [BsonElement("previsto")]
        public int Previsto{ get; set; }


    }
}
