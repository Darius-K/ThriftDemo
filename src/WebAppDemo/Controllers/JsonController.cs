using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace WebAppDemo.Controllers
{
    [Route("api/[controller]")]
    public class JsonController : Controller
    {
        // GET: api/json
        [HttpGet]
        public dynamic Get()
        {
            var content = new RestClient("http://localhost:18802/api/")
                .Execute(new RestRequest("account/{id}")
                    .AddUrlSegment("id", "123"))
                .Content;
            return JsonConvert.DeserializeObject<dynamic>(content);
        }
    }
}
