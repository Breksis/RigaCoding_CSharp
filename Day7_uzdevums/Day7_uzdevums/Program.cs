using System;

namespace Day7_uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void Kalkulators()
        {
            Console.WriteLine("Ievadiet pirmo skaitli.");
            double num1 = Ievade.input();
            Console.WriteLine("Ievadiet otro skaitli.");
            double num2 = Ievade.input();
            Console.WriteLine("Ievadiet darbibu!");
            String darbiba = Console.ReadLine();

            if (darbiba == "+")
            {
                Calculator.plus(num1, num2);
            }
            else if (darbiba == "-")
            {
                Calculator.minus(num1, num2);
            }
            else if (darbiba == "*")
            {
                Calculator.reiz(num1, num2);
            }
            else Calculator.dal(num1, num2);
        }
    }
}
