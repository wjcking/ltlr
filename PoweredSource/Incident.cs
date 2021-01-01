using System;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Newtonsoft.Json;
using Beautiful;
using System.Collections.Generic;
using KansaiUtils;
namespace PoweredSource
{

    public class Incident
    {
        public static int Add(RoleInfo info)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();

            var db = factory.Create(Constant.Database_Beautiful);
            var command = db.GetStoredProcCommand("[dbo].[add_incident_info]");
            db.AddInParameter(command, "@rid", System.Data.DbType.AnsiString, info.ID);
            db.AddInParameter(command, "@desc", System.Data.DbType.AnsiString, info.IncidentInfo.Desc);
            db.AddInParameter(command, "@priority_id", System.Data.DbType.AnsiString, info.PriorityID);
            var result = db.ExecuteScalar(command);

            return System.Convert.ToInt32(result);
        }
        public static IList<RoleInfo> GetList()
        {
            var dr = TSource.ExecuteReader("[dbo].[get_incident_list]");
            var list = new List<RoleInfo>();

            while (dr.Read())
            {
                var roleInfo = new RoleInfo();
                roleInfo.ID = Converter.ToInt32(dr["role_id"]);
                roleInfo.ParentID = Converter.ToInt32(dr["role_parent_id"]);
                roleInfo.Name = dr["role_name"].ToString();
                roleInfo.CategoryInfo.ID = Converter.ToInt32(dr["role_category_id"]);
                roleInfo.CategoryInfo.Name = Converter.ToString(dr["role_category_name"]);
                roleInfo.PriorityID = Converter.ToInt32(dr["role_priority_id"]);

                roleInfo.IncidentInfo.ID = Converter.ToInt32(dr["incident_id"]);
                roleInfo.IncidentInfo.PriorityID = Converter.ToInt32(dr["incident_priority_id"]);
                roleInfo.IncidentInfo.Desc = Converter.ToString(dr["incident_desc"]);

                //label for displaying the nodes 
                roleInfo.IncidentInfo.Shape = dr["shape"].ToString();
                roleInfo.IncidentInfo.NodeStyle = Converter.ToString(dr["node_style"]);
                // roleInfo.IncidentInfo.EdgeStyle = ConvertUtils.ToString(dr["edge_style"]);

                list.Add(roleInfo);
            }

            return list;
        }

      
    }
}
