using System;
using Newtonsoft.Json;

namespace serverAPI
{
    public class Geo
    {
        [JsonProperty("lat")]
        public string lat{get;set;}

        [JsonProperty("lng")]
        public string lng{get;set;}
    }
}