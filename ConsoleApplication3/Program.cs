using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication3
{   
    class Program
    {
        
        static void Main(string[] args)
        {
            SerHanddle();
            Console.WriteLine("+++++++++++++++++++");
            Console.ReadKey();
        }

        public static void XmlHanddle()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xde = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(xde);

            XmlElement xe = doc.CreateElement("Users");
            doc.AppendChild(xe);

            XmlElement user1 = doc.CreateElement("user");
            user1.SetAttribute("ID", "1");
            xe.AppendChild(user1);

            XmlElement name1 = doc.CreateElement("name");
            name1.InnerText = "李明";
            user1.AppendChild(name1);

            XmlElement age1 = doc.CreateElement("age");
            age1.InnerText = "11";
            user1.AppendChild(age1);

            XmlElement user2 = doc.CreateElement("user");
            user2.SetAttribute("ID", "2");
            xe.AppendChild(user2);

            XmlElement name2 = doc.CreateElement("name");
            name2.InnerText = "王像";
            user2.AppendChild(name2);

            XmlElement age2 = doc.CreateElement("age");
            age2.InnerText = "20";
            user2.AppendChild(age2);

            doc.Save("testXml.xml");
        }

        public static void IOHanddle()
        {
            if(File.Exists("testXml.xml"))
            {
                FileInfo file = new FileInfo("testXml.xml");
                file.CopyTo(@"C:\Users\Administrator\Desktop\txt.txt",true);
                FileStream fs = file.OpenRead();
                byte[] buffer = new byte[1024];
                int r = fs.Read(buffer, 0, buffer.Length);

                string info = Encoding.UTF8.GetString(buffer, 0, r);
                Console.Write(info);
            }
        }

        public static void SerHanddle()
        {

            string path = @"C:\Users\Administrator\Desktop\1.txt";
            Config con = new Config
            {
                age = 6,
                name = "李明2",
                width = 164
            };
            using(FileStream fs =new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fs, con);
            }

            Console.WriteLine("序列化成功！！");
            Console.WriteLine(con.age);
            Console.WriteLine(con.name);
            Console.WriteLine(con.width);

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter b = new BinaryFormatter();
                con = b.Deserialize(fs) as Config;
            }
            Console.WriteLine("反序列化成功！！");
            Console.WriteLine(con.age);
            Console.WriteLine(con.name);
            Console.WriteLine(con.width);
        }

    }

   
}
