using System;

namespace Day6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tasks.getA());
            //int skaitlis = Tasks.getA();
            Console.WriteLine("Ievadiet skaitli");
            String input = Console.ReadLine();
            int skaitlis = Convert.ToInt32(input);

            Tasks.setA(skaitlis);
            Console.WriteLine(Tasks.getA());

            Console.WriteLine(Tasks.getB());
            String ievade = Console.ReadLine();
            int num = Convert.ToInt32(ievade);
            Tasks.setB(num);
            Console.WriteLine(Tasks.getB());
        }
    }
}
