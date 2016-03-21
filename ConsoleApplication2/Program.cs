using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "123";
            int b;
            b = Convert.ToInt32(a);
            string c = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int d = 0;
            for (int i = 0; i < 3; i++)
            {

                d++;
            }
            string strVal;
            strVal = BitConverter.ToUInt32((new byte[] { 0x15, 0xcd, 0x5b, 0x07 }), 0).ToString();
            Test te = new Test();
            te.aa();
            int x=stat.method(5,6);

            RMB r = new RMB();
            string result = RMB.CmycurD(15);
            string result2 = r.CmycurD("14");

        }
        public class Test
        {
            public void aa()
            {
                try
                {
                    //short s1 = 1; s1 = s1 + 1;
                    int a = 1;
                    int b = 2;
                    Console.Write(a + b);
                    return;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Console.Write("执行了");
                }
            }
        }
        public int getvalue()
        {
            return 2;
        }
        private  class stat
        {
            public static int method(int a ,int b)
            {
                return a + b;
            }
        }
    }

    
}
