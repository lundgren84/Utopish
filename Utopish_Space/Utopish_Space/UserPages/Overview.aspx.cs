using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utopish_Space.Models;

namespace Utopish_Space.User
{
    public partial class Overview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            if (Session["Player"] == null)
            {
                Response.Redirect("~/default.aspx");
            }
            else
            {
                Account account = new Account();
                PlayerObject playerObject = (PlayerObject)Session["Player"];
                if(account.CheckAccountStatus(playerObject.AccountID) != AccountStatus.Open)
                {
                    Response.Redirect("~/default.aspx");
                }
            }
        }
    }
}