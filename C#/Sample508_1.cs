
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample508_1
{
    class Crow : Bird
    {
        public Crow() : base("カラス")
        {
        }
        //カラスが鳴く
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
    class Sparrow : Bird
    {
        //コンストラクタ
        public Sparrow() : base("すずめ")
        {
        }
        //すずめが鳴く
        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
    abstract class Bird
    {
        //名前フィールド
        private String name;
        //引数付きコンストラクタ
        public Bird(String name)
        {
            this.name = name;
        }
        //名前を取得
        public String Name
        {
            get{return name;}
        }
        //鳴く(抽象メソッド)
        public abstract void Sing();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();        //カラスクラス
            Sparrow s = new Sparrow();  //すずめクラス
            //カラスが鳴く
            Console.Write(c.Name + " : ");
            c.Sing();
            //すずめが鳴く
            Console.Write(s.Name + " : ");
            s.Sing();
        }
    }
}
