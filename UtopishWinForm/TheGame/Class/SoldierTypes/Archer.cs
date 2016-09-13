using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class Archer : ArmyUnit
    {
     public Archer()
        {
            quantity = 0;
            cost = 100;
            HP = 100;
            attackPower = 50;
            armor = 10;
        }
    }
}
