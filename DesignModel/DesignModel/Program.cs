﻿using System;
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
            //wuhanF.MakeYaBo().Say();
            //wuhanF.MakeYajia().Say();
            //shanghaiF.MakeYaBo().Say();
            //shanghaiF.MakeYajia().Say();

            //建造者模式
            //B.Director di = new B.Director();
            //B.Builder1 b1 = new B.Builder1();
            //B.Builder2 b2 = new B.Builder2();

            //var com1 = di.GetComputer(b1);
            //com1.Show();
            //var com2 = di.GetComputer(b2);
            //com2.Show();

            //原型模式
            //var kid = new YX.kid(1);            
            //kid.Id = 3;
            //Console.WriteLine(kid.Id);

            //var kid1 = kid.Clone();            
            //Console.WriteLine(kid1.Id);

            //适配器模式
            //SPQ.IThreeHold two = new SPQ.kid();
            //two.Three();

            //SPQ.Three two1 = new SPQ.Tkid();
            //two1.Tsay();

            //桥接模式
            //QJ.Control a = new QJ.Ctrl();
            //a.tv = new QJ.STv();
            //a.On();
            //a.Off();
            //a.Change();

            //QJ.Control b = new QJ.Ctrl();
            //b.tv = new QJ.CTv();
            //b.On();
            //b.Off();
            //b.Change();


            //装饰者模式
            ZS.Phone p = new ZS.Iphone();
            p.Print();
            WriteLine();
            ZS.xiushi tp = new ZS.Tiemo(p);
            tp.Print();
            WriteLine();
            ZS.xiushi gp = new ZS.Gjian(p);
            gp.Print();
            WriteLine();

            ZS.xiushi gtp = new ZS.Gjian(tp);
            gtp.Print();
            WriteLine();


            Console.ReadKey();

        }

        public static void WriteLine()
        {
            Console.WriteLine("分割线");
        }
    }
}
