
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample505
{
    class Parent
    {
        public virtual void Foo()
        {
            Console.WriteLine("親クラスのFoo()メソッド");
        }
    }
    class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("子クラスのFoo()メソッド");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Parentクラスのインスタンス生成
            Parent p = new Parent();
            //Childクラスのインスタンス生成
            Child c = new Child();
            //それぞれのクラスのfoo, barメソッド実行
            p.Foo();
            c.Foo();
        }
    }
}
