using System;

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
            Students[] info = new Students[5];
            bool working = true;

            while (working)
            {
                Console.WriteLine("1. Izvadit informaciju.");
                Console.WriteLine("2. Pievienot jaunu studentu.");
                Console.WriteLine("3. Rediget ierakstu.");
                Console.WriteLine("4.Beigt darbu.");
                Console.WriteLine();
                Console.WriteLine("Izvelaties velamo darbibu:");
                int opcija = Convert.ToInt32(Console.ReadLine());

                switch (opcija)
                {
                    case 1:
                        Console.Clear();
                        Opcijas.PrintInfo(info);
                        break;
                    case 2:
                        Console.Clear();
                        Opcijas.AddStudent(info);
                        break;
                    case 3:
                        Console.Clear();
                        Opcijas.EditStudent(info);
                        break;
                    case 4:
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
