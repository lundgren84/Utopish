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
        string sql;
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

                  
                    Response.Write("Your Registration is succsesful");
                    PanelRegistration.Visible = false;
                    PanelLoggin.Visible = true;
                    tb_Username.Text = tb_RegUserName.Text;
                    //Page.RegisterStartupScript("UserMsg", "<script>alert('Sending Failed...');if(alert){ window.location='SendMail.aspx';}</script>");
                    Page.RegisterStartupScript("UserMsg", " < script > alert('Your Registration is succsesful'); </ script >");
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonChangeLogin_Click(object sender, EventArgs e)
        {

        }

        protected void Label6_Click(object sender, EventArgs e)
        {
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ButtonChangeLoggin.Text.Contains("Register"))
            {
                ButtonChangeLoggin.Text = "Login";
                PanelLoggin.Visible = false;
                PanelRegistration.Visible = true;
            }
            else
            {
                ButtonChangeLoggin.Text = "Register";
                PanelLoggin.Visible = true;
                PanelRegistration.Visible = false;
            }
        }

        protected void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            //int temp;
            //connection.Open();
            //sql = $@"Selec COUNT(*) FROM Accounts WHERE username = '{tb_Username.Text}' AND password = '{tb_Password.Text}'";
            //using (SqlCommand command = new SqlCommand(sql, connection))
            //{
            //     temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            //}
            AccountObject player = new AccountObject();
            player._email = tb_Username.Text;
            
            Session["Player"] = player;
            Response.Redirect("~/UserPages/Overview.aspx");
           
        }
    }
}