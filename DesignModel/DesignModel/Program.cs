using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式（多线程）
            //Singleton.Instance.Say();

            //简单工厂
            //SF.Food tudou = SF.Factory.Create("tudou");
            //tudou.Say();
            //SF.Food xihongshi = SF.Factory.Create("xihongshi");
            //xihongshi.Say();

            //工厂模式
            //F.TudouFactory tudouFactory = new F.TudouFactory();
            //F.XihongshiFactory xihongshiFactory = new F.XihongshiFactory();

            //F.Food tudou = tudouFactory.Create();
            //tudou.Say();

            //F.Food xihongshi = xihongshiFactory.Create();
            //xihongshi.Say();

            //抽象工厂
            //AF.Factory wuhanF = new AF.WuHanFactory();
            //AF.Factory shanghaiF = new AF.ShangHaiFactory();

            //建造者模式
            B.Director di = new B.Director();
            B.Builder1 b1 = new B.Builder1();
            B.Builder2 b2 = new B.Builder2();

            var com1 = di.GetComputer(b1);
            com1.Show();
            var com2 = di.GetComputer(b2);
            com2.Show();

            //wuhanF.MakeYaBo().Say();
            //wuhanF.MakeYajia().Say();
            //shanghaiF.MakeYaBo().Say();
            //shanghaiF.MakeYajia().Say();

            Console.ReadKey();

        }
    }
}
