using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Player
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string KingdomName { get; set; }
        public string Email { get; set; }
        public int Power { get; set; }
        public string Location { get; set; }
        public int Size { get; set; }
        public int Gold { get; set; }

        public Location location;
        public Knight knight;
        public Archer archer;
        public MountedKnight mountedKnight;
        public Bank bank;
        public Barracks barrack;
        public Lab lab;



        public Player(string username, string password, string email)
        {
            LoginRelated login = new LoginRelated();
            string tempname = "tempname";
            while (!login.UniqueUsername(tempname))
            {
                tempname = "The name you supplied is already taken, please try again";
            }
            this.KingdomName = tempname;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Gold = 1000;
            this.location = FigureOutLocation();
            knight = new Knight(200, 0, 200, 90, 25);
            archer = new Archer(100, 0, 100, 50, 10);
            mountedKnight = new MountedKnight(500, 0, 500, 250, 25);
            bank = new Bank();
            barrack = new Barracks();
            lab = new Lab();
        }
    
    private int FigureOutPlayerID()
        {
            throw new NotImplementedException();
        }

        private Location FigureOutLocation()
        {
            throw new NotImplementedException();
        }

        //public Player CreateNewPlayer()
        //{
        //    LoginRelated login = new LoginRelated();
        //    string tempname = "tempname"; 
        //    while (!login.UniqueUsername(tempname))
        //    {
        //        tempname = "The name you supplied is already taken, please try again";
        //    }
        //    string tempname2 = "tempname2";
        //    while (!login.UniqueKingdomName(tempname2))
        //    {
        //        tempname2 = "The name you supplied is already taken, please try again";
        //    }

        //    Player player = new Player(tempname, tempname2);
        //    return player;


        //}
      
        
    }
}
