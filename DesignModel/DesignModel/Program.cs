using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式（多线程）
            //Singleton.Instance.Say();

            //简单工厂
            //简单工厂.Food tudou = 简单工厂.Factory.Create("tudou");
            //tudou.Say();
            //简单工厂.Food xihongshi = 简单工厂.Factory.Create("xihongshi");
            //xihongshi.Say();

            //工厂模式
            工厂.TudouFactory tudouFactory = new 工厂.TudouFactory();
            工厂.XihongshiFactory xihongshiFactory = new 工厂.XihongshiFactory();

            工厂.Food tudou = tudouFactory.Create();
            tudou.Say();

            工厂.Food xihongshi = xihongshiFactory.Create();
            xihongshi.Say();

            Console.ReadKey();

        }
    }
}
