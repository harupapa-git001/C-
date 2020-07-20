
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("出力する星の数を入れてください:");
            int a = int.Parse(Console.ReadLine());

        
            Console.Write("forループ:");
            
            for(int i = 0; i < a; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine();
            
            Console.Write("whileループ:");
            
            int n = 0;
            
            while(n < a)
            {
                Console.Write("★");
                n++;
            }
            Console.WriteLine();
            
            Console.Write("do~whileループ:");
            
            n = 0;
            
            do
            {
                Console.Write("★");
                n++;
            }
            while(n < a);
            Console.WriteLine();
        }
    }
}
