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

            task4();

            //Taisam klasi ar nosaukumu Students
            //Klase ir konstruktors ar parametriem
            //Vards, Uzvards, kurss, iestasanas gads
            //print() izvada informaciju
            //Kurss 1 - 3
            //ja ir vairak, iestatam 3
            //ja mazak, tad iestatam 1

            //uztaisit 2 testa objektus


        }

        
        static void task4()
        {
            Students stud1 = new Students("Juris", "Ronis", 1, 2020);
            Students stud2 = new Students("Andris", "Berzins", 10, 1995);

            stud1.print();
            stud2.print();
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

        static void objEx1()
        {
            ObjExample obj = new ObjExample(0, 0);
            obj.setA(1);
            obj.setB(2);
            obj.print();

            obj.setA(5);
            obj.print();

            ObjExample obj2 = new ObjExample(0, 0);
            obj2.print();

            ObjExample obj3 = new ObjExample(3, 7);
            obj3.print();
        }

        static void task3()
        {
            //jauna klase
            //metodes no klases Trijsturis.cs
            //uztaisit 2 trijstura objekti
            //vienu ar pareizam maulu vertibam
            //otru, kur divas malas ir 0

            TrijsturisObj tri1 = new TrijsturisObj(10, 5, 5);
            TrijsturisObj tri2 = new TrijsturisObj(5, 0, 0);

            Console.WriteLine("Perimetrs ir " + tri1.perimetrs());

            if (tri2.check(tri2.getA(), tri2.getB(), tri2.getC()) == false)
            {
                Console.WriteLine("Trijsturis ar sadiem malu garumiem neeksiste!");
            }
            else
            {
                Console.WriteLine("Trijstura perimetrs ir " + tri2.perimetrs());
            }

        }
    }
}
