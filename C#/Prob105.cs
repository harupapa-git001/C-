
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("あなたの姓を入力してください:");
            string mn = Console.ReadLine();
            Console.Write("あなたの名を入力してください:");
            string fn = Console.ReadLine();
            //string name = mn + fn;
            Console.WriteLine("あなたは{0}さんですね。", mn + fn); //引数nameでもよい
        }
    }
}
