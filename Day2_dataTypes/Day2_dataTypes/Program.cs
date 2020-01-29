using System;

namespace Day2_dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cilveks ievada skaitli
            //Parbaudam, vai ir lielaks par 5
            //ja ir ##
            //ja nav #

            Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();

            int skaitlis = Convert.ToInt32(ievade);

            if (skaitlis > 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("#");
            }
        }

        static void piemers()
        {
            int a = 5;
            int b = 7;

            int c = a + b;

            Console.WriteLine("Ievadiet skaitli!");
            String ievade = Console.ReadLine();

            int parkonvertetsNr = Convert.ToInt32(ievade);
            c = parkonvertetsNr - a;

            Console.WriteLine("Skaitlis ir " + c);

            String virkne1 = "vertiba ";
            String virkne2 = "ir ";

            String virkne3 = virkne1 + virkne2;
            Console.WriteLine(virkne3);
        }

        static void uzdevums1()
        {
            //Lietotajam paprasam, kurs gads ir
            //lietotajs ievada
            //Lietotajam prasa, kura gada vins ir dzimis
            //lietotajs ievada
            //Atnemat skaitlus, lai izvaditu starpibu
            //Izvadam Vecums ir xx


            Console.WriteLine("Kurs gads ir?");
            String ievade = Console.ReadLine();

            int gads = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadiet savu dzimsanas gadu");
            ievade = Console.ReadLine();

            int dzGads = Convert.ToInt32(ievade);

            int vecums = gads - dzGads;

            Console.WriteLine("Jusu vecums ir " + vecums);
        }

        static void piemers2()
        {
            int a = 5;
            int b = 6;

            if (a > 5)
            {
                Console.WriteLine("Ir");
            }
            else
            {
                Console.WriteLine("Nav");
            }

            // >< lielaks, mazaks
            // <= 
            // <=
            // = pieskirt, == salidzinat
            // != nav vienads

            String piem = "aaa";

            if (piem == "aaa")
            {

            }

            //int c = piem.Lenght; sadi var dabut Stringa garumu
        }
    }
}
