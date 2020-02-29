using System;

namespace Day10_sortSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hangman.game();
        }

        static void start()
        {
            int a = 10;
            int b = 12;

            //b = 10, a = 12

            int c = a;
            a = b;
            b = c;
        }

        static void time()
        {
            int[] mas = new int[10000];
            mas = Sorting.randArray();

            var laiks = new System.Diagnostics.Stopwatch();
            laiks.Start();
            Sorting.Bubble(mas);
            laiks.Stop();
            Console.WriteLine("Bubble sort laiks: " + laiks.ElapsedMilliseconds);

            var laiks2 = new System.Diagnostics.Stopwatch();
            laiks2.Start();
            Sorting.Selection(mas);
            laiks2.Stop();
            Console.WriteLine("Selection sort laiks: " + laiks2.ElapsedMilliseconds);
        }
    }
}
