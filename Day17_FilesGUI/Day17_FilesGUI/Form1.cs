using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day17_FilesGUI
{
    public partial class Form1 : Form
    {
        List<Students> stud;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            stud = new List<Students>();
            stud.Add(new Students("Janis", "Berzins", 3));
            stud.Add(new Students("Andris", "Koks", 1));
            stud.Add(new Students("Valdis", "Zatlers", 3));
            stud.Add(new Students("Artis", "Abols", 3));
            stud.Add(new Students("Oskars", "Ozols", 3));

            for(int i = 0; i < stud.Count; i++)
            {
                studentList.Items.Add(new ListViewItem(stud[i].GetName() + " " + stud[i].GetSurname() + ", " + stud[i].GetCourse()));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stud.Add(new Students(inputName.Text, inputSurname.Text, Convert.ToInt32(inputCourse.Text)));
            studentList.Items.Add(new ListViewItem(inputName.Text + " " + inputSurname.Text + ", " + inputCourse.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in studentList.SelectedItems)
            {
                studentList.Items.Remove(item);
            }
        }
    }
}
