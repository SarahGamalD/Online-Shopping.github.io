using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DB.DBMange
{

    public class user
    {

        //public enum OrderStatus {Saved=1, Confirmed , Approved,Canceled }
        public enum UserStatus { Blocked=1, Aproved,Deleted }
        public static DataTable selectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from userTable");
            DataTable dt = DB.select(cmd);
            return dt;
        }
        public static DataTable selById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from userTable where id = @id");
            cmd.Parameters.AddWithValue("id", id);

            return DB.select(cmd);

        }
        public static int checkUserNameAndEmail(string email, string userName)
        {
            SqlCommand cmd = new SqlCommand("select * from userTable where userName = @userName");
            cmd.Parameters.AddWithValue("userName", userName);

            if (DB.select(cmd).Rows.Count>0) {
                return 1;
            };
             cmd = new SqlCommand("select * from userTable where email = @email");
            cmd.Parameters.AddWithValue("email", email);

            if (DB.select(cmd).Rows.Count > 0)
            {
                return 2;
            };
            return 0;
        }
        public static DataTable login(string email,string password)
        {
            SqlCommand cmd = new SqlCommand("select * from userTable where (username=@email or email =@email)and" +
                " password = @password and status  <> 2");
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", password);

            return DB.select(cmd);

        }
        public static int insert(string fname, string lname, string address, string email,string userName,
            DateTime birthDate, bool isAdmin, string password, string img, string phone, UserStatus status)
        {
            SqlCommand cmd = new SqlCommand("insert into userTable output INSERTED.id values" +
                "(@fname,@lname,@email,@userName,@img,@address,@password,@isAdmin,@status,@phone,@birthDate)");

            cmd.Parameters.AddWithValue("fname", fname);
            cmd.Parameters.AddWithValue("lname", lname);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("userName", userName);
            cmd.Parameters.AddWithValue("birthDate", birthDate);
            cmd.Parameters.AddWithValue("isAdmin", isAdmin);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("status", status);
            if (img != "")
                cmd.Parameters.AddWithValue("img", img);
            else
                cmd.Parameters.AddWithValue("img", null);

            return DB.DMLWithId(cmd);

        }

        public static int delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from userTable where id=@id");
            cmd.Parameters.AddWithValue("id", id);

            return DB.DML(cmd);

        }

        public static int update(string fname,int id, string lname, string address, string email, string userName,
            DateTime birthDate, bool isAdmin, string password, string img, string phone, UserStatus status)
        {
            SqlCommand cmd = new SqlCommand("update userTable set " +
                "fname=@fname,lname=@lname,email=@email,userName=@userName,img=@img," +
                "address=@address,password=@password,isAdmin=@isAdmin,status=@status,phone=@phone,birthDate=@birthDate where id = @id ");
            cmd.Parameters.AddWithValue("fname", fname);
            cmd.Parameters.AddWithValue("lname", lname);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("userName", userName);
            cmd.Parameters.AddWithValue("birthDate", birthDate);
            cmd.Parameters.AddWithValue("isAdmin", isAdmin);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("id",id);
            cmd.Parameters.AddWithValue("status", status);
            if (img != "")
                cmd.Parameters.AddWithValue("img", img);
            
            return DB.DML(cmd);

        }

        public static int updateByAdmin( int id, bool isAdmin, UserStatus status)
        {
            SqlCommand cmd = new SqlCommand("update userTable set "+
                "isAdmin=@isAdmin,status=@status where id=@id ");
          cmd.Parameters.AddWithValue("isAdmin", isAdmin);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("status", status);

            return DB.DML(cmd);

        }
        public static int editUserNameAndEmail(int id, string email, string userName)
        {
            SqlCommand cmd = new SqlCommand("select * from userTable where userName = @userName");
            cmd.Parameters.AddWithValue("userName", userName);

            if (DB.select(cmd).Rows.Count > 0)
            {
                if (Convert.ToInt32(DB.select(cmd).Rows[0]["id"]) != id)
                    return 1;
            };
            cmd = new SqlCommand("select * from userTable where email = @email");
            cmd.Parameters.AddWithValue("email", email);

            if (DB.select(cmd).Rows.Count > 0)
            {
                if (Convert.ToInt32(DB.select(cmd).Rows[0]["id"]) != id)
                    return 2;
            };
            return 0;
        }

        public static int updatebyid(int id, string fname, string lname, string address, string email, string userName,
           string img, string phone)
        {
            SqlCommand cmd = new SqlCommand("update userTable set " +
                "fname=@fname,lname=@lname,email=@email,userName=@userName,img=@img," +
                "address=@address,phone=@phone where id = @id ");
            cmd.Parameters.AddWithValue("fname", fname);
            cmd.Parameters.AddWithValue("lname", lname);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("userName", userName);

            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("phone", phone);

            if (img != "")
                cmd.Parameters.AddWithValue("img", img);

            return DB.DML(cmd);

        }

        public static int changepassword(int id, string oldpassword, string newpassword)
        {

            SqlCommand sc = new SqlCommand("update userTable set password=@newpassword where id=@id and password=@oldpassword ");

            sc.Parameters.AddWithValue("id", id);
            sc.Parameters.AddWithValue("oldpassword", oldpassword);
            sc.Parameters.AddWithValue("newpassword", newpassword);
            return DB.DML(sc);
        }
        public static DataTable getpassword(string email)
        {
            SqlCommand cmd = new SqlCommand("select * from userTable where  email =@email");
            cmd.Parameters.AddWithValue("email", email);


            return DB.select(cmd);

        }
    }
}