using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class World
    {
        List<Location> gameworld;

        public void PopulateWorld()
        {
            gameworld = LoginRelated.GetGameWorld();
        }
    }
}
