using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day15_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(inputName.Text == "")
            {
                lblIzvade.Text = "Nav ievadits Jusu vards!";
            }
            else if(inputAge.Text == "")
            {
                lblIzvade.Text = "Nav noradits Jusu vecums!";
            }
            else
            {
                lblIzvade.Text = "Sveiki, " + inputName.Text + ", Tev ir " + inputAge.Text + " gadi!";
            }
        }
    }
}
