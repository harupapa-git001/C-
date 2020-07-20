
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem301_1
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.Write("★の数を入力:");
            //整数値を入力
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine();
        }
    }
}
