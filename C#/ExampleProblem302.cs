
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem302
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力:");
            //整数値を入力
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                //nが1で割り切れればその値までを表示する
                if(n % 1 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
