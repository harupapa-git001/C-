
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob403
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            for(int i = 0; i < str.Length; i++)
            {
                Console.Write("{0}つ目の文字列を入力:", i + 1);
                str[i] = Console.ReadLine();
            }
            foreach(string s in str)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
        }
    }
}
