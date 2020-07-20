
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem506
{
    class Car : IDrive, IMechanical
    {
        //運転メソッド
        public void Drive()
        {
            Console.WriteLine("運転する");
        }
        //メンテナンスメソッド
        public void Maintain()
        {
            Console.WriteLine("メンテナンスする");
        }
    }
    //ドライブインターフェース
    interface IDrive
    {
        void Drive();
    }
    //メカニカルインターフェース
    interface IMechanical
    {
        void Maintain();
    }
    class Program
    {
        //自動車を運転する
        static void DriveACar(IDrive car)
        {
            car.Drive();
            //car.Maintain();
        }
        //自動車をメンテナンスする
        static void MaintainACar(IMechanical car)
        {
            //car.Drive();
            car.Maintain();
        }
        static void Main(string[] args)
        {
                Car c = new Car();
                DriveACar(c);
                MaintainACar(c);
        }
    }
}
