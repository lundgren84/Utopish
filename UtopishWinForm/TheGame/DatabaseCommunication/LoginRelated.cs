using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheGame
{
    class LoginRelated
    {
        SqlConnection connection;

        public bool UniqueUsername(string name)
        {
            return true;
        }
        public bool UniqueKingdomName(string name)
        {
            return true;
        }
        public bool IsLocationOccupied(Location location)
        {
            return true;
        }
        public static List<Location> GetGameWorld()
        {
            return new List<Location>();
        }
    }
}
