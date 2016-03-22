using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class CallWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Weather.WeatherWebServiceSoapClient w = new Weather.WeatherWebServiceSoapClient();
            //localhost.WebServiceTest wt = new localhost.WebServiceTest();
            myWebService.WebServiceTestSoapClient w = new myWebService.WebServiceTestSoapClient();
            tbResult.Text = w.Getstring(tbInput.Text);
        }
    }
}