using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
    public class PlayerObject
    {
        public int PlayerID { get; set; }
        public int AccountID { get; set; }
        public string EmpireName { get; set; }
        public int TradeBalance { get; set; }
        public int Strength { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public bool DonatorStatus { get; set; }
        public int DailyTradesLeft { get; set; }
        public int RaceID { get; set; }
        public RaceObject RaceObject { get; set; }
        public PlayerObject()
        {
            RaceObject = new RaceObject();
            this.Level = 1;
            this.Experience = 0;
            this.DonatorStatus = false;
            this.TradeBalance = 0;
            this.DailyTradesLeft = 3;
        }
    }
}