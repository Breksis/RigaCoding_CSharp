using System;
using System.Collections.Generic;
using System.Text;

namespace Day11
{
    public class Students
    {
        private String name;
        private String surname;
        private int course;

        public Students(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
        }

        public String GetName()
        {
            return name;
        }
        public String GetSurname()
        {
            return surname;
        }
        public int GetCourse()
        {
            return course;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetSurname(String surname)
        {
            this.surname = surname;
        }
        public void SetCourse(int course)
        {
            this.course = course;
        }

        public void print()
        {
            Console.WriteLine(name + " " + surname + ", Kurss: " + course);
        }
    }
}
