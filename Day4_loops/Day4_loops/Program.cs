using System;

namespace Day4_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            loopExtraExtra();
        }

        
        static void loopExtra()
        {
            //ievada bazi( skaitli, ko kapinat)
            //ievada pakapi
            //izvadam rezultatu
            //izmantojam veselus skaitlus
            //izmanto for ciklu

            Console.WriteLine("Ievadied skaitli!");
            int baze = ievade();
            Console.WriteLine("Ievadiet kapinataju!");
            int kapinatajs = ievade();

            int rezultats = 1;

            for (int i = 1; i <= kapinatajs; i++)
            {
                rezultats *= baze;
                Console.WriteLine(rezultats);
            }
            Console.WriteLine("Rezultats ir " + rezultats);
        }
        
        static void loopExtraExtra()
        {
            //*
            //**
            //***
            //****

            //*
            //**
            //***
            //****
            //***
            //**
            //*
            String star = "";
            for (int i = 0; i < 4; i++)
            {
                star = star + "*";
                Console.WriteLine(star);
            }

            String star2 = "";
            for (int i = 0; i < 4; i++)
            {
                star2 = star2 + "*";
                Console.WriteLine(star2);
            }
            for (int j = 0; j < 4; j++)
            {
                star2 = star2.Remove(star2.Length - 1);
                Console.WriteLine(star2);
            }
        }
        static void forLoopTask2()
        {
            //Ievada 5 skaitlus
            //Izvada skaitlu summu

            Console.WriteLine("Ievadiet 5 skaitlus!");

            int summa = 0;
            for (int i = 0; i < 5; i++)
            {
                int skaitlis = ievade();
                summa += skaitlis ;
            }
            Console.WriteLine(summa);
        }

        static void forLoopTask1()
        {
            //ar for ciklu sasummet skaitus no 1 lidz 10, izvadit summu
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                sum += i;  // sum = sum + 1
            }
            Console.WriteLine(sum);

        }

        static void forLoopExample()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet frazi");
                String fraze = Console.ReadLine();
                Console.WriteLine("Cikla pielietojums -> " + i);
            }*/
        }

        static void whileUnDoWhile()
        {
            int a = 0;

            while (a < 10)
            {
                Console.WriteLine("Cikla pielietojums -> " + a);
                a++;
            }

            a = 0;
            
            do
            {
                Console.WriteLine("Cikla pielietojums -> " + a);
                a++;
            }
            while (a < 10);
        }

        static int ievade()
        {
            String input = Console.ReadLine();
            int ievade = Convert.ToInt32(input);
            return ievade;
        }
    }
}
