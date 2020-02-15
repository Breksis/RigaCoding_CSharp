using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_klases_un_obj
{
    public class TrijsturisObj
    {
        private int a;
        private int b;
        private int c;

        
        public TrijsturisObj(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void setA(int localA)
        {
            a = localA;
        }

        public int getA()
        {
            return a;
        }

        public void setB(int localB)
        {
            b = localB;
        }

        public int getB()
        {
            return b;
        }

        public void setC(int localC)
        {
            c = localC;
        }

        public int getC()
        {
            return c;
        }

        public int perimetrs()
        {
            int perim = a + b + c;
            return perim;
        }

        public bool check(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;
        }
    }
}
