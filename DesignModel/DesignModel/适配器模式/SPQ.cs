﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.SPQ
{
    /*
    适配器模式
    优点：
    可以在不修改原有代码的基础上来复用现有类，很好地符合 “开闭原则”
    可以重新定义Adaptee(被适配的类)的部分行为，因为在类适配器模式中，Adapter是Adaptee的子类
    仅仅引入一个对象，并不需要额外的字段来引用Adaptee实例（这个即是优点也是缺点）。

    缺点：
    用一个具体的Adapter类对Adaptee和Target进行匹配，当如果想要匹配一个类以及所有它的子类时，类的适配器模式就不能胜任了。因为类的适配器模式中没有引入Adaptee的实例，光调用this.SpecificRequest方法并不能去调用它对应子类的SpecificRequest方法。
采用了 “多继承”的实现方式，带来了不良的高耦合。


        对象的适配器模式

优点：
可以在不修改原有代码的基础上来复用现有类，很好地符合 “开闭原则”（这点是两种实现方式都具有的）
采用 “对象组合”的方式，更符合松耦合。

缺点：
使得重定义Adaptee的行为较困难，这就需要生成Adaptee的子类并且使得Adapter引用这个子类而不是引用Adaptee本身。
        
使用场景：
        系统需要复用现有类，而该类的接口不符合系统的需求
        想要建立一个可重复使用的类，用于与一些彼此之间没有太大关联的一些类，包括一些可能在将来引进的类一起工作。
        对于对象适配器模式，在设计里需要改变多个已有子类的接口，如果使用类的适配器模式，就要针对每一个子类做一个适配器，而这不太实际。
        */

    #region 类适配器
    public interface IThreeHold
    {
        void Three();
    }

    public abstract class TwoHold{

        public void Say()
        {
            Console.WriteLine("im two");
        }
    }

    public class kid : TwoHold, IThreeHold
    {
        public void Three()
        {
            base.Say();
        }
    }

    #endregion

    #region 对象适配器

    public class Three
    {
        public virtual void Tsay()
        {

        }
    }

    public class Two
    {
        public void Say()
        {
            Console.WriteLine("im two");
        }
    }

    public class Tkid : Three
    {
        private Two two = new Two();

        public override void Tsay()
        {
            two.Say();
        }
    }

    #endregion

}
