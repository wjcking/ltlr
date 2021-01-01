using Beautiful;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace Business
{
    public static class Role
    {

        public static string Add(string json)
        {
            var deserialized = JsonConvert.DeserializeObject(json.ToString());
            var handler = (JToken)deserialized;
            var info = ((JToken)handler)[Handler.Type_Info];

            var roleInfo = JsonConvert.DeserializeObject<RoleInfo>(info.ToString());

            var result = PoweredSource.Role.Add(roleInfo);

            return result.ToString();
        }

        public static string GetJsonList()
        {
            var tokens = Json.GetTokens<RoleInfo>(PoweredSource.Role.GetList());

            return typeof(RoleInfo).Name + Json.NodeType_Trees + "=" + tokens[Json.Token_Trees];
        }

        public static string GetJsonGroup()
        {
            var tokens = Json.GetTokens<RoleInfo>(PoweredSource.Role.GetListGroup());

            return "RoleGroup" + Json.NodeType_Trees + "=" + tokens[Json.Token_Trees];
        }
    }
}
