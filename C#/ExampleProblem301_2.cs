
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem301_2
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.Write("★の数を入力:");
            //整数値を入力
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while(i < n)
            {
                Console.Write("★");
                i++;
            }
            Console.WriteLine();
        }
    }
}
