using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Utopish_Space.User
{
    public partial class Construction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Player"] == null)
            {
                Response.Redirect("~/default.aspx");
            }
        }
    }
}