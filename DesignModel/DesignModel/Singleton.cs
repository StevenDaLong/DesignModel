using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private static readonly object locker = new object();

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    //多线程lock锁 确保单例
                    lock (locker)
                    {
                        return new Singleton();
                    }
                }

                return _instance;
            }
        }

        private Singleton()
        {
        }

        public void Say()
        {
            Console.WriteLine("Im singleton !");
        }
    }
}
