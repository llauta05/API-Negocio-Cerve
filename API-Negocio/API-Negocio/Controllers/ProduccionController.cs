using API_Negocio.model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Negocio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduccionController
    {
        private readonly Produccion _produccion;

        public ProduccionController(Produccion produccion)
        {
            _produccion = produccion;
        }

    }
}
