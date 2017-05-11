using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
组合模式：
优点：
    组合模式使得客户端代码可以一致地处理对象和对象容器，无需关系处理的单个对象，还是组合的对象容器。
    将”客户代码与复杂的对象容器结构“解耦。
    可以更容易地往组合对象中加入新的构件。

缺点：
    使得设计更加复杂。客户端需要花更多时间理清类之间的层次关系。（这个是几乎所有设计模式所面临的问题）。

注意的问题：
    有时候系统需要遍历一个树枝结构的子构件很多次，这时候可以考虑把遍历子构件的结构存储在父构件里面作为缓存。
    客户端尽量不要直接调用树叶类中的方法（在我上面实现就是这样的，创建的是一个树枝的具体对象，应该使用Graphics complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");），而是借用其父类（Graphics）的多态性完成调用，这样可以增加代码的复用性。

使用场景：
    需要表示一个对象整体或部分的层次结构。
    希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象。
*/
namespace DesignModel.ZH
{
    public abstract class Obj
    {
        protected string _str;
        public Obj(string str)
        {
            _str = str;
        }
        public abstract void Say();
    }

    public class EasyObj : Obj
    {
        public EasyObj(string str):base(str)
        {}

        public override void Say()
        {
            Console.WriteLine(base._str);
        }
    }

    public class MoreObj : Obj
    {
        private List<Obj> objs = new List<Obj>();

        public MoreObj(string str):base(str)
        {
        }

        public override void Say()
        {
            Console.WriteLine(base._str);
            if (objs.Count > 0)
            {
                foreach (var o in objs)
                {
                    o.Say();
                }
            }
        }

        public void Add(Obj obj)
        {
            objs.Add(obj);            
        }

        public void Remove()
        {
            objs.Clear();
        }
    }
}
