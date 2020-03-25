using System;
using System.Collections.Generic;
using System.Text;

namespace Day20
{
    class Divritenis : Transportlidzekli
    {
        private string Krasa = "Balts";

        public Divritenis()
        {
            Console.WriteLine(Krasa + " velosipeds ===>");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dzin, dzin!");
        }
    }
}
