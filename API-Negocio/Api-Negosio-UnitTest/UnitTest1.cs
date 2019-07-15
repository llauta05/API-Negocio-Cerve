using Aggregates;
using API_Negocio.Controllers;
using API_Negocio.model;
using API_Negocio.service;
using API_Negocio.serviceContact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Api_Negosio_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IProductoService _service;
        private readonly ProductoController productoController;

        public UnitTest1()
        {
            _service = new ProductoService();
            productoController = new ProductoController(_service);
        }

        [TestMethod]
        public void GetProductos()
        {
            // Act
            var okResult = productoController.Get();

            // Assert
            //Assert.IsType<OkObjectResult>(okResult.Result);
            //var response = servicio.Get();

            Assert.IsInstanceOfType(okResult, typeof(OkObjectResult));

            //    var controller = new ProductoController(_productoService);
            //    var response = controller.Get();

            //    //Assert.IsInstanceOfType(response, typeof(OkObjectResult));
            //    //       Assert.IsInstanceOfType((response as OkObjectResult).Value, typeof(IMongoCollection<Producto>));
            //    //          Assert.AreEqual(6, ((response as OkObjectResult).Value as IMongoCollection<Producto>));
        }


    }
}

