using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.B
{
    public class Director
    {
        public Computer GetComputer(Builder builder)
        {
            builder.AddCpu();
            builder.AddMain();
            return builder.GetComputer();
        }
    }

    public abstract class Builder
    {
        public abstract void AddCpu();
        public abstract void AddMain();
        public abstract Computer GetComputer();
    }

    public class Builder1 : Builder
    {
        private Computer computer = new Computer();

        public override void AddCpu()
        {
            computer.Add("cpu1");
        }

        public override void AddMain()
        {
            computer.Add("main1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
    public class Builder2 : Builder
    {        
        private Computer computer = new Computer();
        
        public override void AddCpu()
        {
            computer.Add("cpu2");
        }

        public override void AddMain()
        {
            computer.Add("main2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }

    public class Computer
    {
        private List<string> list =new List<string>();

        public void Add(string str)
        {
            list.Add(str);
        }

        public void Show()
        {
            Console.WriteLine("开始组装电脑。。。");
            foreach (var str in list)
            {
                Console.WriteLine($@"开始组装{str}部分。。。");
            }
            Console.WriteLine("组装完成");
        }
    }
}
