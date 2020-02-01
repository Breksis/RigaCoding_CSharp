using System;

namespace Day3_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cilveks ievada 3 skaitlus int
            //Atrast un izvadit lielako

            Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();

            int num1 = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadiet skaitli");
            ievade = Console.ReadLine();

            int num2 = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadiet skaitli");
            ievade = Console.ReadLine();

            int num3 = Convert.ToInt32(ievade);


                if (num1 >= num2 && num1 >= num3)
                {
                    Console.WriteLine("Lielakais ir " + num1);
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    Console.WriteLine("Lielakais ir " + num2);
                }
                else if (num3 >= num1 && num3 >= num1)
                {
                    Console.WriteLine("Lielakais ir " + num3);
                }
            

        }
        static void zarosanas ()
        {
            int a = 5;
            int b = 6;
            // && = UN

            if (a > 5 && b == 6)
            {

            }
            else
            {

            }

            // || = VAI

            if (a > 5 || b == 6)
            {

            }

            int skaitlis = 5;
            //#
            //##

            //>5, <5, ==5

            if (skaitlis > 5)
            {
                Console.WriteLine("#");
            }
            else if (skaitlis < 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("###");
            }
        }
        static void uzd1 ()
        {
            //Kalkulators
            //ievada divus skaitlus
            //ievada darbibu
            //izvada rezultatu
            //ja cilveks ievada nepareizu darbibu, tad kludas pazinojums

            //Convert.ToDouble()

            Console.WriteLine("Kalkulators");
            Console.WriteLine("Ievadiet pirmo skaitli");
            String ievade = Console.ReadLine();

            double skaitlis1 = Convert.ToDouble(ievade);

            Console.WriteLine("Ievadiet otro skaitli");
            ievade = Console.ReadLine();

            double skaitlis2 = Convert.ToDouble(ievade);

            Console.WriteLine("Ievadiet darbibu");
            String darbiba = Console.ReadLine();

            if (darbiba == "+")
            {
                Console.WriteLine(skaitlis1 + skaitlis2);
            }
            else if (darbiba == "-")
            {
                Console.WriteLine(skaitlis1 - skaitlis2);
            }
            else if (darbiba == "*")
            {
                Console.WriteLine(skaitlis1 * skaitlis2);
            }
            else if (darbiba == "/")
            {
                Console.WriteLine(skaitlis1 / skaitlis2);
            }
            else
            {
                Console.WriteLine("Nepareiza darbiba!");
            }
        }
    }
}
