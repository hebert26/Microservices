 
using System.Collections.Generic; 
using Microsoft.AspNetCore.Mvc;

namespace ClientsApi.Controllers
{
    [Route("api/Clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Client 1", "client 2" };
        } 
     
    }
}
