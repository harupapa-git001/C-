
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem210
{
    class Prgram
    {
        static void Main(string[] args)
        {
            //サイコロの目を入力
            Console.Write("サイコロの目(1~6):");
            //コンソールから数値を入力
            int dice = int.Parse(Console.ReadLine());
            //値がサイコロの目の範囲内かどうか調べる
            if(1 <= dice && dice <=6)
            {
                //サイコロの目が偶数か奇数かで処理を分ける
                if(dice == 2 || dice == 4 || dice == 6)
                {
                    //偶数ならば丁(チョウ)
                    Console.WriteLine("丁(チョウ)です。");
                }
                else
                {
                    //奇数なら半(ハン)
                    Console.WriteLine("半(ハン)です。");
                }
            }
            else
            {
                Console.WriteLine("範囲外の数値です。");
            }
            
        }
    }
}
