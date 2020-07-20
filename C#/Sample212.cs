
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem212
{
    class Prgram
    {
        static void Main(string[] args)
        {
            //サイコロの目を入力
            Console.Write("サイコロの目(1~6):");
            //コンソールから数値を入力
            int dice = int.Parse(Console.ReadLine());
            switch(dice)
            {
                case 1:
                case 3:
                case 5:
                    //奇数なら半(ハン)
                    Console.WriteLine("半(ハン)です。");
                    break;
                case 2:
                case 4:
                case 6:
                    //偶数なら丁(チョウ)
                    Console.WriteLine("丁(チョウ)です。");
                    break;
                default:
                    Console.WriteLine("範囲外の数値です。");
                    break;
            }
            
        }
    }
}
