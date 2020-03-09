using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Exceptions
{
    public class Exceptions
    {
        public static void ex1()
        {
            Console.WriteLine("Ievadiet skaitli");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Viss ok!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Nesanaca!");
                Console.WriteLine(e.ToString());
            }
            
        }

        
        public static void task2()
        {
            //Cilvekam jaievada skaitlis
            //Japarliecinas, vai tiesam ir ievadits skaitlis
            //cilveks turpina ievadi, kamer neievada skaitlis

            bool test = false;
            do
            {
                Console.WriteLine("Ievadiet skaitli.");
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    test = true;
                }
                catch
                {
                    Console.WriteLine("Nav ievadits skaitlis.");
                    Console.WriteLine();
                }
            }
            while (!test);
        }

        //Lists, kuru aizpilda cilveks - integeri
        //Uztaist menu
        // pievienot vertibu
        //izvadit visu sarakstu
        //izdzest vertibu pec teksa
        //izdzest pec indeksa
        public static void task3()
        {
            List<int> saraksts = new List<int>();
            Console.WriteLine("Cik ierakstus veiksiet?");
            int skaits = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < skaits; i++)
            {
                Console.WriteLine("Ievadiet skaitli");
                saraksts.Add(Convert.ToInt32(Console.ReadLine()));
            }

            bool work = true;

            while (work)
            {
                Console.WriteLine("1. Pievienot vertibu");
                Console.WriteLine("2. Izvadit sarakstu");
                Console.WriteLine("3. Izdzest pec vertibas");
                Console.WriteLine("4. Izdzest pec indeksa");
                Console.WriteLine("5. Iziet");

                Console.WriteLine("Kuru darbibu veiksim?");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Ievadiet jauno skaitli.");
                        try
                        {
                            saraksts.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch
                        {
                            Console.WriteLine("Neizdevas - nav ievadits skaitlis.");
                        }
                        break;
                    case "2":
                        foreach(int i in saraksts)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case "3":
                        foreach (int i in saraksts)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Kuru vertibu dzesisim?");
                        try
                        {
                            saraksts.Remove(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch
                        {
                            Console.WriteLine("Tada vertiba nav saraksta!");
                        }
                        break;
                    case "4":
                        for (int i = 0; i < saraksts.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + saraksts[i]);
                        }
                        Console.WriteLine("Kuru rindu dzesisim?");
                        int rinda = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            saraksts.RemoveAt(rinda - 1);
                        }
                        catch
                        {
                            Console.WriteLine("Tada rinda neeksiste!");
                        }

                        break;
                    case "5":
                        work = false;
                        break;
                }

            }
            


        }
    }
}
