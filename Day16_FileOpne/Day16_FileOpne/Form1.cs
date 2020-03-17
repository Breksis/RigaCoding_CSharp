using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day16_FileOpne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            List<String> testList = new List<string>();

            for(int i = 0; i < 5; i++)
            {
                testList.Add((i+1) + ". elements");
            }

            foreach(String str in testList)
            {
                var item = new ListViewItem();
                item.Text = str;
                TestListView.Items.Add(item);
            }
        }
    }
}
