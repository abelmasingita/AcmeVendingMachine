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
        private readonly ProductService products;

        public Product(ProductService products)
        {
            this.products = products;
        }

        [HttpGet("Products")]
        public ActionResult GetProducts()
        {
            try
            {
                var products = this.products.GetAllProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ProductById")]
        public ActionResult GetProductById(string id)
        {
            try
            {
                var products = this.products.GetProductById(id);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
