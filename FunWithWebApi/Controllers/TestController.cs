using System.Web.Http;

namespace FunWithWebApi.Controllers
{
    [Route("api/v1/test")]
    public class TestController : ApiController
    {
        [Route("hello")]
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
