using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class Soldiers
    {
        public string SoldierName { get; set; }
        public int Amount { get; set; }
        public double HP { get; set; }
        public double Attack { get; set; }
        public double Armor { get; set; }
        public double MagicResistance { get; set; }

        public Soldiers(string soldierName,double hp, double attack,double armor,double magicResistance)
        {
            this.SoldierName = soldierName;
            this.HP = hp;
            this.Attack = attack;
            this.Armor = armor;
            this.MagicResistance = magicResistance;
    
        }
    }
}
