using API_Negocio.model;
using API_Negocio.service;
using API_Negocio.serviceContact;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService _IProductoService;

        public ProductoController(ProductoService productoService)
        {
            _IProductoService = productoService;
        }

        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            return _IProductoService.Get();
        }
     
        // GET api/values/5
        [HttpGet]
        [Route("GetById/")]
        public ActionResult<Producto> GetById(string id)
        {
            return _IProductoService.Get(id);
        }
        [HttpPost]
        [Route("Create/")]
        public ActionResult<Producto> Create(Producto producto)
        {
            return _IProductoService.Create(producto);
        }
        [HttpPost]
        [Route("Delete/")]
        public ActionResult<bool> Delete(Producto producto)
        {
            return _IProductoService.Remove(producto.Id);
        }

        [HttpPut]
        [Route("Update/")]
        public ActionResult<bool> Update(Producto producto)
        {
            return _IProductoService.Update(producto);
        }
    }
}
