using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_masivi
{
    public class tasks
    {
        public tasks()
        {

        }

        //Uztaisit masivu, kuram garumu ievada lietottajs
        //Pec tam, lai lietotajs aizpilda masivu ar izveletajam vertibam
        //aizpildisanai izmantojam for ciklu
        //izvadat masivu


        //uztaisit masivu ar 5 elemetiem
        //string tipa masivs
        //pirmos 4 elemetus aizpilda cilveks
        //piektaja elementa glabajas pirmo 4 elementu summa


        public static void task1()
        {
            Console.WriteLine("Izvelieties masiva garumu.");
            int garums = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[garums];

            for(int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("Ievadiet " + (i+1) + ". elementu.");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }

        }

        public static void task2()
        {
            String[] masivs = new string[5];

            for(int i = 0; i < masivs.Length - 1; i++)
            {
                Console.WriteLine("Ievadiet simbolu virkni.");
                masivs[i] = Console.ReadLine();
                masivs[masivs.Length - 1] += masivs[i];
            }

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine(masivs[i]);
            }


        }
    }
}
