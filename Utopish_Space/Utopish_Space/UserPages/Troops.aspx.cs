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


            sb.Append($@"      
        <div class='row'>   
            <div class='col-md-2'>
         </div>
         
            <div class='col-md-2'>
           </div>
      
               <div class='col-md-3' style='border:solid 1px gray'>
                    <p  style='color: white'>Cost</p>  
               </div>
       
               <div class='col-md-3' style='border:solid 1px gray'>
                   <p  style='color: white'>Stats</p>  
               </div>
         
               <div class='col-md-2' style='border:solid 1px gray'>
                   <p  style='color: white'>Train Time</p>  
               </div>
        </div>");
            foreach (var item in troopObjects)
            {
                
                
                string troopStats = "";
                string troopCost = "";
                string trainTime = "";

                foreach (var Cost in item.TroopPrice)
                {
                    troopCost += $@"{Cost.Key.ToString()}:{Cost.Value.ToString()} ";
                }
                foreach (var Stats in item.TroopStats)
                {
                    if (Stats.Key != Models.Stats.TrainTime)
                    {
                        troopStats += $@"{Stats.Key}:{Stats.Value} ";
                    }
                    else
                    {
                        trainTime += $@"{Stats.Value} Minutes ";
                    }              
                }


                sb.Append($@"      
        <div class='row'>   
            <div class='col-md-2'>
                      <p  style='color: white'>{item.TroopName}</p>   
            </div>
         
            <div class='col-md-2'>
                 <input runat='server' id='{item.TroopName.Replace(" ","")}ID' type='number'value='0'  class='form-control '>
            </div>
      
               <div class='col-md-3' style='border:solid 1px gray'>
                    <p  style='color: white'>{troopCost}</p>  
               </div>
       
               <div class='col-md-3' style='border:solid 1px gray'>
                   <p  style='color: white'>{troopStats}</p>  
               </div>
         
               <div class='col-md-2' style='border:solid 1px gray'>
                   <p  style='color: white'>{trainTime}</p>  
               </div>
        </div>");
            }
           
            //TroopConrainer.InnerHtml = sb.ToString();
        }

        protected void btn_TrainTroops_Click(object sender, EventArgs e)
        {

        }
    }
}