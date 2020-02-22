using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzminiSkaitli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prieks Tevi redzet " + gender() + "!");
            Console.WriteLine();
            uzminiSkaitli();
            Console.ReadLine();
        }
        static void uzminiSkaitli()
        {
            Skaitlis cpu = new Skaitlis();
            Skaitlis player = new Skaitlis();
            Console.WriteLine(" Spele - Uzmini skaitli!");
            Console.WriteLine();
            
            while(cpu.getWin() < 3)
            {
                Console.WriteLine("Ievadi savu minejumu.");
                int guess = player.userNumberInput();

                if (guess > cpu.getNumber())
                {
                    cpu.addWin();
                    Console.WriteLine("Skaitlis ir mazaks!");
                    Console.WriteLine();
                }
                else if (guess < cpu.getNumber())
                {
                    cpu.addWin();
                    Console.WriteLine("Skaitlis ir lielaks!");
                    Console.WriteLine();
                }
                else if (guess == cpu.getNumber())
                {
                    Console.WriteLine();
                    Console.WriteLine(gender() + " apsveicam! Jus atminejat skaitli!");
                    break;
                }
            }
            if(cpu.getWin() == 3)
            {
                Console.WriteLine();
                Console.WriteLine(gender() + " diemzel Jus skaitli neatminejat.");
                Console.WriteLine("Skaitlis bija " + cpu.getNumber() + "!");
            }
        }
        static string gender()
        {
            Console.WriteLine("Sveiki! Vai drikst uzzinat Jusu vardu?");
            String name = Console.ReadLine();
            String male;
            String female;
            if (name.EndsWith("s"))
            {
                male = name.Remove(name.Length - 1);
                return male;
            }
            else
            {
                female = name;
                return female;
            }
        }
        
    }
}
