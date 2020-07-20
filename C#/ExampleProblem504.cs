
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem504
{
    class Ship
    {
        public void Sail()
        {
            Console.WriteLine("航行する");
        }
    }
    class BattleShip : Ship
    {
        public void Fight()
        {
            Console.WriteLine("戦闘する");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //インスタンスの生成
            Ship ship = new Ship();
            BattleShip battleShip = new BattleShip();
            //航行する
            ship.Sail();
            battleShip.Sail();
            //戦闘する
            battleShip.Fight();
        }
    }
}
