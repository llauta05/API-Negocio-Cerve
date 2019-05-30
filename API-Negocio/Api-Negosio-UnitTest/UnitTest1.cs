using Aggregates;
using API_Negocio.Controllers;
using API_Negocio.model;
using API_Negocio.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Api_Negosio_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private IMongoCollection<Producto> _productoService;
       // private IConfiguration config;

        public UnitTest1()
        {
            var serviceProduct = new ProductoService();

        }

        [TestMethod]
        public void GetProductos()
        {
            var productoController = new ProductoController(_productoService);
            var response = productoController.Get();

            //Assert.IsInstanceOfType(response, typeof(OkObjectResult));
            //       Assert.IsInstanceOfType((response as OkObjectResult).Value, typeof(IMongoCollection<Producto>));
            //          Assert.AreEqual(6, ((response as OkObjectResult).Value as IMongoCollection<Producto>));
        }


    }
}

