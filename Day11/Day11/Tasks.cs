using System;
using System.Collections.Generic;
using System.Text;

namespace Day11
{
    public class Tasks
    {
        public static void task1()
        {
            int[] masivs = new int[5];
            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = randNum();
            }

            Console.WriteLine("Ievadiet velamo masiva garumu.");
            int garums = Convert.ToInt32(Console.ReadLine());

            if (garums <= 5)
            {
                for (int i = 0; i < masivs.Length; i++)
                {
                    Console.Write(masivs[i] + " ");
                }
            }
            else
            {

                int[] temp = new int[masivs.Length];

                for (int i = 0; i < masivs.Length; i++)
                {
                    temp[i] = masivs[i];
                }

                masivs = new int[garums];

                for (int i = 0; i < temp.Length; i++)
                {
                    masivs[i] = temp[i];
                }

                for (int i = temp.Length; i < masivs.Length; i++)
                {
                    masivs[i] = randNum();
                }

                for (int i = 0; i < masivs.Length; i++)
                {
                    Console.Write(masivs[i] + " ");
                }
            }
        }

        public static void task2()
        {
            //masivs ar 100 elementiem
            //[random=a][a+b=c][c+b=d][d+b=e][e+b][random=b]

            int[] array = new int[100];
            array[0] = randNum();
            array[array.Length - 1] = randNum();
            for(int i = 1; i < array.Length -1; i++)
            {
                array[i] = array[i - 1] + array[array.Length - 1];
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void task3()
        {
            //masivs ar 5 vertibam(string)
            //ievada cilveks
            //izvadam masivu
            //parbaudam katra elementa garumu
            //ja elementam vairak par 5 simboliem, tad aizstajam elementu ar "vii"
            //masivu

            String[] vards = new String[5];

            for(int i = 0; i < vards.Length; i++)
            {
                Console.WriteLine("Ievadiet vardu.");
                vards[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for(int i = 0; i < vards.Length; i++)
            {
                Console.WriteLine(vards[i]);
            }
            Console.WriteLine();

            for(int i = 0; i < vards.Length; i++)
            {
                if(vards[i].Length > 5)
                {
                    vards[i] = "vii";
                }
            }
            for(int i = 0; i < vards.Length; i++)
            {
                Console.WriteLine(vards[i]);
            }
        }
        public static int randNum()
        {
            Random randNum = new Random();
            return randNum.Next(1, 100);
        }
        public static void taskStudents()
        {
            Students[] info = new Students[5];

            for(int i = 0; i < info.Length; i++)
            {
                Console.WriteLine("Ievadiet vardu.");
                String name = Console.ReadLine();

                Console.WriteLine("Ievadiet uzvardu.");
                String surname = Console.ReadLine();

                Console.WriteLine("Ievadiet kursu.");
                int course = Convert.ToInt32(Console.ReadLine());

                info[i] = new Students(name, surname, course);
            }
            for(int i = 0; i < info.Length; i++)
            {
                info[i].print();
            }
        }

        public static String strings()
        {
            return Console.ReadLine();
        }
        public static int cipars()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void taskStudents2()
        {
            bool turp = true;
            Students[] info = new Students[5];

            while (turp)
            {
                Console.WriteLine("1. Izvadit informaciju.");
                Console.WriteLine("2. Pievienot jaunu studentu.");
                Console.WriteLine("3. Rediget ierakstu.");
                Console.WriteLine("4.Beigt darbu.");
                Console.WriteLine();
                Console.WriteLine("Izvelaties velamo darbibu:");
                int opcija = Convert.ToInt32(Console.ReadLine());

                if (opcija == 1)
                {
                    Izvade(info);
                }
                else if (opcija == 2)
                {

                }
                else if (opcija == 3)
                {

                }
                else if (opcija == 4)
                {
                    turp = false;
                }
                else
                {
                    Console.WriteLine("Ievadita nepareiza darbiba!");
                    Console.WriteLine();
                }
            }
        }
        public static void Izvade(Students[] array)
        {
            
            int skaits = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    array[i].print();
                }
                else skaits++;
                
            }

            if (skaits == array.Length)
            {
                Console.WriteLine("Saraksts ir tuks.");
                Console.WriteLine();
            }
        }
    }
}
