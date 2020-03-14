using System;
using System.Collections.Generic;
using System.IO;

namespace Day15_List_Reapeat
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
        }
        static void task1()
        {
            //uztaisit listu no int elementiem
            //1. izvadit visus elementus
            //2. pievienot
            //3. sasummet visus lista elemntus
            //Listu jasaglaba un janolasa no faila

            List<int> numbers = new List<int>();

            ReadFile(numbers);

            bool turpinat = true;
            while (turpinat)
            {
                Console.WriteLine("Ievadiet skaitli.");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);
                UpdateList(numbers);

                Console.WriteLine("Vai turpinat ievadit skaitlus?");
                Console.WriteLine("1 - ja, citi taustini - ne!");
                String choice = Console.ReadLine();
                if (choice == "1")
                {
                    turpinat = true;
                }
                else turpinat = false;
            }
                bool work = true;

            while (work)
            {
                Console.WriteLine("1. Izvadit");
                Console.WriteLine("2. Pievienot");
                Console.WriteLine("3. Sasummet");
                Console.WriteLine("4. Iziet");

                String izvele = Console.ReadLine();

                switch (izvele)
                {
                    case "1":
                        foreach (int n in numbers)
                        {
                            Console.WriteLine(n);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ievadiet skaitli.");
                        numbers.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "3":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum = sum + numbers[i];
                        }
                        Console.WriteLine("Summa ir " + sum);
                        break;
                    case "4":
                        work = false;
                        break;
                }
            }

            static void ReadFile(List<int> numbers)
            {
                try
                {
                    StreamReader read = new StreamReader("C:\\Users\\ronis\\OneDrive\\Documents\\task1.txt");

                    int rinda = Convert.ToInt32(read.ReadLine());
                    numbers.Add(rinda);

                    while (!read.EndOfStream)
                    {
                        numbers.Add(rinda);
                    }
                    read.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            static void UpdateList(List<int> numbers)
            {
                try
                {
                    StreamWriter write = new StreamWriter("C:\\Users\\ronis\\OneDrive\\Documents\\task1.txt");
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        write.WriteLine(numbers[i]);
                    }
                    write.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
