using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtopishDataBase
{
    public class Knight
    {
        public int KnightID { get; set; }
        public int Tier { get; set; }
        public string Name { get; set; }
     
        public int Cost { get; set; }
        public int HP { get; set; }
        public int AttackPower { get; set; }
        public int Armor { get; set; }
       
    }
}