using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class Barracks : Buildings
    {
        decimal militaryEffect;

        public Barracks()
        {
            quantity = 0;
            cost = 100;
        }
    }
}
