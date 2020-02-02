using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulators");
            
            Zvaigznes();
            Console.ReadLine();
            Menu();
        }

        static double userInput()
        {
            String ievade = Console.ReadLine();
            double input = Convert.ToDouble(ievade);
            return input;
        }

        static void Menu()
        {
            Console.WriteLine("Izvelieties darbibu!");
            Console.WriteLine("1: Pamatdarbibas(+, -, *, /)");
            Console.WriteLine("2: Kapinasana");
            Console.WriteLine("3: Kvadratsakne");

            Zvaigznes();

            String izvele = Console.ReadLine();

            if (izvele == "1")
            {
                Pamatdarbibas();
            }
            else if (izvele == "2")
            {
                Pakapes();
            }
            else if (izvele == "3")
            {
                Kvadratsaknes();
            }
            else Console.WriteLine("Tada izvele neeksiste!");
        }

        static void Pamatdarbibas()
        {
            Console.WriteLine("Ievadiet pirmo skaitli!");
            double num1 = userInput();
            Console.WriteLine("Ievadiet otro skaitli!");
            double num2 = userInput();
            Console.WriteLine("Ievadiet veicamo darbibu! (+, -, *, /)");
            String darbiba = Console.ReadLine();

            if (darbiba == "+")
            {
                Console.WriteLine("Rezultats: " + num1 + darbiba + num2 + "=" + (num1 + num2));
            }
            else if (darbiba == "-")
            {
                Console.WriteLine("Rezultats: " + num1 + darbiba + num2 + "=" + (num1 - num2));
            }
            else if (darbiba == "*")
            {
                Console.WriteLine("Rezultats: " + num1 + darbiba + num2 + "=" + (num1 * num2));
            }
            else if (darbiba == "/")
            {
                Console.WriteLine("Rezultats: " + num1 + darbiba + num2 + "=" + (num1 / num2));
            }
            else Console.WriteLine("Ievadita nepareiza darbiba!");
        }

        static void Pakapes()
        {
            Console.WriteLine("Ievadiet kapinamo skaitli!");
            double num = userInput();
            Console.WriteLine("Ievadiet kapinataju!");
            double pakape = userInput();
            Console.WriteLine("Skaitlis " + num + " pakape " + pakape + " ir " + Math.Pow(num, pakape));
        }

        static void Kvadratsaknes()
        {
            Console.WriteLine("Ievadiet skaitli, no kura velaties izvilkt kvadratsakni!");
            double num = userInput();
            Console.WriteLine("Kvadratsakne no " + num + " ir " + Math.Sqrt(num));
        }

        static void Zvaigznes(int zv = 50)
        {
            int i;
            for (i = 1; i < zv; i++) Console.Write("*");
        }
    }
}
