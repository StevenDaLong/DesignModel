using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.AF
{

    /*
    抽象工厂模式：提供一个创建产品的接口来负责创建相关或依赖的对象，而不具体明确指定具体类

    优点  对于一系列产品扩展符合开闭规则

    缺点  抽象工厂模式很难支持新种类产品的变化。这是因为抽象工厂接口中已经确定了可以被创建的产品集合，如果需要添加新产品，此时就必须去修改抽象工厂的接口，这样就涉及到抽象工厂类的以及所有子类的改变，这样也就违背了“开发——封闭”原则。
       
        
      使用场景
      
        一个系统不要求依赖产品类实例如何被创建、组合和表达的表达，这点也是所有工厂模式应用的前提。

这个系统有多个系列产品，而系统中只消费其中某一系列产品

系统要求提供一个产品类的库，所有产品以同样的接口出现，客户端不需要依赖具体实现。*/
    public abstract class Factory
    {
        public abstract Yabo MakeYaBo();
        public abstract Yajia MakeYajia();
    }

    public class WuHanFactory : Factory
    {
        public override Yabo MakeYaBo()
        {
            return new WuHanYabo();
        }

        public override Yajia MakeYajia()
        {
            return new WuHanYajia();
        }
    }

    public class ShangHaiFactory : Factory
    {
        public override Yabo MakeYaBo()
        {
            return new ShangHaiYabo();
        }

        public override Yajia MakeYajia()
        {
            return new ShangHaiYajia();
        }
    }

    public abstract class Yabo
    {
        public abstract void Say();
    }

    public abstract class Yajia
    {
        public abstract void Say();
    }

    public class WuHanYabo : Yabo
    {
        public override void Say()
        {
            Console.WriteLine("我是武汉鸭脖");
        }
    }

    public class WuHanYajia : Yajia
    {
        public override void Say()
        {
            Console.WriteLine("我是武汉鸭架");
        }
    }

    public class ShangHaiYabo : Yabo
    {
        public override void Say()
        {
            Console.WriteLine("我是上海鸭脖");
        }
    }

    public class ShangHaiYajia : Yajia
    {
        public override void Say()
        {
            Console.WriteLine("我是上海鸭架");
        }
    }
}
