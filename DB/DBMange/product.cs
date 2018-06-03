using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace DB.DBMange
{
    public class product
    {
        public static DataTable selectproduct(int id)
        {
            SqlCommand cmd = new SqlCommand("select p.id, p.name as ProductName,c.name as CatogryName,p.image,p.description,p.price as PriceBeforeOffer," +
                "(p.price-((p.offer/100.0)*p.price)) as PriceAfterOffer from product p inner join category c on p.categoryId = c.id where p.id=@id");
            cmd.Parameters.AddWithValue("id", id);
            return DB.select(cmd);

        }
        //category
        public static DataTable SelectbycatId(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from product where categoryId=@cid ");
            cmd.Parameters.AddWithValue("cid", id);
            DataTable dt = DB.select(cmd);
            return dt;
        }//end
        public static DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand(" select p.*,c.name as catName from product p,category c where p.categoryId=c.id ");
            DataTable dt=DB.select(cmd);
            return dt;
        }
        public static DataTable SelectAllOffer()
        {
            SqlCommand cmd = new SqlCommand(" select p.*,c.name  from product p inner join category c " +
                " on p.categoryId=c.id where offer > 0 ");
            DataTable dt = DB.select(cmd);
            return dt;
        }

        public static DataTable search(string cat,string name,decimal from ,decimal to )
        {
            SqlCommand cmd = new SqlCommand("select p.*,c.name as catName  from product p inner join category c "+
 "on p.categoryId = c.id where p.[name] like '%'+@name+'%' and c.name = @cat  and p.price between @from and @to");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("cat", cat);
            cmd.Parameters.AddWithValue("from", from);
            cmd.Parameters.AddWithValue("to", to);

            DataTable dt = DB.select(cmd);
            return dt;
        }
        public static DataTable SelectById(int id)
        {
            SqlCommand cmd = new SqlCommand("select p.*,c.name from product p,category c where p.categoryId=c.id and p.id=@id ");
            cmd.Parameters.AddWithValue("id", id);
            DataTable dt = DB.select(cmd);
            return dt;
        }
        public static DataTable SelectByName(string name)
        {
            SqlCommand cmd = new SqlCommand("select p.*,c.name as catName from product p,category c where p.categoryId=c.id and p.name like '%'+@name+'%'");
            cmd.Parameters.AddWithValue("name", name);
            DataTable dt = DB.select(cmd);
            return dt;
        }
        public static int insert(string name,string image,decimal price,int offer,int categoryId,string description)
        {
            SqlCommand cmd = new SqlCommand("insert into product values(@name,@image,@price,@offer,@categoryId,@description)");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("offer", offer);
            cmd.Parameters.AddWithValue("categoryId", categoryId);
            cmd.Parameters.AddWithValue("description", description);
            if (image != "")
                cmd.Parameters.AddWithValue("image", image);
            else
                cmd.Parameters.AddWithValue("image", null);
            return DB.DML(cmd);


        }
        public static int update(int id,string name,string image,decimal price,int offer,int categoryId,string description)
        {
            SqlCommand cmd = new SqlCommand("update product set name=@name,image=@image,price=@price," +
                "offer=@offer,categoryId=@categoryId,description=@description where id=@id");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("offer", offer);
            cmd.Parameters.AddWithValue("categoryId", categoryId);
            cmd.Parameters.AddWithValue("description", description);
            if (image != "")
                cmd.Parameters.AddWithValue("image", image);
            return DB.DML(cmd);
        }
        public static int delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from product where id=@id ");
            cmd.Parameters.AddWithValue("id", id);
            return DB.DML(cmd);
        }

    }
}