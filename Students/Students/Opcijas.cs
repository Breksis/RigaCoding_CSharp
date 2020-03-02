using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public class Opcijas
    {
        public static void PrintInfo(Students[] array)
        {
            int skaits = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    array[i].print();
                }
                else skaits++;
            }

            if (skaits == array.Length)
            {
                Console.WriteLine("Saraksts ir tuks!");
                Console.WriteLine();
            }
        }
        public static void AddStudent(Students[] array)
        {
            int skaits = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    Console.WriteLine("Ievadiet vardu.");
                    String name = Console.ReadLine();

                    Console.WriteLine("Ievadiet uzvardu.");
                    String surname = Console.ReadLine();

                    Console.WriteLine("Ievadiet kursu.");
                    int course = Convert.ToInt32(Console.ReadLine());

                    array[i] = new Students(name, surname, course);

                    break;
                }
                else skaits++;

                if(skaits == array.Length)
                {
                    Console.WriteLine("Saraksta vairs nav vietu!");
                }
            }
        }
        public static void EditStudent(Students[] array)
        {
            int row = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != null)
                {
                    row = i + 1;
                    Console.Write(row + ". "); array[i].print();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kuru rindu velaties labot?");
            int edit = Convert.ToInt32(Console.ReadLine());

            if(edit == row)
            {
                Console.WriteLine("Ko velaties labot?");
                Console.WriteLine("1. Vards.");
                Console.WriteLine("2. Uzvards.");
                Console.WriteLine("3. Kurss.");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ievadiet vardu.");
                        String name = Console.ReadLine();
                        array[row].SetName(Convert.ToString(name));
                        break;
                }
            }

        }
    }
}
