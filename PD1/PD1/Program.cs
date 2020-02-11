using System;

namespace PD1
{
    class Program
    {

        static void Main(string[] args)
        {
            sveiciens();
        }

        static int ievade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String input = Console.ReadLine();
            int skaitlis = Convert.ToInt32(input);

            return skaitlis;
        }

        static void salidzinasana()
        {
            int num1 = ievade();
            int num2 = ievade();
            int num3 = ievade();
            int num4 = ievade();
            int num5 = ievade();
            int num6 = ievade();

            int big = compare(num1, num2);
            big = compare(big, num3);
            big = compare(big, num4);
            big = compare(big, num5);
            big = compare(big, num6);

            Console.WriteLine("Lielakais skaitlis ir " + big);
        }

        static int compare(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }

        static void gradi()
        {
            Console.WriteLine("Ievadiet temperaturu pec Farenheita!");
            double far = Convert.ToDouble(Console.ReadLine());
            double cel = (far - 32) * 5 / 9;
            Console.WriteLine("Temperatura pec Celsija ir " + cel);
        }

        static void kaste()
        {
            Console.WriteLine("Ievadiet augstumu!");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet platumu!");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j < width; j++) Console.Write("#"); Console.WriteLine("#");
            }
        }

        static void virkne()
        {
            String virkne;
            String suns = "suns";
            String zirgs = "zirgs";
            do
            {
                Console.WriteLine("Ievadiet simbolu virkni!");
                virkne = Console.ReadLine();
            }
            while (virkne.Contains(suns) || virkne.Contains(zirgs));

        }

        static void spele()
        {
            Console.WriteLine("1. speletaj ievadiet minamo vardu!");
            String minamais = Console.ReadLine();


            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("2. speletaj ievadiet jusu variantu!");
                String minejums = Console.ReadLine();

                if (minejums == minamais)
                {
                    Console.WriteLine("Apsveicam! Uzvar 2. speletajs!");
                    break;
                }
            }
        }

        static void sveiciens()
        {
            Console.WriteLine("Labdien! Ludzu ievadiet savu vardu!");
            String vards = Console.ReadLine();
            if (vards.EndsWith("s"))
            {
                Console.WriteLine("Esiet sveicinats " + vards.Remove(vards.Length - 1) + "!");
            }
            else Console.WriteLine("Esiet sveicinata " + vards + "!");
        }

    }
}
