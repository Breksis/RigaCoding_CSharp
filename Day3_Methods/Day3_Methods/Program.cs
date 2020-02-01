using System;

namespace Day3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ievada skaitli
            //Uztaisam metodi, kas atgriez (return) vai skaitlis ir pozitivs vai negativs
            int skaitlis = ievade();
            Console.WriteLine(pozNeg(skaitlis));

        }

        static bool pozNeg(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else return false;
        }

        static int ievade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);

            return skaitlis;
        }

        static int compare(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void refactorTask()
        {
            //Cilveks ievada tris skaitlus- int
            //Jaizvada lielakais

            int skaitlis1 = ievade();
            int skaitlis2 = ievade();
            int skaitlis3 = ievade();

            int big = compare(skaitlis1, skaitlis2);
            big = compare(big, skaitlis3);

            Console.WriteLine("Lielakais ir " + big);
        }

        static int salidzinasana(int a, int b, int c)
        {
            int biggest = 0;

            if (a > b)
            {
                biggest = a;
            }
            else
            {
                biggest = b;
            }

            if (biggest < c)
            {
                biggest = c;
            }

            return biggest;

        }

        static void Sum1(int a, int b)
        {
            Console.WriteLine("Rezultats ir " + (a + b));
        }

        static int Sum2()
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

        static int Sum3(int a, int b)
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

        static void uzdevumi()
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

            Console.WriteLine("Rezultats ir " + Sum3(num1, num2));
        }
    }
}
