using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Utopish_Space.Models;

namespace Utopish_Space
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabaseConnectionString"].ConnectionString);
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }
        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            // CHeck Username
             sql = "Select count(*) From Accounts Where username = '" + tb_RegUserName.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            // Check email
             sql = "Select count(*) From Accounts Where email = '" + tb_RegEmail.Text + "'";
            SqlCommand command3 = new SqlCommand(sql, connection);
             int emailtemp = Convert.ToInt32(command3.ExecuteScalar().ToString());

            connection.Close();
            if (temp > 0)
            {
                Response.Write("User already Exists");

            }
            else if(emailtemp > 0)
            {
                Response.Write("Email already Registred");
            }
            else
            {
                try
                {

                    connection.Open();
                    sql = "Insert into Accounts (username,password,email) values (@username,@password,@email)";
                    SqlCommand command2 = new SqlCommand(sql, connection);
                    command2.Parameters.AddWithValue("@username", tb_RegUserName.Text);
                    command2.Parameters.AddWithValue("@email", tb_RegEmail.Text);
                    command2.Parameters.AddWithValue("@password", tb_RegPassword.Text);
                    command2.ExecuteNonQuery();               
                    Response.Write("Your Registration is succsesful");
                    PanelRegistration.Visible = false;
                    PanelLoggin.Visible = true;
                    tb_Username.Text = tb_RegUserName.Text;
                    connection.Close();
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
            PlayerObject player = new PlayerObject();
            player._email = tb_Username.Text;
            
            Session["Player"] = player;
            Response.Redirect("~/UserPages/Overview.aspx");
           
        }
    }
}