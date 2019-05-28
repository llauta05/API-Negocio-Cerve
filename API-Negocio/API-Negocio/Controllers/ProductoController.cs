using API_Negocio.model;
using API_Negocio.service;
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
        private readonly ProductoService _productoService;

        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            return _productoService.Get();
        }
     
        // GET api/values/5
        [HttpGet]
        [Route("GetById/")]
        public ActionResult<Producto> GetById(string id)
        {
            return _productoService.Get(id);
        }
        [HttpPost]
        [Route("Create/")]
        public ActionResult<Producto> Create(Producto producto)
        {
            return _productoService.Create(producto);
        }
        [HttpPost]
        [Route("Delete/")]
        public ActionResult<Producto> Delete(Producto producto)
        {
            return _productoService.Remove(producto);
        }
    }
}
