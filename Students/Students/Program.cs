using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            List<Students> info = new List<Students>();
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
                        Opcijas.PrintInfo(info);
                        break;
                    case "2":
                        Console.Clear();
                        Opcijas.AddStudent(info);
                        break;
                    case "3":
                        Console.Clear();
                        Opcijas.EditStudent(info);
                        break;
                    case "4":
                        Console.Clear();
                        Opcijas.DeleteStudent(info);
                        break;
                    case "5":
                        Console.Clear();
                        Opcijas.SearchStudent(info);
                        break;
                    case "6":
                        Console.Clear();
                        working = false;
                        break;
                    default:
                        Console.Clear();
                        Menu();
                        break;
                }
            }
        }
    }
}
