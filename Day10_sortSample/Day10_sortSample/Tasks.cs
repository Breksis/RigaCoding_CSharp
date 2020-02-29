using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_sortSample
{
    public class Tasks
    {
        public static void task1()
        {
            int[] masivs = new int[5];
            for(int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = Sorting.randNum();
            }

            Console.WriteLine("Ievadiet velamo masiva garumu.");
            int garums = Convert.ToInt32(Console.ReadLine());

            if(garums <= 5)
            {
                for(int i =0; i < masivs.Length; i++)
                {
                    Console.WriteLine(masivs[i]);
                }
            }
            else
            {
                
                int[] temp = new int[masivs.Length];

                for (int i = 0; i < masivs.Length; i++)
                {
                    temp[i] = masivs[i];
                }

                masivs = new int[garums];

                for (int i = 0; i < temp.Length; i++)
                {
                    masivs[i] = temp[i];
                }

                for(int i = 5; i < masivs.Length; i++)
                {
                    masivs[i] = Sorting.randNum();
                }

                for(int i = 0; i < masivs.Length; i++)
                {
                    Console.WriteLine(masivs[i]);
                }

            }
        }
    }
}
