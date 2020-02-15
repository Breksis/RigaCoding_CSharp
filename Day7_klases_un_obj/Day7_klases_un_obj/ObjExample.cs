using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_klases_un_obj
{
    public class ObjExample
    {
        private int a;
        private int b;
        public ObjExample(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int getA()
        {
            return a;
        }

        public void setA(int localA)
        {
            a = localA;
        }

        public int getB()
        {
            return b;
        }

        public void setB(int localB)
        {
            b = localB;
        }

        public void print()
        {
            Console.WriteLine("a = " + a + " b = " + b);
        }
    }
}
