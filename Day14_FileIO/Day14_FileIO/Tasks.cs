using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day14_FileIO
{
    public class Tasks
    {
        //String tipa lists
        //Menu
        //pievienot
        //izvadit
        //iziet
        //saraksts ir janolasa no faila
        //jaieraksta faila
        public static void task1()
        {
            List<String> saraksts = new List<string>();
            bool work = true;
            String line;

            while (work)
            {
                Console.WriteLine("1. Pievienot.");
                Console.WriteLine("2. Izvadit.");
                Console.WriteLine("3.Iziet.");

                String choice = Console.ReadLine();

                if (choice == "1")
                {
                    try
                    {
                        StreamWriter write = new StreamWriter("C:\\Users\\ronis\\OneDrive\\Documents\\Saraksts.txt");
                        Console.WriteLine("Ievadiet vardu.");
                        String input = Console.ReadLine();
                        saraksts.Add(new String(input));
                        
                        for(int i = 0; i < saraksts.Count; i++)
                        {
                            write.WriteLine(saraksts[i]); 
                        }
                        write.Close();
                    }
                    catch
                    {
                        Console.WriteLine("Neizdevas veikt ierakstu.");
                    }
                }
                else if (choice == "2")
                {
                    try
                    {
                        StreamReader sar = new StreamReader("C:\\Users\\ronis\\OneDrive\\Documents\\Saraksts.txt");
                        line = sar.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sar.ReadLine();
                        }
                        sar.Close();
                    }
                    catch
                    {
                        Console.WriteLine("Nevar nolasit failu.");
                    }
                   
                }
                else if (choice == "3")
                {
                    work = false;
                }
                else Console.WriteLine("Nav tadas darbibas!");
            }
           
        }

        public static void task2()
        {
            Console.WriteLine("Ievadiet dazadus vardus.");
            String input = Console.ReadLine();
            String[] vardi = input.Split(',');

            StreamWriter rakstit = new StreamWriter("C:\\Users\\ronis\\OneDrive\\Documents\\Split.txt");
            for (int i = 0; i < vardi.Length; i++)
            {
                rakstit.WriteLine(vardi[i]);
            }
            rakstit.Close();

            StreamReader lasit = new StreamReader("C:\\Users\\ronis\\OneDrive\\Documents\\Split.txt");
            List<String> sakartots = new List<string>();
            String teksts = lasit.ReadLine();
            sakartots.Add(new String(teksts));
            while (teksts != null)
            {
                teksts = lasit.ReadLine();
                sakartots.Add(new String(teksts));
            }
            lasit.Close();
            Console.WriteLine(String.Join(',', sakartots));
        }
    }
}
