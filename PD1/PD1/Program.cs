using System;

namespace PD1
{
    class Program
    {
        private static bool a;
        private static bool b;

        static void Main(string[] args)
        {
            virkne();
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
            do
            {
                Console.WriteLine("Ievadiet simbolu virkni!");
                String virkne = Console.ReadLine();
                String suns = "suns";
                String zirgs = "zirgs";

                bool a = virkne.Contains(suns);
                bool b = virkne.Contains(zirgs);
            }
            while (a || b);
        }
    }
}
