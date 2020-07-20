
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数値を入力してください。");
            int a = int.Parse(Console.ReadLine());
            if(a == 0)
            {
                Console.WriteLine("{0}です。", a);
            }
            else
            {
                Console.WriteLine("0ではありません。");
            }
        }
    }
}
