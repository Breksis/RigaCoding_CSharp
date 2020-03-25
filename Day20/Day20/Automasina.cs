using System;
using System.Collections.Generic;
using System.Text;

namespace Day20
{
    class Automasina : Transportlidzekli
    {
        private string Marka = "Audi";
        private string Krasa = "Melns";
        private int tilpums = 55;

        public Automasina()
        {
            Console.WriteLine(Krasa + " " + Marka + " ===>");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Piiip, piiip!");
        }

        public new void Refill()
        {
            Console.WriteLine("Uzpilditi " + tilpums + " litri!");
        }
    }
}
