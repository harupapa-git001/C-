
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob304
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("2の倍数");
            for(int i = 2; i <= a; i = i + 2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("3の倍数");
            for(int i = 3; i <= a; i = i + 3)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("5の倍数");
            for(int i = 5; i <= a; i = i + 5)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
