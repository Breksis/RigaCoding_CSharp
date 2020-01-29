using System;

namespace MajasDarbs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet virkni ar vismaz 3 simboliem!");
            String ievade = Console.ReadLine();

            int garums = ievade.Length;

            if ((garums >= 3) && (ievade == "aaa"))
            {
                Console.WriteLine("Jusu ievadita virkne ir pareiza");
            }
            else
            {
                Console.WriteLine("Jusu ievaditais " + ievade + " ir " + garums + " simbolus garsh, un neatbilst nosacijumiem!!!");
            }

        }
    }
}
