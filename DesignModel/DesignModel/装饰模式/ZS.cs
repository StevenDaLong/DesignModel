using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
装饰者模式：

优点：
    装饰这模式和继承的目的都是扩展对象的功能，但装饰者模式比继承更灵活
    通过使用不同的具体装饰类以及这些类的排列组合，设计师可以创造出很多不同行为的组合
    装饰者模式有很好地可扩展性

缺点:
    装饰者模式会导致设计中出现许多小对象，如果过度使用，会让程序变的更复杂。并且更多的对象会使得差错变得困难，特别是这些对象看上去都很像。

使用场景：    
    需要扩展一个类的功能或给一个类增加附加责任。
    需要动态地给一个对象增加功能，这些功能可以再动态地撤销。
    需要增加由一些基本功能的排列组合而产生的非常大量的功能
*/
namespace DesignModel.ZS
{
    public abstract class Phone
    {
        public abstract void Print();
    }

    public class Iphone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("im iphone");
        }
    }

    public abstract class xiushi : Phone
    {
        private Phone phone;

        public xiushi(Phone phone)
        {
            this.phone = phone;
        }

        public override void Print()
        {
            if (phone != null)
            {
                phone.Print();
            }
        }
    }

    public class Tiemo : xiushi
    {
        public Tiemo(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();
            AddMo();
        }

        private void AddMo()
        {
            Console.WriteLine("有贴膜");
        }
    }

    public class Gjian : xiushi
    {
        public Gjian(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();
            AddG();
        }

        private void AddG()
        {
            Console.WriteLine("有挂件");
        }
    }
}
