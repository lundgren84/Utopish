using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
   public class MountedKnight : ArmyUnit
    {
        public MountedKnight(int _cost, int _quantity, int _hp, int _attackPower, int _armor) : base(_cost, _quantity, _hp, _attackPower, _armor)
        {
            _quantity = 0;
            _cost = 500;
            _hp = 500;
            _attackPower = 250;
            _armor = 25;
        }
    }
}
