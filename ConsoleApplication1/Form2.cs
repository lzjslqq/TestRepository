using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplication1
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
    }
}
