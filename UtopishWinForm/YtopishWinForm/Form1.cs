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
        List<Player> Players;
        public Form1()
        {
            InitializeComponent();
            RefreshClick();
            Players = new List<Player>();
         
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
                StaticShit.AccName = txtUsername.Text;
                TheGame.Form2 form2 = new TheGame.Form2();
                this.Hide();
                form2.Show();
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
            if (StaticShit.CheckUsername(username) && StaticShit.CheckPassword(password) && StaticShit.CheckEMail(email))
            {
                Players.Add(new Player(username, password, email));
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
