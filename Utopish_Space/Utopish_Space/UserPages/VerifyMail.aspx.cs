using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utopish_Space.Models;

namespace Utopish_Space.UserPages
{
    public partial class VerifyMail : System.Web.UI.Page
    {
        AccountObject account = new AccountObject();
        Models.Login login = new Models.Login();
        protected void Page_Load(object sender, EventArgs e)
        {
            account = (AccountObject)Session["Account"];
        }

        protected void Button_Unlock_Click(object sender, EventArgs e)
        {
            if (TextBox_ActivationCode.Text == account.Status.ActivationCode)
            {
                if (account.Status.AccountStatus == "VerifyEmail")
                {
                    login.ChangeAccountStatus("Open", account._statusRefID);
                 
                    TheGame theGame = new TheGame();
                    PlayerObject playerObject = theGame.CreateNewPlayerObject(account);
                    Session["Player"] = playerObject;
                    Response.Redirect("~/UserPages/Overview.aspx");
                }
            }
            else
            {
                Response.Write("Wrong code!");
            }
        }
    }
}