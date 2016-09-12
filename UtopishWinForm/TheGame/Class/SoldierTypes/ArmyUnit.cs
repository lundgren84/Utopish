using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class ArmyUnit
    {
        public int cost;
        public int quantity;
        public int HP;
        public int attackPower;
        public int armor;

        public ArmyUnit(int _cost,int _quantity, int _hp, int _attackPower, int _armor )
        {
            cost = _cost;
            quantity = _quantity;
            HP = _hp;
            attackPower = _attackPower;
            armor = _armor;
        }
    }
}
