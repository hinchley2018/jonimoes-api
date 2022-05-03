using Microsoft.AspNetCore.Mvc;
namespace JonimoesApi.Controllers
{
    [ApiController]
    [Route("/api/orders")]
    public class OrdersApiController: ControllerBase
    {
        public OrdersApiController()
        {
            
        }

        [HttpGet("")]
        public IActionResult GetOrders()
        {
            return Ok();
        }
    }
}