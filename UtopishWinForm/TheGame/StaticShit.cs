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
        public static Account acc { get; set; }
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

        public static bool CheckLogin(string username, string password,List<Account> Accounts)
        {
            foreach (var item in Accounts)
            {
                if(item.Username == username && item.Password == password)
                {
                    acc = item;
                    return true;
                } 
            }
            return false;
        }

        internal static int AddValue(decimal text, int cost)
        {
            int current;
            int.TryParse(text, out current);

            int output = current + cost;
            return output;
        }
    }
}
