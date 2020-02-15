using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_klases_un_obj
{
    public class SkaitluSumma
    {
        private static int a = 0;
        private static int b = 0;

        public static int getA()
        {
            return a;
        }

        public static void setA(int localA)
        {
            a = localA;
        }

        public static int getB()
        {
            return b;
        }

        public static void setB(int localB)
        {
            b = localB;
        }

        public static void summa()
        {
            Console.WriteLine("Skaitlu summa ir " + (a + b));
        }
    }
}
