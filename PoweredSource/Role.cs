using Beautiful;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using KansaiUtils;
using System.Data.SqlClient;
using System;
using System.Runtime.CompilerServices;
namespace PoweredSource
{
    public class Role
    {
        /// <summary>
        /// 返回的0 或者id
        /// </summary>
        /// <param name="info"></param>
        /// <returns>返回的0 或者id</returns>
        public static int Add(RoleInfo info)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();

            var db = factory.Create(Constant.Database_Beautiful);
            var command = db.GetStoredProcCommand("[dbo].[add_role_info]");
            db.AddInParameter(command, "@id", System.Data.DbType.Int32, info.ID);
            db.AddInParameter(command, "@name", System.Data.DbType.AnsiString, info.Name);
            db.AddInParameter(command, "@parent_id", System.Data.DbType.Int32, info.ParentID);
            db.AddInParameter(command, "@desc", System.Data.DbType.AnsiString, info.Desc);
            db.AddInParameter(command, "@category_id", System.Data.DbType.AnsiString, info.CategoryInfo.ID);
            db.AddInParameter(command, "@priority_id", System.Data.DbType.AnsiString, info.PriorityID);

            var result = db.ExecuteScalar(command);

            return System.Convert.ToInt32(result);
        }

        public static IList<RoleInfo> GetList()
        {
            var dr = TSource.ExecuteReader("[dbo].[get_role_list]");
            var list = new List<RoleInfo>(); 
            while (dr.Read())
            {
                var ri = new RoleInfo();

                ri.ID = Converter.ToInt32(dr["id"]);
                ri.ParentID = Converter.ToInt32(dr["parent_id"]);
                ri.Name = dr["name"].ToString();
              
                ri.Desc = dr["desc"].ToString();
                ri.CategoryInfo.ID = Converter.ToInt32(dr["category_id"]);
                ri.CategoryInfo.Name = Converter.ToString(dr["category_name"]);
            
                ri.PriorityID = Converter.ToInt32(dr["priority_id"]);
                ri.InsertTime = Converter.ToString(dr["insert_time"]);
                ri.UpdateTime = Converter.ToString(dr["update_time"]);

                ri.NodeStyle = Converter.ToString(dr["node_style"]);
                ri.EdgeStyle = Converter.ToString(dr["edge_style"]);
                ri.TreeStyle = String.Empty;// Converter.ToString(dr["edge_style"]);

                ri.Shape = dr["shape"].ToString();

                list.Add(ri);
            }

            //dr.Close();
            return list;
        }
        public static IList<RoleInfo> GetListGroup()
        {
            var dr = TSource.ExecuteReader("[dbo].[get_role_group]");
            var list = new List<RoleInfo>();

            while (dr.Read())
            { 
                var ri = new RoleInfo();
                ri.Name = dr["name"].ToString();       
                ri.Shape = dr["shape"].ToString();
                ri.Desc = dr["desc"].ToString();
                //ri.ParentID = ConvertUtils.ToInt32(dr["parent_id"]);
                ri.CategoryInfo.ID = Converter.ToInt32(dr["category_id"]);
                ri.CategoryInfo.Name = Converter.ToString(dr["category_name"]);
                ri.PriorityID = Converter.ToInt32(dr["priority_id"]);                
                //  ri.InsertTime = ConvertUtils.ToDateTime(dr["insert_time"]);
                //ri = dr["order_id"].ToString();
                ri.ID = Converter.ToInt32(dr["id"]);           
                ri.NodeStyle = Converter.ToString(dr["node_style"]);
                ri.EdgeStyle = Converter.ToString(dr["edge_style"]);
                ri.TreeStyle = String.Empty;// Converter.ToString(dr["edge_style"]);

                list.Add(ri);
            }
           return list;
        }

    }
}
