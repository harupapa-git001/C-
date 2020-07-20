
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem308
{
    class Prgram
    {
        static void Main(string[] args)
        {
            //乱数の設定
            Random rnd = new Random();
            int[] start = new int[10];
            for(int i = 0; i < start.Length; i++)
            {
                start[i] = rnd.Next(1, 101);
                Console.Write("{0} ", start[i]);
            }
            Console.WriteLine();
            //並べ替え
            for(int i = 0; i < start.Length; i++)
            {
                int max = 0;    //仮の最大値
                int pos = 0;    //配列ないいおける仮の最大値の位置
                for(int j = 0; j < start.Length; j++)
                {
                    if(max < start[j])
                    {
                        //最大値と最大値があった位置を更新する
                        max = start[j];
                        pos = j;
                    }
                }
                //最大値の表示
                Console.Write("{0} ", max);
                start[pos] = 0;
            }
            Console.WriteLine();
        
        }
    }
}
