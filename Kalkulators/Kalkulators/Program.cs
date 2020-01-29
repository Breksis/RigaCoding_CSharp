using System;

namespace Kalkulators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulators");

            zvaigznes();

            Console.ReadLine();

            Menu();
            
        }
        static void Menu()
        {
            Console.WriteLine("Izvelieties darbibu!");
            Console.WriteLine("1: Pamatdarbibas(+, -, *, /)");
            Console.WriteLine("2: Kapinasana");
            Console.WriteLine("3: Kvadratsakne");

            zvaigznes();

            String izvele = Console.ReadLine();

            if (izvele == "1")
            {
                pamatdarbibas();
            }
            else if (izvele == "2")
            {
                pakapes();
            }
            else if (izvele == "3")
            {
                kvadratsaknes();
            }
            else Console.WriteLine("Tada izvele neeksiste!");
        }
        static void pamatdarbibas()
        {
            Console.WriteLine("Ievadiet pirmo skaitli!");
            String ievade = Console.ReadLine();

            float skaitlis1 = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadiet otro skaitli!");
            String ievade2 = Console.ReadLine();

            float skaitlis2 = Convert.ToInt32(ievade2);

            Console.WriteLine("Ievadiet veicamo darbibu! (+, -, x, /)");
            String darbiba = Console.ReadLine();

            if (darbiba == "+")
            {
                float rezultats = skaitlis1 + skaitlis2;
                Console.WriteLine("Rezultats = " + rezultats);
            }
            else if (darbiba == "-")
            {
                float rezultats = skaitlis1 - skaitlis2;
                Console.WriteLine("Rezultats = " + rezultats);
            }
            else if (darbiba == "x")
            {
                float rezultats = skaitlis1 * skaitlis2;
                Console.WriteLine("Rezultats = " + rezultats);
            }
            else if (darbiba == "/")
            {
                float rezultats = skaitlis1 / skaitlis2;
                Console.WriteLine("Rezultats = " + rezultats);
            }
            else Console.WriteLine("Ievadita nepareiza darbiba!");
        }
        static void pakapes()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String ievade = Console.ReadLine();

            double skaitlis = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadiet kapinataju!");
            ievade = Console.ReadLine();

            double kapinatajs = Convert.ToInt32(ievade);

            double rezultats = Math.Pow(skaitlis, kapinatajs);
            Console.WriteLine("Rezultats = " + rezultats);
        }
        static void kvadratsaknes()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String ievade = Console.ReadLine();

            double skaitlis = Convert.ToInt32(ievade);

            Console.WriteLine("Rezultats = " + Math.Sqrt(skaitlis));
        }
        static void zvaigznes(int zv = 50)
        {
            int i;
            for (i = 1; i < zv; i++) Console.Write("*");
        }
    }
}
