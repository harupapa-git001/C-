
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem304
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int max = 0;    //最大値を入れておく変数
            int min = 101;  //最小値を入れておく変数
            for(int i = 1; i <= 10; i++)
            {
                //1から100までの乱数を発生させる
                int n = rnd.Next(1, 101);
                Console.Write("{0} ", n);   //数値を表示
                if(n > max)
                {
                    //発生した数値がmaxより大きければ最大値更新
                    max = n;
                }
                if(n < min)
                {
                    //発生した数値がminより小さければ最初値更新
                    min = n;
                }
            }
            Console.WriteLine();    //改行
            //最大値・最小値の表示
            Console.WriteLine("最大値:{0}", max);
            Console.WriteLine("最小値:{0}", min);
        }
    }
}
