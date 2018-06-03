using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace shopingPro
{
    public partial class forgetpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_forget_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {

                DataTable dt = new DataTable();
                int result;
                result= DB.DBMange.user.checkUserNameAndEmail(txt_mail.Text,"");
                if (result == 2)
                {
                    dt = DB.DBMange.user.getpassword(txt_mail.Text);
                    string password = dt.Rows[0]["password"].ToString();
                    MailMessage msg = new MailMessage("fatmamohmed254@gmail.com", txt_mail.Text);
                    msg.Subject = "forget you password";
                    msg.Body = "password: " + password;
                    SmtpClient msgclient = new SmtpClient("smtp.gmail.com",587);
                    msgclient.UseDefaultCredentials = false;
                    msgclient.Credentials = new NetworkCredential("fatmamohmed254@gmail.com","FFayed1995");
                    msgclient.EnableSsl = true;
                    try

                    {
                        msgclient.Send(msg);

                    }
                    catch  (Exception ex)
                    {
                        throw (ex);

                    }
                    Response.Redirect("~/login.aspx");
                }
                else
                    lbl_status.Text = "wrong mail";




            }
        }
    }
}