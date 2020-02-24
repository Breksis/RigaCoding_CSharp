using System;

namespace MD_Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            task4and5();
        }

        static void task1and2()
        {
            String[] mas1 = new string[6];
            for(int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = "#";
            }

            for(int i = 0; i < mas1.Length; i++)
            {
                for(int j = 0; j < mas1.Length; j++)
                {
                    Console.Write(mas1[i]);
                }
                Console.WriteLine();
            }
        }

        static void task3()
        {
            int[] mas2 = new int[5];
            for(int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = i * 2 + 2;
            }

            for(int i = 0; i < mas2.Length; i++)
            {
                Console.WriteLine(mas2[i]);
            }
        }

        static void task4and5()
        {
            Console.WriteLine("Izvelieties masiva izmeru.");
            int[] mas3 = new int[Convert.ToInt32(Console.ReadLine())];

            for(int i = 0; i < mas3.Length; i++)
            {
                Console.WriteLine("Ievadiet vertibu.");
                mas3[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for(int i = 0; i < mas3.Length; i++)
            {
                if(mas3[i] % 2 != 0)
                {
                    Console.WriteLine(mas3[i]);
                }
            }
        }
    }
}
