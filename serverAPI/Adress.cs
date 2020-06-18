using System;
using Newtonsoft.Json;

namespace serverAPI
{
    public class Adress
    {
        [JsonProperty("street")]
        public string street{get;set;}

        [JsonProperty("suite")]
        public string suite{get;set;}

        [JsonProperty("city")]
        public string city{get;set;}

        [JsonProperty("zipcode")]
        public string zipcode{get;set;}

        [JsonProperty("geo")]
        public Geo geo{get;set;}

    
    }
}