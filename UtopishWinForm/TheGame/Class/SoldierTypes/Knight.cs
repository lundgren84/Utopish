using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Knight:Soldiers
    {
        
        public Knight(string soldierName, double hp, double attack, double armor, double magicResistance) : base(soldierName, hp, attack, armor, magicResistance)
        {
            soldierName = "Knight";
            hp = 100;
            attack = 10;
            armor = 0;
            magicResistance = 0;
        }

    }
}
