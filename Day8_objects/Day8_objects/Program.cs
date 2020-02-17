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
            //regenerateNumber metode, kas no jauna uzgenere gadijuma skaitli

            //uztaisam vienu objektu
            //uztasam otru objektu
            //while cikls
            //salidzinam abu objeku gadijuma skaitlus
            //tas kuram lielaks, tas uzvar
            //ka piefikset uzvaras - freestayle
            //apstajamies, kad viens objekts ir uzvarejis 3 reizes

            //Random random = new Random();
            //int number = random.Next(1, 10);

            randomNumber object1 = new randomNumber();
            randomNumber object2 = new randomNumber();

            Console.WriteLine(object1.getNumber());
            Console.WriteLine(object2.getNumber());


        }
    }
}
