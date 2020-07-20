using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample508_2
{
    class Crow  : Bird
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
            //Birdクラスの変数の配列を生成
            Bird[] b = new Bird[2];
            //b[0]にCrowクラスのインスタンスを生成
            b[0] = new Crow();
            //b[2]にSparrowクラスのインスタンスを生成
            b[1] = new Sparrow();
            for(int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i].Name + " : ");
                b[i].Sing();
            }
        }
    }
}
