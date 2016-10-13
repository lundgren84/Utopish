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
            List<RaceObject> raceList = race.GetRaceObjectsFromNames(race.GetAllRaceNamesFromDB());
            FillRaceDiv(raceList);
        }

        private void FillRaceDiv(List<RaceObject> raceList)
        {

            if (raceList != null)
            {
                foreach (var item in raceList)
                {
                    sb.Append($@" <div class='col - sm - 6 col - md - 4'>
                                   <div class='thumbnail'>
                                     <img src = '...' alt='...'>
                                     <div class='caption'>
                                       <h3>Thumbnail label</h3>
                                       <p>...</p>
                                       <p><a href = '#' class='btn btn-primary' role='button'>Button</a> <a href = '#' class='btn btn-default' role='button'>Button</a></p>
                                     </div>
                                   </div>
                                 </div>");
                }
                FillRaces.InnerHtml = sb.ToString();
            }
        }
    }
}