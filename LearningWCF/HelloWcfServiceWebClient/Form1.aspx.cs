using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWcfServiceWebClient
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloWcfServiceReference.HelloWcfServiceClient client = null;
            try
            {
                client = new HelloWcfServiceReference.HelloWcfServiceClient("http://localhost:56335/HelloService");
                var message = client.GetMessage(TextBox1.Text);
                Label1.Text = message;
            }
            finally
            {
                client?.Close();
            }
        }
    }
}