
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample510
{
    //携帯電話クラス(IPhone、IEmailクラスを実装)
    class CellPhone : IPhone, IEmail
    {
        //メールアドレス
        private string mailAddress;
        //電話番号
        private string number;
        //コンストラクタ(メールアドレスと電話番号を設定)
        public CellPhone(String mailAddress, string number)
        {
            this.mailAddress = mailAddress;
            this.number = number;
        }
        //指定したメールアドレスにメールを送信する
        public void SendMail(string address)
        {
            Console.WriteLine(address + "に、" + this.mailAddress + "からメールを出します。");
        }
        //指定した番号に電話をかける
        public void Call(string number)
        {
            Console.WriteLine(number + "に、" + this.number + "から電話をかけます。");
        }
    }
    //電話インターフェース
    interface IPhone
    {
        //指定した番号に電話をかける
        void Call(string number);
    }
    //電子メール
    interface IEmail
    {
        //メールを送る
        void SendMail(string address);
    }
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone("hoge@email.com", "090-1234-5678");
            //携帯電話クラスで電話とメールを送る
            cp.Call("011-123-4567");
            cp.SendMail("fuga@email.com");
            //電話インターフェースでインスタンスにアクセス
            IPhone phone = (IPhone)cp;
            phone.Call("011-987-6543"); //電話をかける
            //メールの送信メソッドは利用できない
            //phone.SendMail("foo@email.com");
            //メールインターフェースでインスタンスにアクセス
            IEmail mail = (IEmail)cp;
            mail.SendMail("bar@imail.com");     //メールを出す
            //mailインターフェースでは電話の機能を利用できない
            //mail.Call("011-222-3333");
        }
    }
}
