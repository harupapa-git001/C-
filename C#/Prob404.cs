
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob404
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("月(1~12)を入力してください:");
            string[] m = {"January", "Feburuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            
            int a = int.Parse(Console.ReadLine());
            
            if(a >= 1 && a <= m.Length)
            {
                Console.WriteLine("{0}月は{1}です。", a, m[a - 1]);
            }
            else
            {
                Console.WriteLine("適切な値を入力してください。");
            }
        }
    }
}
