using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaster
{
    class MainMenu
    {
        DataBaseConection dbc = new DataBaseConection();

        public void Start()
        { 
        Console.WriteLine("Utopish GameMasterProgram");
            Console.WriteLine("1. Fill soldiers");
            ConsoleKeyInfo k;
            k = Console.ReadKey(true);
            switch (k.KeyChar)
            {
                case '1':
                    dbc.OpenConnection("Data Source = (local);Initial Catalog = UtopishDataBase; User ID =Nisse; password = Nisse22; integrated Security = true");
                    dbc.Fillsoldiers();
                    dbc.CloseConnection();
                 break;
                case '2':
                    break;
                default:
                    break;
            }
        }
    }
}
