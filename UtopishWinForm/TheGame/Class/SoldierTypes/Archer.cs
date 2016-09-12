using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class Archer : ArmyUnit
    {
     public Archer(int _cost, int _quantity, int _hp, int _attackPower, int _armor) : base (_cost, _quantity,_hp , _attackPower , _armor)
        {
            _quantity = 0;
            _cost = 100;
            _hp = 100;
            _attackPower = 50;
            _armor = 10;
        }
    }
}
