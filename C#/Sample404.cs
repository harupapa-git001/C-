
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample404
{
    class Access
    {
        //読み込みオンリーのデータ
        private int data1 = 5;
        //書き込みオンリーのデータ
        private int data2 = 0;
        //値の表示
        public void ShowDatas()
        {
            Console.WriteLine("data1 = {0} data2 = {1}", data1, data2);
        }
        //data1のプロパディ(読み込みオンリー)
        public int Data1
        {
            get{return data1;}
        }
        //data2のプロパティ(書き込みオンリー)
        public int Data2
        {
            set{data2 = value;}
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            //a.Data1 = 1;
            a.Data2 = 2;
            a.ShowDatas();
            Console.WriteLine("a.data1 = {0}", a.Data1);
            //Console.WriteLine("a.data2 = {0}, a.Data2);
        }
    }
}
