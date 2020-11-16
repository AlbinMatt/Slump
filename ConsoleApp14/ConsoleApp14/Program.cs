using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Slump = new Random();
            int Slump1 = Slump.Next(0, 101);
            int antalgissningar = 0;


            Console.Write("Skriv ett tal: ");
            int gissning = int.Parse(Console.ReadLine());
            antalgissningar++;

            while (gissning != Slump1)
            {

                if (gissning < Slump1)
                {
                    Console.WriteLine("Din gissning var för låg: " + gissning);
                    Console.Write("Försök igen: ");
                    antalgissningar++;
                }
                else
                {
                    Console.WriteLine("Din gissning var för hög: " + gissning);
                    Console.Write("Försök igen: ");
                    antalgissningar++;
                }

                gissning = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Din gissning var rätt: ");
            Console.WriteLine("Antal gissningar: " + antalgissningar);


        }
    }
}
