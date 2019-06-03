using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Negocio.model;
using API_Negocio.service;
using API_Negocio.serviceContact;
using Microsoft.AspNetCore.Mvc;

namespace API_Negocio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ProductoService _productoService;

        public ValuesController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            return _productoService.Get();
        }

        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "asdsssss" };
        //}

        // GET api/values/5
        [HttpGet]
        [Route("GetById/")]
        public ActionResult<Producto> GetById(string id)
        {
            return _productoService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
