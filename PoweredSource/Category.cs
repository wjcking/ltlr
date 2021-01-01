using Beautiful;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using KansaiUtils;

namespace PoweredSource
{
    public class Category
    {
        public static IList<RoleCategory> GetList()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            var list = new List<RoleCategory>();
            var db = factory.Create(Constant.Database_Beautiful);
            var dr = db.ExecuteReader(System.Data.CommandType.StoredProcedure, "[dbo].[get_category_list]");

            while (dr.Read())
            {
                var rci = new RoleCategory();
                rci.ParentID = Converter.ToInt32(dr["parent_id"]);
                rci.Name = dr["name"].ToString();
                //目前放在json节点之前、才能生成
                rci.ID = Converter.ToInt32(dr["id"]);
                rci.NodeStyle = Converter.ToString(dr["node_style"]);
                rci.EdgeStyle = Converter.ToString(dr["edge_style"]);
                rci.TreeStyle =  string.Empty;
                rci.Shape = dr["shape"].ToString();

                list.Add(rci);
            }
            return list;
        }

    }
}