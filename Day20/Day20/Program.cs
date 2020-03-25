using System;

namespace Day20
{
    class Program
    {
        static void Main(string[] args)
        {
            Divritenis bike = new Divritenis();
            bike.Move();

            Automasina auto = new Automasina();
            auto.Move();
            auto.Refill();

            Motocikls moto = new Motocikls();
            moto.Move();
            moto.Refill();
        }
    }
}
