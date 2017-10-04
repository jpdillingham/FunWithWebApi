using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Runtime.Serialization;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace FunWithWebApi.Controllers
{
    [Route("api/v1/test")]
    public class TestController : ApiController
    {
        /// <summary>
        ///     Hello world endpoint
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/test/hello")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "Everything went ok", typeof(string))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Something went wrong", typeof(Exception))]
        public string HelloWorld()
        {
            throw new Exception("Hello world!");
            return "Hello World!";
        }

        [Route("api/v1/test/add")]
        [HttpPost]
        [ValidateModel]
        public HttpResponseMessage Add([FromBody]TestObject test)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }


    }

    [DataContract]
    public class TestObject
    {
        [DataMember]
        [Required]
        [MinLength(1)]
        public string one { get; set; }

        [DataMember]
        [MinLength(1)]
        public string two { get; set; }
    }
}
