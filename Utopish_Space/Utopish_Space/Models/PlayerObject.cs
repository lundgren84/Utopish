﻿using System;
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
        public int RaceRefID { get; set; }
        public RaceObject RaceObject { get; set; }
    }
}