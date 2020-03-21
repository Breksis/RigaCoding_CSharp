using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day18_GUIFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<String> file = new List<string>();
        private void btnFileRead_Click(object sender, EventArgs e)
        {
            try
            {
                Metodes.ReadFile(file);

                for (int i = 0; i < file.Count; i++)
                {
                    fileList.Items.Add(new ListViewItem(file[i]));
                }

                infoText.Text = "Fails nolasits veiksmigi!";
            }
            catch
            {
                infoText.Text = "Kluda nolasot failu!";
            }
        }
    }
}
