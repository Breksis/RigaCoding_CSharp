using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public class Opcijas
    {
        public static void PrintInfo(List<Students> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(i + 1 + ". "); list[i].print();
            }
            Console.WriteLine();

            if (list.Count == 0)
            {
                Console.WriteLine("Saraksts ir tuks!");
                Console.WriteLine();
            }
        }
        public static void AddStudent(List<Students> list)
        {
            Console.WriteLine("Ievadiet vardu.");
            String name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu.");
            String surname = Console.ReadLine();

            Console.WriteLine("Ievadiet kursu.");
            int course = Convert.ToInt32(Console.ReadLine());

            list.Add(new Students(name, surname, course));
        }
        public static void EditStudent(List<Students> list)
        {
            PrintInfo(list);
            Console.WriteLine();
            Console.WriteLine("Kuru rindu velaties labot?");
            int edit = Convert.ToInt32(Console.ReadLine());
            edit--;

            Console.WriteLine("Ko velaties labot?");
            Console.WriteLine("1. Vards.");
            Console.WriteLine("2. Uzvards.");
            Console.WriteLine("3. Kurss.");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Ievadiet vardu.");
                list[edit].SetName(Console.ReadLine());
            }
            else if (choice == 2)
            {
                Console.WriteLine("Ievadiet uzvardu.");
                list[edit].SetSurname(Console.ReadLine());
            }
            else if (choice == 3)
            {
                Console.WriteLine("Ievadiet kursu.");
                list[edit].SetCourse(Convert.ToInt32(Console.ReadLine()));
            }
            else Console.WriteLine("Tada darbiba neeksiste!");


        }
    }
}
