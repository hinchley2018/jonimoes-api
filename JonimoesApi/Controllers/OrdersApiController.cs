using JonimoesApi.Services;
using Microsoft.AspNetCore.Mvc;
namespace JonimoesApi.Controllers
{
    //adds some functinoality to the controller class
    [ApiController]
    [Route("/api/orders")]
    public class OrdersApiController : ControllerBase
    {
        private readonly IOrdersService _ordersService;
        //DI in my constructors look up dependencies
        public OrdersApiController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetOrders()
        {
            var orders = await _ordersService.GetOrders();
            return Ok(orders);
        }

        [HttpPost("")]
        public ActionResult CreateOrder()
        {
            return Ok("Created Order");
        }
    }
}