using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    class Person
    {
        //名前(フィールド)
        public string name = "";
        //年齢(フィールド)
        public int age = 0;
        //情報の表示(メソッド)
        public void ShowAgeAndName()
        {
            Console.Write("名前:{0} 年齢:{1}", name, age);
            
            Console.WriteLine();
        }
        //情報の設定
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Prgram
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            //１つ目のPersonクラスのメソッドのインスタンを生成
            p1 = new Person();
            //２つ目のPersonクラスのメソッドのインスタンスを生成
            p2 = new Person();
            p1.name = "山田太郎";   //フィールドnameに値を代入
            p1.age = 19;            //フィールドageに値を代入
            //メソッドでnameとageを設定
            p2.SetAgeAndName("佐藤花子", 23);
            //それぞれのインスタンスのnameとageを表示
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
