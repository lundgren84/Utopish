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
        AccountObject acc = new AccountObject();
        Models.Login login = new Models.Login();
        protected void Page_Load(object sender, EventArgs e)
        {
            acc = (AccountObject)Session["Player"];
        }

        protected void Button_Unlock_Click(object sender, EventArgs e)
        {
            if (TextBox_ActivationCode.Text == acc.Status.ActivationCode)
            {
                if (acc.Status.AccountStatus == "VerifyEmail")
                {
                    login.ChangeAccountStatus("Open", acc._statusRefID);
                    Response.Redirect("~/UserPages/Overview.aspx");
                    TheGame theGame = new TheGame();
                    PlayerObject playerObject = theGame.CreateNewPlayerObject(acc);

                }
            }
            else
            {
                Response.Write("Wrong code!");
            }
        }
    }
}