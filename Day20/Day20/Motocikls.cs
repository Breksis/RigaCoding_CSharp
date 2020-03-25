using System;
using System.Collections.Generic;
using System.Text;

namespace Day20
{
    class Motocikls : Transportlidzekli
    {
        private string Marka = "Ducatti";
        private string Krasa = "Sarkans";
        private int tilpums = 20;

        public Motocikls()
        {
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
