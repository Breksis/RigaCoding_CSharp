using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day15_List_Reapeat
{
    public class Tasks
    {
        public static void task2()
        {
            List<int> numbers = new List<int>();
            int skaits = 0;

            Console.WriteLine("Ludzu ievadiet skaitli.");
            int num = Convert.ToInt32(Console.ReadLine());

            try
            {
                StreamReader read = new StreamReader("C:\\Users\\ronis\\OneDrive\\Documents\\task1.txt");

                int rinda = Convert.ToInt32(read.ReadLine());
                numbers.Add(rinda);

                while (!read.EndOfStream)
                {
                    rinda =Convert.ToInt32(read.ReadLine());
                    numbers.Add(rinda);
                }
                read.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                if(num == numbers[i])
                {
                    skaits++;
                }
            }

            if(skaits == 0)
            {
                Console.WriteLine("Sads skaitlis nav faila.");
            }
            else
            {
                Console.WriteLine("Jusu ievaditais skaitlis " + num + " atkartojas " + skaits + " reizes.");
            }
        }
    }
}
