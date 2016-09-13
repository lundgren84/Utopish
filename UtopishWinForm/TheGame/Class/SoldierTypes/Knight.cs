using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class Knight : ArmyUnit
    {
        public Knight()
        {
            quantity = 0;
            cost = 200;
            HP = 200;
            attackPower = 100;
            armor = 25;
        }
    }
}
