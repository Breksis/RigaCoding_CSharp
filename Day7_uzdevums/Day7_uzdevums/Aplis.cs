using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_uzdevums
{
    public class Aplis
    {
        private double r;
        private double PI = 3.14;

        public double laukums()
        {
            double lauk = PI * r * r;
            return lauk;
        }

        public void Print()
        {
            Console.WriteLine("Rinka radiuss ir " + r + "!");
            Console.WriteLine("Rinka laukums ir " + laukums() + "!");
        }

    }
}
