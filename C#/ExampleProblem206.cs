
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem206
{
    class Prgram
    {
        static void Main(string[] args)
        {
            //H20の温度を入力させる
            Console.Write("H20の温度:");
            //コンソールから温度を入力させる
            double temperature = double.Parse(Console.ReadLine());
            if(temperature >= 100.0)
            {
                Console.WriteLine("気体");
            }
            else if(temperature > 0.0)
            {
                Console.WriteLine("液体");
            }
            else
            {
                Console.WriteLine("個体");
            }
        }
    }
}
