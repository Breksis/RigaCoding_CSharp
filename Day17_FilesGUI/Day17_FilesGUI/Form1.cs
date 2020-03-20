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
            stud.Add(new Students("Artis", "Abols", 2));
            stud.Add(new Students("Oskars", "Ozols", 1));

            for(int i = 0; i < stud.Count; i++)
            {
                studentList.Items.Add(new ListViewItem(stud[i].GetName() + " " + stud[i].GetSurname() + ", " + stud[i].GetCourse()));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int course = Convert.ToInt32(inputCourse.Text);
                if (course < 1 || course > 3)
                {
                    InfoText.Text = "Kursam jabut 1, 2 vai 3!";
                }
                else
                {
                    stud.Add(new Students(inputName.Text, inputSurname.Text, course));
                    studentList.Items.Add(new ListViewItem(inputName.Text + " " + inputSurname.Text + ", " + inputCourse.Text));
                    InfoText.Text = "Students veiksmigi pievienots!";
                }
            }
            catch
            {
                InfoText.Text = "Neizdevas pievienot!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in studentList.SelectedItems)
            {
                studentList.Items.Remove(item);
            }

            stud.Clear();

            for(int i = 0; i < studentList.Items.Count; i++)
            {
                String viewItem = studentList.Items[i].ToString();
                String[] split = viewItem.Split(' ', ',');
                String name = split[0];
                String surname = split[1];
                int course;
                int.TryParse(split[2], out course);
                stud.Add(new Students(name, surname, course));
            }

            InfoText.Text = "Ieraksts izdzests!";
        }
    }
}
