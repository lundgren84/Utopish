using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YtopishWinForm;

namespace TheGame
{
  public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Power { get; set; }
        public string Location { get; set; }
        public int Size { get; set; }
        public int Gold { get; set; }

        public Knight knight;
        public Archer archer;
        public MountedKnight mountedKnight;
        public Bank bank;
        public Barracks barrack;
        public Lab lab;

            

        public Account (string username,string password,string email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Gold = 10000;
            knight = new Knight(200, 0,200, 90,25);
            archer = new Archer(100, 0,100,50, 10);
            mountedKnight = new MountedKnight(500, 0, 500, 250, 25);
            bank = new Bank();
            barrack = new Barracks();
            lab = new Lab();
        }
    }
}
