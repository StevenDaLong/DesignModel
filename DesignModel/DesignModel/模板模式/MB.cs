using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
模板模式

优点：
    实现了代码复用
    能够灵活应对子步骤的变化，符合开放-封闭原则
缺点：
    因为引入了一个抽象类，如果具体实现过多的话，需要用户或开发人员需要花更多的时间去理清类之间的关系。
*/
namespace DesignModel.MB
{
    public abstract class ShuCai
    {
        public void CookFood()
        {
            Strat();
            Cook();
            End();
        }

        public void Strat()
        {
            Console.WriteLine("倒油");
        }

        public abstract void Cook();

        public void End()
        {
            Console.WriteLine("完成");
        }
    }

    public class Bocai : ShuCai
    {
        public override void Cook()
        {
            Console.WriteLine("倒入菠菜");
        }
    }

    public class Shengcai : ShuCai
    {
        public override void Cook()
        {
            Console.WriteLine("倒入生菜");
        }
    }
}
