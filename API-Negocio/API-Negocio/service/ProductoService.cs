using Aggregates;
using API_Negocio.model;
using API_Negocio.serviceContact;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.service
{
    public class ProductoService : IProductoService
    {
        private readonly IMongoCollection<Producto> _productos;

        public ProductoService()
        {
            _productos.InsertOne(new Producto { Id = "asdlñ", Nombre = "asdadas", ml = 12, Precio = 102 });
            _productos.InsertOne(new Producto { Id = "asdwqqlñ", Nombre = "test1", ml = 12, Precio = 11 });
            _productos.InsertOne(new Producto { Id = "as111dlñ", Nombre = "feeewew", ml = 12, Precio = 33 });
            _productos.InsertOne(new Producto { Id = "asd222lñ", Nombre = "asdada3232s", ml = 12, Precio = 44 });
        }
        
        public ProductoService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("localhost"));
            var database = client.GetDatabase("BeerSys");
            _productos = database.GetCollection<Producto>("producto");
        }
        public List<Producto> Get()
        {
            try
            {
                return _productos.Find(Producto => true).ToList();
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }

        }

        public Producto Get(string id)
        {
            try
            {
                return _productos.Find<Producto>(Producto => Producto.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }

        }

        public Producto Create(Producto Producto)
        {
            try
            {
                _productos.InsertOne(Producto);
                return Producto;
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }
        }

        public void Update(string id, Producto ProductoIn)
        {
            try
            {
                _productos.ReplaceOne(Producto => Producto.Id == id, ProductoIn);
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }
        }
        public bool Update(Producto ProductoIn)
        {
            try
            {
                var id = ProductoIn.Id;
                _productos.ReplaceOne(Producto => Producto.Id == id, ProductoIn);
                return true;
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }
        }

        public bool Remove(Producto ProductoIn)
        {
            try
            {
                _productos.DeleteOne(Producto => Producto.Id == ProductoIn.Id);
                return true;
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }
        }

        public bool Remove(string id)
        {
            try
            {
                _productos.DeleteOne(Producto => Producto.Id == id);
                return true;
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }
        }
    }
}
