using System;
using System.Collections.Generic;

namespace Day13_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Exceptions.task3();
            
        }

        static void task1()
        {
            //uztaisit listu ar stringiem
            //lai cilveks pats aizpilda listu
            //uztaisit 2 metodes, 1 kas izdzes konkretu saraksta elementu, otru, kas iztira visu sarakstu

            List<string> saraksts = new List<string>();
            Console.WriteLine("Cik ierakstus veiksiet?");
            int skaits = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < skaits; i++)
            {
                Console.WriteLine("Ievadiet vardu.");
                saraksts.Add(Console.ReadLine());
            }

            Console.WriteLine("Vai velaties dzest konkretu ierakstu, vai visu sarakstu? 1 - ierakstu, 2 - sarakstu");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.WriteLine("Kuru ierakstu dzest?");
                int item = Convert.ToInt32(Console.ReadLine());
                saraksts.RemoveAt(item - 1);
            }
            else if(choice == 2)
            {
                saraksts.Clear();
            }

            foreach(string i in saraksts)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
