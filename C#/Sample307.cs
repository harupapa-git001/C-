
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample307
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int[] n = {5, 4, 3, 2, 1};
            string[] s = {"ABC", "DEF", "GHI"};
            int i;
            //整数型配列nの要素表示
            for(i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
            //文字列型配列nの要素表示
            for(i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
    }
}