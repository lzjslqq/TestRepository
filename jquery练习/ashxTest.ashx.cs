using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jquery练习
{
    /// <summary>
    /// ashxTest 的摘要说明
    /// </summary>
    public class ashxTest : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

                 //获取虚拟目录的物理路径。
            string path = context.Server.MapPath("js\\jquery-1.7.1.min.js");
         
            //获取图片文件名
           // string picFileName = context.Request["pic"];
      
           // //获取图片文件的二进制数据。
           // byte[] datas = System.IO.File.ReadAllBytes(path + "\\" + picFileName);
           ////将二进制数据写入到输出流中。
           // context.Response.OutputStream.Write(datas, 0, datas.Length);

           // string file = context.Request.QueryString["file"].ToString();
            context.Response.ContentType = "text/plain";
            context.Response.Write(path);
           // switch (file)
           // {
           //     case "3":
           //         {
           //         context.Response.WriteFile(@"C:\Users\Administrator\Desktop\图片3.png");
           //         context.Response.Write("hello3");
           //         }
           //         break;
           //     case "4":
           //         {
           //             context.Response.WriteFile(@"C:\Users\Administrator\Desktop\图片4.png");
           //             context.Response.Write("hello4");
           //         }
           //         break;
           //     default: context.Response.WriteFile(@"C:\Users\Administrator\Desktop\图片3.png");
           //         break;
           // }
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}