using System;
using System.Collections.Generic;
using System.Text;

namespace Day20
{
    class Divritenis : Transportlidzekli
    {
        public Divritenis()
        {
            Krasa = "Balts";

            Console.WriteLine(Krasa + " velosipeds ===>");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dzin, dzin!");
        }
    }
}
