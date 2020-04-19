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

                ChartFill();
            }
            
            if(Valstis.Text == "Latvija")
            {
                foreach(var item in Metodes.AllCountries().result)
                {
                    
                }
            }
        }

        private void ChartFill()
        {
            this.Chart.Series["Saslimuši"].Points.AddXY("Pasaule", Metodes.GlobalData().result.confirmed);
            this.Chart.Series["Miruši"].Points.AddXY("Pasaule", Metodes.GlobalData().result.deaths);
            this.Chart.Series["Atveseļojušies"].Points.AddXY("Pasaule", Metodes.GlobalData().result.recovered);
        }
    }
}
