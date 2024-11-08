using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int kilometer = int.Parse(Console.ReadLine());

            if (kilometer > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
            }
            else
            {


                int runden = (kilometer * 1000) / 400;

                Console.WriteLine("Das sind (runden) Runden. Bereit für den Lauf?(ja/nein)");

                string bereit = Console.ReadLine();

                if (bereit.ToLower() == "ja")
                {
                    int i = 1;
                    while (i <= runden)
                    {
                        Console.WriteLine("Du läufst Runde{i}");
                        i++;

                    }
                    Console.WriteLine("Du hast es geschafft!");
                }
                else
                {
                    Console.WriteLine("Ende"); 
                }
            }
        }
    }
}
        
    

