using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_sortSample
{
    public class Hangman
    {
        public Hangman()
        {

        }

        public static void game()
        {
            Console.WriteLine("Ievadiet minamo vardu.");
            String input = Console.ReadLine();
            Console.Clear();
            char[] vards = input.ToCharArray();
            char stripas = '_';
            char[] minamais = new char[vards.Length];
            int lives = 5;

            for(int i = 0; i < vards.Length; i++)
            {
                minamais[i] = stripas;
                Console.Write(" " + minamais[i]);
            }
            

            while (lives > 0)
            {
                int skaits = 0;
                int win = 0;

                Console.WriteLine();
                Console.WriteLine("Ievadiet burtu.");
                char burts = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < minamais.Length; i++)
                {
                    if (burts == vards[i])
                    {
                        minamais[i] = burts;
                        win++;
                    }
                    else skaits++;

                    if (skaits == vards.Length)
                    {
                        lives--;
                    }
                }
                Console.Clear();

                for (int i = 0; i < minamais.Length; i++)
                {
                    Console.Write(" " + minamais[i]);
                }

                if(win == minamais.Length)
                {
                    Console.WriteLine("Jus atminejat vardu.");
                    break;
                }
                else if(lives == 0)
                {
                    Console.WriteLine("Jus vardu neatminejat.");
                }
                
            }
        }
    }
}
