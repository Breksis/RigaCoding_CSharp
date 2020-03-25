using System;
using System.Collections.Generic;
using System.Text;

namespace Day20
{
    class Automasina : Transportlidzekli
    {
        public Automasina()
        {
            Marka = "Audi";
            Krasa = "Melns";
            tilpums = 55;

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
