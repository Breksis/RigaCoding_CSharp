using System;

namespace Day8_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot jaunu klasi
            //jabut laukam, kur glabasies skaitlis int
            //uzgeneret random skaitli no 1 lidz 10 (konstruktora)
            //jabut metodei getNumber, kas atgriez so skaitli
            //regenerateNumber() metode, kas no jauna uzgenere gadijuma skaitli

            //uztaisam vienu objektu
            //uztaisam otru objektu
            //while cikls
            //salidzinam abu objeku gadijuma skaitlus
            //tas kuram lielaks, tas uzvar
            //ka piefikset uzvaras - freestayle
            //apstajamies, kad viens objekts ir uzvarejis 3 reizes

            //Random random = new Random();
            //int number = random.Next(1, 10);

            randomNumber object1 = new randomNumber();
            randomNumber object2 = new randomNumber();

            int win1 = 0;
            int win2 = 0;

            while (win1 < 3 && win2 < 3)
            {
                Console.WriteLine("object1 skaitlis ir " + object1.getNumber() + ", object2 skaitlis ir " + object2.getNumber());
                if (object1.getNumber() > object2.getNumber())
                {
                    win1++;
                    Console.WriteLine("Raunda uzvar object1!");
                }
                else if (object1.getNumber() < object2.getNumber())
                {
                    win2++;
                    Console.WriteLine("Raunda uzvar object2!");
                }
                else Console.WriteLine("Raunds ir neizskirts!");

                object1.setNumber(object1.randomGenerator());
                object2.setNumber(object2.randomGenerator());

                Console.WriteLine();
                Console.ReadKey();
            }

            if (win1 > win2)
            {
                Console.WriteLine("Speli uzvar object1 ar rezultatu " + win1 + " pret " + win2);
            }
            else Console.WriteLine("Speli uzvar object2 ar rezultatu " + win2 + " pret " + win1);
        }
    }
}
