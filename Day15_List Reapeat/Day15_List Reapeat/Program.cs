using System;
using System.Collections.Generic;

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

            bool turpinat = true;
            while (turpinat)
            {
                Console.WriteLine("Ievadiet skaitli.");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);

                Console.WriteLine("Vai turpinat ievadit skaitlus?");
                Console.WriteLine("1 - ja, citi taustini - ne!");
                String choice = Console.ReadLine();
                if (choice == "1")
                {
                    turpinat = true;
                }
                else turpinat = false;




            }


        }
    }
}
