
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob305
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max = 0;
            int min = 100;

            for(int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                
                int n = rnd.Next(1, 101);
                Console.Write("{0} ", n);
                
                if(n > max)
                {
                    max = n;
                }
                if(n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値:{0}", max);
            Console.WriteLine("最小値:{0}", min);
        }
    }
}
