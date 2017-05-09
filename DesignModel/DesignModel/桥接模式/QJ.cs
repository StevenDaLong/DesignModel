using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

桥接模式

优点：

    把抽象接口与其实现解耦。

    抽象和实现可以独立扩展，不会影响到对方。

    实现细节对客户透明，对用于隐藏了具体实现细节。

缺点： 
    增加了系统的复杂度

使用场景
    如果一个系统需要在构件的抽象化角色和具体化角色之间添加更多的灵活性，避免在两个层次之间建立静态的联系。
    设计要求实现化角色的任何改变不应当影响客户端，或者实现化角色的改变对客户端是完全透明的。
    需要跨越多个平台的图形和窗口系统上。
    一个类存在两个独立变化的维度，且两个维度都需要进行扩展。

*/
namespace DesignModel.QJ
{
    
    public class Control
    {
        public TV tv { get; set; }

        public void On()
        {
            tv.On();
        }

        public void Off()
        {
            tv.Off();
        }

        public virtual void Change()
        {
            tv.Change();
        }
    }

    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void Change();
    }

    public class Ctrl : Control
    {
        public override void Change()
        {
            Console.WriteLine("---------------------");
            base.Change();
            Console.WriteLine("---------------------");
        }
    }

    public class CTv : TV
    {
        public override void Change()
        {
            Console.WriteLine("长虹换台");
        }

        public override void Off()
        {
            Console.WriteLine("长虹关机");
        }

        public override void On()
        {
            Console.WriteLine("长虹开机");
        }
    }

    public class STv : TV
    {
        public override void Change()
        {
            Console.WriteLine("三星换台");
        }

        public override void Off()
        {
            Console.WriteLine("三星关机");
        }

        public override void On()
        {
            Console.WriteLine("三星开机");
        }
    }
}
