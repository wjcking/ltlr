using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using KansaiUtils;
using Newtonsoft.Json.Linq;

namespace Beautiful
{
    [JsonObject("role_info")]
    public partial class RoleInfo : ParentInfo
    {
        [JsonProperty("priority_id")]
        public int PriorityID { get; set; } = 0;
        [JsonProperty("category_info")]
        public RoleCategory CategoryInfo { get; set; } = new RoleCategory();
        [JsonProperty("incident_info")]
        public IncidentInfo IncidentInfo { get; set; } = new IncidentInfo();
        [JsonProperty("desc")]
        public string Desc { get; set; } = String.Empty;
         [JsonProperty("insert_time")]
        public string InsertTime { get; set; } = Converter.ToString(DateTime.Now);
         [JsonProperty("update_time")]                       
        public string UpdateTime { get; set; } = Converter.ToString(DateTime.Now);

        public override string[] Tokens
        {
            get
            {
                var incidentJson = new StringBuilder();
                incidentJson.Append(" category_info: { id: " + CategoryInfo.ID + ",  name: \"" + CategoryInfo.Name + "\" }");
                incidentJson.Append(",incident_info: { id: 0, desc: \"" + IncidentInfo.Desc.Translate() + "\" }");
                incidentJson.Append($",insert_time:\"{InsertTime.ToTimeString()}\",update_time:\"{UpdateTime.ToTimeString() }\"");
                //should be copied or will be used the base one
                var tokens= base.Tokens;
                tokens[Json.Token_Trees]= "{ " + $"no:{No}, id:{ID}, pId: {ParentID}, name:\"{Name}\", {TreeStyle}" + incidentJson.ToString() + "},";

                return tokens;
            }
        }
    }
}
