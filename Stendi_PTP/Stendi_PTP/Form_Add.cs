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
using System.IO;

namespace Stendi_PTP
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        public static Stends jauns;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String pilseta = txtPilseta.Text;
            String iela = txtIela.Text;
            String indeks = txtIndeks.Text;
            String ePasts = txt_ePasts.Text;
            int number;
            int.TryParse(txtTelefons.Text, out number);
            int telefons = number;
            jauns = new Stends(name, pilseta, iela, indeks, ePasts, telefons);
            this.Close();
        }

        public static Stends GetNewClient()
        {
            return jauns;
        }

        public void AddNew()
        {
            String name = txtName.Text;
            String pilseta = txtPilseta.Text;
            String iela = txtIela.Text;
            String indeks = txtIndeks.Text;
            String ePasts = txt_ePasts.Text;
            int number;
            int.TryParse(txtTelefons.Text, out number);
            int telefons = number;
            Stends jauns = new Stends(name, pilseta, iela, indeks, ePasts, telefons);
            
            String json = JsonConvert.SerializeObject(jauns);

            try
            {
                StreamWriter write = new StreamWriter("C:\\Users\\ronis\\OneDrive\\Documents\\StendiPTP.txt");
                write.WriteLine(json);
                write.Close();
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
