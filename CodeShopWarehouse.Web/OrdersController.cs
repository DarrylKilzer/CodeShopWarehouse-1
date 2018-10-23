using CodeShopWarehouse.Business;
using Microsoft.AspNetCore.Mvc;

namespace CodeShopWarehouse.Web
{
    [ApiController]    
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly OrdersService _ordersService;
        public OrdersController(OrdersService ordersService)
        {
            _ordersService = ordersService;
        }
        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return
            View();
        }   
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ordersService.GetUnprocessedOrders());
        }   
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_ordersService.GetById(id));
        }   
        [HttpPost]
        public IActionResult Create()
        {
            
        }
    }
}