using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_OOP
{
    class Trijsturis : Figura
    {
        public Trijsturis()
        {
            Console.WriteLine("Trijstura laukums ir " + Laukums());
        }
        public double Laukums()
        {
            double S = w * h / 2;
            return S;
        }
    }
}
