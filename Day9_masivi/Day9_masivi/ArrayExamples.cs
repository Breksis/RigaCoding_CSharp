using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_masivi
{
    public class ArrayExamples
    {
        public ArrayExamples()
        {

        }

        public static void ex1()
        {
            int[] a = new int [5];

            a[0] = 4;
            a[1] = 88;
            a[2] = 93;
            a[3] = 1;
            a[4] = 6;

            int[] c = { 4, 88, 93, 1, 6 };

            string[] b = new string[3];
            b[0] = "abc";
            b[1] = "Hello world";
            b[2] = "Wow, massivi!";

            Console.WriteLine(a[0]);
            Console.WriteLine(b[2]);

            for(int i  = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                a[i] = 0;
            }

        }
    }
}
