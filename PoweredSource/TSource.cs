using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoweredSource
{
    public static class TSource
    {
        public static IDataReader ExecuteReader(string commandText =null, CommandType ct = CommandType.StoredProcedure,string database = Constant.Database_Beautiful)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();

            var db = factory.Create(database);
            
           DbCommand command = null;
         //   command.Connection = db.CreateConnection();
          //  command.Connection = db.connc
            if (ct == CommandType.StoredProcedure)
                command = db.GetStoredProcCommand(commandText);
            else
                command = db.GetSqlStringCommand(commandText);
           //
          //  return command.ExecuteReader( CommandBehavior.CloseConnection);

            
           return db.ExecuteReader(command);
        }


    }
}
