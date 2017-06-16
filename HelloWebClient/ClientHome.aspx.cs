using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class ClientHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloWebService.HelloWebServiceSoapClient client = new HelloWebService.HelloWebServiceSoapClient();
            Label1.Text = client.HelloWorld(TextBox1.Text);
        }
    }
}