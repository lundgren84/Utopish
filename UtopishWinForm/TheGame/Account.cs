using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public Knight knight;
        public Archer archer;
        public HorseKnight horseKnight;


        public Account (string username,string password,string email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            knight = new Knight();
            archer = new Archer();
            horseKnight = new HorseKnight();
        }
    }
}
