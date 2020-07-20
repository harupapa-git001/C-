
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob306
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("文字列を入力:");
                string a = Console.ReadLine();
                if(a != "")
                {
                    
                    Console.WriteLine("{0}", a);
                }
                else
                {
                    break;
                    
                }
            }
        }
    }
}
