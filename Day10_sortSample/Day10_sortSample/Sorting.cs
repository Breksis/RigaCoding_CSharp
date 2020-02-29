using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_sortSample
{
    public class Sorting
    {
        public Sorting()
        {

        }

        public static int randNum()
        {
            Random randNum = new Random();
            return randNum.Next(1, 1000);
        }

        public static void Bubble(int[] masivs)
        {
            int temp = 0;
            for (int i = 0; i < masivs.Length; i++)
            {
                for (int j = 0; j < masivs.Length - 1; j++)
                {
                    if (masivs[j] > masivs[j + 1])
                    {
                        temp = masivs[j + 1];
                        masivs[j + 1] = masivs[j];
                        masivs[j] = temp;
                    }
                }
            }
        }

        public static void Selection(int[] masivs)
        {
            for (int i = 0; i < masivs.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < masivs.Length; j++)
                {
                    if (masivs[j] < masivs[min])
                    {
                        min = j;
                    }
                    int temp = masivs[min];
                    masivs[min] = masivs[i];
                    masivs[i] = temp;
                }
            }
        }

        public static int[] randArray()
        {
            int[] masivs = new int[10000];
            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = randNum();
            }
            return masivs;   
        }
    }
}
