using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Classes
{
    public class ExampleClass // 
    {
        // public - varam pieklut no arpasaules
        // private - var izmantot tikai klases iekspuse
        public static int a = 5;
        private static int b = 8;
        public static void test()
        {
            Console.WriteLine("Hello from the other side!");
            privateTest();
        }

        private static void privateTest()
        {
            Console.WriteLine("Incognito");
        }
    }
}
