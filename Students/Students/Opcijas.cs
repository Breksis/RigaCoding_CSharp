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
            try
            {
                int course = Convert.ToInt32(Console.ReadLine());
                list.Add(new Students(name, surname, course));
            }
            catch
            {
                Console.WriteLine("Kursa nummuram ir jabut skaitlim!");
            }

        }
        public static void EditStudent(List<Students> list)
        {
            PrintInfo(list);
            Console.WriteLine();
            Console.WriteLine("Kuru rindu velaties labot?");
            try
            {
                int edit = Convert.ToInt32(Console.ReadLine());
                edit--;

                Console.WriteLine("Ko velaties labot?");
                Console.WriteLine("1. Vards.");
                Console.WriteLine("2. Uzvards.");
                Console.WriteLine("3. Kurss.");

                String choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Ievadiet vardu.");
                    list[edit].SetName(Console.ReadLine());
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Ievadiet uzvardu.");
                    list[edit].SetSurname(Console.ReadLine());
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Ievadiet kursu.");
                    list[edit].SetCourse(Convert.ToInt32(Console.ReadLine()));
                }
                else Console.WriteLine("Tada darbiba neeksiste!");
            }
            catch
            {
                Console.WriteLine("Tada rinda nav saraksta!");
            }
            
        }

        public static void DeleteStudent(List<Students> list)
        {
            PrintInfo(list);
            Console.WriteLine();
            Console.WriteLine("Kuru rindu velaties dzest?");
            try
            {
                int delete = Convert.ToInt32(Console.ReadLine());
                list.RemoveAt(delete - 1);
            }
            catch
            {
                Console.WriteLine("Ievadita neeksistejosa rinda!");
            }
        }

        public static void SearchStudent(List<Students> list)
        {
            Console.WriteLine("Ievadiet vardu, uzvardu vai kursu.");
            string input = Console.ReadLine();
            int kurss;
            int.TryParse(input, out kurss);
            int skaits = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetName().Contains(input) || list[i].GetSurname().Contains(input) || list[i].GetCourse().Equals(kurss))
                {
                    Console.Write(i + 1 + ". "); list[i].print();
                }
                else skaits++;
            }

            if(skaits == list.Count)
            {
                Console.WriteLine("Sads students nav saraksta!");
            }
        }
    }
}
