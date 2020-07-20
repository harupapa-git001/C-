using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("テストの点数を入力してください(0-100):");
            int score = int.Parse(Console.ReadLine());
            if(score >= 0 && score <= 100)
            {
                if(score >= 80)
                {
                    Console.WriteLine("優");
                }
                else if(score >=70)
                {
                    Console.WriteLine("良");
                }
                else if(score >= 60)
                {
                    Console.WriteLine("可");
                }
                else
                {
                    Console.WriteLine("不可");
                }
            }
        }
    }
}
