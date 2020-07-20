
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507
{
    class Crow
    {
        public String name = "カラス";
        //カラスが鳴く
        public void Sing()
        {
            Console.WriteLine("カーカー");
        }
        //名前を取得
        public String Name
        {
            get{return name;}
        }
    }
    class Sparrow
    {
        private String name = "すずめ";
        //すずめが鳴く
        public void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
        //名前を取得
        public String Name
        {
            get{return name;}
        }
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
