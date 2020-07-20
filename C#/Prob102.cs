
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("半径を入力(cm):");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("円の面積(cm2):{0}cm2", 3.14 * r * r);
            Console.WriteLine("円周の長さ(cm):{0}cm", 2 * 3.14 * r);
        }
    }
}
