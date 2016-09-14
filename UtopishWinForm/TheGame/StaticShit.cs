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
       public static string ConString = "Data Source = (local);Initial Catalog = UtopishDataBase; User ID =Nisse; password = Nisse22; integrated Security = true";      
        public static string AccName;
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

        internal static int AddValue(decimal dec, int cost)
        {
            int current = (int)dec;
      

            int output = current * cost;
            return output;
        }
    }
}
