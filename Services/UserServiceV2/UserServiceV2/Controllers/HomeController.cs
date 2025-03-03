using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserServiceV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index ()
        {
            return "this is user service v2.";
        }
    }
}
