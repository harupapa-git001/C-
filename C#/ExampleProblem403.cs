using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem403
{
    class Bingo
    {
        //カードのデータ
        public int[,] data;
        //カードの初期化
        public void Init(int size)
        {
            data = new int[size, size];   //size x sizeカードを生成
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
            while(num <= size * size)
            {
                while(true)
                {
                    //数値を置く場所を決める
                    int m = rnd.Next(size);
                    int n = rnd.Next(size);
                    //その場所の値が0であればそこに数値を置く
                    if(data[m, n] == 0)
                    {
                        data[m, n] = num;
                        num++;
                        break;
                    }
                }
            }
        }
        public void Show()
        {
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
    class Program
    {
        static void Main(string[] args)
        {
            Bingo card = new Bingo();
            Console.Write("ビンゴのマスの縦・横のサイズを入力:");
            int size = int.Parse(Console.ReadLine());
            card.Init(size);
            card.Show();
        }
    }
}
