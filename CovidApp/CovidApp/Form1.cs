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
using System.Windows.Forms.DataVisualization.Charting;

namespace CovidApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void Valstis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Valstis.Text == "Pasaule")
            {
                txtConfirmed.Text = Metodes.GlobalData().result.confirmed;
                txtDeaths.Text = Metodes.GlobalData().result.deaths;
                txtRecovered.Text = Metodes.GlobalData().result.recovered;
                lblDate.Text = Metodes.GlobalData().date;
            }
            
            if(Valstis.Text == "Latvija")
            {
                txtConfirmed.Text = Metodes.Latvija().result.confirmed;
                txtDeaths.Text = Metodes.Latvija().result.deaths;
                txtRecovered.Text = Metodes.Latvija().result.recovered;
            }
        }

        private void ChartFill()
        {
            
        }
    }
}
