
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob401
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Random rnd = new Random();
            
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 11);
                Console.Write("a[{0}]={1} ", i, a[i]);
            }
        }
    }
}
