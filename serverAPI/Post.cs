using System;
using Newtonsoft.Json;

namespace serverAPI
{
    public class Post
    {
        [JsonProperty("userId")]
        public int userId{get;set;}

        [JsonProperty("id")]
        public int id{get;set;}

        [JsonProperty("title")]
        public string title{get;set;}

        [JsonProperty("body")]
        public string body{get;set;}
    }
}