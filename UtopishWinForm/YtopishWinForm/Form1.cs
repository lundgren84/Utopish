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
        Player player;
        List<Account> Accounts;
        public Form1()
        {
            InitializeComponent();
            RefreshClick();
            Accounts = new List<Account>();
            Accounts.Add(new Account("q", "q", "q"));
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
            if (StaticShit.CheckLogin(txtUsername.Text,txtPassword.Text,Accounts))
            { 
            TheGame.Form2 form2 = new TheGame.Form2();
            this.Hide();
            form2.Show();
            }
            else
            {
                lblNews.Text = "Wrong Username or password!";
            }
        }

        private void btnCheckRegister_Click(object sender, EventArgs e)
        {
            RefreshClick();
            string username =txtRUser.Text;
            string password = txtRPassword.Text;
            string email = txtREmail.Text;
            if(StaticShit.CheckUsername(username) && StaticShit.CheckPassword(password) && StaticShit.CheckEMail(email))
            {
                Accounts.Add(new Account(username, password, email));
                panelRegister.Visible = false;
                lblNews.Text = "New Account registred";
            }
            
        }
        private void RefreshClick()
        {
            lblNews.Text = "";
        }
    }
}
