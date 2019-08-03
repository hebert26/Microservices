 
using System.Collections.Generic; 
using Microsoft.AspNetCore.Mvc;

namespace OrdersApi.Controllers
{
    [Route("api/Orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            System.Threading.Thread.Sleep(6000);
            return new string[] { "order 1", "order 2" };
        } 
    }
}
