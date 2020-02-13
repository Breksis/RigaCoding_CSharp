using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Classes
{
    public class Tasks
    {
        //uztaisit 2 privatus mainigos (int)
        //uztaisiet, ta lai cilveks pieskir viniem vertibu
        //Console.ReadLine ir janotiek no Program.cs klases
        //Lai main() varetu vinus izvadit
        //getA, setA
        //getB, setB

        private static int a = 0;
        private static int b = 0;

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
    }
}
