using AcmeVendingMachine.Server.Services;
using AcmeVendingMachine.Server.Utility.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcmeVendingMachine.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product : ControllerBase
    {
        private readonly Products products;

        public Product(Products products)
        {
            this.products = products;
        }

        [HttpGet("Product")]
        public IActionResult GetProducts()
        {
            try
            {
                var products = this.products.getProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
