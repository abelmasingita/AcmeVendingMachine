using AcmeVendingMachine.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcmeVendingMachine.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendingMachineController : ControllerBase
    {
        private readonly VendingMachineService vendingMachine;

        public VendingMachineController(VendingMachineService vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        [HttpGet("calculateChange")]
        public IActionResult CalculateChange(string currency, double purchaseAmount, double tenderAmount)
        {
            try
            {
                var change = this.vendingMachine.CalculateChange(currency,purchaseAmount,tenderAmount);
                return Ok(change);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
