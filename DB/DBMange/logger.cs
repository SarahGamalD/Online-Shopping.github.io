using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using DB.DBMange;

namespace DB.DBMange
{
    public class logger
    {
   
        public static int insert(string message)
        {
            SqlCommand cmd = new SqlCommand("insert into logger values(@message,@date)");
            cmd.Parameters.AddWithValue("message", message);
            cmd.Parameters.AddWithValue("date", DateTime.Now);
           
            return DB.DML(cmd);


        }
     
    }
}