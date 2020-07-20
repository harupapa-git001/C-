
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem310
{
    class Prgram
    {
        static void Main(string[] args)
        {
            //5 x 5の二次元配列を作る
            const int SIZE = 5;
            int[,] data = new int[SIZE, SIZE];
            //値を0で初期化する
            for(int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = 0;
                }
            }
            //乱数を設定する
            Random rnd = new Random();
            int num = 1;
            while(num <= SIZE * SIZE)
            {
                while(true)
                {
                    //数値を置く場所を決める
                    int m = rnd.Next(SIZE);
                    int n = rnd.Next(SIZE);
                    //その場所の値が0であればそこに数値を置く
                    if(data[m, n] == 0)
                    {
                        data[m, n] = num;
                        num++;
                        break;
                    }
                }
            }
            //結果を表示する
            for(int i = 0; i < data.GetLength(0); i++)
            {
                //数値を表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0, 2:d}|", data[i, j]);
                }
                Console.WriteLine();
                //線を表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
        
        }
    }
}
