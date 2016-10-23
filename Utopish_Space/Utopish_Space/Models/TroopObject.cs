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
            TroopStats = new Dictionary<Stats, int>();
            TroopPrice = new Dictionary<Cost, int>();
            TroopStats.Add(Stats.Attack, 250);
            TroopStats.Add(Stats.Defence, 70);
            TroopStats.Add(Stats.Speed, 45);
            TroopStats.Add(Stats.TrainTime, 55);

            TroopPrice.Add(Cost.Minerals, 100);
            TroopPrice.Add(Cost.Monney, 75);
            TroopPrice.Add(Cost.Oil, 175);

        }
    }
}