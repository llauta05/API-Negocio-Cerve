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
    public class StockController: ControllerBase
    {
        private readonly StockService _stockService;

        public StockController(StockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public ActionResult<List<Stock>> Get()
        {
            return _stockService.Get();
        }
    }
}
