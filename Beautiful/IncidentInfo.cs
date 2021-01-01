using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful
{
    [JsonObject("incident_info")]
    public class IncidentInfo : ParentInfo
    {
        [JsonProperty("prioity_id")]
        public int PriorityID { get; set; } = 0;
         
        [JsonProperty("desc")]        
        public string Desc { get; set; }
    }


}
