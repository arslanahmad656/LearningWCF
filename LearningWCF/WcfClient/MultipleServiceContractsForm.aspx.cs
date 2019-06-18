using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfClient
{
    public partial class MultipleServiceContractsForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new MultipleContractService.PublicServiceClient();
            Label1.Text = client.DisplayMessagePublic();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var client = new MultipleContractService.PrivateServiceClient();
            Label1.Text = client.DisplayMessagePrivate();
        }
    }
}