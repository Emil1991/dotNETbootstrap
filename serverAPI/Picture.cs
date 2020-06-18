using System;
using Newtonsoft.Json;

namespace serverAPI
{
    public class Picture
    {
        [JsonProperty("albumId")]
        public int albumId { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string thumbnailUrl { get; set; }

    }
}