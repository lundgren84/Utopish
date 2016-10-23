using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utopish_Space.Models;
using Utopish_Space.UserPages;

namespace Utopish_Space.User
{
    public partial class Troops : System.Web.UI.Page
    {
        StringBuilder sb;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTroops();
        }

        private void LoadTroops()
        {
            sb = new StringBuilder();
            List<TroopObject> troopObjects;
            using (Troop troop = new Troop())
            {
                troopObjects = troop.GetAllTroops();
            }
              
            foreach (var item in troopObjects)
            {
                sb.Append($@"      
        <div class='row'>   
            <div class='col-md-2'>
                      <p class='LogginLabel' style='color: white'>{item.TroopName}</p>   
            </div>
         
            <div class='col-md-2'>
                 <input type='number' class='form-control LogginLabel'>
            </div>
      
               <div class='col-md-3' style='border:solid 1px gray'>
                    <p class='LogginLabel' style='color: white'>{item.TroopName}</p>  
               </div>
       
               <div class='col-md-3' style='border:solid 1px gray'>
                   <p class='LogginLabel' style='color: white'>{item.TroopName}</p>  
               </div>
         
               <div class='col-md-2' style='border:solid 1px gray'>
                   <p class='LogginLabel' style='color: white'>{item.TroopName}</p>  
               </div>
        </div>");
            }

            TroopConrainer.InnerHtml = sb.ToString();
        }
    }
}