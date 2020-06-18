using System;
using Newtonsoft.Json;

namespace serverAPI
{
    public class Company
    {
        [JsonProperty("name")]
         public string name { get; set; }

         [JsonProperty("catchPhrase")]
         public string catchPhrase { get; set; }

         [JsonProperty("bs")]
         public string bs { get; set; }


    }
}