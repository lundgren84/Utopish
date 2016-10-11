using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Utopish_Space.Models;
using Utopish_Space.DAL;


namespace Utopish_Space
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Models.Login login = new Models.Login();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            // Check email
            int count = login.CheckEMail(tb_RegEmail.Text);

            if (count > 0)
            {
                Response.Write("Email already in use");
                Label_EMailInUse.Text = "Email already in use";
            }
            else
            {               
                try
                {
                    Security security = new Security();
                    var salt = security.CreateSalt(10); // Generate salt
                    var hash = security.GenerateSHA256Hash(tb_RegPassword.Text, salt); // Generate Hash
                    AccountObject accountObject = new AccountObject();
                    accountObject._salt = salt;
                    accountObject._hash = hash;
                    accountObject._email = tb_RegEmail.Text;
                    accountObject._firstName = "";
                    accountObject._lastName = "";

                    login.CreateNewAccount(accountObject);

                    MailSender mailSender = new MailSender();
                    string mailContent = $@"Your Code is : {accountObject.Status.ActivationCode}";
                    mailSender.SendMailTo(accountObject._email, mailContent);
                    Response.Write("Your Registration is succsesful");
                    PanelRegistration.Visible = false;
                    PanelLoggin.Visible = false;
                    Panel_RegCompleated.Visible = true;


                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }

        }
        protected void ButtonChangeLogin_Click(object sender, EventArgs e)
        {
            Label_EMailInUse.Text = "";
            if (ButtonChangeLoggin.Text.Contains("Register"))
            {
                ButtonChangeLoggin.Text = "Login";
                PanelLoggin.Visible = false;
                PanelRegistration.Visible = true;
                Panel_RegCompleated.Visible = false;
            }
            else
            {
                ButtonChangeLoggin.Text = "Register";
                PanelLoggin.Visible = true;
                PanelRegistration.Visible = false;
                Panel_RegCompleated.Visible = false;
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {

            AccountObject player = login.AccountLogin(tb_UserEmail.Text, tb_Password.Text);

            if (player != null)
            {
                Session["Player"] = player;
                if (player.Status.AccountStatus == "VerifyEmail")
                {
                    Response.Redirect("~/UserPages/VerifyMail.aspx");
                }
                else if (player.Status.AccountStatus == "Open")
                {
                  
                  
                    Response.Redirect("~/UserPages/Overview.aspx");
                }
            }
            else
            {
                Response.Write("Wrong username or password");
            }




        }

 
    }
}