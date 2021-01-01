using Beautiful;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void handleList()
        {
            string fileName = "content/";
            var handleList = new List<Handler>();

            //handleList.Add(new Handler("role", "add", Business.Role.AddRoleInfo));
            //handleList.Add(new Handler("incident", "add", Business.Incidents.AddIncidentInfo));
             handleList.Add(new Handler("incident", "list", PoweredSource.Incident.GetJson,false));
           
           // handleList.Add(new Handler("role_category", "list", PoweredSource.Category.GetJson));
            //handleList.Add(new Handler("role", "list", PoweredSource.Role.GetJson, false));
            //handleList.Add(new Handler("role_shape_nodes", "func", Business.Category.GetShapeJson));
            //handleList.Add(new Handler("role_shape_edges", "func", Business.Category.GetShapeJson));
            string GetJsonInfo(string item)
            {
                var nameInfo = item.Split('_');
                var nameString = new StringBuilder();
                foreach (var n in nameInfo)
                    nameString.Append(n.Substring(0, 1).ToUpper() + n.Substring(1));
              
                return nameString.ToString();
            }
           var fileList = new Dictionary<string, string>();
            foreach (var item in handleList)
            {
                var jsonName = GetJsonInfo(item.Name);
                //if (item.Type == Handler.Type_List)
                //    continue;
                var jsonInfo = item.Call(item.Name, item.Type);
                Console.WriteLine("\r\n" + jsonName + " = " + jsonInfo);
              //  fileList[item]
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            var json = new StringBuilder();
            json.AppendLine(" { ");
            json.AppendLine("     result : \"jieguo\",");
            json.AppendLine("       name: \"role\",");
            json.AppendLine("      type: \"add\",");
            json.AppendLine("      info:  {");
            json.AppendLine("         priority_id: 0,              ");
            json.AppendLine("         category_info: {             ");
            json.AppendLine("            id: 30,                  ");
            json.AppendLine("           name: \"分类\"                 ");
            json.AppendLine("         },                           ");
            json.AppendLine("         incident_info: {             ");
            json.AppendLine("                     prioity_id: 0,   ");
            json.AppendLine("           desc: \"事件描述\"                 ");
            json.AppendLine("         },                           ");
            json.AppendLine("          desc: \"角色描述\",                 ");

            json.AppendLine("          parent_id: 1,               ");
            json.AppendLine("          parent_name: \"\",          ");
            json.AppendLine("          id: 13,                     ");
            json.AppendLine("          name: \"王丹\"                ");
            json.AppendLine("       } ");
            json.AppendLine(" } ");

            var deserialized = JsonConvert.DeserializeObject(json.ToString());
            var handler = (JToken)deserialized;
            var info = ((JToken)handler)[Handler.Type_Info];


            var builder = new StringBuilder();
            builder.AppendLine(handler["name"].ToString() + "<br/>");
            builder.AppendLine(handler["type"].ToString() + "<br/>");


            builder.AppendLine(info["id"].ToString() + "<br/>");
            builder.AppendLine(info["parent_id"].ToString() + "<br/>");
            builder.AppendLine(info["name"].ToString() + "<br/>");
            builder.AppendLine(info["desc"].ToString() + "<br/>");
            builder.AppendLine(info["priority_id"].ToString() + "<br/>");
            builder.AppendLine(info["parent_id"].ToString() + "<br/>");
            builder.AppendLine(info["parent_name"].ToString() + "<br/>");
            //   builder.AppendLine(info["category_info"].ToString() + "<br/>");
            builder.AppendLine(info["category_info"]["id"].ToString() + "<br/>");
            builder.AppendLine(info["category_info"]["name"].ToString() + "<br/>");
            //  builder.AppendLine(info["incident_info"].ToString() + "<br/>");
            builder.AppendLine(info["incident_info"]["prioity_id"].ToString() + "<br/>");
            builder.AppendLine(info["incident_info"]["desc"].ToString() + "<br/>");


            Console.Write(info.ToString());
            var roleInfo = JsonConvert.DeserializeObject<RoleInfo>(info.ToString());
            //  var categoryInfo = JsonConvert.DeserializeObject<CategoryInfo>(info["category_info"].ToString());
            //Console.Write(builder.ToString());

        }
    }
}
