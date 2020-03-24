using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_OOP
{
    class Cetrsturis : Figura
    {
        public Cetrsturis()
        {
            Console.WriteLine("Cetrstura laukums ir " + Laukums());
        }
        public int Laukums()
        {
            int S = h * w;
            return S;
        }
    }
}
