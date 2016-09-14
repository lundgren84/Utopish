using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Player
    {
        public int playerId;
        public string Name;
        public string Password;
        public string Email;
        public string KingdomName;

        public int Power;
        public int Gold;
        public int Size;
        public Archer archer;
        public Knight knight;
        public MountedKnight mountedKnight;
        public Bank bank;
        public Barracks barrack;
        public Lab lab;

        Location location;

        public Player(string _name, string password, string email)
        {
            this.playerId = FigureOutPlayerID();
            this.Name = _name;
            this.Password = password;
            this.Email = email;
            this.KingdomName = "";
            this.Size = 200;
            this.Gold = 1000;

            this.archer = new Archer();
            this.mountedKnight = new MountedKnight();
            this.knight = new Knight();
            this.bank = new Bank();
            this.barrack = new Barracks();
            this.lab = new Lab();
            this.location = FigureOutLocation();
        }
        public Player(string _name, string _kingdomName)//Placeholder
        {
            this.Name = _name;
            this.KingdomName = _kingdomName;
        }

        private int FigureOutPlayerID()
        {
            return 0;//Placeholder
        }

        private Location FigureOutLocation()
        {
            return new Location(1, 1);//Placeholder
        }

        public Player CreateNewPlayer()
        {
            LoginRelated login = new LoginRelated();
            string tempname = "tempname";
            while (!login.UniqueUsername(tempname))
            {
                tempname = "The name you supplied is already taken, please try again";
            }
            string tempname2 = "tempname2";
            while (!login.UniqueKingdomName(tempname2))
            {
                tempname2 = "The name you supplied is already taken, please try again";
            }

            Player player = new Player(tempname, tempname2);
            return player;


        }


    }
}
