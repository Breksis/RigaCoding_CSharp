using System;

namespace Day6_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            task4();
        }

        static void task1()
        {
            int biggest = Int32.MinValue;
            for(int i = 0; i < 6; i++)
            {
                int currentNumber = ievade("skaitli");
               /* if (i == 0)
                {
                    biggest = currentNumber;
                }*/
                if(currentNumber > biggest)
                {
                    biggest = currentNumber;
                }
            }
            Console.WriteLine(biggest);
        }

        static int ievade(String vertiba)
        {
            Console.WriteLine("Ievadiet " + vertiba);
            String input = Console.ReadLine();
            int skaitlis = Convert.ToInt32(input);

            return skaitlis;
        }

        static void task2()
        {
            Console.WriteLine("ievadiet gradus pec farenheita");
            String input = Console.ReadLine();
            double gradiF = Convert.ToDouble(input);

            double gradiC = (gradiF - 32) * 5 / 9;
            Console.WriteLine("Gradi pec Celsija ir " + gradiC);
        }

        static void task3()
        {
            int w = ievade("platumu");
            int h = ievade("garumu");

            for(int i = 0; i < h; i++)
            {
                for(int j = 0; j < w; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void task4()
        {
            String input2 = "";
            do
            {
                Console.WriteLine("Ievadiet frazi");
                input2 = Console.ReadLine();
            }
            while (input2.Contains("zirgs") || input2.Contains("suns"));
        }
    }
}
