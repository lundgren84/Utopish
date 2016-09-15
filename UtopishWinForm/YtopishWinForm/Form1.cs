using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGame;


namespace YtopishWinForm
{
    public partial class Form1 : Form
    {
        DataBaseConection dbc = new DataBaseConection();
      
        public Form1()
        {
            InitializeComponent();
            RefreshClick();
            panelLogIn.Visible = false;
            panelRegister.Visible = false;
            dbc.OpenConnection(StaticShit.ConString);         
            dbc.CloseConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RefreshClick();
            panelLogIn.BringToFront();
            panelLogIn.Visible = true;
            panelRegister.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RefreshClick();
            panelLogIn.BringToFront();
            panelLogIn.Visible = false;
            panelRegister.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshClick();
            panelLogIn.Visible = false;
            panelRegister.Visible = false;
        }

        private void btnCheckLogin_Click(object sender, EventArgs e)
        {
            RefreshClick();           
            dbc.OpenConnection(StaticShit.ConString);
            if (dbc.CheckLoggin(txtUsername.Text, txtPassword.Text))
            {
                
                this.Cursor = Cursors.WaitCursor;
                StaticShit.AccName = txtUsername.Text;
                TheGame.Form2 form2 = new TheGame.Form2();
                this.Hide();
                ResetForm1();
                form2.Show();
                this.Cursor = Cursors.Arrow;
            }
            //}
            else
            {
                lblNews.Text = "Wrong Username or password!";
            }
            dbc.CloseConnection();
        }

        private void btnCheckRegister_Click(object sender, EventArgs e)
        {
            RefreshClick();
            string username = txtRUser.Text;
            string password = txtRPassword.Text;
            string email = txtREmail.Text;
            dbc.OpenConnection(StaticShit.ConString);
            string check = dbc.CheckRegister(username, email);
            dbc.CloseConnection();
            if ("Clear" == check)
            {
                panelRegister.Visible = false;
                lblNews.Text = "New Account registred";
                dbc.OpenConnection(StaticShit.ConString);
                dbc.CreateAccount(username, password, email);
                dbc.CloseConnection();
            }
            else if ("Username" == check) { lblNews.Text = "Username allready taken, try another one!"; }
            else if ("Mail" == check) { lblNews.Text = "Email allready in use test other!"; }


        }
        private void RefreshClick()
        {
            lblNews.Text = "";
        }
        private void ResetForm1()
        {
            Refresh();
            panelLogIn.Visible = false;
            panelRegister.Visible = false;
            txtUsername.Text = "";
            txtPassword.Text = "";
            this.Cursor = Cursors.Arrow;
        }
    }
}
