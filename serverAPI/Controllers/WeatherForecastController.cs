using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;


namespace serverAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
public  async Task<JsonResult> Get()
{
    // var model = new SearchModel();
    var url = "https://jsonplaceholder.typicode.com/users";//it should be the url of your api
    using (var httpClient = new HttpClient())
    {
        using (var response = await httpClient.GetAsync(url))
        {
            using (var content = response.Content)
            {  
               //get the json result from your api
                var result = await content.ReadAsStringAsync();
                // var root = (JObject)JsonConvert.DeserializeObject(result);
                // var root = (JObject)JsonConvert.DeserializeObject(result);
                // var items = root.SelectToken("responseHeader").Children().OfType<JProperty>().ToDictionary(p => p.Name, p => p.Value);
                // foreach(var item in items)
                // {
                //     if(item.Key== "response")
                //     {
                //         var key = item.Value.SelectToken("").OfType<JProperty>().ToDictionary(p => p.Name, p => p.Value);

                //         foreach (var k in key)
                //         { 
                //             if(k.Key== "docs")
                //             {
                //                 var tests = JsonConvert.DeserializeObject<JArray>(k.Value.ToString());
                //                 var data = k.Value.SelectToken("").Children().First();
                //                 var test = data.SelectToken("").Children().OfType<JProperty>().ToDictionary(p => p.Name, p => p.Value);
                //                 foreach (var t in test)
                //                 {
                //                     if (t.Key == "url")
                //                     {
                //                         model.Source = t.Value.ToString();
                //                     }
                //                     else if (t.Key=="title")
                //                     {
                //                         model.Title = t.Value.ToString();
                //                     }
                //                 }
                //             }
                //         }
                //     }
                // }
                return new JsonResult(result);
            }
        }
    }
}
    }
}
