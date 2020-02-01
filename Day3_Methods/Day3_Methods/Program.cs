using System;

namespace Day3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*piemers1();
            piemers2();
            piemers3(3, 7);
            int c = piemers4();*/

            //1. saskaitisana
            //ievads main metode, padodam skaitlus uz musu izveidoto metodi ka parametrus
            //izvade notiek tur

            //2. ievade notiek musu izveidota metode
            //rezultatu atgriezam ar return un izvadam main

            //3. apvienojam 1. un 2.
            //Musu izveidotaja metode notiek tikai darbiba
            //visa ievade/izvade notiek main(gan parametri, gan return)

            Console.WriteLine("Ievadiet pirmo skaitli");
            String ievade = Console.ReadLine();
            int num1 = Convert.ToInt32(ievade);
            Console.WriteLine("Ievadiet otro skaitli");
            ievade = Console.ReadLine();
            int num2 = Convert.ToInt32(ievade);

            Console.WriteLine("Rezultats ir " + sum3(num1, num2));







        }
        
        static void sum1(int a, int b)
        {
            Console.WriteLine("Rezultats ir " + (a + b));
        }

        static int sum2()
        {
            Console.WriteLine("Ievadiet pirmo skaitli");
            String ievade = Console.ReadLine();
            int num1 = Convert.ToInt32(ievade);
            Console.WriteLine("Ievadiet otro skaitli");
            ievade = Console.ReadLine();
            int num2 = Convert.ToInt32(ievade);

            int rez = num1 + num2;

            return rez;
        }

        static int sum3(int a, int b)
        {
            return a + b;
        }


        static void piemers1()
        {
            Console.WriteLine("Parasta void metode");
        }

        static void piemers2()
        {
            Console.WriteLine("Velviena void metode");
        }

        static void piemers3(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int piemers4()
        {
            int sk1 = 5;
            int sk2 = 6;

            return sk1 + sk2;
        }

        static string piemers5()
        {
            Console.WriteLine("Ievadiet kautko");
            String ievade = Console.ReadLine();

            return ievade;
        }
    }
}
