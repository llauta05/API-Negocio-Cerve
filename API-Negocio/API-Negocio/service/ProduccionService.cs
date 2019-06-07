using Aggregates;
using API_Negocio.model;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.service
{
    public class ProduccionService
    {

        private readonly IMongoCollection<Produccion> _produccion;
        /// <summary>
        /// asdasdasdasdas
        /// </summary>
        /// <param name="config"></param>
        public ProduccionService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("localhost"));
            var database = client.GetDatabase("BeerSys");
            _produccion = database.GetCollection<Produccion>("produccion");
        }
        public List<Produccion> Get()
        {
            try
            {
                return _produccion.Find(Produccion => false).ToList();
            }
            catch (Exception e)
            {
                throw new BusinessException(e.ToString());
            }

        }
    }
}
