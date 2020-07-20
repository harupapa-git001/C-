
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem505
{
    abstract class Mammals
    {
        //名前
        protected string name = "";
        //鳴く
        public abstract void Bark();
        //名前を表示する
        public void ShowName()
        {
            Console.WriteLine("名前:{0}", name);
        }
    }
    class Cat : Mammals
    {
        public Cat()
        {
            this.name = "猫";
        }
        //鳴く
        public override void Bark()
        {
            Console.WriteLine("ニャーニャー");
        }
    }
    class Mice : Mammals
    {
        public Mice()
        {
            this.name = "ネズミ";
        }
        //鳴く
        public override void Bark()
        {
            Console.WriteLine("チューチュー");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animalクラスのオブジェクトの配列を生成
            Mammals[] animals = new Mammals[2];
            //猫クラスのインスタンス生成
            animals[0] = new Cat();
            //ネズミクラスのインスタンス生成
            animals[1] = new Mice();
            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Bark();
                Console.WriteLine("------------");
            }
            
        }
    }
}
