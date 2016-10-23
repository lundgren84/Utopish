using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
    public enum Stats
    {
        Attack,Defence,Speed,TrainTime
    }
    public enum Cost
    {
        Monney,Oil,Minerals
    }
    public class TroopObject
    {
        public int TroopID { get; set; }
        public string TroopName { get; set; }
        public Dictionary<Stats,int> TroopStats { get; set; }
        public Dictionary<Cost,int> TroopPrice { get; set; }
        public TroopObject()
        {
         
        }
    }
}