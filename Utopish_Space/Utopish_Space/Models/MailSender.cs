using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Utopish_Space.Models
{
    public class MailSender
    {
        public void SendMailTo(string email ,string MailContent)
        {
  

            try
            {
                MailMessage o = new MailMessage("lundgren84@hotmail.se", $"{email}", "Validate Email", $"{MailContent}");
                NetworkCredential netCred = new NetworkCredential("Mail@hotmail.se", "Password");
                SmtpClient smtpobj = new SmtpClient("smtp.live.com", 587);
                smtpobj.EnableSsl = true;
                smtpobj.Credentials = netCred;
                smtpobj.Send(o);
            }
            catch
            {
                //    Page.RegisterStartupScript("UserMsg", "<script>alert('Sending Failed...');if(alert){ window.location='SendMail.aspx';}</script>");
           
            }
        }
    }
}