
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem501_2
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }
        static  double Sub (double a, double b)
        {
            return a - b;
        }
        static double Nul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + Add(a, b));
            Console.WriteLine("a - b = " + Sub(a, b));
            Console.WriteLine("a * b = " + Nul(a, b));
            Console.WriteLine("a / b = " + Div(a, b));
            
        }
    }
}
