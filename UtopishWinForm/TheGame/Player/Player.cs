using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class Player
    {
        int playerId;
        string Name;
        string KingdomName;
        Archer archer;
        Knight knight;
        MountedKnight mountedKnight;
        int size;
        List<Buildings> buildings;
        Location location;

        public Player(string _name, string _kingdomName)
        {
            this.playerId = FigureOutPlayerID();
            this.Name = _name;
            this.KingdomName = _kingdomName;
            size = 200;
            this.archer = new Archer(archer.cost, 0, archer.HP, archer.attackPower, archer.armor);
            this.mountedKnight = new MountedKnight(mountedKnight.cost, 0, mountedKnight.HP, mountedKnight.attackPower, mountedKnight.armor);
            this.knight = new Knight(knight.cost, 0, knight.HP, knight.attackPower, knight.armor);
            this.location = FigureOutLocation();
        }

        private int FigureOutPlayerID()
        {
            throw new NotImplementedException();
        }

        private Location FigureOutLocation()
        {
            throw new NotImplementedException();
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
