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
            //ZS.Phone p = new ZS.Iphone();
            //p.Print();
            //WriteLine();
            //ZS.xiushi tp = new ZS.Tiemo(p);
            //tp.Print();
            //WriteLine();
            //ZS.xiushi gp = new ZS.Gjian(p);
            //gp.Print();
            //WriteLine();

            //ZS.xiushi gtp = new ZS.Gjian(tp);
            //gtp.Print();
            //WriteLine();

            //组合模式
            //ZH.Obj a1 = new ZH.EasyObj("线1");
            //ZH.Obj c1 = new ZH.EasyObj("圆1");
            //ZH.Obj a2 = new ZH.EasyObj("线2");
            //ZH.Obj a3 = new ZH.EasyObj("线3");
            //ZH.MoreObj h1 = new ZH.MoreObj("复杂图");
            //h1.Add(a1);
            //h1.Add(a2);
            //h1.Add(a3);
            //h1.Add(c1);
            //h1.Say();

            //ZH.MoreObj h2 = new ZH.MoreObj("复杂图2");
            //h2.Add(h1);
            //h2.Add(a1);
            //h2.Say();

            //外观模式
            //WG.Bag bag = new WG.Bag();
            //bag.Xuanke("设计模式", "steven");

            //享元模式
            //int i = 10;
            //XY.Factory f = new XY.Factory();
            //XY.AbShared a = f.Get("A");
            //if (a != null)
            //{
            //    a.Operation(--i);
            //}
            //else
            //{
            //    Console.WriteLine("no A");
            //}

            //XY.AbShared d = f.Get("D");
            //if (d == null)
            //{
            //    XY.AbShared ad = new XY.Shared("D");
            //    f.ht.Add("D", ad);
            //    Console.WriteLine("finish Add");
            //    XY.AbShared nd = f.Get("D");
            //    if (nd != null)
            //        nd.Operation(--i);
            //}

            //代理模式
            //DL.Person p1 = new DL.Friend();
            //p1.Buy("iphone");

            //模板模式
            //MB.ShuCai bocai = new MB.Bocai();
            //bocai.CookFood();

            //命令模式
            //ML.Student stu = new ML.Student();
            //ML.Mingling mingling = new ML.Pao(stu);
            //ML.Jiaoguan jiaoguan = new ML.Jiaoguan(mingling);
            //jiaoguan.Ex();

            //迭代器模式
            //DD.IList la = new DD.List();
            //DD.IDieDai da = la.GetDiedai();
            //while (da.MoveNext())
            //{
            //    Console.WriteLine(da.GetCurrent());
            //    da.Next();
            //}

            //观察者模式
            GC.IDy dy = new GC.Dy();
            GC.IDy dy2 = new GC.Dy2();
            GC.IZt zt = new GC.Zt();

            dy.DingYue(zt);
            dy2.DingYue(zt);
            zt.Do();
            

            Console.ReadKey();

        }

        public static void WriteLine()
        {
            Console.WriteLine("分割线");
        }
    }
}
