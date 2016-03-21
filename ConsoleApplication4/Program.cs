using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        public delegate string DelTest();
        static void Main(string[] args)
        {
            //List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            //List<int> list2;

            //list2 = list.Where<int>(n => {return n > 4 && n<9 ; }).ToList();
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine("====================================");
            //foreach (int item in list2)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            DelTest del;
            del = t1;
            del += t2;
            del += t3;

            Delegate[] de = del.GetInvocationList();
            foreach (var item in de)
            {
                DelTest d = item as DelTest;
            }
            string re =del();
            Console.WriteLine(re);
            Console.ReadKey();
        }

        static string t1()
        {
            Console.WriteLine("我是t1");
            return "我是t1";
        }

        static string t2()
        {
            Console.WriteLine("我是t2");
            return "我是t2";
        }
        static string t3()
        {
            Console.WriteLine("我是t3");
            return "我是t3";
        }
    }
}
