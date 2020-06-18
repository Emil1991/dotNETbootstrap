using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace serverAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            // var model = new SearchModel();
            var url = "https://jsonplaceholder.typicode.com/users";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    using (var content = response.Content)
                    {
                        //get the json result from your api
                        var result = await content.ReadAsStringAsync();
                        var jRes = JsonConvert.DeserializeObject<List<User>>(result);
                        return jRes;
                    }
                }
            }
        }

        [HttpGet("posts/{id}")]
        public async Task<List<Post>> GetPost(int id)
        {
            // var model = new SearchModel();
            var url = "https://jsonplaceholder.typicode.com/posts";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    using (var content = response.Content)
                    {
                        //get the json result from your api
                        var result = await content.ReadAsStringAsync();
                        var jRes = JsonConvert.DeserializeObject<List<Post>>(result);
                        List<Post> userPosts = new List<Post>();

                        foreach (Post p in jRes)
                        {
                            if (p.userId == id)
                            {
                                userPosts.Add(p);
                            }
                        }
                        return userPosts;
                    }
                }
            }
        }

        [HttpGet("pics")]
        public async Task<List<Picture>> GetPics()
        {
            // var model = new SearchModel();
            var url = "https://jsonplaceholder.typicode.com/photos";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    using (var content = response.Content)
                    {
                        //get the json result from your api
                        var result = await content.ReadAsStringAsync();
                        var jRes = JsonConvert.DeserializeObject<List<Picture>>(result);
                        return jRes;
                    }
                }
            }
        }
    }
}
