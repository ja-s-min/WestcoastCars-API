using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        [HttpGet]
        public ActionResult()
        {
            return Ok("Det funkar");
            
        }
    }
}
