using System;
using System.Collections.Generic;
using System.IO;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> info = new List<Students>();

            ReadFile(info);

            Menu(info);
        }

        static void Menu(List<Students> list)
        {
            bool working = true;

            while (working)
            {
                Console.WriteLine("1. Izvadit informaciju.");
                Console.WriteLine("2. Pievienot jaunu studentu.");
                Console.WriteLine("3. Rediget ierakstu.");
                Console.WriteLine("4. Dzest ierakstu.");
                Console.WriteLine("5. Meklet.");
                Console.WriteLine("6. Beigt darbu");
                Console.WriteLine();
                Console.WriteLine("Izvelaties velamo darbibu:");
                String opcija = Console.ReadLine();

                switch (opcija)
                {
                    case "1":
                        Console.Clear();
                        Opcijas.PrintInfo(list);
                        break;
                    case "2":
                        Console.Clear();
                        Opcijas.AddStudent(list);
                        break;
                    case "3":
                        Console.Clear();
                        Opcijas.EditStudent(list);
                        break;
                    case "4":
                        Console.Clear();
                        Opcijas.DeleteStudent(list);
                        break;
                    case "5":
                        Console.Clear();
                        Opcijas.SearchStudent(list);
                        break;
                    case "6":
                        Console.Clear();
                        working = false;
                        break;
                    default:
                        Console.Clear();
                        Menu(list);
                        break;
                }
            }
        }

        public static void UpdateFile(List<Students> list)
        {
            try
            {
                StreamWriter write = new StreamWriter("C:\\Users\\ronis\\OneDrive\\Documents\\Students.txt");
                for (int i = 0; i < list.Count; i++)
                {
                    write.WriteLine(list[i].GetName() + " " + list[i].GetSurname() + " " + list[i].GetCourse());
                }
                write.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadFile(List<Students> list)
        {
            try
            {
                StreamReader read = new StreamReader("C:\\Users\\ronis\\OneDrive\\Documents\\Students.txt");
                String rinda = read.ReadLine();
                String[] sadalit = rinda.Split(' ');
                String name = sadalit[0];
                String surname = sadalit[1];
                int course;
                int.TryParse(sadalit[2], out course);
                list.Add(new Students(name, surname, course));

                while (!read.EndOfStream)
                {
                    rinda = read.ReadLine();
                    sadalit = rinda.Split(' ');
                    name = sadalit[0];
                    surname = sadalit[1];
                    int.TryParse(sadalit[2], out course);
                    list.Add(new Students(name, surname, course));
                }
                read.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
