using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式（多线程）
            Singleton.Instance.Say();

            Console.ReadKey();

        }
    }
}
