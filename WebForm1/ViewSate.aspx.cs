using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class ViewSate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Request.Form["txtNum"]);
            num++;
            
            byte[] inBytes = Encoding.Default.GetBytes(num.ToString());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] outBytes = md5.ComputeHash(inBytes);
            txtNum.Value = BitConverter.ToString(outBytes);

        }
    }
}