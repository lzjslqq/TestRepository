using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK_MVCTest
{
    public delegate int AddSum(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            AddSum addsum = new AddSum(p.Add);
            AddSum addsum2 = delegate(int a, int b) { return a + b + 1; };//匿名函数
            AddSum addsum3 = (int a, int b) => { return a + b + 2; };//lambda
            int sum = addsum3(3, 5);
            Console.Write(sum.ToString());
            Console.ReadKey();

        }

        public int Add(int a, int b)
        {
            return a + b;
        }

    }
}
