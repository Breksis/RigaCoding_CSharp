using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_objects
{
    public class randomNumber
    {
        private int random;
        public randomNumber()
        {
            random = randomGenerator();
        }

        public int getNumber()
        {
            return random;
        }

        public void setNumber(int random)
        {
            this.random = random;
        }

        public int randomGenerator()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }
    }
}
