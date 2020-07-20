
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem407_2
{
    class Student
    {
        //名前
        private string name;
        //学年
        private int grade;
        //年齢のプロパティ
        private int age;
        //学生情報の設定
        public Student(string name, int grade, int age)
        {
            SetInformation(name, grade, age);
        }
        public void SetInformation(string name, int grade, int age)
        {
            this.name = name; this.grade = grade; this.age = age;
        }
        //学生情報の表示
        public void ShowInformation()
        {
            Console.WriteLine("名前:{0} 学年:{1} 年齢:{2}", name, grade, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            //学生のデータを格納
            students[0].SetInformation("高貴", 3, 18);
            students[1].SetInformation("勇一", 2, 17);
            students[2].SetInformation("花子", 1, 16);
            //情報を表示
            foreach(Student s in students)
            {
                s.ShowInformation();
            }
        }
    }
}
