using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Location
    {
       public int island;
       public int kingdomNumber;
        public Location(int _island, int _kingdomNumber)
        {
            this.island = _island;
            this.kingdomNumber = _kingdomNumber;
        }
    }
    
}
