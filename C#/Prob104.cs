
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("幅(cm) = ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("奥行(cm) = ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm) = ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("立方体の体積 = {0}cm3", w * z * h);
        }
    }
}
