using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Lists
{
    class Example
    {
        public static void ex1()
        {
            List<int> a = new List<int>();
            a.Add(2);
            a.Add(5);

            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            foreach(int b in a)
            {
                Console.WriteLine(b);
            }

            
        }

        //Lists ar int skaitliem
        //Cilveks izvelas, cik skaitlus sarakastam pievienot
        //Cilveks pievieno skaitlus
        //Izvada skaitlu summu

        public static void task1()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Cik skaitlus pievienot sarakastam?");
            int skaits = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < skaits; i++)
            {
                Console.WriteLine("Ievadiet skaitli.");
                int input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            int summa = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                summa = summa + numbers[i];
            }

            Console.WriteLine("Skaitlu summa ir " + summa);
        }
    }
}
