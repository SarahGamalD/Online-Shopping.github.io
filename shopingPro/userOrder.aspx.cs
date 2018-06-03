using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DB;
using DB.DBMange;
using static DB.DBMange.order;

namespace shopingPro
{
    public partial class userOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session.Add("id", 9);
            DataTable dt = DB.DBMange.order.selectuserorder(int.Parse(Session["id"].ToString()));
            dt.Columns.Add("OrderStatus", typeof(String));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
            }
            gv_user.DataSource = dt;
            gv_user.DataBind();


        }
    }
}