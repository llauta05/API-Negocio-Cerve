using Aggregates;
using API_Negocio.model;
using API_Negocio.serviceContact;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.service
{
    public class StockService : IStockService
    {

        private readonly IMongoCollection<Stock> _stock;

        public StockService()
        {
            _stock.InsertOne(new Stock { Id = "asdlñ", ProductoId = "5ce9b61e8f80d860bd36a67c", Previsto = 0, Real = 0 });
           
        }
        public StockService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("localhost"));
            var database = client.GetDatabase("BeerSys");
            _stock = database.GetCollection<Stock>("stock");
        }
        public Stock Create(Stock stock)
        {
            throw new NotImplementedException();
        }

        public List<Stock> Get()
        {
            try
            {
                return _stock.Find(Producto => true).ToList();
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }
        }

        public Stock Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Stock stock)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Stock stock)
        {
            throw new NotImplementedException();
        }

        public bool Update(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
