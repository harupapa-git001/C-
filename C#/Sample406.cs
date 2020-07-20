
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample406
{
    class Person
    {
        //フィールドname(名前)
        private string name = "";
        //フィールドage(年齢)
        private int age = 0;
        //コンストラクタ(引数なし)
        public Person() : this("名無し", 0)
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        //コンストラクタ(引数あり)
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ name:{0} age:{1}", name, age);
        }
        //情報の表示
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前:{0} 年齢:{1}", name, age);
        }
        //nameのプロパティ
        public string Name
        {
            set{name = value;}
            get{return name;}
        }
        //ageプロパティ
        public int Age
        {
            set{age = value;}
            get{return age;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();  //引数なしのコンストラクタ
            p2 = new Person("太田隆", 29);  //引数あり
            p1.Name = "斎藤花子";
            p1.Age = 18;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
