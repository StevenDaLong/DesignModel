using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
享元模式：

优点：
    降低了系统中对象的数量，从而降低了系统中细粒度对象给内存带来的压力。
缺点：
    为了使对象可以共享，需要将一些状态外部化，这使得程序的逻辑更复杂，使系统复杂化。
    享元模式将享元对象的状态外部化，而读取外部状态使得运行时间稍微变长。

使用场景
    下面所有条件都满足时，可以考虑使用享元模式：
        一个系统中有大量的对象；
        这些对象耗费大量的内存；
        这些对象中的状态大部分都可以被外部化
        这些对象可以按照内部状态分成很多的组，当把外部对象从对象中剔除时，每一个组都可以仅用一个对象代替
        软件系统不依赖这些对象的身份，
    满足上面的条件的系统可以使用享元模式。但是使用享元模式需要额外维护一个记录子系统已有的所有享元的表，而这也需要耗费资源，所以，应当在有足够多的享元实例可共享时才值得使用享元模式。

*/
namespace DesignModel.XY
{
    public class Factory
    {
        public Hashtable ht = new Hashtable();

        public Factory()
        {
            ht.Add("A", new Shared("A"));
            ht.Add("B", new Shared("B"));
            ht.Add("C", new Shared("C"));
        }

        public Shared Get(string str) {
            return ht[str] as Shared;
        }
    }

    public abstract class AbShared
    {
        public abstract void Operation(int i);
    }

    public class Shared : AbShared
    {
        private string instance;

        public Shared(string str)
        {
            instance = str;
        }
        public override void Operation(int i)
        {
            Console.WriteLine($@"具体实现类 instance{instance},i{i}");
        }
    }
}
