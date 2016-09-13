using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class MountedKnight : ArmyUnit
    {
        public MountedKnight()
        {
            quantity = 0;
            cost = 500;
            HP = 500;
            attackPower = 250;
            armor = 25;
        }
    }
}
