using Microsoft.AspNetCore.Mvc;

namespace diploma_thesis_backend.Controllers
{
    public class TestController : Controller
    {

        //test endpoint which returns string
        [HttpGet]
        [Route("api/test")]
        public IActionResult Test()
        {
            return Ok("Test");
        }
    }
}
