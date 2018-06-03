using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DB
{
    public class DB
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingSystemCon"].ConnectionString);

        public static DataTable select(SqlCommand cmd)
        {
            try
            {
            cmd.Connection = con;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                con.Close();
            }
        }

        public static SqlDataReader selectConnect(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = con;
                con.Open();
                var dr = cmd.ExecuteReader();
                
                return dr;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                con.Close();
            }
        }
        public static int DML(SqlCommand cmd)
        {

            try
            {
                cmd.Connection = con;
                con.Open();
                int roweffect = cmd.ExecuteNonQuery();
                con.Close();
                return roweffect;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                con.Close();
            }

        }
        public static int DMLWithId(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = con;
                con.Open();
                int id = (int)cmd.ExecuteScalar();
                con.Close();
                return id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                con.Close();
            }
        }
    }
}