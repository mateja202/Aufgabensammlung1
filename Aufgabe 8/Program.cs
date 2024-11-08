using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schreibe einen Kommentar: ");
            string kommentar = Console.ReadLine();
            string[] forbiddenWords = { "arschloch", "bastard", "halt die fresse", "fick", "scheisse", "arsch" };


            if (forbiddenWords.Any(word => kommentar.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0))

            {
                Console.WriteLine("Dein Kommentar enthält verbotene Wörter.");
                Console.WriteLine("Er wird nicht veröffentlicht.");
            }
            else
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar");
            }

            Console.ReadKey();
        }
    }
}
        
    

