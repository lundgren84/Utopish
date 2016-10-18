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
        AccountObject accountObject = new AccountObject();
        Account account = new Account();
        StringBuilder sb = new StringBuilder();
        List<RaceObject> raceList;
        Race race = new Race();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Account"] == null)
            {
                Response.Redirect("~/default.aspx");
            }
            accountObject = (AccountObject)Session["Account"];
            if ((account.CheckAccountStatus(accountObject._accountID)) != AccountStatus.CreatePlayer)
            {
                Response.Redirect("~/default.aspx");
            }

            raceList = race.GetAllRacesFromDB();
            FillRaceDiv(raceList);
            FillDropDown(raceList);
        }

        private void FillDropDown(List<RaceObject> raceList)
        {
            foreach (var item in raceList)
            {
                DropDownList_Races.Items.Add(item.raceName.ToString());
            }

        }

        private void FillRaceDiv(List<RaceObject> raceList)
        {

            if (raceList != null)
            {
                foreach (var item in raceList)
                {

                    string skill1 = "";
                    string skill2 = "";
                    string skill3 = "";
                    string skill4 = "";
                    string skill5 = "";

                    var skillAmount = item.ManipulatorList.Count;
                    var counter = 0;

                    foreach (var skill in item.ManipulatorList)
                    {
                        counter++;
                        if (counter == 1) { skill1 = skill.Key + " = " + skill.Value + " %"; }
                        if (counter == 2) { skill2 = skill.Key + " = " + skill.Value + " %"; }
                        if (counter == 3) { skill3 = skill.Key + " = " + skill.Value + " %"; }
                        if (counter == 4) { skill4 = skill.Key + " = " + skill.Value + " %"; }
                        if (counter == 5) { skill5 = skill.Key + " = " + skill.Value + " %"; }

                    }


                    sb.Append($@" <div class='col-sm-6 col-md-4 raceBlock' style='margin-bottom:2%'>
                                   <div class='thumbnail' style='background-color:black'>
                                     <img src = '../Graphic/RaceLogo/logo1.png' alt='Race img'>
                                     <div class='caption'>
                                       <h3><p>{item.raceName}</p></h3>
                                       <p>{skill1}</p> <p>{skill2}</p> <p>{skill3}</p> <p>{skill4}</p> <p>{skill5}</p>
                                     <p><a href = '#' class='btn btn-default logginButton' OnClick='Button_RaceHistory_Click' role='button'>Race History</a></p>
                                     </div>
                                   </div>
                                 </div>");

                }
                FillRaces.InnerHtml = sb.ToString();
            }
        }

        protected void Button_ConfirmPlayer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBox_EmpireName.Text))
            {
                Player player = new Player();
                PlayerObject playerObject = new PlayerObject();
                //Set Name
                playerObject.EmpireName = TextBox_EmpireName.Text;
                //Set Race        
                playerObject.RaceObject.raceName = (RaceName)Enum.Parse(typeof(RaceName), DropDownList_Races.SelectedIndex.ToString(), true);
                playerObject.RaceObject = race.GetRace(playerObject.RaceObject);
                playerObject.RaceObject.RaceID = GetIDFromList(playerObject.RaceObject);
                //Set AccountID

                playerObject.AccountID = accountObject._accountID;
                //Create the Player
                player.CreateNewPlayer(playerObject);
                //Start Game
                Session["Player"] = playerObject;
                Models.Login login = new Models.Login();
                login.ChangeAccountStatus(AccountStatus.Open, accountObject._statusRefID);
                Response.Redirect("~/UserPages/Overview.aspx");
            }
        }
        private int GetIDFromList(RaceObject raceObject)
        {
            int result = 0;
            foreach (var item in raceList)
            {
                if (item.raceName == raceObject.raceName)
                {
                    result = item.RaceID;
                    break;
                }
            }

            return result;
        }
        protected void Button_RaceHistory_Click(object sender, EventArgs e)
        {

        }

    }
}