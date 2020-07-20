
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob303
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("回数を入力:");
            int a = int.Parse(Console.ReadLine());
            for(int i = a; i >= 0; i--)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
