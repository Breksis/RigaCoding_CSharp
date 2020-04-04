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
    class Metodes
    {
        public static string GetData(string url)
        {
            WebClient client = new WebClient();
            String dati = client.DownloadString(url);

            return dati;
        }

        public static ContainerGlobal GlobalData()
        {
            String url = "https://covidapi.info/api/v1/global";
            String json = GetData(url);
            var received = JsonConvert.DeserializeObject<ContainerGlobal>(json);

            return received;
        }

        public static ContainerGlobal Latvija()
        {
            String url = "https://covidapi.info/api/v1/country/LVA/latest";
            String json = GetData(url);
            var received = JsonConvert.DeserializeObject<ContainerGlobal>(json);

            return received;
        }
    }
}
