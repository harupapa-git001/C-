
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample202
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;                  //変数の宣言
            int b = 3;              //宣言と初期化を同時に行う
            int add, sub,           //複数の変数を同時に宣言
            double avg;             //int以外の変数を宣言
            a = 6;                  //代入
            add = a + b;            //a, bの和
            sub = a - b;            //a, bの差
            avg = (a + b) / 2;      //a, bの平均
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);
        }
    }
}
