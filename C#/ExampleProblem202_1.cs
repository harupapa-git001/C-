
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem202_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = "Tom";   //int型でstringを定義しているのでエラーになる
            Console.WriteLine("My name is {0}.", name);
        }
    }
}
