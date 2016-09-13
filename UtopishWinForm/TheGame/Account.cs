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
        public MountedKnight mountedKnight;


        public Account (string username,string password,string email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            knight = new Knight(knight.cost, 0, knight.HP, knight.attackPower, knight.armor);
            archer = new Archer(archer.cost, 0, archer.HP, archer.attackPower, archer.armor);
            mountedKnight = new MountedKnight(mountedKnight.cost, 0, mountedKnight.HP, mountedKnight.attackPower, mountedKnight.armor);
        }
    }
}
