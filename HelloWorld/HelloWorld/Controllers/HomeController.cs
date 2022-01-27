using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {

        [HttpGet]
        public string HelloWorld()
        {
            return "Ola Mundo!";
        }

    }
}
