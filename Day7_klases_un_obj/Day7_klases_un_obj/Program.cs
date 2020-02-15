using System;

namespace Day7_klases_un_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            //uztaisit jaunu klasi ar nosaukumu SkaitluSumma
            //cilveks ievada 2 int tipa skaitlus no main
            //uztaisit, lai butu get, set, publiska metode, kas izvada abu skaitlu summu
            //abiem skaitliem jabut pieejamiem visa SkaitluSumma klase
            //bet no Program.cs klases tikai ar get un set

            //Klases nosaukums ir trijsturis
            //Cilveks ievada 3 malu vertibas - mainigie jaunaja klase
            //Metode, kas izvada perimetru
            //visa ievade un izvade notiek no main
            //ja kada mala ir 0, par to ir japazino un vertiba nav jaizvada

            task2();


        }

        static void task1()
        {
            Console.WriteLine("Ievadiet pirmo skaitli!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            SkaitluSumma.setA(num1);

            Console.WriteLine("Ievadiet otro skaitli!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            SkaitluSumma.setB(num2);

            SkaitluSumma.summa();
        }

        static void task2()
        {
            Console.WriteLine("Ievadiet pirmas malas garumu.");
            int mala1 = Convert.ToInt32(Console.ReadLine());
            Trijsuris.setA(mala1);

            Console.WriteLine("Ievadiet otras malas garumu.");
            int mala2 = Convert.ToInt32(Console.ReadLine());
            Trijsuris.setB(mala2);

            Console.WriteLine("Ievadiet tresas malas garumu.");
            int mala3 = Convert.ToInt32(Console.ReadLine());
            Trijsuris.setC(mala3);

            if (Trijsuris.check(mala1,mala2, mala3) == false)
            {
                Console.WriteLine("Trijsturis ar sadiem malu garumiem neeksiste!");
            }
            else
            {
                Console.WriteLine("Trijstura perimetrs ir " + Trijsuris.perimetrs());
            }
        }
    }
}
