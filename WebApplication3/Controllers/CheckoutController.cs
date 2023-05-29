using Microsoft.AspNetCore.Mvc;
using WebApplication3.Service;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/checkout")]
    public class CheckoutController:ControllerBase
    {
        private readonly CheckoutService checkoutService;

        public CheckoutController()
        {
            checkoutService = new CheckoutService();
        }

        [HttpGet]
        public IActionResult CalculateTotalPrice(string skus)
        {
            decimal totalPrice = checkoutService.CalculateTotalPrice(skus);
            return Ok(totalPrice);
        }
    }
}
