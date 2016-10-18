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
        int mathAwnser;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                mathAwnser = GetMathAwner(Label_Math.Text);
            }
            else
            {
                Label_Math.Text = getNewMath() + " =";
            }
        }

        private int GetMathAwner(string text)
        {
            char one = text[0];
            char two = text[2];
            int nr1 =int.Parse(one.ToString());
            int nr2 = int.Parse(two.ToString());
            int result = nr1 + nr2;
                return result;
        }

        private string getNewMath()
        {
            string result = "";
            Random random = new Random();
            int nr1 = random.Next(6);
            int nr2 = random.Next(5);
            mathAwnser = nr1 + nr2;
            result = nr1.ToString() + "+" + nr2.ToString();
            return result;
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            // Check email
            int count = login.CheckEMail(tb_RegEmail.Text);
            int testMath;
            int.TryParse(TextBox_MathAwnser.Text, out testMath);

            if (mathAwnser == testMath && CheckBox_GameRules.Checked)
            {
                Label_MathError.Text = "";
                Label_GameRuleError.Text = "";
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
            else
            {
                Label_Math.Text = getNewMath() + " =";
                if (mathAwnser != testMath)
                {
                    Label_MathError.Text = "Wrong!";
                    Label_Math.Text = getNewMath() + " =";
                }
                if(!CheckBox_GameRules.Checked)
                {
                    Label_GameRuleError.Text = "Required";
                }          
            }
        }
        protected void ButtonChangeLogin_Click(object sender, EventArgs e)
        {
            Label_EMailInUse.Text = "";
            Label_MathError.Text = "";
            Label_GameRuleError.Text = "";
            Label_AccountLocked.Text = "";
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
            Label_AccountLocked.Text = "";
            AccountObject Account = login.AccountLogin(tb_UserEmail.Text, tb_Password.Text);
            TheGame theGame = new TheGame();
            if (Account != null)
            {
                Session["Account"] = Account;

                if (Account.Status.accountStatus == AccountStatus.VerifyEmail)
                {
                    Response.Redirect("~/UserPages/VerifyMail.aspx");
                }
                else if (Account.Status.accountStatus == AccountStatus.Open)
                {        
                    PlayerObject playerObject = theGame.CreateNewPlayerObject(Account);
                    Session["Player"] = playerObject;

                    Response.Redirect("~/UserPages/Overview.aspx");
                }
                else if (Account.Status.accountStatus == AccountStatus.CreatePlayer)
                {
                    Response.Redirect("~/UserPages/CreatePlayer.aspx");
                }
                else if (Account.Status.accountStatus == AccountStatus.Locked)
                {
                    Label_AccountLocked.Text = "Account is Locked!";
                }
            }
            else
            {
                Response.Write("Wrong username or password");
            }




        }


    }
}