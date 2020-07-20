
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("回数を入力:");
            int a = int.Parse(Console.ReadLine());
            if(a > 0)
            {
                for(int i = 0; i < a; i++)
                {
                    Console.WriteLine("HelloC#!");
                }
            }
            else
            {
                return;
            }
        }
    }
}

