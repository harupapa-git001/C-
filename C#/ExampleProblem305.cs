
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem305
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九の表示");
            for(int m = 1; m <= 9; m++)
            {
                for(int n = 1; n <= 9; n++)
                {
                    Console.Write("{0} x {1} = {2, 2:d}, ", m, n, m * n);
                }
                //改行処理
                Console.WriteLine();
            }
        }
    }
}
