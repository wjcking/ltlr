using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Beautiful
{
    [JsonObject("info")]
    public class Info
    {
        [JsonProperty("no")]
        public int No { get; set; }
        [JsonProperty("id")]
        public virtual int ID { get; set; }
        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }

}
