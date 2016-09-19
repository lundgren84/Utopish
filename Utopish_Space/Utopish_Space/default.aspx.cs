using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Utopish_Space
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabaseConnectionString"].ConnectionString);
            //    connection.Open();
            //    string sql = "Select count(*) From Accounts Where username = '" + tb_RegUserName.Text + "'";
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            //    if (temp > 0)
            //    {
            //        Response.Write("User already Exists");
            //    }
            //    connection.Close();
            //}
        }
        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabaseConnectionString"].ConnectionString);
            connection.Open();
            string sql = "Select count(*) From Accounts Where username = '" + tb_RegUserName.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            if (temp > 0)
            {
                Response.Write("User already Exists");

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
                    Response.Redirect("GM.aspx");
                    Response.Write("Your Registration is succsesful");
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
            if (ButtonChangeLoggin.Text == "Register")
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
    }
}