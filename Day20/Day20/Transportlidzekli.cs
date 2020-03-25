using System;
using System.Collections.Generic;
using System.Text;

namespace Day20
{
    abstract class Transportlidzekli
    {
        public void Move()
        {
            Console.WriteLine("Braucam!");
            MakeSound();
        }

        public abstract void MakeSound();

        public void Refill()
        {
            Console.WriteLine("Nevar uzpildit sito aparatu!");
        }
    }
}
