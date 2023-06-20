using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       // [Route("[Action]")]
        [HttpGet]
        public string GetName()
        {
            return "Test";
        }
        [HttpGet]
        public string Get()
        {
            return "Test1";
        }

    }
}
