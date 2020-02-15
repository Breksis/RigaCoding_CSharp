using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_klases_un_obj
{
    public class Trijsuris
    {
        private static int a = 0;
        private static int b = 0;
        private static int c = 0;

        public static void setA(int localA)
        {
            a = localA;
        }

        public static int getA()
        {
            return a;
        }

        public static void setB(int localB)
        {
            b = localB;
        }

        public static int getB()
        {
            return b;
        }

        public static void setC(int localC)
        {
            c = localC;
        }

        public static int getC()
        {
            return c;
        }

        public static int perimetrs()
        {
            int perim = a + b + c;
            return perim;
        }

        public static bool check(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;
        }
    }
}
