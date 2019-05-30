using Aggregates;
using API_Negocio.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.serviceContact
{
    public interface IProductoService
    {
        List<Producto> Get();
        Producto Get(string id);
        Producto Create(Producto Producto);
        void Update(string id, Producto ProductoIn);
        bool Update(Producto ProductoIn);
        bool Remove(Producto ProductoIn);
        bool Remove(string id);
    }
}
