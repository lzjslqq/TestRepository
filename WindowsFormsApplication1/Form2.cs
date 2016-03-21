using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public delegate void DelChangeMsg(string msg);

    public partial class Form2 : Form
    {
        private DelChangeMsg _del;
        public Form2(DelChangeMsg d)
        {
            this._del = d;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _del(this.textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _del(this.textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string test = @"123Abc";
            string reg = @"^\d+\w*$";

            Match m = Regex.Match(test, reg);
            textBox1.Text = Regex.Replace(test, reg, "匹配成功");

            WebClient web = new WebClient();
            byte[] buffer= web.DownloadData(@"C:\Users\Administrator\Desktop\视频.txt");
            string result = Encoding.UTF8.GetString(buffer);
            File.WriteAllText(@"C:\Users\Administrator\Desktop\视频.txt", result, Encoding.UTF8);
        }
    }
}
