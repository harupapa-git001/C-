
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem205_2
{
    class Prgram
    {
        static void Main(string[] args)
        {
            //文字列を入力
            Console.Write("文字列を入力:");
            string s = Console.ReadLine();
            if(s.Equals("Hello"))
            {
                Console.WriteLine("HEllloが入力されました。");
            }
            else
            {
                Console.WriteLine("Helloと入力してください。");
            }
        }
    }
}
