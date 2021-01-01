using Beautiful;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace Business
{
    public class Incident
    {
        public static string Add(string json)
        {
            var deserialized = JsonConvert.DeserializeObject(json.ToString());
            var handler = (JToken)deserialized;
            var info = ((JToken)handler)[Handler.Type_Info];

            var roleInfo = JsonConvert.DeserializeObject<RoleInfo>(info.ToString());

            var result = PoweredSource.Incident.Add(roleInfo);

            return result.ToString();
        }

        public static string GetJsonList()
        {
            var tokens = Json.GetTokens<RoleInfo>(PoweredSource.Incident.GetList());

            return typeof(Incident).Name + Json.NodeType_Trees + "=" + tokens[Json.Token_Trees];
        }
    }
}
