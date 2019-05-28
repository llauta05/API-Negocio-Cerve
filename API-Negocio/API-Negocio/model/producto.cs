using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API_Negocio.model
{
    public class Producto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("ml")]
        public int ml { get; set; }
        [BsonElement("precio")]
        public decimal Precio { get; set; }

    }
}
