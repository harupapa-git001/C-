
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem408_1
{
    class Hoo
    {
        public Hoo()
        {
            Console.WriteLine("Hooクラスのインスタンスが生成されました");
        }
        public void Foo()
        {
            Console.WriteLine("fooメソッドが実行されました");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hoo h = new Hoo();
            h.Foo();
        }
    }
}
