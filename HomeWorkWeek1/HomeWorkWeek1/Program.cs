using System;

namespace HomeWorkWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Pozitivs/negativs!");
            Console.WriteLine("2. Random diena!");
            Console.WriteLine("3. Paris/neparis!");

            Console.WriteLine("Ievadiet opciju!");

            String izvele = Console.ReadLine();

            if (izvele == "1")
            {
                PozNeg();
            }
            else if (izvele == "2")
            {
                RandomDiena();
            }
            else if (izvele == "3")
            {
                ParisNeparis();
            }
            else Console.WriteLine("Tada izvele neeksiste!");
        }
        static int Ievade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);

            return skaitlis;
        }

        static void PozNeg()
        {
            int a = Ievade();
            if (a > 0)
            {
                Console.WriteLine("Skaitlis ir pozitivs");
            }
            else if (a < 0)
            {
                Console.WriteLine("Skaitlis ir negativs");
            }
            else Console.WriteLine("Skaitlis ir 0");
        }

        static void RandomDiena()
        {
            Random randDay = new Random();
            int day = randDay.Next(1, 7);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Pirmdiena");
                    break;
                case 2:
                    Console.WriteLine("Otrdiena");
                    break;
                case 3:
                    Console.WriteLine("Tresdiena");
                    break;
                case 4:
                    Console.WriteLine("Ceturtdiena");
                    break;
                case 5:
                    Console.WriteLine("Piektdiena");
                    break;
                case 6:
                    Console.WriteLine("Sestdiena");
                    break;
                case 7:
                    Console.WriteLine("Svetdiena");
                    break;
            }
        }
        static void ParisNeparis()
        {
            int oddEven = Ievade();

            if (oddEven % 2 == 0)
            {
                Console.WriteLine("Skaitlis ir pozitivs!");
            }
            else Console.WriteLine("Skaitlis ir negativs!");
        }
    }
}
