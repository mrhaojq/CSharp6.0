using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppService
{
    public partial class Weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherWebService _client = new WeatherService.WeatherWebService();

            var s = _client.getWeatherbyCityName(txtCity.Text.Trim());

            if (s[8]=="")
            {
                weatherMsg1.Text = "Not Support";
            }
            else
            {
                weatherMsg1.Text = $"天气概况：{s[1]}  {s[6]}";
                weatherMsg2.Text = $"天气实况：{s[10]}";
            }
        }
    }
}