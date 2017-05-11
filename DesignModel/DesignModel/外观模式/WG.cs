using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
外观模式：
门面（Facade）角色：客户端调用这个角色的方法。该角色知道相关的一个或多个子系统的功能和责任，该角色会将从客户端发来的请求委派带相应的子系统中去。

子系统（subsystem）角色：可以同时包含一个或多个子系统。每个子系统都不是一个单独的类，而是一个类的集合。每个子系统都可以被客户端直接调用或被门面角色调用。对于子系统而言，门面仅仅是另外一个客户端，子系统并不知道门面的存在。

优点：
    外观模式对客户屏蔽了子系统组件，从而简化了接口，减少了客户处理的对象数目并使子系统的使用更加简单。
    外观模式实现了子系统与客户之间的松耦合关系，而子系统内部的功能组件是紧耦合的。松耦合使得子系统的组件变化不会影响到它的客户。

缺点：
    如果增加新的子系统可能需要修改外观类或客户端的源代码，这样就违背了”开——闭原则“（不过这点也是不可避免）。

适用场合：
    为一个复杂的子系统提供一个简单的接口
    提供子系统的独立性
    在层次化结构中，可以使用外观模式定义系统中每一层的入口。其中三层架构就是这样的一个例子。

*/
namespace DesignModel.WG
{
    public class Bag{
        private Regist regist;
        private Notify notify;
        public Bag()
        {
            regist = new Regist();
            notify = new Notify();
        }

        public void Xuanke(string kName,string sName)
        {
            if (!regist.Check())
            {
                Console.WriteLine("选课失败");
            }
            else
            {
                Console.WriteLine($@"{kName}选课成功");
                notify.Note(sName);
            }
        }
    }

    public class Regist
    {
        public bool Check()
        {
            Console.WriteLine("注册查询。。。。");
            return true;
        }
    }

    public class Notify
    {
        public void Note(string name)
        {
            Console.WriteLine($@"通知{name}");
        }
    }
}
