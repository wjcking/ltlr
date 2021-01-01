using Beautiful;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
namespace Business
{
    public class Category
    {
        public static IList<RoleCategory> GetList()
        {
            string Cache_Name = "Category.GetList";
            //   var cache = ;
            if (HttpRuntime.Cache.Get(Cache_Name) == null)
            {
                var list = PoweredSource.Category.GetList();
                HttpRuntime.Cache.Insert(Cache_Name, list);
                return list;
            }
            return (IList<RoleCategory>)HttpRuntime.Cache[Cache_Name];
        }

        public static string GetJsonList()
        {
            var tokens = Json.GetTokens<RoleCategory>(GetList());
             
            return typeof(RoleCategory).Name + Json.NodeType_Trees + " = " + tokens[Json.Token_Trees];
        }
    }
}
