using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_klases_un_obj
{
    class Students
    {
        private String name;
        private String surname;
        private int course;
        private int year;
        public Students(String name, String surname, int course, int year)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
            this.year = year;

            if(this.course < 1)
            {
                this.course = 1;
            }
            if(this.course > 3)
            {
                this.course = 3;
            }

        }

        public void print()
        {
            Console.WriteLine(name + " " + surname + ", Kurss: " + course + ". gads: " + year);
        }
    }
}
