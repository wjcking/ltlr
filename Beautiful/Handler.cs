using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful
{
    [JsonObject("handler")]
    public class Handler
    {
        public const string Type_Add = "add";
        public const string Type_Info = "info";
        public const string Type_List = "list";
        public const string Type_Func = "";
        public const string Type_Group = "group";

        /// <summary>
        /// Business.ClassName
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = String.Empty;
        /// <summary>
        /// Function names or store procedure prefixes
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = String.Empty;
        [JsonProperty("info")]
        public Info Info { get; set; }
        [JsonProperty("result")]
        public string Result;

        public Handler(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public HandleString HandleString { get; set; }

        public override string ToString()
        {
            return "{ name:\"" + Name + "\", type:\"" + Type + "\" }"; ;
        }
    }


}
