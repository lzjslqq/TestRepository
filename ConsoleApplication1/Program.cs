using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "grayworm";
            Type tt = n.GetType();
            foreach (MemberInfo mi in tt.GetMembers())
            {
                Console.WriteLine("{0}/t{1}", mi.MemberType, mi.Name);
            }
    
            test t = new test();
            test b = new test();
            string result,result2,result3;

            result = t.method(t, 5);
            result2 = t.method(t,6);
            result3 = b.method(t, 6);
        }
      
       
    }
    
    class test
    {
        int a = 5;
        string b = "hello";

        public string method(test t, int plus)
        {
            t.a+= plus;
            t.b += " is change";
            return t.a.ToString()+t.b;
        }
    }


}
