using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utopish_Space.Models;

namespace Utopish_Space.UserPages
{
    public partial class CreatePlayer : System.Web.UI.Page
    {
        AccountObject account = new AccountObject();
        StringBuilder sb = new StringBuilder();
        Race race = new Race();
        protected void Page_Load(object sender, EventArgs e)
        {
            account = (AccountObject)Session["Account"];
            List<RaceObject> raceList = race.GetAllRaces();
            FillRaceDiv(raceList);
        }

        private void FillRaceDiv(List<RaceObject> raceList)
        {
            
            foreach (var item in raceList)
            {
                sb.Append($@"");
            }
            FillRaces.InnerHtml = sb.ToString();
        }
    }
}