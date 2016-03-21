using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetSingleton();
            Singleton s2 = Singleton.GetSingleton();

            if (s1 == s2)
                Console.WriteLine("Objects are the same instance");

            Console.Read();
        }
    }

    class Singleton
    {
        private static Singleton singleton;
        private static readonly object _object = new object();
        private Singleton() { }
        //public Singleton(){}
        public static Singleton GetSingleton()
        {
            if(singleton == null)
            {
                lock (_object)
                {
                    if(singleton == null)
                    {
                        singleton = new Singleton();
                    }
                }
            }
            return singleton;
        }
    }
}
