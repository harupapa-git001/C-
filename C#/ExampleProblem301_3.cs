using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem301_3
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.Write("★の数を入力:");
            //整数値を入力
            int n = int.Parse(Console.ReadLine());
            //nが０より大きい場合のみdo~whileループを実行する
            if(n > 0)
            {
                int i = 0;
                do
                {
                    Console.Write("★");
                    i++;
                }
                while(i < n);
                Console.WriteLine();
            }
        }
    }
}
