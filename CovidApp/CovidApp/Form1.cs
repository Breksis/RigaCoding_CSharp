using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace CovidApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Global> world;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            String url = "https://covidapi.info/api/v1/global";
            String json = GetData(url);
            var received = JsonConvert.DeserializeObject<ContainerGlobal>(json);

            for(int i = 0; i < received.result.Count; i++)
            {
                txtConfirmed.Text = received.result[i].confirmed;
                txtDeaths.Text = received.result[i].deaths;
                txtRecovered.Text = received.result[i].recovered;

                lblDate.Text = received.date;
            }
        }
        public static string GetData(string url)
        {
            WebClient client = new WebClient();
            String dati = client.DownloadString(url);

            return dati;
        }
    }
}
