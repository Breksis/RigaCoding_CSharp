using System;

namespace Day7_uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet pirmo skaitli.");
            double num1 = Ievade.input();
            Console.WriteLine("Ievadiet otro skaitli.");
            double num2 = Ievade.input();
            Console.WriteLine("Ievadiet darbibu!");
            String darbiba = Console.ReadLine();

            if(darbiba == "+")
            {
                Calculator.plus(num1, num2);
            }
        }
    }
}
