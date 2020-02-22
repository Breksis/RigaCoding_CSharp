using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzminiSkaitli
{
    public class Skaitlis
    {
        private int randNum;
        private int win;
        public Skaitlis()
        {
            randNum = newRandom();
        }
        public int newRandom()
        {
            Random randNum = new Random();
            return randNum.Next(1, 10);
        }
        public int getNumber()
        {
            return randNum;
        }
        public void addWin()
        {
            win++;
        }
        public int getWin()
        {
            return win;
        }
        public int userNumberInput()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

    }
}
