using API_Negocio.model;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.service
{
    public class ProductoService
    {
        private readonly IMongoCollection<Producto> _productos;

        public ProductoService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("localhost"));
            var database = client.GetDatabase("BeerSys");
            _productos = database.GetCollection<Producto>("producto");
        }
        public List<Producto> Get()
        {
            return _productos.Find(Producto => true).ToList();
        }

        public Producto Get(string id)
        {
            return _productos.Find<Producto>(Producto => Producto.Id == id).FirstOrDefault();
        }

        public Producto Create(Producto Producto)
        {
            _productos.InsertOne(Producto);
            return Producto;
        }

        public void Update(string id, Producto ProductoIn)
        {
            _productos.ReplaceOne(Producto => Producto.Id == id, ProductoIn);
        }

        public bool Remove(Producto ProductoIn)
        {
            _productos.DeleteOne(Producto => Producto.Id == ProductoIn.Id);
            return true;
        }

        public bool Remove(string id)
        {
            _productos.DeleteOne(Producto => Producto.Id == id);
            return true;
        }
    }
}
