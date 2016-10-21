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
        AccountObject accountObject;
        Account account;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            accountObject = new AccountObject();
            account = new Account();
            if (Session["Account"] == null)
            {
                Response.Redirect("~/default.aspx");
            }
            accountObject = (AccountObject)Session["Account"];
            //if ((account.CheckAccountStatus(accountObject._accountID)) != AccountStatus.VerifyEmail)
            //{
            //    Response.Redirect("~/default.aspx");
            //}
        }

        protected void Button_Unlock_Click(object sender, EventArgs e)
        {
            if (TextBox_ActivationCode.Text == accountObject.Status.ActivationCode)
            {
                if (accountObject.Status.accountStatus == AccountStatus.VerifyEmail)
                {
                    account.ChangeAccountStatus(AccountStatus.CreatePlayer, accountObject._statusRefID);           
                    Response.Redirect("~/UserPages/CreatePlayer.aspx");
                }
            }
            else
            {
                Response.Write("Wrong code!");
            }
        }
    }
}