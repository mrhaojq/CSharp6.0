using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetResult_Click(object sender, EventArgs e)
        {
            ServiceRef.MyWebServiceSoapClient _client = new ServiceRef.MyWebServiceSoapClient();
            txtResult.Text = _client.Multiplier(int.Parse(txtA.Text), int.Parse(txtB.Text)).ToString();
        }
    }
}