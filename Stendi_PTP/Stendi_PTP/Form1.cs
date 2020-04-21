using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stendi_PTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Stends> klienti = new List<Stends>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_Add form2 = new Form_Add())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    //klienti.Add(new Stends(Form_Add.GetNewClient().GetName(), Form_Add.GetNewClient().GetPilseta(), Form_Add.GetNewClient().GetIela(), Form_Add.GetNewClient().GetIndeks(), Form_Add.GetNewClient().GetEpasts(), Form_Add.GetNewClient().GetTelefons()));
                    label1.Text = Form_Add.jauns.GetName();
                }
            }
        }

        public void Add_Client_ToList()
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {

        }
    }
}
