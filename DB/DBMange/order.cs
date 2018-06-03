using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DB.DBMange
{
    public class order
    {
        public enum OrderStatus { Saved = 1, Confirmed, Approved, Canceled }

        public static DataTable SelectingSaved(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select o.id,o.lastModifiedDate,o.status,u.fName+''+u.lName as FullName from userTable u inner join [order] o on u.id=o.userId where o.status=@state and o.userId=@id");
                cmd.Parameters.AddWithValue("state", OrderStatus.Saved);
                cmd.Parameters.AddWithValue("id", id);
                DataTable dt = DB.select(cmd);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable Selectingconfirmduser(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select o.id,o.lastModifiedDate,o.status,u.fName+''+u.lName as FullName from userTable u inner join [order] o on u.id=o.userId where o.status=@state and o.userId=@id");
                cmd.Parameters.AddWithValue("state", OrderStatus.Confirmed);
                cmd.Parameters.AddWithValue("id", id);
                DataTable dt = DB.select(cmd);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





        public static DataTable selectorder()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("select o.id,o.lastModifiedDate,o.status,u.fName+''+u.lName as FullName from userTable u inner join [order] o on u.id=o.userId");
                return DB.select(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static DataTable selectorderdetails(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select p.name,d.orderId,p.price,p.id,d.quantity from product p inner join orderDetails d on p.id=d.productId where d.orderId=@id");
                cmd.Parameters.AddWithValue("id", id);
                return DB.select(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public static int id()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select id from [order]");
                return DB.DMLWithId(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        public static DataTable selectorderuser(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select o.id,o.lastModifiedDate,o.status,u.fName+''+u.lName as FullName from userTable u inner join [order] o on u.id=o.userId where o.userId=@id");
                cmd.Parameters.AddWithValue("id", id);
                return DB.select(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



       
        public static DataTable SelectingSaved()
        {

            SqlCommand cmd = new SqlCommand("select o.id,o.lastModifiedDate,o.status,u.fName+''+u.lName as FullName from userTable u inner join [order] o on u.id=o.userId where o.status=@state");
            cmd.Parameters.AddWithValue("state", OrderStatus.Saved);
            DataTable dt = DB.select(cmd);
            return dt;
        }
       

      

        public static DataTable selectuserorder(int userid)
        {

            SqlCommand cmd = new SqlCommand("select o.*, u.fName + ' ' + u.userName as FullName, d.quantity, d.orderedPrice, p.name, p.description from(([order] o inner join userTable u   on o.userId = u.id) inner join orderDetails d on o.id = d.orderId) inner join product p on d.productId = p.id where userId =@userid  ");
            cmd.Parameters.AddWithValue("userid", userid);
            return DB.select(cmd);


        }
        public static DataTable select()
        {


            SqlCommand cmd = new SqlCommand("select *  from [order]");
            return DB.select(cmd);

        }

        public static DataTable selectid()
        {


            SqlCommand cmd = new SqlCommand("select id  from [order]");
            return DB.select(cmd);

        }

        public static DataTable SelectAll()
        {

            SqlCommand cmd = new SqlCommand("select u.fName+' '+u.lName as fullname,p.name,p.description, o.*,d.quantity  from ([order] o INNER JOIN userTable u ON o.userId=u.id) INNER JOIN orderDetails d ON o.id = d.orderId INNER Join product p ON p.id = d.productId");
            DataTable dt = DB.select(cmd);
            return dt;
        }
        public static DataTable Selectingnotconfirmd()
        {

            SqlCommand cmd = new SqlCommand("select u.fName+' '+u.lName as fullname,p.name,p.description, o.*,d.quantity  from ([order] o INNER JOIN userTable u ON o.userId=u.id) INNER JOIN orderDetails d ON o.id = d.orderId INNER Join product p ON p.id = d.productId where o.status=@state");
            cmd.Parameters.AddWithValue("state", OrderStatus.Approved);
            DataTable dt = DB.select(cmd);
            return dt;
        }

        public static DataTable Selectingconfirmd()
        {

            SqlCommand cmd = new SqlCommand("select u.fName+' '+u.lName as fullname,p.name,p.description, o.*,d.quantity  from ([order] o INNER JOIN userTable u ON o.userId=u.id) INNER JOIN orderDetails d ON o.id = d.orderId INNER Join product p ON p.id = d.productId where o.status!=@state");
            cmd.Parameters.AddWithValue("state", OrderStatus.Saved);
            DataTable dt = DB.select(cmd);
            return dt;
        }




        public static DataTable Selectstatus(OrderStatus status)
        {

            //SqlCommand cmd = new SqlCommand("select * from orderinfo o,userinfo  u where o.status=@status");
            SqlCommand cmd = new SqlCommand("select o.*,u.userName,d.orderedPrice,d.quantity from [order]  o ,userTable u,orderDetails d where o.[status]=@status");
            cmd.Parameters.AddWithValue("@status", status);
            return DB.select(cmd);


        }

        public static DataTable Selectstatus(OrderStatus status, int id)
        {

            SqlCommand cmd = new SqlCommand("select * from [order] o inner join userTable  u on o.userId=@id and o.status=@status");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@status", status);
            return DB.select(cmd);


        }

        public static int insert(int userid, DateTime lastmodifieddate, OrderStatus state)
        {
            SqlCommand cmd = new SqlCommand("insert into  [order](userId,lastModifiedDate,status) values(@userid,@date,@status)");

            cmd.Parameters.AddWithValue("userid", userid);
            cmd.Parameters.AddWithValue("date", lastmodifieddate);
            cmd.Parameters.AddWithValue("status", state);
            return DB.DML(cmd);

        }

        public static int delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from  [order] where id=@id");
            cmd.Parameters.AddWithValue("id", id);

            return DB.DML(cmd);

        }

        public static int update(int userid, DateTime lastmodifieddate, OrderStatus state, int id)
        {
            SqlCommand cmd = new SqlCommand("update [order] set userId=@userid,lastModifiedDate=@date,status=@status where id=@id");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("userid", userid);
            cmd.Parameters.AddWithValue("date", lastmodifieddate);
            cmd.Parameters.AddWithValue("status", state);
            return DB.DML(cmd);

        }
        public static int updatestatus(OrderStatus state, int id)
        {
            SqlCommand cmd = new SqlCommand("update [order] set status=@status where id=@id");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("status", state);
            return DB.DML(cmd);

        }
        public static int updatestatus(OrderStatus state, int id,string address)
        {
            SqlCommand cmd = new SqlCommand("update [order] set status=@status , address=@address where id=@id");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("status", state);
            cmd.Parameters.AddWithValue("address", address);
            return DB.DML(cmd);

        }
        public static DataTable insertandreturn(int userid, OrderStatus state, DateTime lastmodifieddate)
        {
            SqlCommand cmd = new SqlCommand("Insert into [order] (userid, status, lastModifiedDate) Output Inserted.id Values(@userid,@status,@date) ");

            cmd.Parameters.AddWithValue("userid", userid);
            cmd.Parameters.AddWithValue("date", lastmodifieddate);
            cmd.Parameters.AddWithValue("status", state);
            try
            {
                return DB.select(cmd);

            }
            catch
            {
                cmd = new SqlCommand("Insert into [order] (userid, status, lastModifiedDate) Output Inserted.id Values(@userid,@status,@date) ");

                cmd.Parameters.AddWithValue("userid", userid);
                cmd.Parameters.AddWithValue("date", "24-12-2017");
                cmd.Parameters.AddWithValue("status", state);
                return DB.select(cmd);

            }

        }

    }
}