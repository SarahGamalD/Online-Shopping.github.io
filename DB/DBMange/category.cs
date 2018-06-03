using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using DB.DBMange;

namespace DB.DBMange
{
    public class category
    {
        public static DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand(" select * from category  ");
            DataTable dt = DB.select(cmd);
            return dt;
        }
        public static DataTable SelectById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from category where  id=@id ");
            cmd.Parameters.AddWithValue("id", id);
            DataTable dt = DB.select(cmd);
            return dt;
        }
        public static int insert(string name)
        {
            SqlCommand cmd = new SqlCommand("insert into category values(@name)");
            cmd.Parameters.AddWithValue("name", name);

            return DB.DML(cmd);


        }
        public static int update(int id, string name)
        {
            SqlCommand cmd = new SqlCommand("update category set name=@name");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
           
            return DB.DML(cmd);
        }
        public static int delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from category where id=@id ");
            cmd.Parameters.AddWithValue("id", id);
            return DB.DML(cmd);
        }
    }
}