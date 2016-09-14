using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheGame
{
    class MainMenu
    {
        DataBaseConection dbc = new DataBaseConection();
        Thread gameUpdate;
        static DateTime time;
        string ConString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=UtopishDataBase; User ID = guest; Password=nisse22;";
        public void Start()
        {
            time = DateTime.Now;
            gameUpdate = new Thread(UpdateGame);
            //gameUpdate.Start();
            Console.WriteLine("Utopish GameMaster Program");
            Console.WriteLine("1. Refresh Soldiers");
            Console.WriteLine("2. Refresh Buildings");
            ConsoleKeyInfo k;
            k = Console.ReadKey(true);
            switch (k.KeyChar)
            {
                case '1':
                    dbc.OpenConnection(ConString);
                    dbc.Fillsoldiers();
                    dbc.CloseConnection();
                    break;
                case '2':
                    dbc.OpenConnection(ConString);
                    dbc.FillBuildings();
                    dbc.CloseConnection();
                    break;
                default:
                    break;
            }
        }

        private void UpdateGame()
        {
            time = DateTime.Now;
            int updateNr = 0;
            while (true) {          
            if(time< DateTime.Now)
            {
                     GiveResourses();
                    Console.SetCursorPosition(30, 0);
                Console.WriteLine("UpdatedGame - "+ updateNr);
                    time = DateTime.Now.AddSeconds(1);
                    updateNr++;
            }
            }
        }

        private void GiveResourses()
        {
            dbc.OpenConnection(ConString);
            dbc.UpdateResourses();
            dbc.CloseConnection();
        }
    }
}
