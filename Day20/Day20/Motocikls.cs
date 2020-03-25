using System;
using System.Collections.Generic;
using System.Text;

namespace Day20
{
    class Motocikls : Transportlidzekli
    {
        public Motocikls()
        {
            Marka = "Ducatti";
            Krasa = "Sarkans";
            tilpums = 20;

            Console.WriteLine(Krasa + " " + Marka + " ===>");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Beep, beep!");
        }

        public new void Refill()
        {
            Console.WriteLine("Uzpilditi " + tilpums + " litri!");
        }
    }
}
