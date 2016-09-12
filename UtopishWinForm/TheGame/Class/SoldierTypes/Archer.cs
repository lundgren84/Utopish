using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class Archer
    {
        public int amount;
        public string soldierName;
        public int HP;
        public int attack;
        public double armor;
        public double magicResistance;

        public Archer() 
        {
        soldierName = "Knight";
            HP = 100;
            attack = 10;
            armor = 0;
            magicResistance = 0;
            amount = 0;
        }
    }
}
