using API_Negocio.Data;
using API_Negocio.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.serviceContact
{
    public interface IStockService
    {
        List<StockData> Get();
        Stock Get(string id);
        Stock Create(Stock stock);
        void Update(string id, Stock stock);
        bool Update(Stock stock);
        bool Remove(Stock stock);
        bool Remove(string id);
    }
}
