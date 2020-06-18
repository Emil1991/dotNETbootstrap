using System;
using Newtonsoft.Json;

namespace serverAPI
{
    public class User
    {
        [JsonProperty("id")]
        public int id {get;set;}
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("email")]
         public string email { get; set; }

        [JsonProperty("adress")]
        public Adress adress{get;set;}
    }
}