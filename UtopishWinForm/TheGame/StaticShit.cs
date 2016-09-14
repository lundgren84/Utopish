using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGame;

namespace YtopishWinForm
{
    public static class StaticShit
    {
        public static Player player { get; set; }
        public static bool CheckUsername(string username)
        {
            return true;
        }

        public static bool CheckPassword(string password)
        {
            return true;
        }

        public static bool CheckEMail(string email)
        {
            return true;
        }

        public static bool CheckLogin(string username, string password,List<Player> players)
        {
            foreach (var item in players)
            {
                if(item.Name == username && item.Password == password)
                {
                    player = item;
                    return true;
                } 
            }
            return false;
        }

        internal static int AddValue(decimal dec, int cost)
        {
            int current = (int)dec;
      

            int output = current * cost;
            return output;
        }
    }
}
