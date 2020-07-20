
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem401
{
    class Rectangle
    {
        //幅
        public double width;
        //高さ
        public double height;
        //面積の取得
        public double GetArea()
        {
            return width * height;
        }
        //周の長さの取得
        public double GetPerimeter()
        {
            return width * 2 + height * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            //図形の幅と高さを入力
            Console.Write("幅(cm):");
            r.width = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm):");
            r.height = double.Parse(Console.ReadLine());
            //面積の表示
            Console.WriteLine("面積:{0}cm2", r.GetArea());
            //周の長さの表示
            Console.WriteLine("周の長さ:{0}cm", r.GetPerimeter());
        }
    }
}
