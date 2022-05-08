using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        public IActionResult Get()
        {
            var prdList = new List<Product>() {
                new Product(){ ProductId = 1022, ProductName = "Printer", UnitPrice = 2400, Quantity = 5 },
                new Product(){ ProductId = 1023, ProductName = "Keyboard", UnitPrice = 1200, Quantity = 3 },
                new Product(){ ProductId = 1024, ProductName = "iBall Mouse", UnitPrice = 890, Quantity = 4 },
                new Product(){ ProductId = 1025, ProductName = "Boat Speakers", UnitPrice = 1900, Quantity = 6 },
                new Product(){ ProductId = 1026, ProductName = "DLink Router", UnitPrice = 1350, Quantity = 2 },
                new Product(){ ProductId = 1027, ProductName = "JBL Headset", UnitPrice = 2350, Quantity = 3 },
            };

            return Ok(prdList);

        }
    }
}
