﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameMaster
{
    class MainMenu
    {
        DataBaseConection dbc = new DataBaseConection();
        Thread gameUpdate;
        static DateTime time;
        string ConString = "Data Source = (local);Initial Catalog = UtopishDataBase; User ID =Nisse; password = Nisse22; integrated Security = true";

        public void Start()
        {
            time = DateTime.Now;
            gameUpdate = new Thread(UpdateGame);
            gameUpdate.Start();
            Console.WriteLine("Utopish GameMasterProgram");
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
            if(time == DateTime.Now)
            {
                GiveResourses();

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
