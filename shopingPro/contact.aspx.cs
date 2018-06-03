using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingPro
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(txt_email.Text);
            message.To.Add("bosab67@gmail.com");
            message.Subject = txt_subject.Text;
            message.Body = "Name:" + txt_name.Text + "  " + "Email:" + txt_email.Text + "  " + txt_question.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("ayamohamedsaleh2@gmail.com", "toota141");//mail
            smtp.EnableSsl = true;
            smtp.Send(message);
            txt_name.Text = " ";
            txt_email.Text = " ";
            txt_subject.Text = " ";
            txt_question.Text = " ";
        }
    }
}