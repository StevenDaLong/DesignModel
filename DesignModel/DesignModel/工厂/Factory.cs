using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂
{
    /*
    Factory：充当抽象工厂角色，任何具体工厂都必须继承该抽象类

XihongshiFactory和TudouFactory类：充当具体工厂角色，用来创建具体产品

Food类：充当抽象产品角色，具体产品的抽象类。任何具体产品都应该继承该类

xihongshi和tudou类：充当具体产品角色，实现抽象产品类对定义的抽象方法，由具体工厂类创建，它们之间有一一对应的关系。
       */

        /*工厂方法模式通过面向对象变成中的多态性来将对象的创建延迟到具体工厂中实现，从而解决了简单工厂模式中存在的问题，也很好的符合了开放封闭原则（即对扩展开放，对修改封闭）*/
    public abstract class Factory
    {
        public abstract Food Create();
    }

    public class XihongshiFactory : Factory
    {
        public override Food Create()
        {
            return new xihongshi();
        }
    }

    public class TudouFactory : Factory
    {
        public override Food Create()
        {
            return new tudou();
        }
    }

    public abstract class Food
    {
        public abstract void Say();
    }

    public class xihongshi : Food
    {
        public override void Say()
        {
            Console.WriteLine("西红柿");
        }
    }

    public class tudou : Food
    {
        public override void Say()
        {
            Console.WriteLine("土豆");
        }
    }

}
