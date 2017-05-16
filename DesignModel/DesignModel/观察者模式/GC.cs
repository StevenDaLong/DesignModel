using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
观察者模式

优点：
    观察者模式实现了表示层和数据逻辑层的分离，并定义了稳定的更新消息传递机制，并抽象了更新接口，使得可以有各种各样不同的表示层，即观察者。
    观察者模式在被观察者和观察者之间建立了一个抽象的耦合，被观察者并不知道任何一个具体的观察者，只是保存着抽象观察者的列表，每个具体观察者都符合一个抽象观察者的接口。
    观察者模式支持广播通信。被观察者会向所有的注册过的观察者发出通知。
缺点：
    如果一个被观察者有很多直接和间接的观察者时，将所有的观察者都通知到会花费很多时间。
    虽然观察者模式可以随时使观察者知道所观察的对象发送了变化，但是观察者模式没有相应的机制使观察者知道所观察的对象是怎样发生变化的。
    如果在被观察者之间有循环依赖的话，被观察者会触发它们之间进行循环调用，导致系统崩溃，在使用观察者模式应特别注意这点。

*/
namespace DesignModel.GC
{
    public interface IZt
    {
        void Do();
        void Add(IDy idy);
    }

    public interface IDy
    {
        void DingYue(IZt izt);

        void Respone();
    }

    public class Zt : IZt
    {
        private List<IDy> idList = new List<IDy>();
        public void Add(IDy idy)
        {
            idList.Add(idy);
        }

        public void Do()
        {
            Console.WriteLine("更新了");
            if (idList.Count >0)
            {
                foreach (IDy d in idList)
                {
                    d.Respone();
                }
            }
            else
            {
                Console.WriteLine("没有订阅");
            }
            
        }
    }

    public class Dy : IDy
    {
        public void DingYue(IZt izt)
        {
            izt.Add(this);
        }

        public void Respone()
        {
            Console.WriteLine("推送到了");
        }
    }

    public class Dy2 : IDy
    {
        public void DingYue(IZt izt)
        {
            izt.Add(this);
        }

        public void Respone()
        {
            Console.WriteLine("dy2推送到了");
        }
    }
}
