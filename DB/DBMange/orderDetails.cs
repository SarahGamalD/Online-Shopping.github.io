using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static DB.DBMange.order;

namespace DB.DBMange
{
    public class orderDetails
    {
        public static DataTable selectall()
        {
            SqlCommand sc = new SqlCommand("select * from orderDetails ");
            DataTable dt = DB.select(sc);
            return dt;
        }

        public static DataTable selectbyid(int id)
        {
            SqlCommand sc = new SqlCommand("select * from orderDetails where id=@id");
            sc.Parameters.AddWithValue("id", id);
            DataTable dt = DB.select(sc);
            return dt;
        }
        public static int insert(int orderId, decimal orderedPrice, int quantity, int productId)
        {
            SqlCommand sc = new SqlCommand("insert into orderDetails (orderId,orderedPrice,quantity,productId) values (@orderid,@orderprice,@quantity,@productid)");
            sc.Parameters.AddWithValue("orderid", orderId);
            sc.Parameters.AddWithValue("orderprice", orderedPrice);
            sc.Parameters.AddWithValue("quantity", quantity);
            sc.Parameters.AddWithValue("productid", productId);
            return DB.DML(sc);
        }
        public static int deletebyid(int id)
        {
            SqlCommand sc = new SqlCommand("delete from orderDetails where id=@id");
            sc.Parameters.AddWithValue("id", id);
            return DB.DML(sc);
        }


        public static DataTable Selectstatus(OrderStatus status, int id)
        {

            SqlCommand cmd = new SqlCommand("select product.*,[order].id as orderid ,orderDetails.quantity,orderDetails.orderedPrice,orderDetails.id as detailid from product join orderDetails on product.id = orderDetails.productId inner join [order] on orderDetails.orderId =[order].id where[order].userId = @id and [order].status = @status ");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@status", status);
            return DB.select(cmd);


        }
        public static int count(int id, int quantity)
        {
            SqlCommand sc = new SqlCommand("update orderDetails set quantity=@quantity where id =@id ");
            sc.Parameters.AddWithValue("id", id);
            sc.Parameters.AddWithValue("quantity", quantity);
            return DB.DML(sc);
        }
        public static int update(int orderId, decimal orderedPrice, int quantity, int productId)
        {
            SqlCommand sc = new SqlCommand("update orderDetails set orderId=@orderid,orderedPrice=@orderprice,quantity=@quantity,productId=@productid");
            sc.Parameters.AddWithValue("orderid", orderId);
            sc.Parameters.AddWithValue("orderprice", orderedPrice);
            sc.Parameters.AddWithValue("quantity", quantity);
            sc.Parameters.AddWithValue("productid", productId);
            return DB.DML(sc);
        }
        public static DataTable Selectbyprodandorder(int proid, int orderid)
        {

            SqlCommand cmd = new SqlCommand("select * from orderDetails where orderId=@orderid and productId=@proid");
            cmd.Parameters.AddWithValue("@orderid", orderid);
            cmd.Parameters.AddWithValue("@proid", proid);
            return DB.select(cmd);


        }



    }
}